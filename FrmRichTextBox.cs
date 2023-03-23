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
	public partial class FrmRichTextBox : Form
	{
		public FrmRichTextBox()
		{
			InitializeComponent();
		}

		private void FrmRichTextBox_Load(object sender, EventArgs e)
		{
			this.rtbThongTin.SelectedText = "Chào mừng bạn đến với";
			this.rtbThongTin.SelectionColor = Color.Purple;
			this.rtbThongTin.SelectedText = "ListTextBox";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
