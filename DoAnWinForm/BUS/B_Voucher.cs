using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class B_Voucher
    {
        public static DataTable GetVoucher()
        {
            return DAL.Function.getData("SELECT * FROM VOUCHER");
        }

        public static void ThemVoucher() => DAL.D_Voucher.ThemVoucher();
        public static void SuaVoucher() => DAL.D_Voucher.SuaVoucher();
        public static void XoaVoucher() => DAL.D_Voucher.XoaVoucher();


    }
}