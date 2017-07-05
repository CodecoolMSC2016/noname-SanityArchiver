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
            this.LeftView = new System.Windows.Forms.DataGridView();
            this.LeftTextBox = new System.Windows.Forms.TextBox();
            this.RightView = new System.Windows.Forms.DataGridView();
            this.RightTextBox = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ToolbarMain = new System.Windows.Forms.ToolStrip();
            this.ToolFileDrop = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tempOpenTextFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.iconHeaderRight = new System.Windows.Forms.DataGridViewImageColumn();
            this.nameHeaderRight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeHeaderRight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extensionHeaderRight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconHeaderLeft = new System.Windows.Forms.DataGridViewImageColumn();
            this.nameHeaderLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeHeaderLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extensionHeaderLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightView)).BeginInit();
            this.ToolbarMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.LeftView);
            this.splitContainer1.Panel1.Controls.Add(this.LeftTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.RightView);
            this.splitContainer1.Panel2.Controls.Add(this.RightTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(750, 365);
            this.splitContainer1.SplitterDistance = 375;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // LeftView
            // 
            this.LeftView.AllowUserToAddRows = false;
            this.LeftView.AllowUserToDeleteRows = false;
            this.LeftView.AllowUserToOrderColumns = true;
            this.LeftView.AllowUserToResizeRows = false;
            this.LeftView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LeftView.BackgroundColor = System.Drawing.Color.White;
            this.LeftView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LeftView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iconHeaderLeft,
            this.nameHeaderLeft,
            this.sizeHeaderLeft,
            this.extensionHeaderLeft});
            this.LeftView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftView.Location = new System.Drawing.Point(0, 21);
            this.LeftView.Margin = new System.Windows.Forms.Padding(0);
            this.LeftView.Name = "LeftView";
            this.LeftView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.LeftView.RowHeadersWidth = 4;
            this.LeftView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LeftView.Size = new System.Drawing.Size(375, 344);
            this.LeftView.TabIndex = 3;
            this.LeftView.Click += new System.EventHandler(this.LeftView_Click);
            this.LeftView.DoubleClick += new System.EventHandler(this.leftView_DoubleClick);
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
            // 
            // RightView
            // 
            this.RightView.AllowUserToAddRows = false;
            this.RightView.AllowUserToDeleteRows = false;
            this.RightView.AllowUserToOrderColumns = true;
            this.RightView.AllowUserToResizeRows = false;
            this.RightView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RightView.BackgroundColor = System.Drawing.Color.White;
            this.RightView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RightView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iconHeaderRight,
            this.nameHeaderRight,
            this.sizeHeaderRight,
            this.extensionHeaderRight});
            this.RightView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightView.Location = new System.Drawing.Point(0, 21);
            this.RightView.Margin = new System.Windows.Forms.Padding(0);
            this.RightView.Name = "RightView";
            this.RightView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.RightView.RowHeadersWidth = 4;
            this.RightView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RightView.Size = new System.Drawing.Size(372, 344);
            this.RightView.TabIndex = 4;
            this.RightView.Click += new System.EventHandler(this.RightView_Click);
            this.RightView.DoubleClick += new System.EventHandler(this.rightView_DoubleClick);
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
            this.toolStripButton1});
            this.ToolbarMain.Location = new System.Drawing.Point(0, 0);
            this.ToolbarMain.Name = "ToolbarMain";
            this.ToolbarMain.Size = new System.Drawing.Size(750, 27);
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
            this.ToolFileDrop.Size = new System.Drawing.Size(38, 24);
            this.ToolFileDrop.Text = "File";
            // 
            // toolFileExit
            // 
            this.toolFileExit.Name = "toolFileExit";
            this.toolFileExit.Size = new System.Drawing.Size(184, 22);
            this.toolFileExit.Text = "Exit (Alt+F4)";
            this.toolFileExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tempOpenTextFileToolStripMenuItem
            // 
            this.tempOpenTextFileToolStripMenuItem.Name = "tempOpenTextFileToolStripMenuItem";
            this.tempOpenTextFileToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.tempOpenTextFileToolStripMenuItem.Text = "Temp. Open Text File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::noname_SanityArchiver.Properties.Resources.icon_archive;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(71, 24);
            this.toolStripButton1.Text = "Archive";
            this.toolStripButton1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // iconHeaderRight
            // 
            this.iconHeaderRight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.iconHeaderRight.HeaderText = "Icon";
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
            // sizeHeaderRight
            // 
            this.sizeHeaderRight.HeaderText = "Size";
            this.sizeHeaderRight.Name = "sizeHeaderRight";
            this.sizeHeaderRight.ReadOnly = true;
            // 
            // extensionHeaderRight
            // 
            this.extensionHeaderRight.HeaderText = "Extension";
            this.extensionHeaderRight.Name = "extensionHeaderRight";
            // 
            // iconHeaderLeft
            // 
            this.iconHeaderLeft.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.iconHeaderLeft.HeaderText = "Icon";
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
            // sizeHeaderLeft
            // 
            this.sizeHeaderLeft.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sizeHeaderLeft.HeaderText = "Size";
            this.sizeHeaderLeft.Name = "sizeHeaderLeft";
            this.sizeHeaderLeft.ReadOnly = true;
            this.sizeHeaderLeft.Width = 64;
            // 
            // extensionHeaderLeft
            // 
            this.extensionHeaderLeft.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.extensionHeaderLeft.HeaderText = "Extension";
            this.extensionHeaderLeft.Name = "extensionHeaderLeft";
            this.extensionHeaderLeft.Width = 64;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 392);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ToolbarMain);
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
            ((System.ComponentModel.ISupportInitialize)(this.LeftView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightView)).EndInit();
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
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem tempOpenTextFileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TextBox LeftTextBox;
        private System.Windows.Forms.TextBox RightTextBox;
        private System.Windows.Forms.DataGridView LeftView;
        private System.Windows.Forms.DataGridView RightView;
        private System.Windows.Forms.DataGridViewImageColumn iconHeaderRight;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameHeaderRight;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeHeaderRight;
        private System.Windows.Forms.DataGridViewTextBoxColumn extensionHeaderRight;
        private System.Windows.Forms.DataGridViewImageColumn iconHeaderLeft;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameHeaderLeft;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeHeaderLeft;
        private System.Windows.Forms.DataGridViewTextBoxColumn extensionHeaderLeft;
    }
}

