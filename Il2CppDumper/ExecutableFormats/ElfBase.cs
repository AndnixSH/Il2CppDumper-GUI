using System;
using System.IO;
using System.Windows.Forms;

namespace Il2CppDumper
{
    public abstract class ElfBase : Il2Cpp
    {
        public bool IsDumped;
        public ulong DumpAddr;

        protected ElfBase(Stream stream) : base(stream) { }

        public void GetDumpAddress()
        {
            FormGUI.Log("Detected this may be a dump file.");
            FormDump form = new FormDump();
            form.Message = 0;
            if (form.ShowDialog() == DialogResult.OK)
            {
                DumpAddr = Convert.ToUInt64(form.ReturnedText, 16);
                FormGUI.Log("Inputted address: " + DumpAddr.ToString("X"));
            }
            if (DumpAddr != 0)
            {
                IsDumped = true;
            }
        }
    }
}
