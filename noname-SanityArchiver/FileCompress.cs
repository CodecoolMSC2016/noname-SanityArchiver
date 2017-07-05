using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Diagnostics;

namespace noname_SanityArchiver
{
    class FileCompress
    {
        private List<string> filesToCompress;

        public FileCompress() { }

        public bool CheckSelectedItemIsFolder(List<string> filesToCompress)
        {
            if (filesToCompress.Count == 1)
            {
                string path = filesToCompress[0];
                if (File.Exists(path))
                {
                    return false;
                }
                else if (Directory.Exists(path))
                {
                    return true;
                }
                else
                {
                    // path doesn't exist
                    Debug.WriteLine("Path doesn't exist.");
                }
            }
            return false;
        }

        public void Compress(List<string> filesToCompress, string zipFileName)
        {
            
            if (this.CheckSelectedItemIsFolder(filesToCompress))
            {
                string folderName = filesToCompress[0];
                string startPath = Path.GetFullPath(folderName);
                string zipPath = Path.GetDirectoryName(startPath) + "\\" + zipFileName + ".zip";

                // compress the folder
                ZipFile.CreateFromDirectory(startPath, zipPath);
            }
            else
            {
                string fileName = filesToCompress[0];
                string startPath = Path.GetDirectoryName(fileName);
                string zipPath = startPath + "\\" + zipFileName + ".zip";

                // compress file(s)
                string[] files = filesToCompress.ToArray();

                ZipArchive zip = ZipFile.Open(zipPath, ZipArchiveMode.Create);
                foreach (string file in files)
                {
                    zip.CreateEntryFromFile(file, Path.GetFileName(file), CompressionLevel.Optimal);

                }
                zip.Dispose();
            } 
        }

        public void DeCompress(string fileToDecompress, string folderToExtract)
        {
            ZipFile.ExtractToDirectory(fileToDecompress, folderToExtract);
        }
    }
}
