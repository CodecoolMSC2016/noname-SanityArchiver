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
            SaveFile(fileLocation);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = String.Format("Default Extension (*{0})|*{0}", new FileInfo(fileLocation).Extension);
            saveFileDialog1.DefaultExt = new FileInfo(fileLocation).Extension;
            saveFileDialog1.AddExtension = true;
            DialogResult dr = saveFileDialog1.ShowDialog(this);

            if (dr == DialogResult.OK )
            {
                SaveFile(saveFileDialog1.FileName);
            }
        }

        private void SaveFile(string newFileLocation)
        {
            try
            {
                File.WriteAllText(newFileLocation, richTextBox1.Text, Encoding.UTF8);
                MessageBox.Show("File succesfully saved to: " + new FileInfo(newFileLocation).Name, "File Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                MessageBox.Show("Error while saving file: " + err.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void changeFontSize(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, float.Parse(((ToolStripMenuItem)sender).Text), richTextBox1.Font.Style);
        }
    }
}
