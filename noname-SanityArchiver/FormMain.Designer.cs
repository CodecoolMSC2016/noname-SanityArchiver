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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "afjklal;skf;alksdkjugfhskdjghskdjghskdjghskdjghskdjghsdjkghsdjkhgssdf",
            "",
            "egy",
            "ketto"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("afjklal;skf;alksdf");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listViewLeft = new System.Windows.Forms.ListView();
            this.iconHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sizeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.extensionHeaderLeft = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listViewRight = new System.Windows.Forms.ListView();
            this.nameHeaderRight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sizeHeaderRight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.extensionHeaderRight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ToolbarMain = new System.Windows.Forms.ToolStrip();
            this.ToolFileDrop = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tempOpenTextFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.listViewLeft);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listViewRight);
            this.splitContainer1.Size = new System.Drawing.Size(1000, 455);
            this.splitContainer1.SplitterDistance = 500;
            this.splitContainer1.TabIndex = 0;
            // 
            // listViewLeft
            // 
            this.listViewLeft.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.iconHeader,
            this.nameHeader,
            this.sizeHeader,
            this.extensionHeaderLeft});
            this.listViewLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewLeft.FullRowSelect = true;
            this.listViewLeft.HideSelection = false;
            this.listViewLeft.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewLeft.Location = new System.Drawing.Point(0, 0);
            this.listViewLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewLeft.MinimumSize = new System.Drawing.Size(500, 4);
            this.listViewLeft.Name = "listViewLeft";
            this.listViewLeft.Size = new System.Drawing.Size(500, 455);
            this.listViewLeft.SmallImageList = this.imageList1;
            this.listViewLeft.TabIndex = 0;
            this.listViewLeft.UseCompatibleStateImageBehavior = false;
            this.listViewLeft.View = System.Windows.Forms.View.Details;
            // 
            // iconHeader
            // 
            this.iconHeader.Text = "";
            this.iconHeader.Width = 34;
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "Name";
            this.nameHeader.Width = 104;
            // 
            // sizeHeader
            // 
            this.sizeHeader.Text = "Size";
            this.sizeHeader.Width = 38;
            // 
            // extensionHeaderLeft
            // 
            this.extensionHeaderLeft.Text = "Extension";
            this.extensionHeaderLeft.Width = 354;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listViewRight
            // 
            this.listViewRight.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameHeaderRight,
            this.sizeHeaderRight,
            this.extensionHeaderRight});
            this.listViewRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewRight.FullRowSelect = true;
            this.listViewRight.HideSelection = false;
            this.listViewRight.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listViewRight.Location = new System.Drawing.Point(0, 0);
            this.listViewRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewRight.MinimumSize = new System.Drawing.Size(500, 4);
            this.listViewRight.Name = "listViewRight";
            this.listViewRight.Size = new System.Drawing.Size(500, 455);
            this.listViewRight.TabIndex = 1;
            this.listViewRight.UseCompatibleStateImageBehavior = false;
            this.listViewRight.View = System.Windows.Forms.View.Details;
            // 
            // nameHeaderRight
            // 
            this.nameHeaderRight.Text = "Name";
            this.nameHeaderRight.Width = 104;
            // 
            // sizeHeaderRight
            // 
            this.sizeHeaderRight.Text = "Size";
            this.sizeHeaderRight.Width = 38;
            // 
            // extensionHeaderRight
            // 
            this.extensionHeaderRight.Text = "Extension";
            this.extensionHeaderRight.Width = 354;
            // 
            // ToolbarMain
            // 
            this.ToolbarMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolbarMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolFileDrop,
            this.toolStripButton1});
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
            this.toolFileExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tempOpenTextFileToolStripMenuItem
            // 
            this.tempOpenTextFileToolStripMenuItem.Name = "tempOpenTextFileToolStripMenuItem";
            this.tempOpenTextFileToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.tempOpenTextFileToolStripMenuItem.Text = "Temp. Open Text File";
            this.tempOpenTextFileToolStripMenuItem.Click += new System.EventHandler(this.tempOpenTextFileToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 482);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ToolbarMain);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Totally Noname Commander - NEM REGISZTRÁLT";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ToolbarMain.ResumeLayout(false);
            this.ToolbarMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listViewLeft;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStrip ToolbarMain;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.Windows.Forms.ColumnHeader sizeHeader;
        private System.Windows.Forms.ColumnHeader extensionHeaderLeft;
        private System.Windows.Forms.ListView listViewRight;
        private System.Windows.Forms.ColumnHeader nameHeaderRight;
        private System.Windows.Forms.ColumnHeader sizeHeaderRight;
        private System.Windows.Forms.ColumnHeader extensionHeaderRight;
        private System.Windows.Forms.ToolStripDropDownButton ToolFileDrop;
        private System.Windows.Forms.ToolStripMenuItem toolFileExit;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ColumnHeader iconHeader;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem tempOpenTextFileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

