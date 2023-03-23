
namespace LyThuyetBuoi2
{
	partial class FrmListView
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
			this.listView1 = new System.Windows.Forms.ListView();
			this.mssv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.hoten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.gioitinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tuoi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mssv,
            this.hoten,
            this.gioitinh,
            this.tuoi,
            this.lop});
			this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(13, 13);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(418, 150);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// mssv
			// 
			this.mssv.Text = "MSSV";
			this.mssv.Width = 69;
			// 
			// hoten
			// 
			this.hoten.Text = "Họ & Tên";
			this.hoten.Width = 143;
			// 
			// gioitinh
			// 
			this.gioitinh.Text = "Giới Tính";
			// 
			// tuoi
			// 
			this.tuoi.Text = "Tuổi";
			this.tuoi.Width = 45;
			// 
			// lop
			// 
			this.lop.Text = "Lớp";
			this.lop.Width = 97;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(356, 178);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Cancel";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// FrmListView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(443, 213);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.listView1);
			this.Name = "FrmListView";
			this.Text = "FrmListView";
			this.Load += new System.EventHandler(this.FrmListView_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader mssv;
		private System.Windows.Forms.ColumnHeader hoten;
		private System.Windows.Forms.ColumnHeader gioitinh;
		private System.Windows.Forms.ColumnHeader tuoi;
		private System.Windows.Forms.ColumnHeader lop;
		private System.Windows.Forms.Button button1;
	}
}