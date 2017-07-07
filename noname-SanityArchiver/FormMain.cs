using noname_SanityArchiver.Properties;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
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
            leftFileExplorer = new FileExplorer(leftView, leftTextBox, listMenu);
            rightFileExplorer = new FileExplorer(rightView, rightTextBox, listMenu);
            root = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System));
            var formStart = new FormStartWindow();
            formStart.ShowDialog(this);

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

        }

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
            DataGridView view = (DataGridView)sender;
            FileExplorer explorer = GetFileExplorer(view);
            if (e.Button == MouseButtons.Right && explorer.SelectedItems.Length == 1)
            {
                var hti = view.HitTest(e.X, e.Y);
                view.ClearSelection();
                if (hti.RowIndex >= 0)
                {
                    view.Rows[hti.RowIndex].Selected = true;
                }
                if (sender == leftView)
                {
                    menuItemCopy.Image = Resources.icon_arrow_right;
                    menuItemMove.Image = Resources.icon_arrow_right;
                }
                else
                {
                    menuItemCopy.Image = Resources.icon_arrow_left;
                    menuItemMove.Image = Resources.icon_arrow_left;
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
            UpdatePanes();
        }

        private void menuItemCopy_Click(object sender, EventArgs e)
        {
            FileCompress compress = new FileCompress();
            FileExplorer explorer = GetFileExplorer(FocusedView);
            FileExplorer otherExp = GetFileExplorer(GetOtherView(FocusedView));
            string[] selectedPaths = explorer.SelectedItems
                .Select(selected => selected.FullName)
                .ToArray();

            string dest = otherExp.CurrentDirectory.FullName;
            FileTransfer.TransferFiles(selectedPaths, Path.Combine(dest), FileTransfer.TransferType.Copy);

            UpdatePanes();
        }

        private void menuItemDecrypt_Click(object sender, EventArgs e)
        {
            FileCompress compress = new FileCompress();
            FileExplorer explorer = GetFileExplorer(FocusedView);
            string[] selectedPaths = explorer.SelectedItems
                .Where(info => info.Extension == ".tnc")
                .Select(selected => selected.FullName)
                .ToArray();

            string password = Microsoft.VisualBasic.Interaction.InputBox("Please enter password:", "Enter password");

            for (int i = 0; i < selectedPaths.Length; i++)
            {
                FileCryptor cryptor = new FileCryptor(selectedPaths[i]);
                string zipFile = cryptor.DecryptFile(password);
                Regex removeZipExt = new Regex(@"\.zip$", RegexOptions.IgnoreCase);
                string dir = removeZipExt.Replace(zipFile, "");
                Directory.CreateDirectory(dir);
                compress.DeCompress(zipFile, dir);
                File.Delete(zipFile);
            }
            UpdatePanes();
        }

        private void menuItemDelete_Click(object sender, EventArgs e)
        {
            FileExplorer explorer = GetFileExplorer(FocusedView);
            string[] selectedPaths = explorer.SelectedItems
                .Select(selected => selected.FullName)
                .ToArray();
            for (int i = 0; i < selectedPaths.Length; i++)
            {
                string path = selectedPaths[i];
                if (FileTransfer.IsDirectory(path))
                {
                    Directory.Delete(path, true);
                }
                else
                {
                    File.Delete(path);
                }
            }
            UpdatePanes();
        }

        private void menuItemEncrypt_Click(object sender, EventArgs e)
        {
            FileCompress compress = new FileCompress();
            FileExplorer explorer = GetFileExplorer(FocusedView);
            string[] selectedPaths = explorer.SelectedItems
                .Select(selected => selected.FullName)
                .ToArray();

            string password = Microsoft.VisualBasic.Interaction.InputBox("Please enter password:", "Enter password");

            if (selectedPaths.Length == 1)
            {
                string filepath = selectedPaths[0];
                FileCryptor cryptor = new FileCryptor(filepath);
                if (password != "")
                {
                    cryptor.EncryptFile(password);
                }
            }
            else if (selectedPaths.Length > 1)
            {
                DirectoryInfo currentDir = explorer.CurrentDirectory;
                FileCryptor.EncryptMultiple(selectedPaths,
                    Path.Combine(currentDir.FullName, currentDir.Name + ".zip"),
                    password);
            }

            UpdatePanes();
        }

        private void menuItemMove_Click(object sender, EventArgs e)
        {
            FileCompress compress = new FileCompress();
            FileExplorer explorer = GetFileExplorer(FocusedView);
            FileExplorer otherExp = GetFileExplorer(GetOtherView(FocusedView));
            string[] selectedPaths = explorer.SelectedItems
                .Select(selected => selected.FullName)
                .ToArray();

            string dest = GetFileExplorer(GetOtherView(FocusedView)).CurrentDirectory.FullName;
            FileTransfer.TransferFiles(selectedPaths, dest, FileTransfer.TransferType.Move);

            UpdatePanes();
        }

        private void menuItemRefresh_Click(object sender, EventArgs e)
        {
            FileExplorer explorer = GetFileExplorer(FocusedView);
            UpdatePanes();
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
            UpdatePanes();
        }

        private void menuItemView_Click(object sender, EventArgs e)
        {
            FileExplorer explorer = GetFileExplorer(FocusedView);
            textFileWindow viewer = new textFileWindow(explorer.SelectedItems[0].FullName);
        }

        private void Switch_Click(object sender, EventArgs e)
        {
            PictureBox control = (PictureBox)sender;
            FileExplorer from = GetFileExplorer(control);
            FileExplorer to = GetFileExplorer(GetOtherView(FocusedView));
            to.DisplayFiles(from.CurrentDirectory);
        }

        #endregion MenuStrip Handlers

        #region Helpers

        private FileExplorer GetFileExplorer(Control control)
        {
            if (control == leftView || control == leftTextBox || control == leftToRight)
            {
                return leftFileExplorer;
            }
            else if (control == rightView || control == rightTextBox || control == rightToLeft)
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

        private void listMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            FileExplorer explorer = GetFileExplorer(FocusedView);
            FileSystemInfo[] selectedPaths = explorer.SelectedItems;
            long size = 0;
            for (int i = 0; i < selectedPaths.Length; i++)
            {
                string path = selectedPaths[i].FullName;

                if (FileTransfer.IsDirectory(path))
                {

                    size += explorer.GetFolderSize(path, e);
                }
                else
                {
                    FileInfo selectedFile = (FileInfo)selectedPaths[i];
                    size += selectedFile.Length;
                }
            }
            menuItemSize.Text = (size / 1024) + " kB";
        }

        private void menuItemChangeAttr_Click(object sender, EventArgs e)
        {
            FileExplorer explorer = GetFileExplorer(FocusedView);
            string selectedFile = explorer.SelectedItems[0].FullName;

            FileAttributeChange fac = new FileAttributeChange(selectedFile);
        }

    }

}