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
        // check whether a file has hidden attribute
        public bool HasHiddenAttribute(string filePath)
        {
            bool isHidden = ((File.GetAttributes(filePath) & FileAttributes.Hidden)
                == FileAttributes.Hidden);

            if (isHidden == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // set readonly attribute (no other attribute will set)
        public void SetReadonlyAttribute(string filePath)
        {
            File.SetAttributes(filePath, FileAttributes.ReadOnly);
        }

        // set hidden attribute (no other attribute will set)
        public void SetHiddenAttribute(string filePath)
        {
            File.SetAttributes(filePath, FileAttributes.Hidden);
        }

        

    }
}   

