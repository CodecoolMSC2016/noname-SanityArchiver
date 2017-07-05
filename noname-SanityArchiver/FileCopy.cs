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
            foreach (var filePath in filePaths)
            {
                if (transferType == TransferType.Copy)
                {
                    File.Copy(filePath, destinationPath, true);
                }
                else
                {
                    File.Move(filePath, destinationPath);
                }
                    
            }
        }

        public void TransferFiles(string filePath, string destinationPath, TransferType transferType)
        {
            if (transferType == TransferType.Copy)
            {
                File.Copy(filePath, destinationPath, true);
            }
            else
            {
                File.Move(filePath, destinationPath);
            }
        }


    }
}
