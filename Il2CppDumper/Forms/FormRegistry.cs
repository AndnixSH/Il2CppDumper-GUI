using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Il2CppDumper
{
    public class FormRegistry
    {
        private static FormGUI main;

        public FormRegistry(FormGUI Main)
        {
            main = Main;
        }

		public static string BinaryFileTxtBox
		{
			get
			{
				return main.binFileTxtBox.Text;
			}
			set
			{
				main.binFileTxtBox.Text = value;
			}
		}

        public static string DatFileTxtBox
		{
			get
			{
				return main.datFileTxtBox.Text;
			}
			set
			{
				main.datFileTxtBox.Text = value;
			}
		}
		
        public static string OutputTxtBox
		{
			get
			{
				return main.outputTxtBox.Text;
			}
			set
			{
				main.outputTxtBox.Text = value;
			}
		}
        
        public static bool MachO
		{
			get
			{
				return main.iOSSwitch.Value;
			}
			set
			{
                main.iOSSwitch.Value = value;
			}
		}

		private static bool rememberWindowPosition;
		public static bool RememberWindowPosition
		{
			get
			{
				return rememberWindowPosition;
			}
			set
			{
				rememberWindowPosition = value;
			}
		}

		private static bool autoSetDir;
		public static bool AutoSetDir
		{
			get
			{
				return autoSetDir;
			}
			set
			{
				autoSetDir = value;
			}
		}

		private static bool checkForUpdate;
		public static bool CheckForUpdate
		{
			get
			{
				return checkForUpdate;
			}
			set
			{
				checkForUpdate = value;
			}
		}

		private static bool extBinaryChkBox;
		public static bool ExtBinaryChkBox
		{
			get
			{
				return extBinaryChkBox;
			}
			set
			{
				extBinaryChkBox = value;
			}
		}

		public static void Load()
		{
            RegistryKey rkey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Il2CppDumper GUI");
            if (rkey != null)
            {
                try
                {
                    BinaryFileTxtBox = (string)rkey.GetValue("BinFile");
                    DatFileTxtBox = (string)rkey.GetValue("DatFile");
                    OutputTxtBox = (string)rkey.GetValue("OutputDir");
					RememberWindowPosition = (int)rkey.GetValue("RememberWindowPosition") == 1;
					AutoSetDir = (int)rkey.GetValue("AutoSetDir") == 1;
					CheckForUpdate = (int)rkey.GetValue("CheckForUpdate") == 1;
					ExtBinaryChkBox = (int)rkey.GetValue("ExtractBinary") == 1;
                    MachO = (int)rkey.GetValue("Platform") == 1;
                    if (RememberWindowPosition)
                    {
                        main.StartPosition = FormStartPosition.Manual;
                        int formX = (int)rkey.GetValue("X");
                        int formY = (int)rkey.GetValue("Y");
                        main.Location = new Point(formX, formY);
                    }
                    rkey.Close();
                }
                catch
                { //silent
                }
            }
        }

        public static void Save()
        {
            RegistryKey regKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Il2CppDumper GUI");
            regKey.SetValue("BinFile", BinaryFileTxtBox);
            regKey.SetValue("DatFile", DatFileTxtBox);
            regKey.SetValue("OutputDir", OutputTxtBox);
            regKey.SetValue("X", main.Location.X, RegistryValueKind.DWord);
            regKey.SetValue("Y", main.Location.Y, RegistryValueKind.DWord);
            regKey.SetValue("RememberWindowPosition", RememberWindowPosition, RegistryValueKind.DWord);
            regKey.SetValue("AutoSetDir", AutoSetDir, RegistryValueKind.DWord);
            regKey.SetValue("CheckForUpdate", CheckForUpdate, RegistryValueKind.DWord);
            regKey.SetValue("MachO", MachO, RegistryValueKind.DWord);
            regKey.SetValue("ExtractBinary", ExtBinaryChkBox, RegistryValueKind.DWord);
            regKey.Close();
        }
	}
}
