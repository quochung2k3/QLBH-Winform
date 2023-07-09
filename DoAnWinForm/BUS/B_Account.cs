using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class B_Account
    {
        public static DataTable GetAccount()
        {
            return DAL.Function.getData("SELECT * FROM ACCOUNT");
        }
        public static void ThemAccount() => DAL.D_Account.ThemAccount();
        public static void SuaAccount() => DAL.D_Account.SuaAccount();
        public static void XoaAccount() => DAL.D_Account.XoaAccount();
    }
}
