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
    public partial class FormDump : Form
    {
        public string ReturnedText { get; set; }

        private static FormGUI main;

        public FormDump(FormGUI Main)
        {
            main = Main;
        }

        public FormDump()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(main.Location.X + 130, main.Location.Y + 150);

            main.SetAllControlsFont(Controls);
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            ReturnedText = dumpAdrTxtBox.Text;
            DialogResult = DialogResult.OK;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
