
namespace LyThuyetBuoi2
{
	partial class FrmRichTextBox
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
			this.rtbThongTin = new System.Windows.Forms.RichTextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// rtbThongTin
			// 
			this.rtbThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtbThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.rtbThongTin.Location = new System.Drawing.Point(32, 48);
			this.rtbThongTin.Name = "rtbThongTin";
			this.rtbThongTin.Size = new System.Drawing.Size(281, 99);
			this.rtbThongTin.TabIndex = 0;
			this.rtbThongTin.Text = "Đây là hộp RichTextBox";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(131, 178);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Cancel";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// FrmRichTextBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(346, 213);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.rtbThongTin);
			this.Name = "FrmRichTextBox";
			this.Text = "RichTextBox";
			this.Load += new System.EventHandler(this.FrmRichTextBox_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox rtbThongTin;
		private System.Windows.Forms.Button button1;
	}
}