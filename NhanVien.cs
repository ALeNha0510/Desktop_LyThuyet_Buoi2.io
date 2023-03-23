using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyThuyetBuoi2
{
	public class NhanVien
	{
		//Các thuộc tính của lớp nhân viên
		public string MaSo { get; set; }
		public string HoTen { get; set; }
		public DateTime NgaySinh { get; set; }
		public bool Phai { get; set; }
		public string DiaChi { get; set; }
		public string Email { get; set; }
		public string SoDT { get; set; }
		public string Phong { get; set; }
		public string Hinh { get; set; }

		public NhanVien()
		{

		}

		public NhanVien(string ms, string ht, DateTime ngay, bool gt, string dc, string email, string sdt, string phong, string hinh)
		{
			this.MaSo = ms;
			this.HoTen = ht;
			this.NgaySinh = ngay;
			this.Phai = gt;
			this.DiaChi = dc;
			this.Email = email;
			this.SoDT = sdt;
			this.Phong = phong;
			this.Hinh = hinh;
		}

	}
}
