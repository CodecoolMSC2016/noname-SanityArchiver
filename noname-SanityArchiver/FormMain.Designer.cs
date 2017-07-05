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
            this.LeftTextBox = new System.Windows.Forms.TextBox();
            this.rightView = new System.Windows.Forms.DataGridView();
            this.RightTextBox = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ToolbarMain = new System.Windows.Forms.ToolStrip();
            this.ToolFileDrop = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tempOpenTextFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolButtonEncrypt = new System.Windows.Forms.ToolStripButton();
            this.toolButtonDecrypt = new System.Windows.Forms.ToolStripButton();
            this.toolButtonCompress = new System.Windows.Forms.ToolStripButton();
            this.toolButtonDecompress = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.iconHeaderLeft = new System.Windows.Forms.DataGridViewImageColumn();
            this.nameHeaderLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extensionHeaderLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeHeaderLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconHeaderRight = new System.Windows.Forms.DataGridViewImageColumn();
            this.nameHeaderRight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extensionHeaderRight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeHeaderRight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightView)).BeginInit();
            this.ToolbarMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.leftView);
            this.splitContainer1.Panel1.Controls.Add(this.LeftTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rightView);
            this.splitContainer1.Panel2.Controls.Add(this.RightTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(1000, 455);
            this.splitContainer1.SplitterDistance = 500;
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
            this.leftView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftView.Location = new System.Drawing.Point(0, 24);
            this.leftView.Margin = new System.Windows.Forms.Padding(0);
            this.leftView.Name = "leftView";
            this.leftView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.leftView.RowHeadersWidth = 4;
            this.leftView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.leftView.Size = new System.Drawing.Size(500, 431);
            this.leftView.TabIndex = 3;
            this.leftView.DoubleClick += new System.EventHandler(this.leftView_DoubleClick);
            this.leftView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LeftView_KeyDown);
            // 
            // LeftTextBox
            // 
            this.LeftTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LeftTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.LeftTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LeftTextBox.Location = new System.Drawing.Point(0, 0);
            this.LeftTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LeftTextBox.Name = "LeftTextBox";
            this.LeftTextBox.Size = new System.Drawing.Size(500, 24);
            this.LeftTextBox.TabIndex = 2;
            this.LeftTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.leftTextBox_KeyDown);
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
            this.rightView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightView.Location = new System.Drawing.Point(0, 24);
            this.rightView.Margin = new System.Windows.Forms.Padding(0);
            this.rightView.Name = "rightView";
            this.rightView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.rightView.RowHeadersWidth = 4;
            this.rightView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rightView.Size = new System.Drawing.Size(496, 431);
            this.rightView.TabIndex = 4;
            this.rightView.DoubleClick += new System.EventHandler(this.rightView_DoubleClick);
            this.rightView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RightView_KeyDown);
            // 
            // RightTextBox
            // 
            this.RightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RightTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.RightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RightTextBox.Location = new System.Drawing.Point(0, 0);
            this.RightTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.RightTextBox.Name = "RightTextBox";
            this.RightTextBox.Size = new System.Drawing.Size(496, 24);
            this.RightTextBox.TabIndex = 3;
            this.RightTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rightTextBox_KeyDown);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ToolbarMain
            // 
            this.ToolbarMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolbarMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolFileDrop,
            this.toolStripSeparator1,
            this.toolButtonEncrypt,
            this.toolButtonDecrypt,
            this.toolButtonCompress,
            this.toolButtonDecompress});
            this.ToolbarMain.Location = new System.Drawing.Point(0, 0);
            this.ToolbarMain.Name = "ToolbarMain";
            this.ToolbarMain.Size = new System.Drawing.Size(1000, 27);
            this.ToolbarMain.TabIndex = 1;
            this.ToolbarMain.Text = "toolStrip1";
            // 
            // ToolFileDrop
            // 
            this.ToolFileDrop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolFileDrop.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolFileExit,
            this.tempOpenTextFileToolStripMenuItem});
            this.ToolFileDrop.Image = ((System.Drawing.Image)(resources.GetObject("ToolFileDrop.Image")));
            this.ToolFileDrop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolFileDrop.Name = "ToolFileDrop";
            this.ToolFileDrop.Size = new System.Drawing.Size(46, 24);
            this.ToolFileDrop.Text = "File";
            // 
            // toolFileExit
            // 
            this.toolFileExit.Name = "toolFileExit";
            this.toolFileExit.Size = new System.Drawing.Size(222, 26);
            this.toolFileExit.Text = "Exit (Alt+F4)";
            this.toolFileExit.Click += new System.EventHandler(this.toolFileExit_Click);
            // 
            // tempOpenTextFileToolStripMenuItem
            // 
            this.tempOpenTextFileToolStripMenuItem.Name = "tempOpenTextFileToolStripMenuItem";
            this.tempOpenTextFileToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.tempOpenTextFileToolStripMenuItem.Text = "Temp. Open Text File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolButtonEncrypt
            // 
            this.toolButtonEncrypt.Image = global::noname_SanityArchiver.Properties.Resources.icon_archive;
            this.toolButtonEncrypt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolButtonEncrypt.Name = "toolButtonEncrypt";
            this.toolButtonEncrypt.Size = new System.Drawing.Size(82, 24);
            this.toolButtonEncrypt.Text = "Encrypt";
            this.toolButtonEncrypt.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolButtonEncrypt.Click += new System.EventHandler(this.toolButtonEncrypt_Click);
            // 
            // toolButtonDecrypt
            // 
            this.toolButtonDecrypt.Image = ((System.Drawing.Image)(resources.GetObject("toolButtonDecrypt.Image")));
            this.toolButtonDecrypt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolButtonDecrypt.Name = "toolButtonDecrypt";
            this.toolButtonDecrypt.Size = new System.Drawing.Size(85, 24);
            this.toolButtonDecrypt.Text = "Decrypt";
            this.toolButtonDecrypt.Click += new System.EventHandler(this.toolButtonDecrypt_Click);
            // 
            // toolButtonCompress
            // 
            this.toolButtonCompress.Image = ((System.Drawing.Image)(resources.GetObject("toolButtonCompress.Image")));
            this.toolButtonCompress.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolButtonCompress.Name = "toolButtonCompress";
            this.toolButtonCompress.Size = new System.Drawing.Size(98, 24);
            this.toolButtonCompress.Text = "Compress";
            this.toolButtonCompress.Click += new System.EventHandler(this.toolButtonCompress_Click);
            // 
            // toolButtonDecompress
            // 
            this.toolButtonDecompress.Image = ((System.Drawing.Image)(resources.GetObject("toolButtonDecompress.Image")));
            this.toolButtonDecompress.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolButtonDecompress.Name = "toolButtonDecompress";
            this.toolButtonDecompress.Size = new System.Drawing.Size(115, 24);
            this.toolButtonDecompress.Text = "Decompress";
            this.toolButtonDecompress.Click += new System.EventHandler(this.toolButtonDecompress_Click);
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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 482);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ToolbarMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Totally Noname Commander - NEM REGISZTRÁLT";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leftView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightView)).EndInit();
            this.ToolbarMain.ResumeLayout(false);
            this.ToolbarMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStrip ToolbarMain;
        private System.Windows.Forms.ToolStripDropDownButton ToolFileDrop;
        private System.Windows.Forms.ToolStripMenuItem toolFileExit;
        private System.Windows.Forms.ToolStripButton toolButtonEncrypt;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem tempOpenTextFileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TextBox LeftTextBox;
        private System.Windows.Forms.TextBox RightTextBox;
        private System.Windows.Forms.DataGridView leftView;
        private System.Windows.Forms.DataGridView rightView;
        private System.Windows.Forms.ToolStripButton toolButtonCompress;
        private System.Windows.Forms.ToolStripButton toolButtonDecrypt;
        private System.Windows.Forms.ToolStripButton toolButtonDecompress;
        private System.Windows.Forms.DataGridViewImageColumn iconHeaderLeft;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameHeaderLeft;
        private System.Windows.Forms.DataGridViewTextBoxColumn extensionHeaderLeft;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeHeaderLeft;
        private System.Windows.Forms.DataGridViewImageColumn iconHeaderRight;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameHeaderRight;
        private System.Windows.Forms.DataGridViewTextBoxColumn extensionHeaderRight;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeHeaderRight;
    }
}

