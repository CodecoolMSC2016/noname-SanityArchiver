using noname_SanityArchiver.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace noname_SanityArchiver
{
    internal class FileExplorer
    {
        public FileExplorer(DataGridView view, TextBox textBox, ContextMenuStrip listMenu)
        {
            View = view;
            CurrentItems = new List<FileSystemInfo>();
            AbsoluePathBox = textBox;
            this.listMenu = listMenu;
        }

        public enum ItemType { Directory, File };

        public TextBox AbsoluePathBox { get; }
        public DirectoryInfo CurrentDirectory { get; set; }
        public List<FileSystemInfo> CurrentItems { get; set; }
        private ContextMenuStrip listMenu;

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
            FileInfo[] files;
            DirectoryInfo[] directories;

            LoadFilesAndDirectories(out files, out directories, selectedFolder);

            if (files != null && directories != null)
            {
                View.Rows.Clear();
                CurrentItems.Clear();

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
        }

        public void DisplayFiles()
        {
            Microsoft.VisualBasic.Interaction.Beep();
            DisplayFiles(CurrentDirectory);
            View.ClearSelection();
        }

        private void LoadFilesAndDirectories(out FileInfo[] files, out DirectoryInfo[] directories, DirectoryInfo selectedFolder)
        {
            try
            {
                files = selectedFolder.GetFiles();
                directories = selectedFolder.GetDirectories();

            }
            catch (Exception exception)
            {
                files = null;
                directories = null;

                //string messageToDisplay = "Something went wrong.";

                if (exception is DirectoryNotFoundException)
                {
                    UpdateAbsolutePath();
                    return;
                }
                MessageBox.Show(exception.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            long size = 0;
            if (File.GetAttributes(directoryPath).HasFlag(FileAttributes.Directory))
            {
                string[] files = Directory.GetFiles(directoryPath);
                string[] directories = Directory.GetDirectories(directoryPath);

                foreach (string file in files)
                {
                    size += new FileInfo(file).Length;
                }

                foreach (string directory in directories)
                {
                    size += GetFolderSize(directory);
                }
            }
            return size;
        }

        public long GetFolderSize(string directoryPath, CancelEventArgs e)
        {
            try
            {
               return GetFolderSize(directoryPath);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return 0;
            }

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