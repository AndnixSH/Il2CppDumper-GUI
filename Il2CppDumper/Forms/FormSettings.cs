using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Il2CppDumper
{
    public partial class FormOptions : Form
    {
        private static FormGUI main;

        public FormOptions(FormGUI Main)
        {
            main = Main;
        }

        public FormOptions()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(main.Location.X + 190, main.Location.Y + 90);

            main.SetAllControlsFont(Controls);

            updateChkBox.Checked = FormRegistry.CheckForUpdate;
            winPosCheckBox.Checked = FormRegistry.RememberWindowPosition;
            autoSetDirCheck.Checked = FormRegistry.AutoSetDir;
            extBinaryChkBox.Checked = FormRegistry.ExtBinaryChkBox;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Save();
            Close();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            Save();
            Close();
        }

        private void Save()
        {
            FormRegistry.CheckForUpdate = updateChkBox.Checked;
            FormRegistry.RememberWindowPosition = winPosCheckBox.Checked;
            FormRegistry.AutoSetDir = autoSetDirCheck.Checked;
            FormRegistry.ExtBinaryChkBox = extBinaryChkBox.Checked;
        }
    }
}
