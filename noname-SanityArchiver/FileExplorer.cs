using noname_SanityArchiver.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace noname_SanityArchiver
{
    internal class FileExplorer
    {
        public FileExplorer(DataGridView view, TextBox textBox)
        {
            View = view;
            CurrentItems = new List<FileSystemInfo>();
            AbsoluePathBox = textBox;
        }

        public enum ItemType { Directory, File };

        public TextBox AbsoluePathBox { get; }
        public DirectoryInfo CurrentDirectory { get; set; }
        public List<FileSystemInfo> CurrentItems { get; set; }

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

        public DataGridView View { get; }

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
            catch (Exception exception)
            {
                if (exception is DirectoryNotFoundException || exception is UnauthorizedAccessException)
                {
                    UpdateAbsolutePath();
                    return;
                }
            }

            CurrentDirectory = selectedFolder;
            UpdateAbsolutePath();
            DirectoryInfo parent = Directory.GetParent(selectedFolder.FullName); ;
            if (parent != null)
            {
                CurrentItems.Add(parent);
                View.Rows.Add(Resources.icon_arrow_left, "...", "", "");
            }

            AddItemsToView(directories, ItemType.Directory);

            AddItemsToView(files, ItemType.File);
        }

        public void DisplayFiles()
        {
            Microsoft.VisualBasic.Interaction.Beep();
            DisplayFiles(CurrentDirectory);
            View.ClearSelection();
        }

        public string GetFileNameWithExtension(DataGridViewRow row)
        {
            string name = row.Cells[1].Value.ToString();
            string extension = row.Cells[3].Value.ToString();
            return name + extension;
        }

        /// <summary>
        /// Returns the size of the given folder in bytes
        /// </summary>
        public long GetFolderSize(string directoryPath)
        {
            if (!File.GetAttributes(directoryPath).HasFlag(FileAttributes.Directory))
            {
                return 0;
            }

            long size = 0;
            string[] files = Directory.GetFiles(directoryPath);

            foreach (string file in files)
            {
                size += new FileInfo(file).Length;
            }

            string[] directories = Directory.GetDirectories(directoryPath);

            foreach (string directory in directories)
            {
                size += GetFolderSize(directory);
            }

            return size;
        }

        public void UpdateAbsolutePath()
        {
            AbsoluePathBox.Text = CurrentDirectory.FullName;
        }

        private void AddItemsToView(FileSystemInfo[] items, ItemType itemType)
        {
            string fileSize;
            string baseName;
            string extension;
            Bitmap icon;
            for (int i = 0; i < items.Length; i++)
            {
                CurrentItems.Add(items[i]);
                baseName = items[i].Name;
                icon = Resources.icon_folder_full;
                fileSize = string.Empty;
                extension = string.Empty;

                if (itemType == ItemType.File)
                {
                    baseName = Path.GetFileNameWithoutExtension(baseName);
                    fileSize = (((FileInfo)items[i]).Length / 1024).ToString() + " kB";
                    icon = Icon.ExtractAssociatedIcon(items[i].FullName).ToBitmap();
                    extension = items[i].Extension;
                }
                else
                {
                    if (IsEmpty((DirectoryInfo)items[i]))
                    {
                        icon = Resources.icon_folder;
                    }
                }
                View.Rows.Add(icon, baseName, extension, fileSize);
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
    }
}