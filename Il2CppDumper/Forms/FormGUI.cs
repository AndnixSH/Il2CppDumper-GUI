﻿using Bluegrams.Application;
using Il2CppDumper.Properties;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

//Note: Rename the assembly name every update to bypass false positives by anti-virus

namespace Il2CppDumper
{
    public partial class FormGUI : Form
    {
        public static FormGUI main;

        internal FormDump aFormDump;
        internal FormSettings aFormOptions;
        internal FormAbout aFormAbout;

        private static Config config;

        //Fonts
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
   IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);
        public PrivateFontCollection fonts = new PrivateFontCollection();

        string realPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\";
        string tempPath = Path.GetTempPath() + "\\";

        string Version = "1.5.0";

        public FormGUI()
        {
            InitializeComponent();

            settingsPicBox.MouseLeave += new EventHandler((sender, e) => settingsPicBox.BackColor = Color.FromArgb(0, 0, 0, 0));
            settingsPicBox.MouseEnter += new EventHandler((sender, e) => settingsPicBox.BackColor = Color.FromArgb(36, 93, 127));
            aboutPicBox.MouseLeave += new EventHandler((sender, e) => aboutPicBox.BackColor = Color.FromArgb(0, 0, 0, 0));
            aboutPicBox.MouseEnter += new EventHandler((sender, e) => aboutPicBox.BackColor = Color.FromArgb(36, 93, 127));

            aFormDump = new FormDump(this);
            aFormOptions = new FormSettings(this);
            aFormAbout = new FormAbout(this);

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            byte[] fontData = Resources.GOTHIC;
            IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
            Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Resources.GOTHIC.Length);
            AddFontMemResourceEx(fontPtr, (uint)Resources.GOTHIC.Length, IntPtr.Zero, ref dummy);
            Marshal.FreeCoTaskMem(fontPtr);

            fontData = Resources.GOTHICB;
            fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
            Marshal.Copy(fontData, 0, fontPtr, fontData.Length);

            fonts.AddMemoryFont(fontPtr, Resources.GOTHICB.Length);
            AddFontMemResourceEx(fontPtr, (uint)Resources.GOTHICB.Length, IntPtr.Zero, ref dummy);
            Marshal.FreeCoTaskMem(fontPtr);

            SetAllControlsFont(Controls);

            //copy context menu
            ContextMenu contextMenu = new ContextMenu();
            MenuItem menuItem = new MenuItem();
            menuItem = new MenuItem("Copy");
            menuItem.Click += new EventHandler(CopyAction);
            contextMenu.MenuItems.Add(menuItem);
            richTextBoxLogs.ContextMenu = contextMenu;

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
            if (File.Exists(realPath + "config.json"))
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
                var flag = il2Cpp.PlusSearch(metadata.methodDefs.Count(x => x.methodIndex >= 0), metadata.typeDefs.Length, metadata.imageDefs.Length);
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    if (!flag && il2Cpp is PE)
                    {
                        LogOutput("Use custom PE loader");
                        il2Cpp = PELoader.Load(il2cppPath);
                        il2Cpp.SetProperties(version, metadata.maxMetadataUsages);
                        flag = il2Cpp.PlusSearch(metadata.methodDefs.Count(x => x.methodIndex >= 0), metadata.typeDefs.Length, metadata.imageDefs.Length);
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
                LogOutput(ex.ToString());
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
            if (config.GenerateStruct)
            {
                WriteLine("Generate struct...");
                var scriptGenerator = new StructGenerator(executor);
                scriptGenerator.WriteScript(outputDir);
                WriteLine("Done!");
            }
            if (config.GenerateDummyDll)
            {
                WriteLine("Generate dummy dll...");
                DummyAssemblyExporter.Export(executor, outputDir, config.DummyDllAddToken);
                WriteLine("Done!");
                Directory.SetCurrentDirectory(realPath); //Fix read-only directory permission
            }
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
                            LogOutput("https://repo.andnixsh.com/tools/il2cppdumper/Il2CppDumperGUI.zip", Color.Lime);
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
        private async Task iOSDump(string file, string outputPath)
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
                            if (Settings.Default.ExtDatChkBox)
                                metadataFile.ExtractToFile(FileDir(outputPath + "global-metadata.dat"), true);
                            metadataFile.ExtractToFile(tempPath + "global-metadata.dat", true);
                            if (iOSSwitch.Value)
                            {
                                LogOutput("----- [Dumping ARM64] -----", Color.Chartreuse);

                                if (Settings.Default.ExtBinaryChkBox)
                                    binaryFile.ExtractToFile(FileDir(outputPath + $"/{ipaBinaryName}"), true);
                                binaryFile.ExtractToFile(tempPath + "arm64", true);
                                Dumper(tempPath + "arm64", tempPath + "global-metadata.dat", FileDir(outputPath + "\\"));
                            }
                            else
                            {
                                LogOutput("----- [Dumping ARMv7] -----", Color.Chartreuse);

                                if (Settings.Default.ExtBinaryChkBox)
                                    binaryFile.ExtractToFile(FileDir(outputPath + $"/{ipaBinaryName}"), true);
                                binaryFile.ExtractToFile(tempPath + "armv7", true);
                                Dumper(tempPath + "armv7", tempPath + "global-metadata.dat", FileDir(outputPath + "\\"));
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

        private async Task APKDump(string file, string outputPath)
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
                        if (Settings.Default.ExtDatChkBox)
                            metadataFile.ExtractToFile(FileDir(outputPath + "global-metadata.dat"), true);
                        metadataFile.ExtractToFile(tempPath + "global-metadata.dat", true);

                        foreach (ZipArchiveEntry entry in archive.Entries)
                        {
                            if (entry.FullName.Equals(@"lib/armeabi-v7a/libil2cpp.so"))
                            {
                                LogOutput("----- [Dumping ARMv7] -----", Color.Chartreuse);

                                if (Settings.Default.ExtBinaryChkBox)
                                    entry.ExtractToFile(FileDir(outputPath + "\\ARMv7\\libil2cpp.so"), true);
                                entry.ExtractToFile(tempPath + "libil2cpparmv7", true);
                                Dumper(tempPath + "libil2cpparmv7", tempPath + "global-metadata.dat", FileDir(outputPath + "\\ARMv7\\"));
                            }

                            if (entry.FullName.Equals(@"lib/arm64-v8a/libil2cpp.so"))
                            {
                                LogOutput("----- [Dumping ARM64] -----", Color.Chartreuse);

                                if (Settings.Default.ExtBinaryChkBox)
                                    entry.ExtractToFile(FileDir(outputPath + "\\ARM64\\libil2cpp.so"), true);
                                entry.ExtractToFile(tempPath + "libil2cpparm64", true);
                                Dumper(tempPath + "libil2cpparm64", tempPath + "global-metadata.dat", FileDir(outputPath + "\\ARM64\\"));
                            }

                            if (entry.FullName.Equals(@"lib/x86/libil2cpp.so"))
                            {
                                LogOutput("Dumping x86...", Color.Chartreuse);

                                if (Settings.Default.ExtBinaryChkBox)
                                    entry.ExtractToFile(FileDir(outputPath + "\\x86\\libil2cpp.so"), true);
                                entry.ExtractToFile(tempPath + "libil2cppx86", true);
                                Dumper(tempPath + "libil2cppx86", tempPath + "global-metadata.dat", FileDir(outputPath + "\\x86\\"));
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

        private async Task APKSplitDump(string file, string outputPath)
        {
            LogOutput("----- [Dumping Split APK] -----", Color.Chartreuse);
            await Task.Factory.StartNew(() =>
            {
                using (ZipArchive archive = ZipFile.OpenRead(file))
                {
                    var binaryFile = archive.Entries.FirstOrDefault(f => f.Name.Contains("libil2cpp.so"));
                    var metadataPath = archive.Entries.FirstOrDefault(f => f.FullName.Contains("assets/bin/Data/Managed/etc/"));
                    var metadataFile = archive.Entries.FirstOrDefault(f => f.FullName == "assets/bin/Data/Managed/Metadata/global-metadata.dat");

                    if (metadataFile != null)
                    {
                        if (Settings.Default.ExtDatChkBox)
                            metadataFile.ExtractToFile(FileDir(outputPath + "global-metadata.dat"), true);
                        metadataFile.ExtractToFile(tempPath + "global-metadata.dat", true);
                    }

                    if (binaryFile != null)
                    {
                        binaryFile.ExtractToFile(tempPath + "libil2cpp.so", true);
                    }

                    if (File.Exists(tempPath + "libil2cpp.so") && File.Exists(tempPath + "global-metadata.dat"))
                    {
                        Dumper(tempPath + "libil2cpp.so", tempPath + "global-metadata.dat", FileDir(outputPath + "\\"));
                    }
                }
            });
        }

        private async Task APKsDump(string file, string outputPath)
        {
            await Task.Factory.StartNew(() =>
            {
                using (ZipArchive archive = ZipFile.OpenRead(file))
                {
                    foreach (var entryApks in archive.Entries)
                    {
                        if (entryApks.FullName.EndsWith(".apk", StringComparison.OrdinalIgnoreCase))
                        {
                            var apkFile = Path.Combine(tempPath, entryApks.FullName);
                            entryApks.ExtractToFile(apkFile, true);
                            using (ZipArchive entryBase = ZipFile.OpenRead(apkFile))
                            {
                                var binaryFile = entryBase.Entries.FirstOrDefault(f => f.Name.Contains("libil2cpp.so"));
                                var metadataFile = entryBase.Entries.FirstOrDefault(f => f.FullName == "assets/bin/Data/Managed/Metadata/global-metadata.dat");

                                if (Settings.Default.ExtDatChkBox)
                                    metadataFile?.ExtractToFile(FileDir(outputPath + "global-metadata.dat"), true);
                                metadataFile?.ExtractToFile(tempPath + "global-metadata.dat", true);

                                if (binaryFile != null)
                                {
                                    binaryFile.ExtractToFile(tempPath + "libil2cpp.so", true);

                                    foreach (var entry in entryBase.Entries)
                                    {
                                        if (entry.FullName.Equals("lib/armeabi-v7a/libil2cpp.so"))
                                        {
                                            WriteLine("Dumping ARMv7...", Color.Chartreuse);

                                            if (Settings.Default.ExtBinaryChkBox)
                                                entry.ExtractToFile(FileDir(outputPath + "\\ARMv7\\libil2cpp.so"), true);
                                            entry.ExtractToFile(tempPath + "libil2cpparmv7", true);
                                            Dumper(tempPath + "libil2cpparmv7", tempPath + "global-metadata.dat", FileDir(outputPath + "\\ARMv7\\"));
                                        }

                                        if (entry.FullName.Equals(@"lib/arm64-v8a/libil2cpp.so"))
                                        {
                                            WriteLine("Dumping ARM64...", Color.Chartreuse);

                                            if (Settings.Default.ExtBinaryChkBox)
                                                entry.ExtractToFile(FileDir(outputPath + "\\ARM64\\libil2cpp.so"), true);
                                            entry.ExtractToFile(tempPath + "libil2cpparm64", true);
                                            Dumper(tempPath + "libil2cpparm64", tempPath + "global-metadata.dat", FileDir(outputPath + "\\ARM64\\"));
                                        }

                                        if (entry.FullName.Equals(@"lib/x86/libil2cpp.so"))
                                        {
                                            WriteLine("Dumping x86...", Color.Chartreuse);

                                            if (Settings.Default.ExtBinaryChkBox)
                                                entry.ExtractToFile(FileDir(outputPath + "\\x86\\libil2cpp.so"), true);
                                            entry.ExtractToFile(tempPath + "libil2cppx86", true);
                                            Dumper(tempPath + "libil2cppx86", tempPath + "global-metadata.dat", FileDir(outputPath + "\\x86\\"));
                                        }
                                    }
                                }
                                entryBase.Dispose();
                            }
                            File.Delete(apkFile);
                        }
                    }
                    archive.Dispose();
                }
            }).ConfigureAwait(false);
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
                LogOutput(ex.ToString() + "\n", Color.Red);
            }
        }

        private void CopyScripts(string outputPath)
        {
            var guiPath = AppDomain.CurrentDomain.BaseDirectory;
            try
            {
                if (Settings.Default.ghidra)
                {
                    if (File.Exists(guiPath + "ghidra.py"))
                    {
                        File.Copy(guiPath + "ghidra.py", outputPath + "ghidra.py", true);
                        LogOutput($"Copied ghidra.py");
                    }
                    else
                        LogOutput("ghidra.py does not exist", Color.Yellow);
                }
                if (Settings.Default.ghidra_with_struct)
                {
                    if (File.Exists(guiPath + "ghidra_with_struct.py"))
                    {
                        File.Copy(guiPath + "ghidra_with_struct.py", outputPath + "ghidra_with_struct.py", true);
                        LogOutput($"Copied ghidra_with_struct.py");
                    }
                    else
                        LogOutput("ghidra_with_struct.py does not exist", Color.Yellow);
                }
                if (Settings.Default.ida)
                {
                    if (File.Exists(guiPath + "ida.py"))
                    {
                        File.Copy(guiPath + "ida.py", outputPath + "ida.py", true);
                        LogOutput($"Copied ida.py");
                    }
                    else
                        LogOutput("ida.py does not exist", Color.Yellow);
                }
                if (Settings.Default.ida_py3)
                {
                    if (File.Exists(guiPath + "ida_py3.py"))
                    {
                        File.Copy(guiPath + "ida_py3.py", outputPath + "ida_py3.py", true);
                        LogOutput($"Copied ida_py3.py");
                    }
                    else
                        LogOutput("ida_py3.py does not exist", Color.Yellow);
                }
                if (Settings.Default.ida_with_struct)
                {
                    if (File.Exists(guiPath + "ida_with_struct.py"))
                    {
                        File.Copy(guiPath + "ida_with_struct.py", outputPath + "ida_with_struct.py", true);
                        LogOutput($"Copied ida_with_struct.py");
                    }
                    else
                        LogOutput("ida_with_struct.py does not exist", Color.Yellow);
                }
                if (Settings.Default.ida_with_struct_py3)
                {
                    if (File.Exists(guiPath + "ida_with_struct_py3.py"))
                    {
                        File.Copy(guiPath + "ida_with_struct_py3.py", outputPath + "ida_with_struct_py3.py", true);
                        LogOutput($"Copied ida_with_struct_py3.py");
                    }
                    else
                        LogOutput("ida_with_struct_py3.py does not exist", Color.Yellow);
                }
            }
            catch (Exception ex)
            {
                LogOutput(ex.ToString(), Color.Red);
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
                    DeleteFile(tempPath + "global-metadata.dat");
                    DeleteFile(tempPath + "libil2cpp.so");
                }
                string outputPath;
                if (Settings.Default.AutoSetDir)
                {
                    outputPath = Path.GetDirectoryName(files[0]) + "\\" + Path.GetFileNameWithoutExtension(files[0]) + "_dumped\\";
                }
                else
                {
                    outputPath = outputTxtBox.Text + Path.GetFileNameWithoutExtension(files[0]) + "_dumped\\";
                }

                foreach (var file in files)
                {
                    switch (Path.GetExtension(file))
                    {
                        case ".dat":
                            datFileTxtBox.Text = file;
                            break;
                        case ".apk":
                            richTextBoxLogs.Text = "";
                            if (files.Length > 1)
                            {
                                LogOutput("Dumping Il2Cpp from splitted APKs...", Color.Cyan);
                                await APKSplitDump(file, outputPath);
                            }
                            else
                                await APKDump(file, outputPath);
                            break;
                        case ".apks":
                        case ".xapk":
                            await APKsDump(file, outputPath);
                            break;
                        case ".ipa":
                            richTextBoxLogs.Text = "";
                            await iOSDump(file, outputPath);
                            break;
                        default:
                            binFileTxtBox.Text = file;
                            break;
                    }

                    if (Settings.Default.AutoSetDir)
                        outputTxtBox.Text = Path.GetDirectoryName(file) + "\\";
                }

                CopyScripts(outputPath);
            }

            catch (Exception ex)
            {
                LogOutput(ex.ToString());
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

        private void FormGUI_Load(object sender, EventArgs e)
        {
            //https://github.com/Bluegrams/SettingsProviders
            PortableSettingsProvider.SettingsFileName = "Il2CppDumper.config";
            PortableSettingsProviderBase.SettingsDirectory = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            PortableSettingsProvider.ApplyProvider(Settings.Default);

            binFileTxtBox.Text = Settings.Default.BinaryFileTxtBox;
            datFileTxtBox.Text = Settings.Default.DatFileTxtBox;
            outputTxtBox.Text = Settings.Default.OutputTxtBox;
            iOSSwitch.Checked = Settings.Default.MachO;
            if (Settings.Default.RememberWindowPosition)
            {
                Location = Settings.Default.Location;
            }

            titleLbl.Text += " " + Version;

            if (IsAdministrator())
            {
                titleLbl.Text += " - Administrator ";
                LogOutput("You are running as administrator. Drag and drop will not work\nIf this program is running as administrator by default, change your User Account Control back to default", Color.Yellow);
            }

            if (Settings.Default.CheckForUpdate)
                CheckUpdate();
        }
        #endregion

        #region Button click handlers
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Settings.Default.BinaryFileTxtBox = binFileTxtBox.Text;
            Settings.Default.DatFileTxtBox = datFileTxtBox.Text;
            Settings.Default.OutputTxtBox = outputTxtBox.Text;
            Settings.Default.MachO = iOSSwitch.Checked;
            Settings.Default.Location = Location;

            Settings.Default.Save();
            Application.Exit();
        }

        private void settingsPicBox_Click(object sender, EventArgs e)
        {
            FormSettings form = new FormSettings();
            form.Show();
        }

        private void aboutPicBox_Click(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
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
                if (Settings.Default.AutoSetDir)
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
        public static bool IsAdministrator()
        {
            return (new WindowsPrincipal(WindowsIdentity.GetCurrent()))
                      .IsInRole(WindowsBuiltInRole.Administrator);
        }

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