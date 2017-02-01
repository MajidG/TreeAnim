using GraphApp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TreeAnim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ExpTb.Text = "a+b";
        }

        private void DrawBtn_Click(object sender, EventArgs e)
        {
            Node root = PostfixTree.Parse(ExpTb.Text);
            if (root != null) 
                root.Build(80, 0);
            graphCanvas1.Root = root;
            graphCanvas1.Invalidate();
        }

        private void ExpTb_TextChanged(object sender, EventArgs e)
        {
            Node root = PostfixTree.Parse(ExpTb.Text);
            if (root != null)
            {
                root.Build(80, 0);
                ExpTb.ForeColor = Color.Black;
            }
            else
                ExpTb.ForeColor = Color.Red;
            graphCanvas1.Root = root;
            graphCanvas1.Invalidate();
        }
    }
}
