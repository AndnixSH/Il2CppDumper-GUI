using System;
using System.Drawing;
using System.Windows.Forms;

namespace Il2CppDumper
{
    public partial class FormSettings : Form
    {
        private static FormGUI main;

        public FormSettings(FormGUI Main)
        {
            main = Main;
        }

        public FormSettings()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(main.Location.X + 20, main.Location.Y + 60);

            main.SetAllControlsFont(Controls);

            updateChkBox.Checked = Properties.Settings.Default.CheckForUpdate;
            winPosCheckBox.Checked = Properties.Settings.Default.RememberWindowPosition;
            autoSetDirCheck.Checked = Properties.Settings.Default.AutoSetDir;
            extBinaryChkBox.Checked = Properties.Settings.Default.ExtBinaryChkBox;
            extDatChkBox.Checked = Properties.Settings.Default.ExtDatChkBox;

            script1ChkBox.Checked = Properties.Settings.Default.ghidra;
            script2ChkBox.Checked = Properties.Settings.Default.ghidra_with_struct;
            script3ChkBox.Checked = Properties.Settings.Default.ida;
            script4ChkBox.Checked = Properties.Settings.Default.ida_py3;
            script5ChkBox.Checked = Properties.Settings.Default.ida_with_struct;
            script6ChkBox.Checked = Properties.Settings.Default.ida_with_struct_py3;
            scriptGhiWasmChkBox.Checked = Properties.Settings.Default.ghidra_wasm;
            scriptHeader2GhidraChkBox.Checked = Properties.Settings.Default.il2cpp_header_to_ghidra;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            Save();
            Close();
        }

        private void Save()
        {
            Properties.Settings.Default.CheckForUpdate = updateChkBox.Checked;
            Properties.Settings.Default.RememberWindowPosition = winPosCheckBox.Checked;
            Properties.Settings.Default.AutoSetDir = autoSetDirCheck.Checked;
            Properties.Settings.Default.ExtBinaryChkBox = extBinaryChkBox.Checked;
            Properties.Settings.Default.ExtDatChkBox = extDatChkBox.Checked;

            Properties.Settings.Default.ghidra = script1ChkBox.Checked;
            Properties.Settings.Default.ghidra_with_struct = script2ChkBox.Checked;
            Properties.Settings.Default.ida = script3ChkBox.Checked;
            Properties.Settings.Default.ida_py3 = script4ChkBox.Checked;
            Properties.Settings.Default.ida_with_struct = script5ChkBox.Checked;
            Properties.Settings.Default.ida_with_struct_py3 = script6ChkBox.Checked;
            Properties.Settings.Default.ghidra_wasm = scriptGhiWasmChkBox.Checked;
            Properties.Settings.Default.il2cpp_header_to_ghidra = scriptHeader2GhidraChkBox.Checked;

            Properties.Settings.Default.Save();

            Dispose();
        }
    }
}
