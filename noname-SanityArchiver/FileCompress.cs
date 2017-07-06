using System.IO;
using System.IO.Compression;

namespace noname_SanityArchiver
{
    internal class FileCompress
    {
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

        public string Compress(string[] items, string zipFileName)
        {
            return items.Length == 1 ?
                CreateZipFromOneSelectedItem(items[0], zipFileName)
                : CreateZipFromMoreSelectedItems(items, zipFileName);
        }

        public string CreateZipFromMoreSelectedItems(string[] items, string zipPath)
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

                // compress the temporary folder as a single folder
                ZipFile.CreateFromDirectory(tempFolderPath, zipPath);

                Directory.Delete(tempFolderPath, true);

                return zipPath;
            }
            else
            {
                string fileName = items[0];
                string startPath = Path.GetDirectoryName(fileName);

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

        public string CreateZipFromOneSelectedItem(string item, string zipPath)
        {
            string itemPath = Path.GetFullPath(item);

            if (File.Exists(itemPath))
            {
                // compress the file
                File.Delete(zipPath);
                ZipArchive zip = ZipFile.Open(zipPath, ZipArchiveMode.Create);
                zip.CreateEntryFromFile(item, Path.GetFileName(item), CompressionLevel.Optimal);

                zip.Dispose();

                return zipPath;
            }
            else if (Directory.Exists(itemPath))
            {
                string folderPath = Path.GetFullPath(item);

                // compress the folder
                ZipFile.CreateFromDirectory(folderPath, zipPath);
                return zipPath;
            }
            return null;
        }

        public void DeCompress(string fileToDecompress, string folderToExtract)
        {
            ZipFile.ExtractToDirectory(fileToDecompress, folderToExtract);
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
    }
}