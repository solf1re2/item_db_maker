using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace item_database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var node2 = new TreeNode("wool");
            var node3 = new TreeNode("wood");
            var array = new TreeNode[] { node2, node3 };
            var treeNode = new TreeNode("primary items", array);
            itemTree.Nodes.Add(treeNode);

            treeNode = new TreeNode("secondary items");
            itemTree.Nodes.Add(treeNode);

            treeNode = new TreeNode("tertiary items");
            itemTree.Nodes.Add(treeNode);

        }

        private void itemTree_MouseDoubleClick(object sender, MouseEventArgs mouseEventArgs)
        {
            TreeNode node = itemTree.SelectedNode;
            MessageBox.Show(string.Format("You selected: {0}", node.Text));
        }

    }
}
