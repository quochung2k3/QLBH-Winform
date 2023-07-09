using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class B_NhanVienQL
    {
        public static DataTable GetNhanVienQL()
        {
            return DAL.Function.getData("SELECT MaNV, Ten, MaChiNhanh, DiaChi, SDT, NgaySinh FROM NHANVIEN WHERE LoaiNhanVien = 'Quan ly'");
        }
    }
}
