using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class B_Ban
    {
        public static DataTable GetAllKV1()
        {
            return DAL.Function.getData("SELECT MaBan, TrangThai FROM BAN WHERE MaKV='KV01'");
        }
        public static DataTable GetAllKV2()
        {
            return DAL.Function.getData("SELECT MaBan, TrangThai FROM BAN WHERE MaKV='KV02'");
        }
        public static DataTable GetAllKV3()
        {
            return DAL.Function.getData("SELECT MaBan, TrangThai FROM BAN WHERE MaKV='KV03'");
        }
        public static DataTable GetAllBan()
        {
            return DAL.D_Ban.getData("SELECT * FROM BAN");
        }
    }
}