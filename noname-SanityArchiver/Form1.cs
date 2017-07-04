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
using System.IO.Compression;
using System.Diagnostics;

namespace noname_SanityArchiver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void CompressButton_Click(object sender, EventArgs e)
        {
           
            if (listView1.SelectedItems == null)
            {
                MessageBox.Show("Select any items to compress!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            List<string> filesToCompress = new List<string>();
            for (int i= 0; i < listView1.SelectedItems.Count; i++)
            {
                filesToCompress.Add(listView1.SelectedItems[i].Text + "." + listView1.SelectedItems[i].SubItems[2]);
            }
            for(int i = 0; i < filesToCompress.Count; i++)
            {
                Debug.WriteLine(filesToCompress[i]);
            }

            FileCompress fc = new FileCompress(filesToCompress);
            string zipFileName = "test.zip";
            fc.Compress(filesToCompress, zipFileName);
            

        }
    }
}
