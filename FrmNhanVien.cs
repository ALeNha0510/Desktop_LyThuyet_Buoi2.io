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
	public partial class FrmNhanVien : Form
	{
		QuanLyNhanVien qlnv;
		public FrmNhanVien()
		{
			InitializeComponent();
		}

		private NhanVien GetNhanVien()
		{
			NhanVien nv = new NhanVien();
			bool gt = true;

			nv.MaSo = this.txtMaNV.Text;
			nv.HoTen = this.txtHoTen.Text;
			nv.NgaySinh = this.dtpNgaySinh.Value;
			if (rdNu.Checked)
				gt = false;
			nv.Phai = gt;
			nv.DiaChi = this.txtDiaChi.Text;
			nv.Email = this.txtEmail.Text;
			nv.SoDT = this.mktbSoDT.Text;
			nv.Phong = this.cboPhongBan.Text;
			nv.Hinh = this.txtHinh.Text;
			return nv;

		}

		//Lấy tt nhân viên từ dòng item của listview
		private NhanVien GetNhanVienLV(ListViewItem lvitem)
		{
			NhanVien nv = new NhanVien();
			nv.MaSo = lvitem.SubItems[0].Text;
			nv.HoTen = lvitem.SubItems[1].Text;
			nv.NgaySinh = DateTime.Parse(lvitem.SubItems[2].Text);

			nv.Phai = false;
			if (lvitem.SubItems[3].Text == "Nam")
				nv.Phai = true;
			nv.DiaChi = lvitem.SubItems[4].Text;
			nv.Email = lvitem.SubItems[5].Text;
			nv.SoDT = lvitem.SubItems[6].Text;
			nv.Phong = lvitem.SubItems[7].Text;

			return nv;
		}

		//Thiết lập các thông tin trên control sinh viên
		private void ThietLapThongTin(NhanVien nv)
		{
			this.txtMaNV.Text = nv.MaSo;
			this.txtHoTen.Text = nv.HoTen;
			this.dtpNgaySinh.Value = nv.NgaySinh;
			if (nv.Phai)
				this.rdNam.Checked = true;
			else
				this.rdNu.Checked = true;

			this.txtDiaChi.Text = nv.DiaChi;
			this.txtEmail.Text = nv.Email;
			this.mktbSoDT.Text = nv.SoDT;
			this.cboPhongBan.Text = nv.Phong;
			this.txtHinh.Text = nv.Hinh;
		}

		//thêm nhân viên vào list view
		private void ThemNV(NhanVien nv)
		{
			ListViewItem lvitem = new ListViewItem(nv.MaSo);
			lvitem.SubItems.Add(nv.HoTen);
			lvitem.SubItems.Add(nv.NgaySinh.ToShortDateString());
			string gt = "Nữ";
			if (nv.Phai)
				gt = "Nam";
			lvitem.SubItems.Add(gt);
			lvitem.SubItems.Add(nv.DiaChi);
			lvitem.SubItems.Add(nv.Email);
			lvitem.SubItems.Add(nv.SoDT);
			lvitem.SubItems.Add(nv.Phong);
			lvitem.SubItems.Add(nv.Hinh);

			this.listView1.Items.Add(lvitem);
		}

		//Hiển thị thông tin nhân viên trong listview
		private void LoadListView()
		{
			this.listView1.Items.Clear();
			foreach (NhanVien nv in qlnv.DanhSach)
			{
				ThemNV(nv);
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{
			int count = this.listView1.SelectedItems.Count;
			if (count > 0)
			{
				ListViewItem lvitem = this.listView1.SelectedItems[0];
				NhanVien nv = GetNhanVienLV(lvitem);
				ThietLapThongTin(nv);
			}
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			NhanVien nv = GetNhanVien();
			NhanVien kq = qlnv.Tim(nv.MaSo,
				delegate (object obj1, object obj2)
				{
					return (obj2 as NhanVien).MaSo.CompareTo(obj1.ToString());
				});
			if (kq != null)
			{
				MessageBox.Show("Mã Nhân Viên đã tông tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				this.qlnv.Them(nv);
				this.LoadListView();
			}
		}

		private int SoSanhTheoMa(object obj1, object obj2)
		{
			NhanVien nv = obj2 as NhanVien;
			return nv.MaSo.CompareTo(obj1);
		}
		private void btnXoa_Click(object sender, EventArgs e)
		{
			string manv = txtMaNV.Text;
			if (manv.Length == 0)
			{
				MessageBox.Show("Chưa chọn sinh viên");
				return;
			}
			foreach (ListViewItem it in listView1.Items)
			{
				if (it.Text == manv)
				{
					it.Remove();
					MessageBox.Show("Xóa thành công", "Thông báo");
					return;
				}
			}
			MessageBox.Show("Không tìm thấy dữ liệu cần xóa", "Thông báo");
		}

		private void btnMacDinh_Click(object sender, EventArgs e)
		{
			string manv = txtMaNV.Text;
			if (manv.Length == 0)
			{
				MessageBox.Show("Chưa chọn sinh viên", "Thông báo");
				return;
			}
			foreach (ListViewItem it in listView1.Items)
			{
				if (it.Text == manv)
				{
					this.txtMaNV.Text = "";
					this.txtHoTen.Text = "";
					this.dtpNgaySinh.Value = DateTime.Now;
					this.rdNam.Checked = true;
					this.txtDiaChi.Text = "";
					this.txtEmail.Text = "";
					this.mktbSoDT.Text = "";
					this.cboPhongBan.Text = "";
					this.txtHinh.Text = "";
					MessageBox.Show("Đã đưa về dữ liệu mặc định", "Thông báo");
					return;
				}
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			int i = 0;
			for (i = 0; i < listView1.Items.Count; i++)
			{
				if (listView1.Items[i].Text == txtMaNV.Text)
				{
					listView1.Items[i].SubItems[1].Text = txtHoTen.Text;
					listView1.Items[i].SubItems[2].Text = dtpNgaySinh.Text;
					listView1.Items[i].SubItems[3].Text = "";
					listView1.Items[i].SubItems[4].Text = txtDiaChi.Text;
					listView1.Items[i].SubItems[5].Text = txtEmail.Text;
					listView1.Items[i].SubItems[6].Text = mktbSoDT.Text;
					listView1.Items[i].SubItems[7].Text = cboPhongBan.Text;

					return;
				}
			}
			System.Windows.Forms.ListViewItem item = new System.Windows.Forms.ListViewItem(new string[] {
				txtMaNV.Text ,txtHoTen.Text,dtpNgaySinh.Text,"", txtDiaChi.Text, txtEmail.Text, mktbSoDT.Text, cboPhongBan.Text});
			
		}

		private void FrmNhanVien_Load(object sender, EventArgs e)
		{
			ListViewItem lvitem = new ListViewItem(new string[] { "0001", "Nguyễn Trường An", "23/06/1990", "Nam", "Q1 - Tp.HCM", "annt@gmail.com", "0833.469.156", "02"});
			this.listView1.Items.Add(lvitem);
			lvitem = new ListViewItem(new string[] { "0002", "Lê Thị Hồng Gấm", "14/02/1993", "Nữ", "Nam Kỳ Khởi Nghĩa - Tp.Đà Lạt", "gamlth@gmail.com", "0986.725.553", "05"});
			this.listView1.Items.Add(lvitem);
			lvitem = new ListViewItem(new string[] { "0003", "Nguyễn Công Thành", "29/05/1989", "Nam", "Điện Biên Phủ - Nha Trang", "thanhnc@gmail.com", "01554.672.871", "01" });
			this.listView1.Items.Add(lvitem);
			lvitem = new ListViewItem(new string[] { "0004", "Võ Hữu Kiệt", "07/12/1992", "Nam", "Nguyễn Văn Trỗi - Tp.Đà Lạt", "kietvh@gmail.com", "0860.421.444", "04" });
			this.listView1.Items.Add(lvitem);
			lvitem = new ListViewItem(new string[] { "0005", "Lý Thanh Hân", "21/06/1990", "Nữ", "Lê Lợi - Tp.Huế", "hanlt@gmail.com", "0862.351.425", "03" });
			this.listView1.Items.Add(lvitem);

			
		}
		
	}
}
