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
        public string CreateZipFromOneSelectedItem(string item, string zipFileName)
        {
            string itemPath = Path.GetFullPath(item);
            string zipPath;

            if (File.Exists(itemPath))
            {
                // compress the file
                zipPath = Path.GetDirectoryName(itemPath) + "\\" + zipFileName + ".zip";
                ZipArchive zip = ZipFile.Open(zipPath, ZipArchiveMode.Create);
                zip.CreateEntryFromFile(item, Path.GetFileName(item), CompressionLevel.Optimal);

                zip.Dispose();

                return zipPath;
            }
            else if (Directory.Exists(itemPath))
            {
                string folderPath = Path.GetFullPath(item);

                zipPath = Path.GetDirectoryName(folderPath) + "\\" + zipFileName + ".zip";

                // compress the folder
                ZipFile.CreateFromDirectory(folderPath, zipPath);
                return zipPath;
            }
            return null;
        }

        public string CreateZipFromMoreSelectedItems(string[] items, string zipFileName)
        {
            if (this.CheckIfSelectedItemsContainsFolder(items))
            {
                // create temporary folder
                string folderName = items[0];
                string folderPath = Path.GetFullPath(folderName);

                string tempFolderPath = Path.Combine(Path.GetDirectoryName(folderName), "tempFolder");

                Directory.CreateDirectory(tempFolderPath);

                // put file(s) and folder(s) to the temporary folder
                foreach (string i in items)
                {
                    if (File.Exists(Path.GetFullPath(i)))
                    {
                        string fileName = System.IO.Path.GetFileName(i);
                        string destFile = System.IO.Path.Combine(tempFolderPath, fileName);
                        File.Copy(i, destFile, true);
                    }
                    if (Directory.Exists(Path.GetFullPath(i)))
                    {
                        CopyDirectory(Path.GetFullPath(i), tempFolderPath);
                    }

                }

                string zipPath = Path.GetDirectoryName(folderPath) + "\\" + zipFileName + ".zip";

                // compress the temporary folder as a single folder
                ZipFile.CreateFromDirectory(tempFolderPath, zipPath);

                return zipPath;
            }
            else
            {
                string fileName = items[0];
                string startPath = Path.GetDirectoryName(fileName);
                string zipPath = startPath + "\\" + zipFileName + ".zip";

                // compress file(s)
                ZipArchive zip = ZipFile.Open(zipPath, ZipArchiveMode.Create);

                foreach (string i in items)
                {
                    zip.CreateEntryFromFile(i, Path.GetFileName(i), CompressionLevel.Optimal);
                }
                zip.Dispose();

                return zipPath;
            }

        }

        public bool CheckIfSelectedItemsContainsFolder(string[] items)
        {
            foreach (string i in items)
            {
                if (Directory.Exists(Path.GetDirectoryName(i)))
                {
                    return true;
                }
            }
            return false;
        }


        private static void CopyDirectory(string root, string dest)
        {
            foreach (var directory in Directory.GetDirectories(root))
            {
                string dirName = Path.GetFileName(directory);
                if (!Directory.Exists(Path.Combine(dest, dirName)))
                {
                    Directory.CreateDirectory(Path.Combine(dest, dirName));
                }
                CopyDirectory(directory, Path.Combine(dest, dirName));
            }

            foreach (var file in Directory.GetFiles(root))
            {
                File.Copy(file, Path.Combine(dest, Path.GetFileName(file)));
            }
        }


        public void DeCompress(string fileToDecompress, string folderToExtract)
        {
            ZipFile.ExtractToDirectory(fileToDecompress, folderToExtract);
        }
    }
}
