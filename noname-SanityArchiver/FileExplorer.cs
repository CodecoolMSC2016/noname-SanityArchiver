using noname_SanityArchiver.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace noname_SanityArchiver
{
    class FileExplorer
    {
        public enum ItemType { Directory, File};

        public List<FileSystemInfo> CurrentItems { get; set; }

        public DataGridView View { get; }

        private TextBox absoluePathBox;
        

        public FileExplorer(DataGridView view, TextBox textBox)
        {
            View = view;
            CurrentItems = new List<FileSystemInfo>();
            absoluePathBox = textBox;
        }

        public FileSystemInfo GetSelectedItem()
        {
            int itemIndex = View.CurrentCell.RowIndex;
            return CurrentItems[itemIndex];
        }

        public void DisplayFiles(DirectoryInfo selectedFolder)
        {
            View.Rows.Clear();
            CurrentItems.Clear();

            UpdateAbsolutePath(selectedFolder.FullName);

            FileInfo[] files = selectedFolder.GetFiles();
            DirectoryInfo[] directories = selectedFolder.GetDirectories();

            DirectoryInfo parent = Directory.GetParent(selectedFolder.FullName); ;
            if (parent == null)
            {
                parent = selectedFolder;
            }
            CurrentItems.Add(parent);

            View.Rows.Add(Resources.icon_arrow, "...", "", "");

            AddItemsToView(directories, ItemType.Directory);

            AddItemsToView(files, ItemType.File);
        }

        private void AddItemsToView(FileSystemInfo[] items, ItemType itemType)
        {
            string fileSize;
            string baseName;
            Bitmap icon;
            for (int i = 0; i < items.Length; i++)
            {
                CurrentItems.Add(items[i]);
                baseName = RemoveFileExtension(items[i].Name);
                icon = Resources.icon_folder;
                fileSize = "";

                if (itemType == ItemType.File)
                {
                    fileSize = (((FileInfo)items[i]).Length / 1048576).ToString();
                    icon = Icon.ExtractAssociatedIcon(items[i].FullName).ToBitmap();
                }
                View.Rows.Add(icon, baseName, fileSize, items[i].Extension);
            }
            
        }

        public void UpdateAbsolutePath(string path)
        {
            absoluePathBox.Text = path;
        }

        public string GetFileNameWithExtension(DataGridViewRow row)
        {
            string name = row.Cells[1].Value.ToString();
            string extension = row.Cells[3].Value.ToString();
            return name + extension;
        }

        private string RemoveFileExtension(string fileName)
        {
            string fullName = fileName;
            return fullName.Substring(fullName.LastIndexOf('.') + 1);
        }
    }
}
