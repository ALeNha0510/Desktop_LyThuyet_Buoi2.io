using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyThuyetBuoi2
{
	public delegate int SoSanh(object nv1, object nv2);
	class QuanLyNhanVien
	{
		public List<NhanVien> DanhSach;

		public QuanLyNhanVien()
		{
			DanhSach = new List<NhanVien>();
		}

		//Thêm 1 nhân viên vào ds
		public void Them(NhanVien a)
		{
			this.DanhSach.Add(a);
		}
		public NhanVien this[int index]
		{
			get { return DanhSach[index]; }
			set { DanhSach[index] = value; }
		}
		//===========================================
		public void Xoa(object obj, SoSanh ss)
		{
			int i = DanhSach.Count - 1;
			for (; i >= 0; i--)
				if (ss(obj, this[i]) == 0)
					this.DanhSach.RemoveAt(i);
		}

		public bool Sua(NhanVien nvsua, object obj, SoSanh ss)
		{
			int i, count;
			bool kq = false;
			count = this.DanhSach.Count - 1;
			for (i = 0; i < count; i++)
			{
				if (ss(obj, this[i]) == 0)
				{
					this[i] = nvsua;
					kq = true;
					break;
				}
			}
			return kq;
		}
		public NhanVien Tim(object obj, SoSanh ss)
		{
			NhanVien nvresult = null;
			foreach (NhanVien nv in DanhSach)
			{
				if (ss(obj, nv) == 0)
				{
					nvresult = nv;
					break;
				}
			}
			return nvresult;
		}
	}
}
