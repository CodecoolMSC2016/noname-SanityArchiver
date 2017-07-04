using noname_SanityArchiver.Properties;
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

        public Dictionary<string, DirectoryInfo> CurrentDirectories { get; set; }

        public Dictionary<string, FileInfo> CurrentFiles { get; set; }

        public DataGridView View { get; }

        private TextBox absoluePathBox;
        

        public FileExplorer(DataGridView view, TextBox textBox)
        {
            View = view;
            CurrentDirectories = new Dictionary<string, DirectoryInfo>();
            CurrentFiles = new Dictionary<string, FileInfo>();
            absoluePathBox = textBox;
        }

        public FileSystemInfo GetSelectedItem()
        {
            string itemName = GetFileNameWithExtension(View.SelectedRows[0]);
            if (CurrentDirectories.ContainsKey(itemName))
            {
                return CurrentDirectories[itemName];
            }
            return CurrentFiles[itemName];
        }

        public void DisplayFiles(DirectoryInfo selectedFolder)
        {
            View.Rows.Clear();
            CurrentDirectories.Clear();
            CurrentFiles.Clear();

            UpdateAbsolutePath(selectedFolder.FullName);

            FileInfo[] files = selectedFolder.GetFiles();
            DirectoryInfo[] directories = selectedFolder.GetDirectories();
            //List<ListViewItem> items = new List<ListViewItem>();
            //items.Add(new ListViewItem(new[] { "0", "...", "", "" }));
            View.Rows.Add(Resources.icon_arrow, "...", "", "");
            try
            {
                CurrentDirectories["..."] = Directory.GetParent(selectedFolder.FullName);
            }
            catch (NullReferenceException)
            {
                CurrentDirectories["..."] = selectedFolder;
            }

            for (int i = 0; i < directories.Length; i++)
            {
                CurrentDirectories.Add(directories[i].Name, directories[i]);
                string dirName = directories[i].Name.Split('.')[0];
                View.Rows.Add(Resources.icon_folder, dirName, "", directories[i].Extension);

            }

            for (int i = 0; i < files.Length; i++)
            {
                CurrentFiles.Add(files[i].Name, files[i]);
                string fileSize = (files[i].Length / 1048576).ToString();
                Icon icon = Icon.ExtractAssociatedIcon(files[i].FullName);
                string fileName = files[i].Name.Split('.')[0];
                View.Rows.Add(icon, fileName, fileSize, files[i].Extension);
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
    }
}
