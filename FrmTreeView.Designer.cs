
namespace LyThuyetBuoi2
{
	partial class FrmTreeView
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Bánh Tằm Mì");
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Bánh Bò");
			System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Bánh Ít");
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Bánh Ngọt", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
			System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Bánh Xèo");
			System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Bánh Chưng");
			System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Bánh Mặn", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
			System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Các Loại Bánh", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode7});
			System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Sting");
			System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Coca");
			System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("7 UP");
			System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Nước Ngọt", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
			System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Trà Dâu");
			System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Trà Sữa");
			System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Trà", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
			System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Các Loại Nước", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode15});
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTreeView));
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.imgList = new System.Windows.Forms.ImageList(this.components);
			this.btnExpandAll = new System.Windows.Forms.Button();
			this.btnCollapseAll = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// treeView1
			// 
			this.treeView1.LabelEdit = true;
			this.treeView1.Location = new System.Drawing.Point(12, 14);
			this.treeView1.Name = "treeView1";
			treeNode1.BackColor = System.Drawing.Color.White;
			treeNode1.Name = "Node8";
			treeNode1.Text = "Bánh Tằm Mì";
			treeNode2.Name = "Node9";
			treeNode2.Text = "Bánh Bò";
			treeNode3.Name = "Node10";
			treeNode3.Text = "Bánh Ít";
			treeNode4.Name = "Node6";
			treeNode4.Text = "Bánh Ngọt";
			treeNode5.Name = "Node11";
			treeNode5.Text = "Bánh Xèo";
			treeNode6.Name = "Node12";
			treeNode6.Text = "Bánh Chưng";
			treeNode7.Name = "Node7";
			treeNode7.Text = "Bánh Mặn";
			treeNode8.Name = "Node0";
			treeNode8.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			treeNode8.Text = "Các Loại Bánh";
			treeNode9.Name = "Node13";
			treeNode9.Text = "Sting";
			treeNode10.Name = "Node14";
			treeNode10.Text = "Coca";
			treeNode11.Name = "Node15";
			treeNode11.Text = "7 UP";
			treeNode12.Name = "Node4";
			treeNode12.Text = "Nước Ngọt";
			treeNode13.Name = "Node16";
			treeNode13.Text = "Trà Dâu";
			treeNode14.Name = "Node17";
			treeNode14.Text = "Trà Sữa";
			treeNode15.Name = "Node5";
			treeNode15.Text = "Trà";
			treeNode16.Name = "Node1";
			treeNode16.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			treeNode16.Text = "Các Loại Nước";
			this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode16});
			this.treeView1.Size = new System.Drawing.Size(263, 266);
			this.treeView1.TabIndex = 0;
			// 
			// imgList
			// 
			this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
			this.imgList.TransparentColor = System.Drawing.Color.Transparent;
			this.imgList.Images.SetKeyName(0, "tammi.png");
			this.imgList.Images.SetKeyName(1, "banhbo.png");
			this.imgList.Images.SetKeyName(2, "banhit.png");
			this.imgList.Images.SetKeyName(3, "banhxeo.png");
			this.imgList.Images.SetKeyName(4, "banhchung.png");
			this.imgList.Images.SetKeyName(5, "sting.png");
			this.imgList.Images.SetKeyName(6, "coca.png");
			this.imgList.Images.SetKeyName(7, "7up.png");
			this.imgList.Images.SetKeyName(8, "tradau.png");
			this.imgList.Images.SetKeyName(9, "trasua.png");
			// 
			// btnExpandAll
			// 
			this.btnExpandAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExpandAll.Location = new System.Drawing.Point(293, 92);
			this.btnExpandAll.Name = "btnExpandAll";
			this.btnExpandAll.Size = new System.Drawing.Size(125, 37);
			this.btnExpandAll.TabIndex = 1;
			this.btnExpandAll.Text = "ExpandAll";
			this.btnExpandAll.UseVisualStyleBackColor = true;
			this.btnExpandAll.Click += new System.EventHandler(this.btnExpandAll_Click);
			// 
			// btnCollapseAll
			// 
			this.btnCollapseAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCollapseAll.Location = new System.Drawing.Point(293, 26);
			this.btnCollapseAll.Name = "btnCollapseAll";
			this.btnCollapseAll.Size = new System.Drawing.Size(125, 37);
			this.btnCollapseAll.TabIndex = 1;
			this.btnCollapseAll.Text = "CollapseAll";
			this.btnCollapseAll.UseVisualStyleBackColor = true;
			this.btnCollapseAll.Click += new System.EventHandler(this.btnCollapseAll_Click);
			// 
			// btnRemove
			// 
			this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRemove.Location = new System.Drawing.Point(293, 157);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(125, 37);
			this.btnRemove.TabIndex = 1;
			this.btnRemove.Text = "Remove";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.Location = new System.Drawing.Point(293, 222);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(125, 37);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// FrmTreeView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(430, 292);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnCollapseAll);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.btnExpandAll);
			this.Controls.Add(this.treeView1);
			this.Name = "FrmTreeView";
			this.Text = "TreeView";
			this.Load += new System.EventHandler(this.FrmTreeView_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.ImageList imgList;
		private System.Windows.Forms.Button btnExpandAll;
		private System.Windows.Forms.Button btnCollapseAll;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Button btnCancel;
	}
}