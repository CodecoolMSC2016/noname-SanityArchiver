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
    public partial class FormChangeAttr : Form
    {
        FileAttributeChange fac { get; set; }

        public FormChangeAttr(FileAttributeChange fac)
        {
            InitializeComponent();
            this.fac = fac;
        }

        public Boolean HiddenState
        {
            get
            {
                return checkBoxHidden.Checked;
            }
            set
            {
                checkBoxHidden.Checked = value;
            }
        }

        public Boolean ReadOnlyState
        {
            get
            {
                return checkBoxReadOnly.Checked;
            }
            set
            {
                checkBoxReadOnly.Checked = value;
            }
        }

        public void checkHidden(Boolean state)
        {
            checkBoxHidden.Checked = state;
        }

        public void checkReadOnly(Boolean state)
        {
            checkBoxReadOnly.Checked = state;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void changeAttribute_Load(object sender, EventArgs e)
        {
            button1.Click += new EventHandler(fac.button1_Click);
        }
    }
}