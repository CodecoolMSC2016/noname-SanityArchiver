using noname_SanityArchiver.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace noname_SanityArchiver
{
    class FileExplorer
    {
        public enum ItemType { Directory, File};

        public List<FileSystemInfo> CurrentItems { get; set; }

        public DataGridView View { get; }

        public TextBox AbsoluePathBox { get; }

        private DirectoryInfo CurrentDirectory { get; set; }

        public FileExplorer(DataGridView view, TextBox textBox)
        {
            View = view;
            CurrentItems = new List<FileSystemInfo>();
            AbsoluePathBox = textBox;
        }

        public FileSystemInfo[] SelectedItems
        {
            get
            {
                var selectedRows = View.SelectedRows;
                FileSystemInfo[] selectedInfos = new FileSystemInfo[selectedRows.Count];
                for (int i = 0; i < selectedRows.Count; i++)
                {
                    int selectedIndex = selectedRows[i].Index;
                    selectedInfos[i] = CurrentItems[selectedIndex];
                }
                return selectedInfos;
            }
        }

        /// <summary>
        /// fbgbhnzsnsznhznhszn
        /// </summary>
        /// <param name="selectedFolder"></param>
        public void DisplayFiles(DirectoryInfo selectedFolder)
        {
            FileInfo[] files = null;
            DirectoryInfo[] directories = null;
            try
            {
                files = selectedFolder.GetFiles();
                directories = selectedFolder.GetDirectories();
                View.Rows.Clear();
                CurrentItems.Clear();
            }
            catch (UnauthorizedAccessException)
            {
                // give admin priviliges to user and remove try catch
                return;
            }
            catch (DirectoryNotFoundException)
            {
                UpdateAbsolutePath();
                return;
            }


            CurrentDirectory = selectedFolder;
            UpdateAbsolutePath();
            DirectoryInfo parent = Directory.GetParent(selectedFolder.FullName); ;
            if (parent != null)
            {
                CurrentItems.Add(parent);
                View.Rows.Add(Resources.icon_arrow, "...", "", "");
            }

            AddItemsToView(directories, ItemType.Directory);

            AddItemsToView(files, ItemType.File);
        }

        public void DisplayFiles()
        {
            DisplayFiles(CurrentDirectory);
        }

        private void AddItemsToView(FileSystemInfo[] items, ItemType itemType)
        {
            string fileSize;
            string baseName;
            Bitmap icon;
            for (int i = 0; i < items.Length; i++)
            {
                CurrentItems.Add(items[i]);
                baseName = Path.GetFileNameWithoutExtension(items[i].Name);
                fileSize = "";
                icon = Resources.icon_folder_full;

                if (itemType == ItemType.File)
                {
                    fileSize = (((FileInfo)items[i]).Length / 1024).ToString();
                    icon = Icon.ExtractAssociatedIcon(items[i].FullName).ToBitmap();
                }else
                {
                    if (IsEmpty((DirectoryInfo)items[i]))
                    { 
                        icon = Resources.icon_folder;
                    }
                    
                }
                View.Rows.Add(icon, baseName, items[i].Extension, fileSize);
            }
            
        }

        private bool IsEmpty(DirectoryInfo dirInfo)
        {
            try
            {
                int fileCount = ((DirectoryInfo)dirInfo).GetFiles().Length;
                int dirCount = ((DirectoryInfo)dirInfo).GetDirectories().Length;
                return (fileCount + dirCount) == 0;
            }
            catch (Exception exception)
            {
                if (exception is UnauthorizedAccessException || exception is NotSupportedException)
                {
                    return false;
                }
                throw exception;
            }
        }

        public void UpdateAbsolutePath()
        {
            AbsoluePathBox.Text = CurrentDirectory.FullName;
        }
        public string GetFileNameWithExtension(DataGridViewRow row)
        {
            string name = row.Cells[1].Value.ToString();
            string extension = row.Cells[3].Value.ToString();
            return name + extension;
        }

        /// <summary>
        /// Returns the size of the given folder in Megabytes
        /// </summary>
        public double getFolderSize(string directoryPath)
        {
            if (!File.GetAttributes(directoryPath).HasFlag(FileAttributes.Directory))
            {
                return 0;
            }

            double size = 0;
            string[] files = Directory.GetFiles(directoryPath);

            foreach (string file in files)
            {
                size += new FileInfo(file).Length;
            }

            string[] directories = Directory.GetFiles(directoryPath);

            foreach (string directory in directories)
            {
                size += getFolderSize(directory);
            }

            return Math.Ceiling(size / 1024 / 1024);
        }
    }
}
