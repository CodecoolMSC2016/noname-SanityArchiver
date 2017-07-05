using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace noname_SanityArchiver
{
    class FileAttributeChange
    {

        public FileAttributeChange() { }

        // get file attributes
        public FileAttributes GetFileAttributes(string filePath)
        {
            FileAttributes attributes = File.GetAttributes(filePath);
            return attributes;
        }

        // check whether a file has readonly attribute
        public bool HasReadonlyAttribute(string filePath)
        {
            bool isReadOnly = ((File.GetAttributes(filePath) & FileAttributes.ReadOnly)
            == FileAttributes.ReadOnly);

            if (isReadOnly == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }   
}
