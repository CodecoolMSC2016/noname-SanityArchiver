using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noname_SanityArchiver
{
    class FileTransfer
    {
        public enum TransferType { Copy, Move }

        public static void TransferFiles(List<string> filePaths, string destinationPath, TransferType transferType)
        {
            if (transferType == TransferType.Copy)
            {
                foreach (string filePath in filePaths)
                {
                    if (IsDirectory(filePath))
                    {
                        CopyDirectory(filePath, destinationPath);   
                    }
                    else
                    {
                        File.Copy(filePath, destinationPath, true);
                    }
                }
            }
            else if (transferType == TransferType.Move)
            {
                foreach (string filePath in filePaths)
                {
                    if (IsDirectory(filePath))
                    {
                        Directory.Move(filePath, destinationPath);
                    }
                    else
                    {
                        File.Move(filePath, destinationPath);
                    }
                }
            }
        }

        public static void TransferFile(string filePath, string destinationPath, TransferType transferType)
        {
            TransferFiles(new List<string>() { filePath }, destinationPath, transferType);
        }

        private static void CopyDirectory(string sourceDirName, string destinationPath)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();

            if (!Directory.Exists(destinationPath))
            {
                Directory.CreateDirectory(destinationPath);
            }

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destinationPath, file.Name);
                file.CopyTo(temppath, true);
            }

            foreach (DirectoryInfo subdir in dirs)
            {
                string temppath = Path.Combine(destinationPath, subdir.Name);
                CopyDirectory(subdir.FullName, temppath);
            }


        }

        public static void Rename(string oldPath, string newName)
        {
            try
            {
                if (IsDirectory(oldPath))
                {
                    DirectoryInfo dir = new DirectoryInfo(oldPath);
                    dir.MoveTo(Path.Combine(dir.Parent.FullName, newName));
                }
                else
                {
                    FileInfo fi = new FileInfo(oldPath);
                    fi.MoveTo(Path.Combine(fi.DirectoryName, newName));
                }
            }
            catch (IOException)
            {
                throw;
            }
        }

        private static bool IsDirectory(string path)
        {
            FileAttributes attr = File.GetAttributes(path);
            return attr.HasFlag(FileAttributes.Directory);
        }
    }
}
