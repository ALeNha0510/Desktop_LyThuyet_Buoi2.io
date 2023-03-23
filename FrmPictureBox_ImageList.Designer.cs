
namespace LyThuyetBuoi2
{
	partial class FrmPictureBox_ImageList
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPictureBox_ImageList));
			this.label1 = new System.Windows.Forms.Label();
			this.cboChonHinh = new System.Windows.Forms.ComboBox();
			this.pbHinhAnh = new System.Windows.Forms.PictureBox();
			this.imlDemo = new System.Windows.Forms.ImageList(this.components);
			this.btnExit = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pbHinhAnh)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(30, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(132, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Chọn hình hiển thị:";
			// 
			// cboChonHinh
			// 
			this.cboChonHinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboChonHinh.FormattingEnabled = true;
			this.cboChonHinh.Items.AddRange(new object[] {
            "Hình 1",
            "Hình 2",
            "Hình 3",
            "Hình 4",
            "Hình 5"});
			this.cboChonHinh.Location = new System.Drawing.Point(168, 25);
			this.cboChonHinh.Name = "cboChonHinh";
			this.cboChonHinh.Size = new System.Drawing.Size(121, 21);
			this.cboChonHinh.TabIndex = 1;
			this.cboChonHinh.SelectedIndexChanged += new System.EventHandler(this.cboChonHinh_SelectedIndexChanged);
			// 
			// pbHinhAnh
			// 
			this.pbHinhAnh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pbHinhAnh.Location = new System.Drawing.Point(12, 68);
			this.pbHinhAnh.Name = "pbHinhAnh";
			this.pbHinhAnh.Size = new System.Drawing.Size(302, 199);
			this.pbHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbHinhAnh.TabIndex = 2;
			this.pbHinhAnh.TabStop = false;
			// 
			// imlDemo
			// 
			this.imlDemo.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlDemo.ImageStream")));
			this.imlDemo.TransparentColor = System.Drawing.Color.Transparent;
			this.imlDemo.Images.SetKeyName(0, "xexam.png");
			this.imlDemo.Images.SetKeyName(1, "xetrang.png");
			this.imlDemo.Images.SetKeyName(2, "xedo.png");
			this.imlDemo.Images.SetKeyName(3, "xevang.png");
			this.imlDemo.Images.SetKeyName(4, "xexanh.jpg");
			// 
			// btnExit
			// 
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(239, 282);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 3;
			this.btnExit.Text = "Cancel";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// FrmPictureBox_ImageList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(326, 317);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.pbHinhAnh);
			this.Controls.Add(this.cboChonHinh);
			this.Controls.Add(this.label1);
			this.Name = "FrmPictureBox_ImageList";
			this.Text = "PictureBox_ImageList";
			this.Load += new System.EventHandler(this.FrmPictureBox_ImageList_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbHinhAnh)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cboChonHinh;
		private System.Windows.Forms.PictureBox pbHinhAnh;
		private System.Windows.Forms.ImageList imlDemo;
		private System.Windows.Forms.Button btnExit;
	}
}