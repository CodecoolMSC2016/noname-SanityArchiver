using Microsoft.VisualBasic.FileIO;
using System.IO;

namespace noname_SanityArchiver
{
    internal class FileTransfer
    {
        public enum TransferType { Copy, Move }

        public static bool IsDirectory(string path)
        {
            FileAttributes attr = File.GetAttributes(path);
            return attr.HasFlag(FileAttributes.Directory);
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

        public static void TransferFile(string filePath, string destinationPath, TransferType transferType)
        {
            TransferFiles(new string[] { filePath }, destinationPath, transferType);
        }

        public static void TransferFiles(string[] filePaths, string destinationPath, TransferType transferType)
        {
            if (transferType == TransferType.Copy)
            {
                foreach (string filePath in filePaths)
                {
                    string fullpath = Path.Combine(destinationPath, Path.GetFileName(filePath));
                    if (IsDirectory(filePath))
                    {
                        FileSystem.CopyDirectory(filePath, fullpath, UIOption.AllDialogs, UICancelOption.DoNothing);
                    }
                    else
                    {
                        FileSystem.CopyFile(filePath, fullpath, UIOption.AllDialogs, UICancelOption.DoNothing);
                    }
                }
            }
            else if (transferType == TransferType.Move)
            {
                foreach (string filePath in filePaths)
                {
                    string fullpath = Path.Combine(destinationPath, Path.GetFileName(filePath));
                    if (IsDirectory(filePath))
                    {
                        FileSystem.MoveDirectory(filePath, fullpath, UIOption.AllDialogs, UICancelOption.DoNothing);
                    }
                    else
                    {
                        FileSystem.MoveFile(filePath, fullpath, UIOption.AllDialogs, UICancelOption.DoNothing);
                    }
                }
            }
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
    }
}