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
	public partial class FrmMessageBox : Form
	{
		public FrmMessageBox()
		{
			InitializeComponent();
		}

		private void FrmMessageBox_Load(object sender, EventArgs e)
		{
			if (MessageBox.Show("Mở trang lỗi, bạn có muồn thoát","Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
			{
				Application.Exit();
			}	
		}
	}
}
