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
    public partial class FormMain : Form
    {
        private string root;
        private FileExplorer leftFileExplorer;
        private FileExplorer rightFileExplorer;

        public FormMain()
        {
            InitializeComponent();
            leftFileExplorer = new FileExplorer(LeftView, LeftTextBox);
            rightFileExplorer = new FileExplorer(RightView, RightTextBox);
            root = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System));
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            var rootDirInfo = new DirectoryInfo(root).Root;
            rightFileExplorer.DisplayFiles(rootDirInfo);
            leftFileExplorer.DisplayFiles(rootDirInfo);
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

#region ClickEvents
        private void leftView_DoubleClick(object sender, EventArgs e)
        {
            CallAppropriateExplorer(leftFileExplorer);
        }

        private void rightView_DoubleClick(object sender, EventArgs e)
        {
            CallAppropriateExplorer(rightFileExplorer);
        }

        private void LeftView_Click(object sender, EventArgs e)
        {
            UpdateAppropriateTextBox(leftFileExplorer);
        }

        private void RightView_Click(object sender, EventArgs e)
        {
            UpdateAppropriateTextBox(rightFileExplorer);
        }
#endregion
        private void CallAppropriateExplorer(FileExplorer explorer)
        {
            string selectedItem = GetFileNameWithExtension(explorer.View.SelectedRows[0]);
            if (explorer.CurrentDirectories.ContainsKey(selectedItem))
            {
                DirectoryInfo chosenDirectory = explorer.CurrentDirectories[selectedItem];
                explorer.DisplayFiles(chosenDirectory);
            }
        }

        private void UpdateAppropriateTextBox(FileExplorer explorer)
        {
            string path = GetFullPathOfSelectedItem(explorer);
            explorer.UpdateAbsolutePath(path);
        }

        private string GetFullPathOfSelectedItem(FileExplorer explorer)
        {
            var selectedRow = explorer.View.SelectedRows[0];
            string name = selectedRow.Cells[1].Value.ToString();
            string extension = selectedRow.Cells[3].Value.ToString();
            string selectedItem = name + extension;

            if (explorer.CurrentDirectories.ContainsKey(selectedItem))
            {
                return explorer.CurrentDirectories[selectedItem].FullName;
            }
            return explorer.CurrentFiles[selectedItem].FullName;
        }

        private string GetFileNameWithExtension(DataGridViewRow row)
        {
            string name = row.Cells[1].Value.ToString();
            string extension = row.Cells[3].Value.ToString();
            return name + extension;
        }


    }
}
