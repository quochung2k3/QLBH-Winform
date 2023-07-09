using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class B_TaiChinh
    {
        public static DataTable GetLuong()
        {
            return DAL.Function.getData("SELECT MaNV, Ten, LoaiNhanVien, MaChiNhanh, LuongCoBan From NHANVIEN");
        }
    }
}
