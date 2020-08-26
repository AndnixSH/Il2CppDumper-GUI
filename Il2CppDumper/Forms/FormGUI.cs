using System;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Microsoft.Win32;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Net;
using System.Drawing.Text;
using System.IO.Compression;
using System.Threading.Tasks;
using System.Threading;

using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

//Note: Rename the assembly name every update to bypass false positives by anti-virus

namespace Il2CppDumper
{
    public partial class FormGUI : Form
    {
        public static FormGUI main;

        internal FormDump aFormDump;
        internal FormOptions aFormOptions;
        internal FormRegistry aFormRegistry;

        private static Config config;

        //Fonts
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
   IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);
        public PrivateFontCollection fonts = new PrivateFontCollection();

        string RealPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\";
        string TempPath = Path.GetTempPath() + "\\";

        string Version = "1.3.4";

        public FormGUI()
        {
            InitializeComponent();
            titleLbl.Text += " - " + Version;

            settingsPicBox.MouseLeave += new EventHandler((sender, e) => settingsPicBox.BackColor = Color.FromArgb(0, 0, 0, 0));
            settingsPicBox.MouseEnter += new EventHandler((sender, e) => settingsPicBox.BackColor = Color.FromArgb(36, 93, 127));

            aFormDump = new FormDump(this);
            aFormOptions = new FormOptions(this);
            aFormRegistry = new FormRegistry(this);

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            byte[] fontData = Properties.Resources.GOTHIC;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.GOTHIC.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.GOTHIC.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            fontData = Properties.Resources.GOTHICB;
            fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);

            fonts.AddMemoryFont(fontPtr, Properties.Resources.GOTHICB.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.GOTHICB.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            SetAllControlsFont(Controls);

            //copy context menu
            ContextMenu contextMenu = new ContextMenu();
            MenuItem menuItem = new MenuItem();
            menuItem = new MenuItem("Copy");
            menuItem.Click += new EventHandler(CopyAction);
            contextMenu.MenuItems.Add(menuItem);
            richTextBoxLogs.ContextMenu = contextMenu;

            FormRegistry.Load();

            if (FormRegistry.CheckForUpdate)
                CheckUpdate();

            main = this;
        }

        #region Il2Cpp dumper
        private bool Init(string il2cppPath, string metadataPath, out Metadata metadata, out Il2Cpp il2Cpp)
        {
            string Mach_O = "2";
            Invoke(new Action(delegate ()
            {
                if (!iOSSwitch.Value)
                    Mach_O = "1";
            }));

            LogOutput("Read config...");
            if (File.Exists(RealPath + "config.json"))
            {
                config = JsonConvert.DeserializeObject<Config>(File.ReadAllText(Application.StartupPath + Path.DirectorySeparatorChar + @"config.json"));
            }
            else
            {
                config = new Config();
                LogOutput("config.json file does not exist. Using defaults", Color.Yellow);
            }

            LogOutput("Initializing metadata...");
            var metadataBytes = File.ReadAllBytes(metadataPath);
            metadata = new Metadata(new MemoryStream(metadataBytes));
            LogOutput($"Metadata Version: {metadata.Version}");
            LogOutput("Initializing il2cpp file...");
            var il2cppBytes = File.ReadAllBytes(il2cppPath);
            var il2cppMagic = BitConverter.ToUInt32(il2cppBytes, 0);
            var il2CppMemory = new MemoryStream(il2cppBytes);
            switch (il2cppMagic)
            {
                default:
                    throw new NotSupportedException("ERROR: il2cpp file not supported.");
                case 0x6D736100:
                    var web = new WebAssembly(il2CppMemory);
                    il2Cpp = web.CreateMemory();
                    break;
                case 0x304F534E:
                    var nso = new NSO(il2CppMemory);
                    il2Cpp = nso.UnCompress();
                    break;
                case 0x905A4D: //PE
                    il2Cpp = new PE(il2CppMemory);
                    break;
                case 0x464c457f: //ELF
                    if (il2cppBytes[4] == 2) //ELF64
                    {
                        il2Cpp = new Elf64(il2CppMemory);
                    }
                    else
                    {
                        il2Cpp = new Elf(il2CppMemory);
                    }
                    break;
                case 0xCAFEBABE: //FAT Mach-O
                case 0xBEBAFECA:
                    var machofat = new MachoFat(new MemoryStream(il2cppBytes));
                    for (var i = 0; i < machofat.fats.Length; i++)
                    {
                        var fat = machofat.fats[i];
                        //Console.Write(fat.magic == 0xFEEDFACF ? $"{i + 1}.64bit " : $"{i + 1}.32bit ");
                    }
                    var index = int.Parse(Mach_O) - 1;
                    var magic = machofat.fats[index % 2].magic;
                    il2cppBytes = machofat.GetMacho(index % 2);
                    il2CppMemory = new MemoryStream(il2cppBytes);
                    if (magic == 0xFEEDFACF)
                        goto case 0xFEEDFACF;
                    else
                        goto case 0xFEEDFACE;
                case 0xFEEDFACF: // 64bit Mach-O
                    il2Cpp = new Macho64(il2CppMemory);
                    break;
                case 0xFEEDFACE: // 32bit Mach-O
                    il2Cpp = new Macho(il2CppMemory);
                    break;
            }

            var version = config.ForceIl2CppVersion ? config.ForceVersion : metadata.Version;
            il2Cpp.SetProperties(version, metadata.maxMetadataUsages);
            LogOutput($"Il2Cpp Version: {il2Cpp.Version}");
            if (il2Cpp.Version >= 27 && il2Cpp is ElfBase elf && elf.IsDumped)
            {
                FormDump form = new FormDump();
                form.dumpNoteLbl.Text = "Input global-metadata.dat dump address:";
                form.Message = 0;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    metadata.Address = Convert.ToUInt64(Console.ReadLine(), 16);
                    LogOutput("Inputted address: " + metadata.Address.ToString("X"));
                }
            }

            LogOutput("Searching...");
            try
            {
                var flag = il2Cpp.PlusSearch(metadata.methodDefs.Count(x => x.methodIndex >= 0), metadata.typeDefs.Length);
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    if (!flag && il2Cpp is PE)
                    {
                        LogOutput("Use custom PE loader");
                        il2Cpp = PELoader.Load(il2cppPath);
                        il2Cpp.SetProperties(version, metadata.maxMetadataUsages);
                        flag = il2Cpp.PlusSearch(metadata.methodDefs.Count(x => x.methodIndex >= 0), metadata.typeDefs.Length);
                    }
                }
                if (!flag)
                {
                    flag = il2Cpp.Search();
                }
                if (!flag)
                {
                    flag = il2Cpp.SymbolSearch();
                }
                if (!flag)
                {
                    LogOutput("ERROR: Can't use auto mode to process file, input offset pointers to try manual mode.", Color.Yellow);
                    var codeRegistration = Convert.ToUInt64(CodeRegistrationTxtBox.Text, 16);
                    var metadataRegistration = Convert.ToUInt64(metadataRegistrationTxtBox.Text, 16);
                    il2Cpp.Init(codeRegistration, metadataRegistration);
                    return true;
                }
            }
            catch (Exception ex)
            {
                LogOutput("An error occurred while processing.", Color.Red);
#if DEBUG
                LogOutput(ex.ToString());
#else
                LogOutput(ex.Message);
#endif
                return false;
            }
            return true;
        }

        private void Dump(Metadata metadata, Il2Cpp il2Cpp, string outputDir)
        {
            WriteLine("Dumping...");
            var executor = new Il2CppExecutor(metadata, il2Cpp);
            var decompiler = new Il2CppDecompiler(executor);
            decompiler.Decompile(config, outputDir);
            WriteLine("Done!");
            if (config.GenerateScript)
            {
                WriteLine("Generate script...");
                var scriptGenerator = new ScriptGenerator(executor);
                scriptGenerator.WriteScript(outputDir);
                WriteLine("Done!");
            }
            if (config.GenerateDummyDll)
            {
                WriteLine("Generate dummy dll...");
                DummyAssemblyExporter.Export(executor, outputDir);
                WriteLine("Done!");
                Directory.SetCurrentDirectory(RealPath); //Fix read-only directory permission
            }
            WriteLine("");
        }
        #endregion

        #region Check for update
        private async void CheckUpdate()
        {
            await Task.Factory.StartNew(() =>
            {
                if (NetworkInterface.GetIsNetworkAvailable() == true)
                {
                    try
                    {
                        WebClient w = new WebClient();
                        string remoteVersion = w.DownloadString("https://repo.andnixsh.com/tools/il2cppdumper/version");

                        if (!String.IsNullOrEmpty(remoteVersion) && !remoteVersion.Contains(Version))
                        {
                            LogOutput("A new version is available: " + remoteVersion, Color.Lime);
                            LogOutput("\nhttps://repo.andnixsh.com/tools/il2cppdumper/Il2CppDumperGUI.zip", Color.Lime);
                        }
                    }
                    catch
                    {
                        LogOutput("An error checking for update", Color.Yellow);
                    }
                }
            });
        }

        private void richTextBoxLogs_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }
        #endregion

        #region Auto Dump
        async Task iOSDump(string file, string outputPath)
        {
            await Task.Factory.StartNew(() =>
            {
                using (ZipArchive archive = ZipFile.OpenRead(file))
                {
                    var ipaBinaryFolder = archive.Entries.FirstOrDefault(f => f.FullName.StartsWith("Payload/") && f.FullName.EndsWith(".app/") && f.FullName.Count(x => x == '/') == 2);

                    if (ipaBinaryFolder != null)
                    {
                        Regex myRegex3 = new Regex(@"(?<=Payload\/)(.*?)(?=.app\/)", RegexOptions.None);
                        Match match = myRegex3.Match(ipaBinaryFolder.FullName);

                        var ipaBinaryName = match.ToString();
                        var metadataFile = archive.Entries.FirstOrDefault(f => f.FullName == $"Payload/{ipaBinaryName}.app/Data/Managed/Metadata/global-metadata.dat");
                        var binaryFile = archive.Entries.FirstOrDefault(f => f.FullName == $"Payload/{ipaBinaryName}.app/{ipaBinaryName}");
                        if (metadataFile != null)
                        {
                            metadataFile.ExtractToFile(TempPath + "global-metadata.dat", true);
                            if (iOSSwitch.Value)
                            {
                                LogOutput("Dumping ARM64...", Color.Chartreuse);

                                if (FormRegistry.ExtBinaryChkBox)
                                    binaryFile.ExtractToFile(FileDir(outputPath + $"/{ipaBinaryName}"), true);
                                binaryFile.ExtractToFile(TempPath + "arm64", true);
                                Dumper(TempPath + "arm64", TempPath + "global-metadata.dat", FileDir(outputPath + "\\"));
                            }
                            else
                            {
                                LogOutput("Dumping ARMv7...", Color.Chartreuse);

                                if (FormRegistry.ExtBinaryChkBox)
                                    binaryFile.ExtractToFile(FileDir(outputPath + $"/{ipaBinaryName}"), true);
                                binaryFile.ExtractToFile(TempPath + "armv7", true);
                                Dumper(TempPath + "armv7", TempPath + "global-metadata.dat", FileDir(outputPath + "\\"));
                            }
                        }
                        else
                            LogOutput("This IPA does not contain an IL2CPP application", Color.Yellow);
                    }
                    else
                    {
                        LogOutput("Failed to extract required file. Please extract the files manually", Color.Yellow);
                    }
                }
            });
        }

        async Task APKDump(string file, string outputPath)
        {
            await Task.Factory.StartNew(() =>
            {
                using (ZipArchive archive = ZipFile.OpenRead(file))
                {
                    var binaryFile = archive.Entries.FirstOrDefault(f => f.Name.Contains("libil2cpp.so"));
                    var metadataPath = archive.Entries.FirstOrDefault(f => f.FullName.Contains("assets/bin/Data/Managed/Resources/"));
                    var metadataFile = archive.Entries.FirstOrDefault(f => f.FullName == "assets/bin/Data/Managed/Metadata/global-metadata.dat");

                    if (binaryFile == null && metadataPath != null)
                    {
                        LogOutput("This APK does not contain lib folder. APK has been splitted", Color.Yellow);
                        return;
                    }
                    else if (binaryFile != null && metadataPath == null)
                    {
                        LogOutput("This APK contains il2cpp but does not contain global-metadata.dat. It may be protected or APK has been splitted", Color.Yellow);
                        return;
                    }

                    if (metadataFile != null)
                    {
                        metadataFile.ExtractToFile(TempPath + "global-metadata.dat", true);

                        foreach (ZipArchiveEntry entry in archive.Entries)
                        {
                            if (entry.FullName.Equals(@"lib/armeabi-v7a/libil2cpp.so"))
                            {
                                LogOutput("Dumping ARMv7...", Color.Chartreuse);

                                if (FormRegistry.ExtBinaryChkBox)
                                    entry.ExtractToFile(FileDir(outputPath + "\\ARMv7\\libil2cpp.so"), true);
                                entry.ExtractToFile(TempPath + "libil2cpparmv7", true);
                                Dumper(TempPath + "libil2cpparmv7", TempPath + "global-metadata.dat", FileDir(outputPath + "\\ARMv7\\"));
                            }

                            if (entry.FullName.Equals(@"lib/arm64-v8a/libil2cpp.so"))
                            {
                                LogOutput("Dumping ARM64...", Color.Chartreuse);

                                if (FormRegistry.ExtBinaryChkBox)
                                    entry.ExtractToFile(FileDir(outputPath + "\\ARM64\\libil2cpp.so"), true);
                                entry.ExtractToFile(TempPath + "libil2cpparm64", true);
                                Dumper(TempPath + "libil2cpparm64", TempPath + "global-metadata.dat", FileDir(outputPath + "\\ARM64\\"));
                            }

                            if (entry.FullName.Equals(@"lib/x86/libil2cpp.so"))
                            {
                                LogOutput("Dumping x86...", Color.Chartreuse);

                                if (FormRegistry.ExtBinaryChkBox)
                                    entry.ExtractToFile(FileDir(outputPath + "\\x86\\libil2cpp.so"), true);
                                entry.ExtractToFile(TempPath + "libil2cppx86", true);
                                Dumper(TempPath + "libil2cppx86", TempPath + "global-metadata.dat", FileDir(outputPath + "\\x86\\"));
                            }
                        }
                    }
                    else
                    {
                        LogOutput("This APK does not contain an IL2CPP application", Color.Yellow);
                    }
                }
            });
        }

        async Task APKSplitDump(string file, string outputPath)
        {
            await Task.Factory.StartNew(() =>
            {
                using (ZipArchive archive = ZipFile.OpenRead(file))
                {
                    var binaryFile = archive.Entries.FirstOrDefault(f => f.Name.Contains("libil2cpp.so"));
                    var metadataPath = archive.Entries.FirstOrDefault(f => f.FullName.Contains("assets/bin/Data/Managed/etc/"));
                    var metadataFile = archive.Entries.FirstOrDefault(f => f.FullName == "assets/bin/Data/Managed/Metadata/global-metadata.dat");

                    if (metadataFile != null)
                    {
                        Debug.WriteLine("Extracted global-metadata.dat to temp");
                        metadataFile.ExtractToFile(TempPath + "global-metadata.dat", true);
                    }

                    if (binaryFile != null)
                    {
                        Debug.WriteLine("Extracted libil2cpp.so to temp");
                        binaryFile.ExtractToFile(TempPath + "libil2cpp.so", true);
                    }

                    if (File.Exists(TempPath + "libil2cpp.so") && File.Exists(TempPath + "global-metadata.dat"))
                    {
                        Dumper(TempPath + "libil2cpp.so", TempPath + "global-metadata.dat", FileDir(outputPath + "\\"));
                    }
                }
            });
        }
        #endregion

        #region Dumping
        private void Dumper(string file, string metadataPath, string outputPath)
        {
            try
            {
                if (Init(file, metadataPath, out var metadata, out var il2Cpp))
                {
                    Dump(metadata, il2Cpp, outputPath);
                }
            }
            catch (Exception ex)
            {
#if DEBUG
                LogOutput($"{ex.ToString()}");
#else
                LogOutput($"{ex.Message}");
#endif
            }
        }
        #endregion

        #region Drag & Drop handlers
        private async void FormGUI_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                FormState(State.Running);

                BackColor = Color.FromArgb(21, 25, 31);
                if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;

                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length > 1)
                {
                    DeleteFile(TempPath + "global-metadata.dat");
                    DeleteFile(TempPath + "libil2cpp.so");
                }
                string outputPath;
                if (FormRegistry.AutoSetDir)
                {
                    outputPath = Path.GetDirectoryName(files[0]) + "\\" + Path.GetFileNameWithoutExtension(files[0]) + "_dumped\\";
                }
                else
                {
                    outputPath = outputTxtBox.Text + Path.GetFileNameWithoutExtension(files[0]) + "_dumped\\";
                }

                foreach (var file in files)
                {
                    var ext = Path.GetExtension(file);
                    if (ext.Equals(".dat"))
                    {
                        datFileTxtBox.Text = file;
                    }
                    else if (ext.Equals(".apk"))
                    {
                        richTextBoxLogs.Text = "";
                        if (files.Length > 1)
                        {
                            LogOutput("Dumping Il2Cpp from splitted APKs...", Color.Cyan);
                            await APKSplitDump(file, outputPath);
                        }
                        else
                            await APKDump(file, outputPath);
                    }
                    else if (ext.Equals(".ipa"))
                    {
                        richTextBoxLogs.Text = "";
                        await iOSDump(file, outputPath);
                    }
                    else
                    {
                        binFileTxtBox.Text = file;
                    }

                    if (FormRegistry.AutoSetDir)
                        outputTxtBox.Text = Path.GetDirectoryName(file) + "\\";
                }
            }

            catch (Exception ex)
            {
#if DEBUG
                LogOutput(ex.ToString());
#else
                LogOutput(ex.Message);
#endif
            }
            FormState(State.Idle);
        }

        private void FormGUI_DragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (var file in files)
            {
                var ext = Path.GetExtension(file);
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void FormGUI_DragLeave(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(21, 25, 31);
        }

        private void FormGUI_DragOver(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (var file in files)
            {
                var ext = Path.GetExtension(file);
                BackColor = Color.FromArgb(34, 40, 50);
            }
        }
        #endregion

        #region Window handlers
        //Apply custom font without installing font on the system
        public void SetAllControlsFont(System.Windows.Forms.Control.ControlCollection ctrls)
        {
            foreach (Control c in ctrls)
            {
                if (c.Controls != null)
                {
                    SetAllControlsFont(c.Controls);
                }
                if (c is Label || c is TextBox)
                    c.Font = new Font(fonts.Families[0], c.Font.Size, c.Font.Style);
            }
        }

        void FormState(State state)
        {
            if (state == State.Running)
            {
                startBtn.Text = "Dumping...";
                startBtn.Enabled = false;
                selBinFile.Enabled = false;
                selDatFile.Enabled = false;
                selOutDir.Enabled = false;
                binFileTxtBox.Enabled = false;
                datFileTxtBox.Enabled = false;
                outputTxtBox.Enabled = false;
                iOSSwitch.Enabled = false;
            }
            else
            {
                startBtn.Text = "Start dumping";
                startBtn.Enabled = true;
                selBinFile.Enabled = true;
                selDatFile.Enabled = true;
                selOutDir.Enabled = true;
                binFileTxtBox.Enabled = true;
                datFileTxtBox.Enabled = true;
                outputTxtBox.Enabled = true;
                iOSSwitch.Enabled = true;
            }
        }
        private void richTextBoxLogs_TextChanged(object sender, EventArgs e)
        {
            richTextBoxLogs.SelectionStart = richTextBoxLogs.Text.Length;
            richTextBoxLogs.ScrollToCaret();
        }
        #endregion

        #region Button click handlers
        private void settingsPicBox_Click(object sender, EventArgs e)
        {
            FormOptions form = new FormOptions();
            form.Show();
        }

        private async void startBtn_Click(object sender, EventArgs e)
        {
            richTextBoxLogs.Text = "";
            if (!Directory.Exists(outputTxtBox.Text))
            {
                LogOutput("Output directory does not exist", Color.Red);
                return;
            }

            //Check of bin or dat file exists
            if (binFileTxtBox.Text == "")
            {
                LogOutput("Executable file is not selected", Color.Red);
                return;
            }

            if (datFileTxtBox.Text == "")
            {
                LogOutput("Metadata-global.dat file is not selected", Color.Red);
                return;
            }

            FormState(State.Running);

            await Task.Factory.StartNew(() =>
            {
                Dumper(binFileTxtBox.Text, datFileTxtBox.Text, outputTxtBox.Text);
            });

            FormState(State.Idle);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            FormRegistry.Save();
            Application.Exit();
        }

        private void openFolderBtn_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", outputTxtBox.Text);
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void selBinFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Il2Cpp binary file|*.*";
            ofd.Title = "Select Il2Cpp binary file";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                binFileTxtBox.Text = ofd.FileName;
                CodeRegistrationTxtBox.Text = "";
                metadataRegistrationTxtBox.Text = "";
                if (FormRegistry.AutoSetDir)
                {
                    outputTxtBox.Text = Path.GetDirectoryName(binFileTxtBox.Text) + "\\";
                }
            }
        }

        private void selDatFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "global-metadata|global-metadata.dat";
            ofd.Title = "Select global-metadata.dat";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                datFileTxtBox.Text = ofd.FileName;
                CodeRegistrationTxtBox.Text = "";
                metadataRegistrationTxtBox.Text = "";
            }
        }

        private void selOutDir_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                outputTxtBox.Text = fbd.SelectedPath + "\\"; //Show the path in label
            }
        }
        #endregion

        #region Copy to clipboard
        private void CopyAction(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBoxLogs.SelectedText);
        }
        #endregion

        #region Logging
        public static void WriteLine(string text)
        {
            main.LogOutput(text);
        }

        public static void WriteLine(string text, object text2)
        {
            main.LogOutput(string.Format(text, text2));
        }

        //Color list /*http://www.flounder.com/csharp_color_table.htm*/
        public void LogOutput(string text, Color? color = null)
        {
            Invoke(new Action(delegate ()
            {
                richTextBoxLogs.SelectionColor = color ?? Color.White;
                richTextBoxLogs.AppendText(text + Environment.NewLine);
            }));
        }
        #endregion

        #region Others

        string FileDir(string path)
        {
            if (!Directory.Exists(Path.GetDirectoryName(path)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(path));
            }
            return path;
        }

        void DeleteFile(string file)
        {
            if (File.Exists(file))
            {
                File.Delete(file);
            }
        }

        public enum State
        {
            Idle,
            Running
        }
        #endregion
    }
}