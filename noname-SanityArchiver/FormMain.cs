﻿using noname_SanityArchiver.Properties;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace noname_SanityArchiver
{
    public partial class FormMain : Form
    {
        private FileExplorer leftFileExplorer;
        private FileExplorer rightFileExplorer;
        private string root;

        public FormMain()
        {
            InitializeComponent();
            leftFileExplorer = new FileExplorer(leftView, LeftTextBox);
            rightFileExplorer = new FileExplorer(rightView, RightTextBox);
            root = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System));
        }

        public DataGridView FocusedView
        {
            get
            {
                return rightView.Focused ? rightView : leftView;
            }
        }

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

        private void FormMain_Load(object sender, EventArgs e)
        {
            var rootDirInfo = new DirectoryInfo(root).Root;
            leftFileExplorer.DisplayFiles(rootDirInfo);
            rightFileExplorer.DisplayFiles(rootDirInfo);
            leftView.ClearSelection();
            rightView.ClearSelection();
        }

        #region ToolStrip Handlers

        private void toolButtonCompress_Click(object sender, EventArgs e)
        {
            // TODO: implement compress button
        }

        private void toolButtonDecompress_Click(object sender, EventArgs e)
        {
        }

        private void toolButtonDecrypt_Click(object sender, EventArgs e)
        {
            FileExplorer selectedExplorer = GetFileExplorer(FocusedView);

            FileCryptor cryptor = new FileCryptor(selectedExplorer.SelectedItems[0].FullName);
            cryptor.DecryptFile("pass");
            UpdatePanes();
        }

        private void toolButtonEncrypt_Click(object sender, EventArgs e)
        {
            FileExplorer selectedExplorer = GetFileExplorer(FocusedView);

            FileCryptor cryptor = new FileCryptor(selectedExplorer.SelectedItems[0].FullName);
            cryptor.EncryptFile("pass");
            UpdatePanes();
        }

        private void toolFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion ToolStrip Handlers

        #region View Events

        private void leftView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string oldPath = leftFileExplorer.CurrentItems[e.RowIndex].FullName;
                var changedRow = leftView.Rows[e.RowIndex];
                string newName = ((string)changedRow.Cells["nameHeaderLeft"].Value +
                    (string)changedRow.Cells["extensionHeaderLeft"].Value);
                FileTransfer.Rename(oldPath, newName);
                UpdatePanes();
            }
        }

        private void leftView_DoubleClick(object sender, EventArgs e)
        {
            CallAppropriateExplorer(leftFileExplorer);
        }

        private void rightView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string oldPath = rightFileExplorer.CurrentItems[e.RowIndex].FullName;
                var changedRow = rightView.Rows[e.RowIndex];
                string newName = ((string)changedRow.Cells["nameHeaderRight"].Value +
                    (string)changedRow.Cells["extensionHeaderRight"].Value);
                FileTransfer.Rename(oldPath, newName);
                UpdatePanes();
            }
        }

        private void rightView_DoubleClick(object sender, EventArgs e)
        {
            CallAppropriateExplorer(rightFileExplorer);
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (IsEnterPressed(e))
            {
                TextBox textbox = (TextBox)sender;
                SearchForDirectory(GetFileExplorer(textbox));
            }
        }

        private void View_KeyDown(object sender, KeyEventArgs e)
        {
            if (IsEnterPressed(e))
            {
                DataGridView view = (DataGridView)sender;
                CallAppropriateExplorer(GetFileExplorer(view));
            }
        }

        private void View_Leave(object sender, EventArgs e)
        {
            ((DataGridView)sender).ClearSelection();
        }

        private void View_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DataGridView view = (DataGridView)sender;
                var hti = view.HitTest(e.X, e.Y);
                view.ClearSelection();
                view.Rows[hti.RowIndex].Selected = true;
                if (sender == leftView)
                {
                    menuItemMove.Image = Resources.icon_arrow;
                    menuItemMove.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
                }
                else
                {
                    menuItemMove.Image = Resources.icon_arrow;
                }
                view.Focus();
            }
        }

        #endregion View Events

        #region MenuStrip Handlers

        private void menuItemArchive_Click(object sender, EventArgs e)
        {
            FileCompress compress = new FileCompress();
            FileExplorer explorer = GetFileExplorer(FocusedView);
            string[] selectedPaths = explorer.SelectedItems
                .Select(selected => selected.FullName)
                .ToArray();

            sfd.InitialDirectory = explorer.CurrentDirectory.FullName;
            sfd.FileName = Path.GetFileNameWithoutExtension(explorer.SelectedItems[0].Name);
            DialogResult result = sfd.ShowDialog(this);
            if (result != DialogResult.OK)
            {
                return;
            }

            compress.Compress(selectedPaths, sfd.FileName);
            explorer.DisplayFiles();
        }

        private void menuItemUnarchive_Click(object sender, EventArgs e)
        {
            FileCompress compress = new FileCompress();
            FileExplorer explorer = GetFileExplorer(FocusedView);
            string[] selectedPaths = explorer.SelectedItems
                .Where(info => info.Extension == ".zip")
                .Select(selected => selected.FullName)
                .ToArray();

            fbd.SelectedPath = explorer.CurrentDirectory.FullName;
            DialogResult result = fbd.ShowDialog(this);
            if (result != DialogResult.OK)
            {
                return;
            }

            for (int i = 0; i < selectedPaths.Length; i++)
            {
                compress.DeCompress(selectedPaths[i], fbd.SelectedPath);
            }
            explorer.DisplayFiles();
        }

        private void menuItemView_Click(object sender, EventArgs e)
        {
            FileExplorer explorer = GetFileExplorer(FocusedView);
            textFileWindow viewer = new textFileWindow(explorer.SelectedItems[0].FullName);
        }

        #endregion MenuStrip Handlers

        #region Helpers

        private FileExplorer GetFileExplorer(Control control)
        {
            if (control == leftView || control == LeftTextBox)
            {
                return leftFileExplorer;
            }
            else if (control == rightView || control == RightTextBox)
            {
                return rightFileExplorer;
            }
            return null;
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

        private bool IsEnterPressed(KeyEventArgs e)
        {
            return e.KeyCode == Keys.Enter;
        }

        private void SearchForDirectory(FileExplorer explorer)
        {
            string absolutePath = explorer.AbsoluePathBox.Text;
            try
            {
                explorer.DisplayFiles(new DirectoryInfo(absolutePath));
            }
            catch (Exception exception)
            {
                if (exception is UnauthorizedAccessException || exception is NotSupportedException)
                {
                    explorer.UpdateAbsolutePath();
                }
                throw exception;
            }
        }

        private void UpdatePanes()
        {
            leftFileExplorer.DisplayFiles();
            rightFileExplorer.DisplayFiles();
        }

        #endregion Helpers
    }
}