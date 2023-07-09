using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTiet_HD
    {
        private String MaHD;
        private String MaDongDung;

        public ChiTiet_HD(string maHD, string maDongDung)
        {
            MaHD = maHD;
            MaDongDung = maDongDung;
        }

        public string MaHD1 { get => MaHD; set => MaHD = value; }
        public string MaDongDung1 { get => MaDongDung; set => MaDongDung = value; }
    }
}
