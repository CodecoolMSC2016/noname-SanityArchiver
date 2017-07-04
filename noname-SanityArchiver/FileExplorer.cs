using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noname_SanityArchiver
{
    class FileExplorer
    {
        public static FileExplorer INSTANCE = new FileExplorer();

        public Dictionary<string, DirectoryInfo> CurrentDirectories { get; set; }

        public Dictionary<string, FileInfo> CurrentFiles { get; set; }

        private FileExplorer()
        {
            CurrentDirectories = new Dictionary<string, DirectoryInfo>();
            CurrentFiles = new Dictionary<string, FileInfo>();
        }

    }
}
