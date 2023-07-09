using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class B_NhanVien
    {
        public static DataTable GetNhanVien()
        {
            return DAL.Function.getData("SELECT MaNV,Ten, LoaiNhanVien, DiaChi,SDT,MaChiNhanh, NgaySinh FROM NHANVIEN ");
        }
        public static void ThemNhanVien() => DAL.D_NhanVien.ThemNhanVien();
        public static void SuaNhanVien() => DAL.D_NhanVien.SuaNhanVien();
    }
}
