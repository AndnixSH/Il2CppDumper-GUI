using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Il2CppDumper
{

    public partial class FormAbout : Form
    {
        private static FormGUI main;

        public FormAbout(FormGUI Main)
        {
            main = Main;
        }

        public FormAbout()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(main.Location.X + 60, main.Location.Y + 90);

            main.SetAllControlsFont(Controls);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/AndnixSH/Il2CppDumper-GUI");
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
