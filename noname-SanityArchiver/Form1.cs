using noname_SanityArchiver.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace noname_SanityArchiver
{
    public partial class Form1 : Form
    {
        private string root;
        private FileExplorer fileExplorer;

        public Form1()
        {
            InitializeComponent();
            fileExplorer = FileExplorer.INSTANCE;
            root = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System));
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            /*
            #region Szarfos 

            string filename = @"C: \Users\racer01\AppData\Local\GitHubDesktop\GitHub Desktop.exe";
            Icon icon = Icon.ExtractAssociatedIcon(filename);


            imageList1.Images.Add(icon);
            listView1.Items.Add(new ListViewItem("", 0));

            #endregion*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayFiles(root);
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string selectedItem = listView1.SelectedItems[0].SubItems[1].Text;

            //string absolutePath = Path.GetFullPath(selectedFolder);
            string selectedFolder = fileExplorer.CurrentDirectories[selectedItem].FullName;
            FileAttributes attr = File.GetAttributes(selectedFolder);
            if (attr.HasFlag(FileAttributes.Directory))
            {
                displayFiles(selectedFolder);
            }
        }

        private void displayFiles(DirectoryInfo selectedFolder)
        {
            listView1.Items.Clear();
            fileExplorer.CurrentDirectories.Clear();
            //root = selectedFolder;
            //listView1.Update();
            //listView1.Refresh();

            FileInfo[] files = selectedFolder.GetFiles();
            DirectoryInfo[] directories = selectedFolder.GetDirectories();
            List<ListViewItem> items = new List<ListViewItem>();
            items.Add(new ListViewItem(new[] { "0", "...", "", "" }));
            try
            {
                fileExplorer.CurrentDirectories["..."] = Directory.GetParent(selectedFolder.FullName);
            }
            catch (NullReferenceException)
            {
                fileExplorer.CurrentDirectories["..."] = selectedFolder;
            }

            for (int i = 0; i < directories.Length; i++)
            {
                fileExplorer.CurrentDirectories.Add(directories[i].Name, directories[i].FullName);
                string dirName = directories[i].Name.Split('.')[0];
                var row = new ListViewItem(new[] { "", dirName, "", directories[i].Extension });
                row.ImageIndex = i;
                items.Add(row);
                imageList1.Images.Add(Resources.folder);
            }


            for (int i = 0; i < files.Length; i++)
            {
                currentDirs.Add(files[i].Name, files[i].FullName);
                string fileSize = (files[i].Length / 1048576).ToString();
                Icon icon = Icon.ExtractAssociatedIcon(files[i].FullName);
                string fileName = files[i].Name.Split('.')[0];
                var row = new ListViewItem(new[] { "", fileName, fileSize, files[i].Extension });
                row.ImageIndex = i;
                items.Add(row);
                imageList1.Images.Add(icon);

            }
            listView1.Items.AddRange(items.ToArray());
        }
    }
}
