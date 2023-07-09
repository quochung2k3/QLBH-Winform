using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class B_KhachHang
    {
        public static DataTable GetKhachHang()
        {
            return DAL.Function.getData("SELECT MaKH, Ten, NgaySinh, SDT FROM KHACHHANG");
        }
    }
}
