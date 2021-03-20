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
            FormGUI.WriteLine("Detected this may be a dump file.");
            FormGUI.WriteLine("Input il2cpp dump address or input 0 to force continue:");
            FormDump form = new FormDump();
            form.Message = 0;
            if (form.ShowDialog() == DialogResult.OK)
            {
                DumpAddr = Convert.ToUInt64(form.ReturnedText, 16);
                FormGUI.WriteLine("Inputted address: " + DumpAddr.ToString("X"));
            }
            if (DumpAddr != 0)
            {
                IsDumped = true;
            }
        }
    }
}
