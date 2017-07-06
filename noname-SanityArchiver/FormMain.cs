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
using System.Diagnostics;

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
            leftFileExplorer = new FileExplorer(leftView, LeftTextBox);
            rightFileExplorer = new FileExplorer(rightView, RightTextBox);
            root = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System));
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            var rootDirInfo = new DirectoryInfo(root).Root;
            leftFileExplorer.DisplayFiles(rootDirInfo);
            rightFileExplorer.DisplayFiles(rootDirInfo);
            leftView.ClearSelection();
            rightView.ClearSelection();
        }

#region ToolStrip Handlers


        private void toolFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolButtonEncrypt_Click(object sender, EventArgs e)
        {
            FileExplorer selectedExplorer = rightView.Focused ? rightFileExplorer : leftFileExplorer;

            FileCryptor cryptor = new FileCryptor(selectedExplorer.SelectedItems[0].FullName);
            cryptor.EncryptFile("pass");
            UpdatePanes();
        }

        private void toolButtonDecrypt_Click(object sender, EventArgs e)
        {
            FileExplorer selectedExplorer = rightView.Focused ? rightFileExplorer : leftFileExplorer;

            FileCryptor cryptor = new FileCryptor(selectedExplorer.SelectedItems[0].FullName);
            cryptor.DecryptFile("pass");
            UpdatePanes();
        }

        private void toolButtonCompress_Click(object sender, EventArgs e)
        {
            // TODO: implement compress button
        }

        private void toolButtonDecompress_Click(object sender, EventArgs e)
        {

        }


        #endregion

#region View Events
        private void leftView_DoubleClick(object sender, EventArgs e)
        {
            CallAppropriateExplorer(leftFileExplorer);
        }

        private void rightView_DoubleClick(object sender, EventArgs e)
        {
            CallAppropriateExplorer(rightFileExplorer);
        }

        private void View_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DataGridView view = (DataGridView)sender;
                var hti = view.HitTest(e.X, e.Y);
                view.ClearSelection();
                view.Rows[hti.RowIndex].Selected = true;
                view.Focus();
            }
        }

        private void View_Leave(object sender, EventArgs e)
        {
            ((DataGridView)sender).ClearSelection();
        }

        private void View_KeyDown(object sender, KeyEventArgs e)
        {
            if (IsEnterPressed(e))
            {
                DataGridView view = (DataGridView)sender;
                CallAppropriateExplorer(GetFileExplorer(view));
            }
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (IsEnterPressed(e))
            {
                TextBox textbox = (TextBox)sender;
                SearchForDirectory(GetFileExplorer(textbox));
            }
        }

        private void leftView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string oldPath = leftFileExplorer.CurrentItems[e.RowIndex].FullName;
                var changedRow = leftView.Rows[e.RowIndex];
                string newName = ((string)changedRow.Cells["nameHeaderLeft"].Value +
                    (string)changedRow.Cells["extensionHeaderLeft"].Value);
                FileTransfer ft = new FileTransfer();
                ft.Rename(oldPath, newName);
                UpdatePanes();
            }
        }

        private void rightView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string oldPath = rightFileExplorer.CurrentItems[e.RowIndex].FullName;
                var changedRow = rightView.Rows[e.RowIndex];
                string newName = ((string)changedRow.Cells["nameHeaderRight"].Value +
                    (string)changedRow.Cells["extensionHeaderRight"].Value);
                FileTransfer ft = new FileTransfer();
                ft.Rename(oldPath, newName);
                UpdatePanes();
            }
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


        private void SearchForDirectory(FileExplorer explorer)
        {
            string absolutePath = explorer.AbsoluePathBox.Text;
            try
            {
                explorer.DisplayFiles(new DirectoryInfo(absolutePath));
            }
            catch (ArgumentException)
            {
                explorer.UpdateAbsolutePath();
            }
        }

        private bool IsEnterPressed(KeyEventArgs e)
        {
            return e.KeyCode == Keys.Enter;
        }



        private void UpdatePanes()
        {
            leftFileExplorer.DisplayFiles();
            rightFileExplorer.DisplayFiles();
        }

        private DataGridView GetOtherView(DataGridView view)
        {
            if (view == leftView)
            {
                return rightView;
            }
            else if (view == rightView)
            {
                return leftView;
            }
            return null;
        }

        private FileExplorer GetFileExplorer(DataGridView view)
        {
            if (view == leftView)
            {
                return leftFileExplorer;
            }
            else if (view == rightView)
            {
                return rightFileExplorer;
            }
            return null;
        }

        private FileExplorer GetFileExplorer(TextBox textbox)
        {
            if (true)
            {
                if (textbox == LeftTextBox)
                {
                    return leftFileExplorer;
                }
                else if (textbox == RightTextBox)
                {
                    return rightFileExplorer;
                }
                return null;
            }
        }
    }
}
