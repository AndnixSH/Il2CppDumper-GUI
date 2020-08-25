﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Il2CppDumper
{
    public class BinaryStream : IDisposable
    {
        public float Version;
        public bool Is32Bit;
        private Stream stream;
        private BinaryReader reader;
        private BinaryWriter writer;
        private MethodInfo readClass;
        private MethodInfo readClassArray;
        private Dictionary<Type, MethodInfo> genericMethodCache = new Dictionary<Type, MethodInfo>();
        private Dictionary<FieldInfo, VersionAttribute> attributeCache = new Dictionary<FieldInfo, VersionAttribute>();

        public BinaryStream(Stream input)
        {
            stream = input;
            reader = new BinaryReader(stream, Encoding.UTF8, true);
            writer = new BinaryWriter(stream, Encoding.UTF8, true);
            readClass = GetType().GetMethod("ReadClass", Type.EmptyTypes);
            readClassArray = GetType().GetMethod("ReadClassArray", new[] { typeof(long) });
        }

        public bool ReadBoolean() => reader.ReadBoolean();

        public byte ReadByte() => reader.ReadByte();

        public byte[] ReadBytes(int count) => reader.ReadBytes(count);

        public sbyte ReadSByte() => reader.ReadSByte();

        public short ReadInt16() => reader.ReadInt16();

        public ushort ReadUInt16() => reader.ReadUInt16();

        public int ReadInt32() => reader.ReadInt32();

        public uint ReadUInt32() => reader.ReadUInt32();

        public long ReadInt64() => reader.ReadInt64();

        public ulong ReadUInt64() => reader.ReadUInt64();

        public float ReadSingle() => reader.ReadSingle();

        public double ReadDouble() => reader.ReadDouble();

        public uint ReadULeb128()
        {
            uint value = reader.ReadByte();
            if (value >= 0x80)
            {
                var bitshift = 0;
                value &= 0x7f;
                while (true)
                {
                    var b = reader.ReadByte();
                    bitshift += 7;
                    value |= (uint)((b & 0x7f) << bitshift);
                    if (b < 0x80)
                        break;
                }
            }
            return value;
        }

        public void Write(bool value) => writer.Write(value);

        public void Write(byte value) => writer.Write(value);

        public void Write(sbyte value) => writer.Write(value);

        public void Write(short value) => writer.Write(value);

        public void Write(ushort value) => writer.Write(value);

        public void Write(int value) => writer.Write(value);

        public void Write(uint value) => writer.Write(value);

        public void Write(long value) => writer.Write(value);

        public void Write(ulong value) => writer.Write(value);

        public void Write(float value) => writer.Write(value);

        public void Write(double value) => writer.Write(value);

        public ulong Position
        {
            get => (ulong)stream.Position;
            set => stream.Position = (long)value;
        }

        public ulong Length => (ulong)stream.Length;

        private object ReadPrimitive(Type type)
        {
            var typename = type.Name;
            switch (typename)
            {
                case "Int32":
                    return ReadInt32();
                case "UInt32":
                    return ReadUInt32();
                case "Int16":
                    return ReadInt16();
                case "UInt16":
                    return ReadUInt16();
                case "Byte":
                    return ReadByte();
                case "Int64" when Is32Bit:
                    return (long)ReadInt32();
                case "Int64":
                    return ReadInt64();
                case "UInt64" when Is32Bit:
                    return (ulong)ReadUInt32();
                case "UInt64":
                    return ReadUInt64();
                default:
                    throw new NotSupportedException();
            }
        }

        public T ReadClass<T>(ulong addr) where T : new()
        {
            Position = addr;
            return ReadClass<T>();
        }

        public T ReadClass<T>() where T : new()
        {
            var type = typeof(T);
            if (type.IsPrimitive)
            {
                return (T)ReadPrimitive(type);
            }
            else
            {
                var t = new T();
                foreach (var i in t.GetType().GetFields())
                {
                    if (!attributeCache.TryGetValue(i, out var versionAttribute))
                    {
                        if (Attribute.IsDefined(i, typeof(VersionAttribute)))
                        {
                            versionAttribute = i.GetCustomAttribute<VersionAttribute>();
                            attributeCache.Add(i, versionAttribute);
                        }
                    }
                    if (versionAttribute != null)
                    {
                        if (Version < versionAttribute.Min || Version > versionAttribute.Max)
                            continue;
                    }
                    var fieldType = i.FieldType;
                    if (fieldType.IsPrimitive)
                    {
                        i.SetValue(t, ReadPrimitive(fieldType));
                    }
                    else if (fieldType.IsEnum)
                    {
                        var e = fieldType.GetField("value__").FieldType;
                        i.SetValue(t, ReadPrimitive(e));
                    }
                    else if (fieldType.IsArray)
                    {
                        var arrayLengthAttribute = i.GetCustomAttribute<ArrayLengthAttribute>();
                        if (!genericMethodCache.TryGetValue(fieldType, out var methodInfo))
                        {
                            methodInfo = readClassArray.MakeGenericMethod(fieldType.GetElementType());
                            genericMethodCache.Add(fieldType, methodInfo);
                        }
                        i.SetValue(t, methodInfo.Invoke(this, new object[] { arrayLengthAttribute.Length }));
                    }
                    else
                    {
                        if (!genericMethodCache.TryGetValue(fieldType, out var methodInfo))
                        {
                            methodInfo = readClass.MakeGenericMethod(fieldType);
                            genericMethodCache.Add(fieldType, methodInfo);
                        }
                        i.SetValue(t, methodInfo.Invoke(this, null));
                    }
                }
                return t;
            }
        }

        public T[] ReadClassArray<T>(long count) where T : new()
        {
            var t = new T[count];
            for (var i = 0; i < count; i++)
            {
                t[i] = ReadClass<T>();
            }
            return t;
        }

        public T[] ReadClassArray<T>(ulong addr, long count) where T : new()
        {
            Position = addr;
            return ReadClassArray<T>(count);
        }

        public string ReadStringToNull(ulong addr)
        {
            Position = addr;
            var bytes = new List<byte>();
            byte b;
            while ((b = ReadByte()) != 0)
                bytes.Add(b);
            return Encoding.UTF8.GetString(bytes.ToArray());
        }

        public long ReadIntPtr()
        {
            return Is32Bit ? ReadInt32() : ReadInt64();
        }

        public ulong ReadUIntPtr()
        {
            return Is32Bit ? ReadUInt32() : ReadUInt64();
        }

        public ulong PointerSize
        {
            get => Is32Bit ? 4ul : 8ul;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                reader.Close();
                writer.Close();
                stream.Close();
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
    }
}
