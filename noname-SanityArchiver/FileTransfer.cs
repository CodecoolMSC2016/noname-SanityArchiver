using Microsoft.VisualBasic.FileIO;
using System;
using System.IO;
using System.Windows.Forms;

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
                MessageBox.Show("Cannot rename file or directory.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MakeTransfer(FileSystem.CopyDirectory, FileSystem.CopyFile,
                        filePath, fullpath, UIOption.AllDialogs, UICancelOption.DoNothing);
                }
            }
            else if (transferType == TransferType.Move)
            {
                foreach (string filePath in filePaths)
                {
                    string fullpath = Path.Combine(destinationPath, Path.GetFileName(filePath));
                    MakeTransfer(FileSystem.MoveDirectory, FileSystem.MoveFile,
                        filePath, fullpath, UIOption.AllDialogs, UICancelOption.DoNothing);
                }
            }
        }

        private delegate void Transfer(string filePath, string fullPath, UIOption option, UICancelOption cancelOption);

        private static void MakeTransfer(Transfer dirTransfer, Transfer fileTransfer,
            string filePath, string fullPath, UIOption option, UICancelOption cancelOption)
        {
            try
            {
                if (IsDirectory(filePath))
                {
                    dirTransfer.Invoke(filePath, fullPath, option, cancelOption);
                }
                else
                {
                    fileTransfer.Invoke(filePath, fullPath, option, cancelOption);
                }
            } catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}