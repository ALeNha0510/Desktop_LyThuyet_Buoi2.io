using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LyThuyetBuoi2
{
	public partial class FrmTreeView : Form
	{
		public FrmTreeView()
		{
			InitializeComponent();
		}

		private void FrmTreeView_Load(object sender, EventArgs e)
		{
			TreeNode rNode, cNode;
			rNode = this.treeView1.Nodes.Add("Các Loại Bánh");

			cNode = new TreeNode("Bánh Ngọt");
			rNode.Nodes.Add(cNode);

			cNode = new TreeNode("Bánh Tầm Mì");
			cNode.ImageIndex = 0;
			rNode.Nodes.Add(cNode);
			cNode = new TreeNode("Bánh Bò");
			cNode.ImageIndex = 1;
			rNode.Nodes.Add(cNode);
			cNode = new TreeNode("Bánh Ít");
			cNode.ImageIndex = 2;
			rNode.Nodes.Add(cNode);

			cNode = new TreeNode("Bánh Mặn");
			rNode.Nodes.Add(cNode);

			cNode = new TreeNode("Bánh Xèo");
			cNode.ImageIndex = 3;
			rNode.Nodes.Add(cNode);
			cNode = new TreeNode("Bánh Chưng");
			cNode.ImageIndex = 4;
			rNode.Nodes.Add(cNode);

			rNode = this.treeView1.Nodes.Add("Các Loại Nước");

			cNode = new TreeNode("Nước Ngọt");
			rNode.Nodes.Add(cNode);

			cNode = new TreeNode("Sting");
			cNode.ImageIndex = 5;
			rNode.Nodes.Add(cNode);
			cNode = new TreeNode("Coca");
			cNode.ImageIndex = 6;
			rNode.Nodes.Add(cNode);
			cNode = new TreeNode("7 Up");
			cNode.ImageIndex = 7;
			rNode.Nodes.Add(cNode);

			cNode = new TreeNode("Trà");
			rNode.Nodes.Add(cNode);

			cNode = new TreeNode("Trà Dâu");
			cNode.ImageIndex = 8;
			rNode.Nodes.Add(cNode);
			cNode = new TreeNode("Trà Sữa");
			cNode.ImageIndex = 9;
			rNode.Nodes.Add(cNode);
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			if (treeView1.SelectedNode != null)
			{
				treeView1.SelectedNode.Remove();
			}	
		}

		private void btnCollapseAll_Click(object sender, EventArgs e)
		{
			treeView1.ExpandAll();
		}

		private void btnExpandAll_Click(object sender, EventArgs e)
		{
			treeView1.CollapseAll();
		}
	}
}
