using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoopDetector3000
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Node n10 = new Node(10);
            Node n9 = new Node(9, n10);
            Node n8 = new Node(8, n9);
            Node n7 = new Node(7, n8);
            Node n6 = new Node(6, n7);
            Node n5 = new Node(5, n6);
            Node n4 = new Node(4, n5);
            Node n3 = new Node(3, n4);
            Node n2 = new Node(2, n3);
            Node n1 = new Node(1, n2);

            List<Node> nodes = n1.ListNodes();
            for (int i = 0; i < nodes.Count; i++)
            {
                richTextBox1.Text += Environment.NewLine + nodes[i]; 
            }

            if ( n1.hasLoop() )
            {
                richTextBox1.Text += Environment.NewLine + " HAS LOOP ";
            } else
            {
                richTextBox1.Text += Environment.NewLine + " THERE IS NO LOOP ";
            }
        }
    }
}
