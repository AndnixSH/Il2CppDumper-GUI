using Bluegrams.Application;
using Il2CppDumper.Forms;
using Il2CppDumper.Properties;
using Il2CppDumper.Utils;
using Ionic.Zip;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shell;

namespace Il2CppDumper
{
    public partial class MainForm : Window
    {
        private static Config config;
        public static MainForm main { get; private set; }
        string appVersion = null;

        //string realPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\";
        string realPath = Path.GetDirectoryName(AppContext.BaseDirectory);
        string tempPath = Path.Combine(Path.GetTempPath(), "Il2CppDumper");
        string tempLibFile = Path.Combine(Path.GetTempPath(), "Il2CppDumper", "libil2cpp.so");

        //Nobody mod 32-bit iOS games so the switch has been removed, and forced 64-bit dump
        //I'll leave the codes here in case someone want to mod 32-bit games
        bool use64bitMach_O = true;

        public MainForm()
        {
            InitializeComponent();
            main = this;

            // Register the code page provider to fix error
            // System.ArgumentException: ''IBM437' is not a supported encoding name. For information on defining a custom encoding, see the documentation for the Encoding.RegisterProvider method. Arg_ParamName_Name'
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            //Create temp dir
            if (Directory.Exists(tempPath))
                Directory.Delete(tempPath, true);
            Directory.CreateDirectory(tempPath);

            //Get version
            string[] versionArray = Assembly.GetExecutingAssembly().GetName().Version.ToString().Split('.');
            appVersion = string.Join(".", versionArray.Take(3));
            versionTxt.Text = "v" + appVersion;

            //Load configs
            //https://github.com/Bluegrams/SettingsProviders
            PortableSettingsProvider.SettingsFileName = "Il2CppDumper.config";
            PortableSettingsProviderBase.SettingsDirectory = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            PortableSettingsProvider.ApplyProvider(Settings.Default);

            binFileTxtBox.Text = Settings.Default.BinaryFileTxtBox;
            datFileTxtBox.Text = Settings.Default.DatFileTxtBox;
            outputTxtBox.Text = Settings.Default.OutputTxtBox;
            androArch.SelectedIndex = Settings.Default.AndroArch;

            updateChkBox.IsChecked = Settings.Default.CheckForUpdate;
            autoSetDirCheck.IsChecked = Settings.Default.AutoSetDir;
            extBinaryChkBox.IsChecked = Settings.Default.ExtBinaryChkBox;
            extDatChkBox.IsChecked = Settings.Default.ExtDatChkBox;

            ghidraChkBox.IsChecked = Settings.Default.ghidra;
            ghidraWasmChkBox.IsChecked = Settings.Default.ghidra_wasm;
            ghidraWithStructChkBox.IsChecked = Settings.Default.ghidra_with_struct;
            hopperPy3ChkBox.IsChecked = Settings.Default.hopper;
            hopperPy3ChkBox.IsChecked = Settings.Default.hopper;
            idaChkBox.IsChecked = Settings.Default.ida;
            idaPy3ChkBox.IsChecked = Settings.Default.ida_py3;
            idaStructChkBox.IsChecked = Settings.Default.ida_with_struct;
            idaStructPy3ChkBox.IsChecked = Settings.Default.ida_with_struct_py3;
            headerToBinjaChkBox.IsChecked = Settings.Default.il2cpp_header_to_binja;
            headerToGhidraChkBox.IsChecked = Settings.Default.il2cpp_header_to_ghidra;

            //Check admin
            bool isAdmin = new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
            if (isAdmin)
            {
                Title += " - Administrator ";
                Log("You are running as administrator. Drag and drop will not work\nIf this program is running as administrator by default, change your User Account Control back to default", Brushes.Yellow);
            }

            if (Settings.Default.CheckForUpdate)
                CheckUpdate();
        }

        #region Il2Cpp dumper
        private bool Init(string il2cppPath, string metadataPath, out Metadata metadata, out Il2Cpp il2Cpp)
        {
            string Mach_O = "2";

            if (!use64bitMach_O)
                Mach_O = "1";

            Log("Read config...");
            if (File.Exists(realPath + "config.json"))
            {
                config = JsonConvert.DeserializeObject<Config>(File.ReadAllText(realPath + "config.json"));
            }
            else
            {
                config = new Config();
                Log("config.json file does not exist. Using defaults", Brushes.Yellow);
            }

            Log("Initializing metadata...");
            var metadataBytes = File.ReadAllBytes(metadataPath);
            metadata = new Metadata(new MemoryStream(metadataBytes));
            Log($"Metadata Version: {metadata.Version}");
            Log("Initializing il2cpp file...");
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
            il2Cpp.SetProperties(version, metadata.metadataUsagesCount);
            Log($"Il2Cpp Version: {il2Cpp.Version}");
            if (config.ForceDump || il2Cpp.CheckDump())
            {
                if (il2Cpp is ElfBase elf)
                {
                    bool confirm = false;
                    ulong DumpAddr = 0;
                    System.Windows.Application.Current.Dispatcher.Invoke((Action)delegate
                    {
                        InputOffsetForm form = new InputOffsetForm();
                        if (form.ShowDialog() ?? true)
                        {
                            confirm = true;
                            DumpAddr = Convert.ToUInt64(form.ReturnedOffset, 16);
                        }
                    });

                    if (confirm)
                    {
                        Log("Inputted address: " + DumpAddr.ToString("X"));
                        if (DumpAddr != 0)
                        {
                            il2Cpp.ImageBase = DumpAddr;
                            il2Cpp.IsDumped = true;
                            if (!config.NoRedirectedPointer)
                            {
                                elf.Reload();
                            }
                        }
                    }
                    else
                    {
                        il2Cpp.IsDumped = true;
                    }
                }
            }

            Log("Searching...");
            try
            {
                var flag = il2Cpp.PlusSearch(metadata.methodDefs.Count(x => x.methodIndex >= 0), metadata.typeDefs.Length, metadata.imageDefs.Length);
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    if (!flag && il2Cpp is PE)
                    {
                        Log("Use custom PE loader");
                        il2Cpp = PELoader.Load(il2cppPath);
                        il2Cpp.SetProperties(version, metadata.metadataUsagesCount);
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
                    Log("ERROR: Can't use auto mode to process file, trying manual mode...", Brushes.Yellow);
                    if (string.IsNullOrEmpty(codeRegistrationTxtBox.Text) || string.IsNullOrEmpty(codeRegistrationTxtBox.Text))
                    {
                        Log("CodeRegistration or MetadataRegistration is empty", Brushes.Orange);
                        return false;
                    }
                    var codeRegistration = Convert.ToUInt64(codeRegistrationTxtBox.Text, 16);
                    var metadataRegistration = Convert.ToUInt64(metadataRegistrationTxtBox.Text, 16);
                    il2Cpp.Init(codeRegistration, metadataRegistration);
                }
                if (il2Cpp.Version >= 27 && il2Cpp.IsDumped)
                {
                    var typeDef = metadata.typeDefs[0];
                    var il2CppType = il2Cpp.types[typeDef.byvalTypeIndex];
                    metadata.ImageBase = il2CppType.data.typeHandle - metadata.header.typeDefinitionsOffset;
                }
            }
            catch (Exception ex)
            {
                Log("An error occurred while processing.", Brushes.Orange);
                Log(ex.ToString(), Brushes.Orange);
                return false;
            }
            return true;
        }

        private void Dump(Metadata metadata, Il2Cpp il2Cpp, string outputDir)
        {
            Log("Output path: " + outputDir);
            Log("Dumping... ");
            var executor = new Il2CppExecutor(metadata, il2Cpp);
            var decompiler = new Il2CppDecompiler(executor);
            decompiler.Decompile(config, outputDir);

            Log("Done!");
            if (config.GenerateStruct)
            {
                Log("Generate struct...");
                try
                {
                    var scriptGenerator = new StructGenerator(executor);
                    scriptGenerator.WriteScript(outputDir);
                    Log("Done!");
                }
                catch (Exception ex)
                {
                    Log("There was an error trying to generate struct: " + ex.ToString(), Brushes.Orange);
                }
            }
            if (config.GenerateDummyDll)
            {
                Log("Generating dummy dll...");
                DummyAssemblyExporter.Export(executor, outputDir, config.DummyDllAddToken);
                Log("Done!");
                Directory.SetCurrentDirectory(realPath); //Fix read-only directory permission
            }
        }

        private void Dumper(string file, string metadataPath, string outputPath)
        {
            try
            {
                if (Init(file, metadataPath, out var metadata, out var il2Cpp))
                {
                    Dump(metadata, il2Cpp, outputPath);
                    CopyScripts(outputPath);
                }
            }
            catch (Exception ex)
            {
                Log(ex.ToString() + "\n", Brushes.Orange);
            }
        }
        #endregion

        #region Auto Dump
        private async Task IPADump(string file, string outputPath)
        {
            await Task.Factory.StartNew(() =>
            {
                using (ZipFile archive = ZipFile.Read(file))
                {
                    archive.FlattenFoldersOnExtract = true;
                    var ipaBinaryFolder = archive.Entries.FirstOrDefault(f => f.FileName.StartsWith("Payload/") && f.FileName.Contains(".app/") && f.FileName.Count(x => x == '/') == 2);

                    if (ipaBinaryFolder != null)
                    {
                        Regex myRegex3 = new Regex(@"(?<=Payload\/)(.*?)(?=.app\/)", RegexOptions.None);
                        Match match = myRegex3.Match(ipaBinaryFolder.FileName);

                        var ipaBinaryName = match.ToString();
                        var metadataFile = archive.Entries.FirstOrDefault(f => f.FileName == $"Payload/{ipaBinaryName}.app/Data/Managed/Metadata/global-metadata.dat");
                        var frameworkFile = archive.Entries.FirstOrDefault(f => f.FileName == $"Payload/{ipaBinaryName}.app/Frameworks/UnityFramework.framework/UnityFramework");
                        var binaryFile = archive.Entries.FirstOrDefault(f => f.FileName == $"Payload/{ipaBinaryName}.app/{ipaBinaryName}");
                        if (metadataFile != null)
                        {
                            if (frameworkFile != null)
                                binaryFile = frameworkFile;

                            Directory.CreateDirectory(outputPath);

                            if (Settings.Default.ExtDatChkBox)
                                metadataFile.Extract(outputPath, ExtractExistingFileAction.OverwriteSilently);
                            metadataFile.Extract(tempPath, ExtractExistingFileAction.OverwriteSilently);

                            if (use64bitMach_O)
                            {
                                Log("----- [Dumping ARM64] -----", Brushes.Chartreuse);
                                if (Settings.Default.ExtBinaryChkBox)
                                    binaryFile.Extract(outputPath, ExtractExistingFileAction.OverwriteSilently);
                                binaryFile.Extract(tempPath, ExtractExistingFileAction.OverwriteSilently);
                                Dumper(Path.Combine(tempPath, Path.GetFileName(binaryFile.FileName)), Path.Combine(tempPath, "global-metadata.dat"), outputPath);
                            }
                            else
                            {
                                Log("----- [Dumping ARMv7] -----", Brushes.Chartreuse);

                                if (Settings.Default.ExtBinaryChkBox)
                                    binaryFile.Extract(outputPath, ExtractExistingFileAction.OverwriteSilently);
                                binaryFile.Extract(tempPath, ExtractExistingFileAction.OverwriteSilently);
                                Dumper(Path.Combine(tempPath, Path.GetFileName(binaryFile.FileName)), Path.Combine(tempPath, "global-metadata.dat"), outputPath);
                            }
                        }
                        else
                            Log("This IPA does not contain an IL2CPP application", Brushes.Yellow);
                    }
                    else
                    {
                        Log("Failed to extract required file. Please extract the files manually", Brushes.Yellow);
                    }
                }
            });
        }

        private async Task APKDump(string file, string outputPath)
        {
            Debug.WriteLine("arch: " + Settings.Default.AndroArch);
            await Task.Factory.StartNew(() =>
            {
                using (ZipFile archive = ZipFile.Read(file))
                {
                    Log("Extracting files");
                    archive.FlattenFoldersOnExtract = true;
                    var binaryFile = archive.Entries.FirstOrDefault(f => f.FileName.Contains("libil2cpp.so"));
                    var metadataPath = archive.Entries.FirstOrDefault(f => f.FileName.Contains("assets/bin/Data/Managed/Resources/"));
                    var metadataFile = archive.Entries.FirstOrDefault(f => f.FileName == "assets/bin/Data/Managed/Metadata/global-metadata.dat");

                    if (binaryFile == null && metadataPath != null)
                    {
                        Log("This APK does not contain lib folder. APK has been splitted", Brushes.Yellow);
                        return;
                    }
                    else if (binaryFile != null && metadataPath == null)
                    {
                        Log("This APK is an il2cpp game but does not contain global-metadata.dat. It may be protected or APK has been splitted", Brushes.Yellow);
                        return;
                    }

                    if (metadataFile != null)
                    {
                        Directory.CreateDirectory(outputPath);

                        if (Settings.Default.ExtDatChkBox)
                            metadataFile.Extract(outputPath, ExtractExistingFileAction.OverwriteSilently);
                        metadataFile.Extract(tempPath, ExtractExistingFileAction.OverwriteSilently);

                        bool dumpArm64 = true, dumpArmv7 = true, dumpx86 = true, dumpx86_64 = true;
                        if (Settings.Default.AndroArch != 0)
                        {
                            dumpArm64 = Settings.Default.AndroArch == 1;
                            dumpArmv7 = Settings.Default.AndroArch == 2;
                            dumpx86 = Settings.Default.AndroArch == 3;
                            dumpx86_64 = Settings.Default.AndroArch == 4;
                        }

                        foreach (var entry in archive.Entries)
                        {
                            if (entry.FileName.Equals(@"lib/armeabi-v7a/libil2cpp.so") && dumpArmv7)
                            {
                                Log("Dumping ARMv7", Brushes.Chartreuse);
                                string archPath = Path.Combine(outputPath, "ARMv7");

                                Directory.CreateDirectory(archPath);
                                if (Settings.Default.ExtBinaryChkBox)
                                    entry.Extract(archPath, ExtractExistingFileAction.OverwriteSilently);
                                binaryFile.Extract(tempPath, ExtractExistingFileAction.OverwriteSilently);
                                Dumper(tempLibFile, Path.Combine(tempPath, "global-metadata.dat"), archPath + "\\");
                            }

                            if (entry.FileName.Equals(@"lib/arm64-v8a/libil2cpp.so") && dumpArm64)
                            {
                                Log("Dumping ARM64", Brushes.Chartreuse);
                                string archPath = Path.Combine(outputPath, "ARM64");

                                Directory.CreateDirectory(archPath);
                                if (Settings.Default.ExtBinaryChkBox)
                                    entry.Extract(archPath, ExtractExistingFileAction.OverwriteSilently);
                                binaryFile.Extract(tempPath, ExtractExistingFileAction.OverwriteSilently);
                                Dumper(tempLibFile, Path.Combine(tempPath, "global-metadata.dat"), archPath + "\\");
                            }

                            if (entry.FileName.Equals(@"lib/x86/libil2cpp.so") && dumpx86)
                            {
                                Log("Dumping x86", Brushes.Chartreuse);
                                string archPath = Path.Combine(outputPath, "x86");

                                Directory.CreateDirectory(archPath);
                                if (Settings.Default.ExtBinaryChkBox)
                                    entry.Extract(archPath, ExtractExistingFileAction.OverwriteSilently);
                                binaryFile.Extract(tempPath, ExtractExistingFileAction.OverwriteSilently);
                                Dumper(tempLibFile, Path.Combine(tempPath, "global-metadata.dat"), archPath + "\\");
                            }

                            if (entry.FileName.Equals(@"lib/x86_64/libil2cpp.so") && dumpx86_64)
                            {
                                Log("Dumping x86_64", Brushes.Chartreuse);
                                string archPath = Path.Combine(outputPath, "x86_64");

                                Directory.CreateDirectory(archPath);
                                if (Settings.Default.ExtBinaryChkBox)
                                    entry.Extract(archPath, ExtractExistingFileAction.OverwriteSilently);
                                binaryFile.Extract(tempPath, ExtractExistingFileAction.OverwriteSilently);
                                Dumper(tempLibFile, Path.Combine(tempPath, "global-metadata.dat"), archPath + "\\");
                            }
                        }
                    }
                    else
                    {
                        Log("This APK does not contain an IL2CPP application", Brushes.Yellow);
                    }
                }
            });
        }

        private async Task SplitAPKDump(string file, string outputPath)
        {
            await Task.Factory.StartNew(() =>
            {
                bool dumpArm64 = true, dumpArmv7 = true, dumpx86 = true, dumpx86_64 = true;
                int archIndex = Settings.Default.AndroArch;
                if (archIndex != 0)
                {
                    dumpArm64 = archIndex == 1;
                    dumpArmv7 = archIndex == 2;
                    dumpx86 = archIndex == 3;
                    dumpx86_64 = archIndex == 4;
                }

                Log("Extracting files");
                using (ZipFile archive = ZipFile.Read(file))
                {
                    archive.FlattenFoldersOnExtract = true;
                    foreach (var entryApks in archive.Entries)
                    {
                        Debug.WriteLine("Files: " + entryApks.FileName);

                        if (!entryApks.FileName.StartsWith("config.") && entryApks.FileName.EndsWith(".apk"))
                        {
                            Log("Checking " + entryApks.FileName);

                            var apkFile = Path.Combine(tempPath, entryApks.FileName);
                            entryApks.Extract(tempPath, ExtractExistingFileAction.OverwriteSilently);

                            using (ZipFile entryBase = ZipFile.Read(apkFile))
                            {
                                entryBase.FlattenFoldersOnExtract = true;

                                var metadataFile = entryBase.Entries.FirstOrDefault(f => f.FileName == "assets/bin/Data/Managed/Metadata/global-metadata.dat");

                                if (metadataFile == null)
                                {
                                    Log("No global-metadata.dat found in " + entryApks.FileName, Brushes.Yellow);
                                }
                                else
                                {
                                    Log($"Found global-metadata.dat from {entryApks.FileName}. Extracting", Brushes.Chartreuse);

                                    Directory.CreateDirectory(outputPath);

                                    if (Settings.Default.ExtDatChkBox)
                                        metadataFile.Extract(outputPath, ExtractExistingFileAction.OverwriteSilently);
                                    metadataFile.Extract(tempPath, ExtractExistingFileAction.OverwriteSilently);
                                }
                                //entryBase.Dispose();
                            }
                        }
                        var libabi = new List<string> { "armeabi_v7a", "arm64_v8a", "x86", "x86_64" };
                        foreach (string abi in libabi)
                        {
                            bool archMatch = (dumpArm64 && abi == "arm64_v8a") ||
                                (dumpArmv7 && abi == "armeabi_v7a") ||
                                (dumpx86_64 && abi == "x86_64") ||
                                (dumpx86 && abi == "x86");

                            if (entryApks.FileName.Contains(abi) && entryApks.FileName.EndsWith(".apk") && archMatch)
                            {
                                Log("Checking " + entryApks.FileName);

                                var apkFile = Path.Combine(tempPath, entryApks.FileName);
                                entryApks.Extract(tempPath, ExtractExistingFileAction.OverwriteSilently);

                                using (ZipFile entryBase = ZipFile.Read(apkFile))
                                {
                                    entryBase.FlattenFoldersOnExtract = true;
                                    var binaryFile = entryBase.Entries.FirstOrDefault(f => f.FileName.Contains("libil2cpp.so"));

                                    if (binaryFile == null)
                                    {
                                        Log($"The split APK {entryApks.FileName} does not contain libil2cpp.so folder", Brushes.Yellow);
                                        return;
                                    }
                                    else
                                    {
                                        Directory.CreateDirectory(outputPath);

                                        foreach (var entry in entryBase.Entries)
                                        {
                                            if (entry.FileName.Contains("libil2cpp.so"))
                                            {
                                                Log($"Found libil2cpp.so from {entry.FileName}. Dumping", Brushes.Chartreuse);
                                                string archPath = Path.Combine(outputPath, abi);

                                                Directory.CreateDirectory(archPath);
                                                if (Settings.Default.ExtBinaryChkBox)
                                                    entry.Extract(archPath, ExtractExistingFileAction.OverwriteSilently);
                                                binaryFile.Extract(tempPath, ExtractExistingFileAction.OverwriteSilently);
                                                Dumper(tempLibFile, Path.Combine(tempPath, "global-metadata.dat"), archPath + "\\");
                                            }
                                        }
                                        entryBase.Dispose();
                                    }
                                }
                            }
                        }
                    }
                    archive.Dispose();
                }
            }).ConfigureAwait(false);
        }

        //Copy python scripts after dump successfully
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
                        Log("Copied ghidra.py");
                    }
                    else
                        Log("ghidra.py does not exist", Brushes.Yellow);
                }
                if (Settings.Default.ghidra_with_struct)
                {
                    if (File.Exists(guiPath + "ghidra_with_struct.py"))
                    {
                        File.Copy(guiPath + "ghidra_with_struct.py", outputPath + "ghidra_with_struct.py", true);
                        Log("Copied ghidra_with_struct.py");
                    }
                    else
                        Log("ghidra_with_struct.py does not exist", Brushes.Yellow);
                }
                if (Settings.Default.ida)
                {
                    if (File.Exists(guiPath + "ida.py"))
                    {
                        File.Copy(guiPath + "ida.py", outputPath + "ida.py", true);
                        Log($"Copied ida.py");
                    }
                    else
                        Log("ida.py does not exist", Brushes.Yellow);
                }
                if (Settings.Default.ida_py3)
                {
                    if (File.Exists(guiPath + "ida_py3.py"))
                    {
                        File.Copy(guiPath + "ida_py3.py", outputPath + "ida_py3.py", true);
                        Log("Copied ida_py3.py");
                    }
                    else
                        Log("ida_py3.py does not exist", Brushes.Yellow);
                }
                if (Settings.Default.ida_with_struct)
                {
                    if (File.Exists(guiPath + "ida_with_struct.py"))
                    {
                        File.Copy(guiPath + "ida_with_struct.py", outputPath + "ida_with_struct.py", true);
                        Log("Copied ida_with_struct.py");
                    }
                    else
                        Log("ida_with_struct.py does not exist", Brushes.Yellow);
                }
                if (Settings.Default.ida_with_struct_py3)
                {
                    if (File.Exists(guiPath + "ida_with_struct_py3.py"))
                    {
                        File.Copy(guiPath + "ida_with_struct_py3.py", outputPath + "ida_with_struct_py3.py", true);
                        Log("Copied ida_with_struct_py3.py");
                    }
                    else
                        Log("ida_with_struct_py3.py does not exist", Brushes.Yellow);
                }
                if (Settings.Default.ghidra_wasm)
                {
                    if (File.Exists(guiPath + "ghidra_wasm.py"))
                    {
                        File.Copy(guiPath + "ghidra_wasm.py", outputPath + "ghidra_wasm.py", true);
                        Log("Copied ghidra_wasm.py");
                    }
                    else
                        Log("ghidra_wasm does not exist", Brushes.Yellow);
                }
                if (Settings.Default.ghidra_wasm)
                {
                    if (File.Exists(guiPath + "il2cpp_header_to_ghidra.py"))
                    {
                        File.Copy(guiPath + "il2cpp_header_to_ghidra.py", outputPath + "il2cpp_header_to_ghidra.py", true);
                        Log("Copied il2cpp_header_to_ghidra.py");
                    }
                    else
                        Log("il2cpp_header_to_ghidra does not exist", Brushes.Yellow);
                }
            }
            catch (Exception ex)
            {
                Log(ex.ToString(), Brushes.Red);
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

                        if (!String.IsNullOrEmpty(remoteVersion))
                        {
                            Version currentVersion = Version.Parse(appVersion);
                            Version latestVersion = Version.Parse(remoteVersion);

                            if (latestVersion > currentVersion)
                            {
                                Log("A new version is available: " + remoteVersion, Brushes.Lime);
                                Log("https://github.com/AndnixSH/Il2CppDumper-GUI/releases", Brushes.Lime);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Log("An error checking for update: " + ex.Message, Brushes.Yellow);
                    }
                }
            });
        }

        private void richTextBoxLogs_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }
        #endregion

        #region Logging
        public static void Log(string text)
        {
            main.Log(text);
        }

        public static void Log(string text, object text2)
        {
            main.Log(string.Format(text, text2));
        }

        //Color list /*http://www.flounder.com/csharp_color_table.htm*/
        public void Log(string text, SolidColorBrush color = null)
        {
            if (!String.IsNullOrEmpty(text))
            {
                Debug.WriteLine(text);

                if (!Dispatcher.CheckAccess())
                {
                    LogBox.Dispatcher.Invoke(() =>
                    {
                        PrintLog(text, color);
                    });
                }
                else
                {
                    PrintLog(text, color);
                }
            }
        }

        void PrintLog(string text, SolidColorBrush color = null)
        {
            if (color != null)
            {
                Paragraph paragraph = new Paragraph();
                paragraph.Inlines.Add(new Run(text) { Foreground = color });
                LogBox.Document.Blocks.Add(paragraph);
            }
            else
            {
                Paragraph paragraph = new Paragraph();
                paragraph.Inlines.Add(new Run(text));
                LogBox.Document.Blocks.Add(paragraph);
            }
        }
        #endregion

        #region Save Config
        private void SaveConfig()
        {
            Settings.Default.BinaryFileTxtBox = binFileTxtBox.Text;
            Settings.Default.DatFileTxtBox = datFileTxtBox.Text;
            Settings.Default.OutputTxtBox = outputTxtBox.Text;
            Settings.Default.AndroArch = androArch.SelectedIndex;

            Settings.Default.CheckForUpdate = (bool)updateChkBox.IsChecked;
            Settings.Default.AutoSetDir = (bool)autoSetDirCheck.IsChecked;
            Settings.Default.ExtBinaryChkBox = (bool)extBinaryChkBox.IsChecked;
            Settings.Default.ExtDatChkBox = (bool)extDatChkBox.IsChecked;

            Settings.Default.ghidra = (bool)ghidraChkBox.IsChecked;
            Settings.Default.ghidra_wasm = (bool)ghidraWasmChkBox.IsChecked;
            Settings.Default.ghidra_with_struct = (bool)ghidraWithStructChkBox.IsChecked;
            Settings.Default.hopper = (bool)hopperPy3ChkBox.IsChecked;
            Settings.Default.hopper = (bool)hopperPy3ChkBox.IsChecked;
            Settings.Default.ida = (bool)idaChkBox.IsChecked;
            Settings.Default.ida_py3 = (bool)idaPy3ChkBox.IsChecked;
            Settings.Default.ida_with_struct = (bool)idaStructChkBox.IsChecked;
            Settings.Default.ida_with_struct_py3 = (bool)idaStructPy3ChkBox.IsChecked;
            Settings.Default.il2cpp_header_to_binja = (bool)headerToBinjaChkBox.IsChecked;
            Settings.Default.il2cpp_header_to_ghidra = (bool)headerToGhidraChkBox.IsChecked;

            Settings.Default.Save();
        }
        #endregion

        #region Window handlers
        private bool _actionButtonsEnabled;
        internal bool ActionButtonsEnabled
        {
            set
            {
                startBtn.Content = value ? "Press start or drop APK, APKS, XAPK, ZIP, decrypted IPA file to dump" : "Dumping...";
                startBtn.IsEnabled = value;
                selBinFile.IsEnabled = value;
                selDatFile.IsEnabled = value;
                selOutDir.IsEnabled = value;
                binFileTxtBox.IsEnabled = value;
                datFileTxtBox.IsEnabled = value;
                outputTxtBox.IsEnabled = value;
                androArch.IsEnabled = value;
                codeRegistrationTxtBox.IsEnabled = value;
                metadataRegistrationTxtBox.IsEnabled = value;
            }
            get
            {
                return _actionButtonsEnabled;
            }
        }

        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.ToString()) { UseShellExecute = true });
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            SaveConfig();
        }
        private void LogBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            LogBox.ScrollToVerticalOffset(double.MaxValue);
        }
        #endregion

        #region Button click handlers
        private async void startBtn_Click(object sender, RoutedEventArgs e)
        {
            SaveConfig();
            LogBox.Document.Blocks.Clear();
            if (!Directory.Exists(outputTxtBox.Text))
            {
                Log("Output directory does not exist", Brushes.Orange);
                return;
            }

            //Check of bin or dat file exists
            if (binFileTxtBox.Text == "")
            {
                Log("Executable file is not selected", Brushes.Orange);
                return;
            }

            if (datFileTxtBox.Text == "")
            {
                Log("Metadata-global.dat file is not selected", Brushes.Orange);
                return;
            }

            ActionButtonsEnabled = false;

            string binFile = binFileTxtBox.Text;
            string datFile = datFileTxtBox.Text;
            string outputPath = outputTxtBox.Text;

            await Task.Factory.StartNew(() =>
            {
                DirectoryUtils.Delete(tempPath);
                Directory.CreateDirectory(tempPath);

                Dumper(binFile, datFile, outputPath);
            });

            ActionButtonsEnabled = true;
        }

        private void openFolderBtn_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("explorer.exe", outputTxtBox.Text);
        }

        private void selBinFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Il2Cpp binary file|*.*";
            ofd.Title = "Select Il2Cpp binary file";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                binFileTxtBox.Text = ofd.FileName;
                codeRegistrationTxtBox.Text = "";
                metadataRegistrationTxtBox.Text = "";
                if (Settings.Default.AutoSetDir)
                {
                    outputTxtBox.Text = Path.GetDirectoryName(binFileTxtBox.Text) + "\\";
                }
            }
        }

        private void selDatFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "global-metadata|global-metadata.dat";
            ofd.Title = "Select global-metadata.dat";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                datFileTxtBox.Text = ofd.FileName;
                codeRegistrationTxtBox.Text = "";
                metadataRegistrationTxtBox.Text = "";
            }
        }

        private void selOutDir_Click(object sender, RoutedEventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                outputTxtBox.Text = fbd.SelectedPath + "\\"; //Show the path in label
            }
        }

        #endregion

        #region Drag & Drop handlers
        private void selBinFile_DragLeave(object sender, System.Windows.DragEventArgs e)
        {
            selBinFile.BorderBrush = null;
        }

        private void selBinFile_DragOver(object sender, System.Windows.DragEventArgs e)
        {
            if (e.CheckDragOver())
            {
                selBinFile.BorderThickness = new Thickness(1, 1, 1, 1);
                selBinFile.BorderBrush = Brushes.PaleTurquoise;
            }
        }

        private void selBinFile_Drop(object sender, System.Windows.DragEventArgs e)
        {
            string[] files = e.GetFilesDrop();
            if (File.Exists(files[0]))
                binFileTxtBox.Text = files[0];

            selBinFile.BorderBrush = null;
        }

        private void selDatFile_DragLeave(object sender, System.Windows.DragEventArgs e)
        {
            selDatFile.BorderBrush = null;
        }

        private void selDatFile_DragOver(object sender, System.Windows.DragEventArgs e)
        {
            if (e.CheckDragOver(".dat"))
            {
                selDatFile.BorderThickness = new Thickness(1, 1, 1, 1);
                selDatFile.BorderBrush = Brushes.PaleTurquoise;
            }
        }

        private void selDatFile_Drop(object sender, System.Windows.DragEventArgs e)
        {
            string[] files = e.GetFilesDrop();
            if (File.Exists(files[0]))
                datFileTxtBox.Text = files[0];

            selDatFile.BorderBrush = null;
        }

        private void selOutDir_DragLeave(object sender, System.Windows.DragEventArgs e)
        {
            selOutDir.BorderBrush = null;
        }

        private void selOutDir_DragOver(object sender, System.Windows.DragEventArgs e)
        {
            if (e.CheckDragOverFolder())
            {
                selOutDir.BorderThickness = new Thickness(1, 1, 1, 1);
                selOutDir.BorderBrush = Brushes.PaleTurquoise;
            }
        }

        private void selOutDir_Drop(object sender, System.Windows.DragEventArgs e)
        {
            string[] files = e.GetFilesDrop();
            if (Directory.Exists(files[0]))
                outputTxtBox.Text = files[0];

            selOutDir.BorderBrush = null;
        }

        private void startBtn_DragLeave(object sender, System.Windows.DragEventArgs e)
        {
            startBtn.BorderBrush = null;
        }

        private void startBtn_DragOver(object sender, System.Windows.DragEventArgs e)
        {
            if (e.CheckManyDragOver(".apk", ".xapk", ".zip", ".apks", ".apkm", ".ipa"))
            {
                startBtn.BorderThickness = new Thickness(1, 1, 1, 1);
                startBtn.BorderBrush = Brushes.PaleTurquoise;
            }
        }

        private async void startBtn_Drop(object sender, System.Windows.DragEventArgs e)
        {
            startBtn.BorderBrush = null;
            ActionButtonsEnabled = false;
            LogBox.Document.Blocks.Clear();
            SaveConfig();
            string[] files = e.GetFilesDrop();
            foreach (var file in files)
            {
                string outputPath;
                if (Settings.Default.AutoSetDir)
                {
                    outputPath = Path.GetDirectoryName(file) + "\\" + Path.GetFileNameWithoutExtension(file) + "_dumped\\";
                }
                else
                {
                    outputPath = outputTxtBox.Text + Path.GetFileNameWithoutExtension(file) + "_dumped\\";
                }

                switch (Path.GetExtension(file))
                {
                    case ".apk":
                        await APKDump(file, outputPath);
                        break;
                    case ".apks":
                    case ".xapk":
                    case ".zip":
                        await SplitAPKDump(file, outputPath);
                        break;
                    case ".ipa":
                        await IPADump(file, outputPath);
                        break;
                    default:
                        return;
                }

                if (Settings.Default.AutoSetDir)
                    outputTxtBox.Text = Path.GetDirectoryName(file) + "\\";
            }
            ActionButtonsEnabled = true;
        }
        #endregion
    }
}
