﻿using noname_SanityArchiver.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
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

        public FileSystemInfo GetSelectedItem()
        {
            int itemIndex = View.CurrentCell.RowIndex;
            return CurrentItems[itemIndex];
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
                baseName = RemoveFileExtension(items[i].Name);
                icon = Resources.icon_folder;
                fileSize = "";

                if (itemType == ItemType.File)
                {
                    fileSize = (((FileInfo)items[i]).Length / 1024).ToString();
                    icon = Icon.ExtractAssociatedIcon(items[i].FullName).ToBitmap();
                }
                View.Rows.Add(icon, baseName, fileSize, items[i].Extension);
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

        private string RemoveFileExtension(string fileName)
        {
            int extensionIndex = fileName.Contains('.') ? fileName.LastIndexOf('.') : fileName.Length;
            return fileName.Substring(0, extensionIndex);
        }
    }
}
