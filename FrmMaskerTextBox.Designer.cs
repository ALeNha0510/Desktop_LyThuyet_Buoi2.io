
namespace LyThuyetBuoi2
{
	partial class FrmMaskerTextBox
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
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.Location = new System.Drawing.Point(138, 64);
			this.maskedTextBox1.Mask = "00/00/0000";
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(121, 20);
			this.maskedTextBox1.TabIndex = 0;
			this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(42, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nhập Ngày:";
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(224, 114);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// FrmMaskerTextBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(311, 149);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.maskedTextBox1);
			this.Name = "FrmMaskerTextBox";
			this.Text = "Demo MaskerTextBox";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MaskedTextBox maskedTextBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCancel;
	}
}