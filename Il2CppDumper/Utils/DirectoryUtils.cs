using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Il2CppDumper.Utils
{
    internal class DirectoryUtils
    {
        internal static void Delete(string path)
        {
            if (Directory.Exists(path))
                Directory.Delete(path, true);
        }
    }
}
