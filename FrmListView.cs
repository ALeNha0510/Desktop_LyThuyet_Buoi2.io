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
	public partial class FrmListView : Form
	{
		public FrmListView()
		{
			InitializeComponent();
		}

		private void FrmListView_Load(object sender, EventArgs e)
		{
			ListViewItem lvitem = new ListViewItem(new string[] { "001", "Nguyễn Văn Hùng", "Nam", "18", "CTK45A"});
			this.listView1.Items.Add(lvitem);
			lvitem = new ListViewItem(new string[] { "002", "Trương Thị Lệ", "Nữ", "17", "CTK45B" });
			this.listView1.Items.Add(lvitem);
			lvitem = new ListViewItem(new string[] { "003", "Nguyễn Hoàng Nam", "Nam", "20", "CTK43A" });
			this.listView1.Items.Add(lvitem);
			lvitem = new ListViewItem("004");
			lvitem.SubItems.Add("Lê Thị Hồng");
			lvitem.SubItems.Add("Nữ");
			lvitem.SubItems.Add("19");
			lvitem.SubItems.Add("CTK44B");
			this.listView1.Items.Add(lvitem);

			lvitem = new ListViewItem("005");
			lvitem.SubItems.Add("Trần Kim Nhã");
			lvitem.SubItems.Add("Nữ");
			lvitem.SubItems.Add("18");
			lvitem.SubItems.Add("CTK45A");
			this.listView1.Items.Add(lvitem);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
