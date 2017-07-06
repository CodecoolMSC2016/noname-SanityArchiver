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

        // check whether a file has readonly attribute
        public bool HasReadonlyAttribute(string filePath)
        {
            return ((File.GetAttributes(filePath) & FileAttributes.ReadOnly)
            == FileAttributes.ReadOnly);
        }

        // check whether a file has hidden attribute
        public bool HasHiddenAttribute(string filePath)
        {
            return ((File.GetAttributes(filePath) & FileAttributes.Hidden)
                == FileAttributes.Hidden);
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

        // clear all file attributes
        public void ClearAttributes(string filePath)
        {
            File.SetAttributes(filePath, FileAttributes.Normal);
        }
    }
}   

