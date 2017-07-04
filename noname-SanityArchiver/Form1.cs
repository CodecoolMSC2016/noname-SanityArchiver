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

namespace noname_SanityArchiver
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            #region Szarfos

            /*
            string filename = @"C: \Users\racer01\AppData\Local\GitHubDesktop\GitHub Desktop.exe";
            Icon icon = Icon.ExtractAssociatedIcon(filename);

            imageList1.Images.Add(icon);
            listView1.Items.Add(new ListViewItem("", 0));
            */

            #endregion Szarfos
        }

        private void tempOpenTextFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if ( openFileDialog1.FileName != "" )
            {
                textFileWindow tfWindow = new textFileWindow(openFileDialog1.FileName);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            listViewLeft.Rows.Add(Resources.cica, "/ValamiTeszt.txt", "1235235Kb", ".EXE");
        }
    }
}