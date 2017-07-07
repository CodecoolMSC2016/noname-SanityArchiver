namespace noname_SanityArchiver
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.leftView = new System.Windows.Forms.DataGridView();
            this.iconHeaderLeft = new System.Windows.Forms.DataGridViewImageColumn();
            this.nameHeaderLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extensionHeaderLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeHeaderLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemArchive = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemUnarchive = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemEncrypt = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDecrypt = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemMove = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemChangeAttr = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemSize = new System.Windows.Forms.ToolStripTextBox();
            this.searchPanelLeft = new System.Windows.Forms.Panel();
            this.leftTextBox = new System.Windows.Forms.TextBox();
            this.leftToRight = new System.Windows.Forms.PictureBox();
            this.rightView = new System.Windows.Forms.DataGridView();
            this.iconHeaderRight = new System.Windows.Forms.DataGridViewImageColumn();
            this.nameHeaderRight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extensionHeaderRight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeHeaderRight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchPanelRight = new System.Windows.Forms.Panel();
            this.rightTextBox = new System.Windows.Forms.TextBox();
            this.rightToLeft = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftView)).BeginInit();
            this.listMenu.SuspendLayout();
            this.searchPanelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftToRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightView)).BeginInit();
            this.searchPanelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightToLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.leftView);
            this.splitContainer1.Panel1.Controls.Add(this.searchPanelLeft);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rightView);
            this.splitContainer1.Panel2.Controls.Add(this.searchPanelRight);
            this.splitContainer1.Size = new System.Drawing.Size(750, 392);
            this.splitContainer1.SplitterDistance = 375;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // leftView
            // 
            this.leftView.AllowUserToAddRows = false;
            this.leftView.AllowUserToDeleteRows = false;
            this.leftView.AllowUserToOrderColumns = true;
            this.leftView.AllowUserToResizeRows = false;
            this.leftView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.leftView.BackgroundColor = System.Drawing.Color.White;
            this.leftView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.leftView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iconHeaderLeft,
            this.nameHeaderLeft,
            this.extensionHeaderLeft,
            this.sizeHeaderLeft});
            this.leftView.ContextMenuStrip = this.listMenu;
            this.leftView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftView.Location = new System.Drawing.Point(0, 20);
            this.leftView.Margin = new System.Windows.Forms.Padding(0);
            this.leftView.Name = "leftView";
            this.leftView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.leftView.RowHeadersWidth = 4;
            this.leftView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.leftView.Size = new System.Drawing.Size(375, 372);
            this.leftView.TabIndex = 3;
            this.leftView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.leftView_CellValueChanged);
            this.leftView.DoubleClick += new System.EventHandler(this.leftView_DoubleClick);
            this.leftView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.View_KeyDown);
            this.leftView.Leave += new System.EventHandler(this.View_Leave);
            this.leftView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.View_MouseDown);
            // 
            // iconHeaderLeft
            // 
            this.iconHeaderLeft.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.iconHeaderLeft.Frozen = true;
            this.iconHeaderLeft.HeaderText = "";
            this.iconHeaderLeft.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.iconHeaderLeft.Name = "iconHeaderLeft";
            this.iconHeaderLeft.ReadOnly = true;
            this.iconHeaderLeft.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iconHeaderLeft.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iconHeaderLeft.Width = 32;
            // 
            // nameHeaderLeft
            // 
            this.nameHeaderLeft.HeaderText = "Name";
            this.nameHeaderLeft.Name = "nameHeaderLeft";
            // 
            // extensionHeaderLeft
            // 
            this.extensionHeaderLeft.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.extensionHeaderLeft.HeaderText = "Extension";
            this.extensionHeaderLeft.Name = "extensionHeaderLeft";
            this.extensionHeaderLeft.Width = 64;
            // 
            // sizeHeaderLeft
            // 
            this.sizeHeaderLeft.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sizeHeaderLeft.HeaderText = "Size";
            this.sizeHeaderLeft.Name = "sizeHeaderLeft";
            this.sizeHeaderLeft.ReadOnly = true;
            this.sizeHeaderLeft.Width = 64;
            // 
            // listMenu
            // 
            this.listMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.listMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemRefresh,
            this.toolStripSeparator4,
            this.menuItemView,
            this.menuItemArchive,
            this.menuItemUnarchive,
            this.toolStripSeparator1,
            this.menuItemEncrypt,
            this.menuItemDecrypt,
            this.toolStripSeparator2,
            this.menuItemCopy,
            this.menuItemMove,
            this.toolStripSeparator3,
            this.menuItemChangeAttr,
            this.toolStripSeparator5,
            this.menuItemDelete,
            this.toolStripSeparator6,
            this.menuItemSize});
            this.listMenu.Name = "listMenu";
            this.listMenu.Size = new System.Drawing.Size(170, 340);
            this.listMenu.Closing += new System.Windows.Forms.ToolStripDropDownClosingEventHandler(this.listMenu_Closing);
            this.listMenu.Opening += new System.ComponentModel.CancelEventHandler(this.listMenu_Opening);
            // 
            // menuItemRefresh
            // 
            this.menuItemRefresh.Image = global::noname_SanityArchiver.Properties.Resources.icon_refresh;
            this.menuItemRefresh.Name = "menuItemRefresh";
            this.menuItemRefresh.Size = new System.Drawing.Size(169, 26);
            this.menuItemRefresh.Text = "Refresh";
            this.menuItemRefresh.Click += new System.EventHandler(this.menuItemRefresh_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(166, 6);
            // 
            // menuItemView
            // 
            this.menuItemView.Image = global::noname_SanityArchiver.Properties.Resources.icon_eye;
            this.menuItemView.Name = "menuItemView";
            this.menuItemView.Size = new System.Drawing.Size(169, 26);
            this.menuItemView.Text = "View";
            this.menuItemView.Click += new System.EventHandler(this.menuItemView_Click);
            // 
            // menuItemArchive
            // 
            this.menuItemArchive.Image = global::noname_SanityArchiver.Properties.Resources.icon_inpack;
            this.menuItemArchive.Name = "menuItemArchive";
            this.menuItemArchive.Size = new System.Drawing.Size(169, 26);
            this.menuItemArchive.Text = "Archive";
            this.menuItemArchive.Click += new System.EventHandler(this.menuItemArchive_Click);
            // 
            // menuItemUnarchive
            // 
            this.menuItemUnarchive.Image = global::noname_SanityArchiver.Properties.Resources.icon_unpack;
            this.menuItemUnarchive.Name = "menuItemUnarchive";
            this.menuItemUnarchive.Size = new System.Drawing.Size(169, 26);
            this.menuItemUnarchive.Text = "Unarchive";
            this.menuItemUnarchive.Click += new System.EventHandler(this.menuItemUnarchive_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(166, 6);
            // 
            // menuItemEncrypt
            // 
            this.menuItemEncrypt.Image = global::noname_SanityArchiver.Properties.Resources.icon_lock;
            this.menuItemEncrypt.Name = "menuItemEncrypt";
            this.menuItemEncrypt.Size = new System.Drawing.Size(169, 26);
            this.menuItemEncrypt.Text = "Encrypt";
            this.menuItemEncrypt.Click += new System.EventHandler(this.menuItemEncrypt_Click);
            // 
            // menuItemDecrypt
            // 
            this.menuItemDecrypt.Image = global::noname_SanityArchiver.Properties.Resources.icon_unlock;
            this.menuItemDecrypt.Name = "menuItemDecrypt";
            this.menuItemDecrypt.Size = new System.Drawing.Size(169, 26);
            this.menuItemDecrypt.Text = "Decrypt";
            this.menuItemDecrypt.Click += new System.EventHandler(this.menuItemDecrypt_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(166, 6);
            // 
            // menuItemCopy
            // 
            this.menuItemCopy.Image = global::noname_SanityArchiver.Properties.Resources.icon_arrow_left;
            this.menuItemCopy.Name = "menuItemCopy";
            this.menuItemCopy.Size = new System.Drawing.Size(169, 26);
            this.menuItemCopy.Text = "Copy";
            this.menuItemCopy.Click += new System.EventHandler(this.menuItemCopy_Click);
            // 
            // menuItemMove
            // 
            this.menuItemMove.Image = global::noname_SanityArchiver.Properties.Resources.icon_move;
            this.menuItemMove.Name = "menuItemMove";
            this.menuItemMove.Size = new System.Drawing.Size(169, 26);
            this.menuItemMove.Text = "Move";
            this.menuItemMove.Click += new System.EventHandler(this.menuItemMove_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(166, 6);
            // 
            // menuItemChangeAttr
            // 
            this.menuItemChangeAttr.Image = global::noname_SanityArchiver.Properties.Resources.icon_attributes;
            this.menuItemChangeAttr.Name = "menuItemChangeAttr";
            this.menuItemChangeAttr.Size = new System.Drawing.Size(169, 26);
            this.menuItemChangeAttr.Text = "Change Attribute";
            this.menuItemChangeAttr.Click += new System.EventHandler(this.menuItemChangeAttr_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(166, 6);
            // 
            // menuItemDelete
            // 
            this.menuItemDelete.Image = global::noname_SanityArchiver.Properties.Resources.icon_erase;
            this.menuItemDelete.Name = "menuItemDelete";
            this.menuItemDelete.Size = new System.Drawing.Size(169, 26);
            this.menuItemDelete.Text = "Delete";
            this.menuItemDelete.Click += new System.EventHandler(this.menuItemDelete_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(166, 6);
            // 
            // menuItemSize
            // 
            this.menuItemSize.BackColor = System.Drawing.Color.White;
            this.menuItemSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.menuItemSize.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.menuItemSize.Name = "menuItemSize";
            this.menuItemSize.ReadOnly = true;
            this.menuItemSize.Size = new System.Drawing.Size(100, 16);
            this.menuItemSize.Text = "Calculating...";
            // 
            // searchPanelLeft
            // 
            this.searchPanelLeft.Controls.Add(this.leftTextBox);
            this.searchPanelLeft.Controls.Add(this.leftToRight);
            this.searchPanelLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchPanelLeft.Location = new System.Drawing.Point(0, 0);
            this.searchPanelLeft.Margin = new System.Windows.Forms.Padding(2);
            this.searchPanelLeft.Name = "searchPanelLeft";
            this.searchPanelLeft.Size = new System.Drawing.Size(375, 20);
            this.searchPanelLeft.TabIndex = 5;
            // 
            // leftTextBox
            // 
            this.leftTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leftTextBox.Location = new System.Drawing.Point(0, 0);
            this.leftTextBox.Name = "leftTextBox";
            this.leftTextBox.Size = new System.Drawing.Size(357, 21);
            this.leftTextBox.TabIndex = 2;
            this.leftTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // leftToRight
            // 
            this.leftToRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leftToRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.leftToRight.Image = global::noname_SanityArchiver.Properties.Resources.icon_arrow_right;
            this.leftToRight.Location = new System.Drawing.Point(357, 0);
            this.leftToRight.Margin = new System.Windows.Forms.Padding(2);
            this.leftToRight.Name = "leftToRight";
            this.leftToRight.Size = new System.Drawing.Size(18, 20);
            this.leftToRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.leftToRight.TabIndex = 4;
            this.leftToRight.TabStop = false;
            this.leftToRight.Click += new System.EventHandler(this.Switch_Click);
            // 
            // rightView
            // 
            this.rightView.AllowUserToAddRows = false;
            this.rightView.AllowUserToDeleteRows = false;
            this.rightView.AllowUserToOrderColumns = true;
            this.rightView.AllowUserToResizeRows = false;
            this.rightView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rightView.BackgroundColor = System.Drawing.Color.White;
            this.rightView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rightView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iconHeaderRight,
            this.nameHeaderRight,
            this.extensionHeaderRight,
            this.sizeHeaderRight});
            this.rightView.ContextMenuStrip = this.listMenu;
            this.rightView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightView.Location = new System.Drawing.Point(0, 20);
            this.rightView.Margin = new System.Windows.Forms.Padding(0);
            this.rightView.Name = "rightView";
            this.rightView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.rightView.RowHeadersWidth = 4;
            this.rightView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rightView.Size = new System.Drawing.Size(372, 372);
            this.rightView.TabIndex = 4;
            this.rightView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.rightView_CellValueChanged);
            this.rightView.DoubleClick += new System.EventHandler(this.rightView_DoubleClick);
            this.rightView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.View_KeyDown);
            this.rightView.Leave += new System.EventHandler(this.View_Leave);
            this.rightView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.View_MouseDown);
            // 
            // iconHeaderRight
            // 
            this.iconHeaderRight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.iconHeaderRight.HeaderText = "";
            this.iconHeaderRight.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.iconHeaderRight.Name = "iconHeaderRight";
            this.iconHeaderRight.ReadOnly = true;
            this.iconHeaderRight.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iconHeaderRight.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iconHeaderRight.Width = 32;
            // 
            // nameHeaderRight
            // 
            this.nameHeaderRight.HeaderText = "Name";
            this.nameHeaderRight.Name = "nameHeaderRight";
            // 
            // extensionHeaderRight
            // 
            this.extensionHeaderRight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.extensionHeaderRight.HeaderText = "Extension";
            this.extensionHeaderRight.Name = "extensionHeaderRight";
            this.extensionHeaderRight.Width = 64;
            // 
            // sizeHeaderRight
            // 
            this.sizeHeaderRight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sizeHeaderRight.HeaderText = "Size";
            this.sizeHeaderRight.Name = "sizeHeaderRight";
            this.sizeHeaderRight.ReadOnly = true;
            this.sizeHeaderRight.Width = 64;
            // 
            // searchPanelRight
            // 
            this.searchPanelRight.Controls.Add(this.rightTextBox);
            this.searchPanelRight.Controls.Add(this.rightToLeft);
            this.searchPanelRight.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchPanelRight.Location = new System.Drawing.Point(0, 0);
            this.searchPanelRight.Margin = new System.Windows.Forms.Padding(2);
            this.searchPanelRight.Name = "searchPanelRight";
            this.searchPanelRight.Size = new System.Drawing.Size(372, 20);
            this.searchPanelRight.TabIndex = 5;
            // 
            // rightTextBox
            // 
            this.rightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rightTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rightTextBox.Location = new System.Drawing.Point(18, 0);
            this.rightTextBox.Name = "rightTextBox";
            this.rightTextBox.Size = new System.Drawing.Size(354, 21);
            this.rightTextBox.TabIndex = 3;
            this.rightTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // rightToLeft
            // 
            this.rightToLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rightToLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.rightToLeft.Image = global::noname_SanityArchiver.Properties.Resources.icon_arrow_left;
            this.rightToLeft.Location = new System.Drawing.Point(0, 0);
            this.rightToLeft.Margin = new System.Windows.Forms.Padding(2);
            this.rightToLeft.Name = "rightToLeft";
            this.rightToLeft.Size = new System.Drawing.Size(18, 20);
            this.rightToLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rightToLeft.TabIndex = 4;
            this.rightToLeft.TabStop = false;
            this.rightToLeft.Click += new System.EventHandler(this.Switch_Click);
            // 
            // sfd
            // 
            this.sfd.Filter = "Zip Files(*.zip)|*.zip|All Files(*.*)|*.*";
            // 
            // fbd
            // 
            this.fbd.Description = "Select the destination folder.";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 392);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Totally Noname Commander - NEM REGISZTRÁLT";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leftView)).EndInit();
            this.listMenu.ResumeLayout(false);
            this.listMenu.PerformLayout();
            this.searchPanelLeft.ResumeLayout(false);
            this.searchPanelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftToRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightView)).EndInit();
            this.searchPanelRight.ResumeLayout(false);
            this.searchPanelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightToLeft)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.TextBox leftTextBox;
        private System.Windows.Forms.TextBox rightTextBox;
        private System.Windows.Forms.DataGridView leftView;
        private System.Windows.Forms.DataGridView rightView;
        private System.Windows.Forms.DataGridViewImageColumn iconHeaderLeft;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameHeaderLeft;
        private System.Windows.Forms.DataGridViewTextBoxColumn extensionHeaderLeft;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeHeaderLeft;
        private System.Windows.Forms.DataGridViewImageColumn iconHeaderRight;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameHeaderRight;
        private System.Windows.Forms.DataGridViewTextBoxColumn extensionHeaderRight;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeHeaderRight;
        private System.Windows.Forms.ContextMenuStrip listMenu;
        private System.Windows.Forms.ToolStripMenuItem menuItemView;
        private System.Windows.Forms.ToolStripMenuItem menuItemArchive;
        private System.Windows.Forms.ToolStripMenuItem menuItemEncrypt;
        private System.Windows.Forms.ToolStripMenuItem menuItemMove;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.ToolStripMenuItem menuItemUnarchive;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.ToolStripMenuItem menuItemDecrypt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuItemCopy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuItemDelete;
        private System.Windows.Forms.ToolStripMenuItem menuItemRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Panel searchPanelLeft;
        private System.Windows.Forms.PictureBox leftToRight;
        private System.Windows.Forms.Panel searchPanelRight;
        private System.Windows.Forms.PictureBox rightToLeft;
        private System.Windows.Forms.ToolStripMenuItem menuItemChangeAttr;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripTextBox menuItemSize;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

