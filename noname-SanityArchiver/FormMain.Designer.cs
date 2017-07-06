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
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LeftTextBox = new System.Windows.Forms.TextBox();
            this.rightView = new System.Windows.Forms.DataGridView();
            this.iconHeaderRight = new System.Windows.Forms.DataGridViewImageColumn();
            this.nameHeaderRight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extensionHeaderRight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeHeaderRight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RightTextBox = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftView)).BeginInit();
            this.listMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightView)).BeginInit();
            this.toolStrip1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.LeftTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rightView);
            this.splitContainer1.Panel2.Controls.Add(this.RightTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(750, 367);
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
            this.leftView.Location = new System.Drawing.Point(0, 21);
            this.leftView.Margin = new System.Windows.Forms.Padding(0);
            this.leftView.Name = "leftView";
            this.leftView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.leftView.RowHeadersWidth = 4;
            this.leftView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.leftView.Size = new System.Drawing.Size(375, 346);
            this.leftView.TabIndex = 3;
            this.leftView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.leftView_CellValueChanged);
            this.leftView.DoubleClick += new System.EventHandler(this.leftView_DoubleClick);
            this.leftView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LeftView_KeyDown);
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
            this.listMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.archiveToolStripMenuItem,
            this.encryptToolStripMenuItem});
            this.listMenu.Name = "listMenu";
            this.listMenu.Size = new System.Drawing.Size(173, 70);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::noname_SanityArchiver.Properties.Resources.icon_eye;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.openToolStripMenuItem.Text = "View";
            // 
            // archiveToolStripMenuItem
            // 
            this.archiveToolStripMenuItem.Image = global::noname_SanityArchiver.Properties.Resources.icon_package;
            this.archiveToolStripMenuItem.Name = "archiveToolStripMenuItem";
            this.archiveToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.archiveToolStripMenuItem.Text = "Archive/Unarchive";
            // 
            // encryptToolStripMenuItem
            // 
            this.encryptToolStripMenuItem.Image = global::noname_SanityArchiver.Properties.Resources.icon_lock;
            this.encryptToolStripMenuItem.Name = "encryptToolStripMenuItem";
            this.encryptToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.encryptToolStripMenuItem.Text = "Encrypt/Decrypt";
            // 
            // LeftTextBox
            // 
            this.LeftTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LeftTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.LeftTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LeftTextBox.Location = new System.Drawing.Point(0, 0);
            this.LeftTextBox.Name = "LeftTextBox";
            this.LeftTextBox.Size = new System.Drawing.Size(375, 21);
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
            this.rightView.ContextMenuStrip = this.listMenu;
            this.rightView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightView.Location = new System.Drawing.Point(0, 21);
            this.rightView.Margin = new System.Windows.Forms.Padding(0);
            this.rightView.Name = "rightView";
            this.rightView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.rightView.RowHeadersWidth = 4;
            this.rightView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rightView.Size = new System.Drawing.Size(372, 346);
            this.rightView.TabIndex = 4;
            this.rightView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.rightView_CellValueChanged);
            this.rightView.DoubleClick += new System.EventHandler(this.rightView_DoubleClick);
            this.rightView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RightView_KeyDown);
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
            // RightTextBox
            // 
            this.RightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RightTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.RightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RightTextBox.Location = new System.Drawing.Point(0, 0);
            this.RightTextBox.Name = "RightTextBox";
            this.RightTextBox.Size = new System.Drawing.Size(372, 21);
            this.RightTextBox.TabIndex = 3;
            this.RightTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rightTextBox_KeyDown);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripTextBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 367);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(750, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(45, 22);
            this.toolStripLabel1.Text = "Search:";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripTextBox1.Size = new System.Drawing.Size(300, 25);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 392);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
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
            this.listMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rightView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox LeftTextBox;
        private System.Windows.Forms.TextBox RightTextBox;
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
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ContextMenuStrip listMenu;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptToolStripMenuItem;
    }
}

