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
	public partial class FrmTimer_ProgressBar : Form
	{
		public FrmTimer_ProgressBar()
		{
			InitializeComponent();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (progressBar1.Value == progressBar1.Maximum)
			{
				timer1.Stop();
				MessageBox.Show("Thành Công!!!");
				progressBar1.Value = progressBar1.Minimum;
				this.label2.Text = "0 %";
			}
			else
			{
				progressBar1.PerformStep();
				this.label2.Text = progressBar1.Value.ToString() + " %";
			}
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			timer1.Start();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
