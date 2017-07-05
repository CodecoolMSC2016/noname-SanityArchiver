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

#region ToolStrip Handlers


        private void toolFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolButtonEncrypt_Click(object sender, EventArgs e)
        {
            // TODO: implement crypt button
        }

        private void toolButtonDecrypt_Click(object sender, EventArgs e)
        {

        }

        private void toolButtonCompress_Click(object sender, EventArgs e)
        {
            // TODO: implement compress button
        }

        private void toolButtonDecompress_Click(object sender, EventArgs e)
        {

        }


#endregion

        #region View ClickEvents
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
            int itemIndex = explorer.View.CurrentCell.RowIndex;
            FileSystemInfo selectedItem = explorer.CurrentItems[itemIndex];
            var attr = File.GetAttributes(selectedItem.FullName);
            if (attr.HasFlag(FileAttributes.Directory))
            {
                explorer.DisplayFiles((DirectoryInfo)selectedItem);
            }
        }

        private void UpdateAppropriateTextBox(FileExplorer explorer)
        {
            string path = explorer.GetSelectedItem().FullName;
            explorer.UpdateAbsolutePath(path);
        }

    }
}
