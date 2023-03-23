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
	public partial class FrmChinh : Form
	{
		public FrmChinh()
		{
			InitializeComponent();
		}

		private void maskedTextBoxToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form1 = new FrmMaskerTextBox();
			form1.ShowDialog();
		}



		private void monthCalendarDateTimePickerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form3 = new FrmMonthCalendar_DateTimePicker();
			form3.ShowDialog();
		}

		private void timerProgressBarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form4 = new FrmTimer_ProgressBar();
			form4.ShowDialog();
		}

		private void pictureBoxImageListToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form5 = new FrmPictureBox_ImageList();
			form5.ShowDialog();
		}

		private void messageBoxToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form6 = new FrmMessageBox();
			form6.ShowDialog();
		}

		private void listViewToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form7 = new FrmListView();
			form7.ShowDialog();
		}

		private void treeViewToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form8 = new FrmTreeView();
			form8.ShowDialog();
		}

		private void menuStripToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form9 = new FrmMenuStrip();
			form9.ShowDialog();
		}

		private void toolStripToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form10 = new FrmToolStrip();
			form10.ShowDialog();
		}

		private void numericDomainUpDownToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form2 = new FrmNumDomainUpDown();
			form2.ShowDialog();
		}

		private void richTextBoxToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form11 = new FrmRichTextBox();
			form11.ShowDialog();
		}

		private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form12 = new FrmNhanVien();
			form12.ShowDialog();
		}
	}

}
