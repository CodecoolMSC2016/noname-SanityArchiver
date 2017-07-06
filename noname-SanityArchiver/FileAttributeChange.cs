using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace noname_SanityArchiver
{
    public class FileAttributeChange
    {
        public string selectedFile { get; set; }
        private changeAttribute window;

        public FileAttributeChange(string filePath)
        {
            selectedFile = filePath;
            window = new changeAttribute(this);

            window.Show();
            window.checkHidden(HasHiddenAttribute(filePath));
            window.checkReadOnly(HasReadonlyAttribute(filePath));
        }

        // get file attributes
        public FileAttributes GetFileAttributes(string filePath)
        {
            return File.GetAttributes(filePath);
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
        public void SetReadonlyAttribute(string filePath )
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

        public void button1_Click(object sender, EventArgs e)
        {
            ClearAttributes(selectedFile);

            if ( window.HiddenState )
            {
                Debug.WriteLine("HIDDEN:" + window.HiddenState);
                SetHiddenAttribute( selectedFile );
            }

            if ( window.ReadOnlyState )
            {
                Debug.WriteLine("READONLY:" + window.ReadOnlyState);
                SetReadonlyAttribute(selectedFile);
            }
        }
    }
}   

