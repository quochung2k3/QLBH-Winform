using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        private String Username;
        private String Pass;
        private String MaNV;

        public Account(string username, string pass, string maNV)
        {
            Username = username;
            Pass = pass;
            MaNV = maNV;
        }

        public string Username1 { get => Username; set => Username = value; }
        public string Pass1 { get => Pass; set => Pass = value; }
        public string MaNV1 { get => MaNV; set => MaNV = value; }
    }
}
