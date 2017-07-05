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

        public void TransferFiles(List<string> filePaths, string destinationPath, TransferType transferType)
        {
            if (transferType == TransferType.Copy)
            {
                foreach (string filePath in filePaths)
                {
                    if (IsDirectory(filePath))
                    {
                        // TODO: implement directory copy
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

        public void TransferFiles(string filePath, string destinationPath, TransferType transferType)
        {
            TransferFiles(new List<string>() { "" }, destinationPath, transferType);
        }

        public void Rename(string oldPath, string newName)
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

        private bool IsDirectory(string path)
        {
            FileAttributes attr = File.GetAttributes(path);
            return attr.HasFlag(FileAttributes.Directory);
        }
    }
}
