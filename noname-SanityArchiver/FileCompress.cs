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

        public FileCompress(List<string> filesToCompress)
        {
            this.filesToCompress = filesToCompress;
        }

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
                string startPath = Path.GetDirectoryName(folderName);
                string zipPath = startPath + zipFileName + ".zip";

                // compress the folder
                ZipFile.CreateFromDirectory(startPath, zipPath);
            }
            else
            {
                string fileName = filesToCompress[0];
                string startPath = Path.GetDirectoryName(fileName);
                string zipPath = startPath + zipFileName + ".zip";

                // compress file(s)
                string[] files = filesToCompress.ToArray();

                using (ZipArchive zip = ZipFile.Open(zipPath, ZipArchiveMode.Create))
                {
                    foreach (string file in files)
                    {
                        zip.CreateEntryFromFile(file, Path.GetFileName(file), CompressionLevel.Optimal);

                    }
                }
            } 
        }

        public void DeCompress(string fileToDecompress, string folderToExtract)
        {
            ZipFile.ExtractToDirectory(fileToDecompress, folderToExtract);
        }

        public void Main(string[] args)
        {

            string path = @"C:\MyTest.txt";
            if(!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Hello");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");
                }
            }


            List<string> filesToCompressTEST = new List<string>();

            filesToCompressTEST.Add("MyTest.txt");

            FileCompress fc = new FileCompress(filesToCompressTEST);
            fc.Compress(filesToCompressTEST, "test.zip");
            Console.WriteLine("compress done");
            Console.ReadKey();
        }
    }
}
