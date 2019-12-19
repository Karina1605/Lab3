using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        BinaryTree tree = new BinaryTree();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BEnter_Click(object sender, EventArgs e)
        {
            string t =TInput.Text;
            tree.TryLaodFromString(t);
            tree.Print(TStartTree);
        }

        private void BClear_Click(object sender, EventArgs e)
        {
            TInput.Text = TOutput.Text = "";
            tree.Clear();
            TStartTree.Nodes.Clear();
            TFinishTree.Nodes.Clear();
        }

        private void BTask_Click(object sender, EventArgs e)
        {
            tree.Simplify();
            TOutput.Text = tree.ToString();
            tree.Print(TFinishTree);
        }

        private void BExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
