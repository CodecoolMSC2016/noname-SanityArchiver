using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace noname_SanityArchiver
{
    public partial class textFileWindow : Form
    {
        private string fileLocation { get; set; }

        public textFileWindow(string fileLocation)
        {
            InitializeComponent();

            this.fileLocation = fileLocation;
            richTextBox1.Text = File.ReadAllText(fileLocation, Encoding.UTF8);
            Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(fileLocation, richTextBox1.Text, Encoding.UTF8);
                string simpleFileName = new FileInfo(fileLocation).Name;
                MessageBox.Show("File succesfully saved to: " + simpleFileName, "File Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                MessageBox.Show("Error while saving file: " + err.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "All Files (*.*)|*.*";
            saveFileDialog1.FileName = new FileInfo(fileLocation).Name;
            saveFileDialog1.DefaultExt = new FileInfo(fileLocation).Extension;
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.ShowDialog(this);
        }

        private void changeFontSize(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, float.Parse(((ToolStripMenuItem)sender).Text), richTextBox1.Font.Style);
        }
    }
}
