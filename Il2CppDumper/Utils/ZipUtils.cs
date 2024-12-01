using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Il2CppDumper.Utils
{
    internal class ZipUtils
    {
        public static void ExtractFile(ZipArchiveEntry entry, string destinationPath)
        {
            string fullPath = Path.Combine(destinationPath, entry.Name);
            Directory.CreateDirectory(Path.GetDirectoryName(fullPath));
            entry.ExtractToFile(fullPath, true);
        }
    }
}
