using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThanhToan
    {
        private String MaNV;
        private String MaKH;
        private String MaVoucher;
        private String MaHD;

        public ThanhToan(string maNV, string maKH, string maVoucher, string maHD)
        {
            MaNV = maNV;
            MaKH = maKH;
            MaVoucher = maVoucher;
            MaHD = maHD;
        }

        public string MaNV1 { get => MaNV; set => MaNV = value; }
        public string MaKH1 { get => MaKH; set => MaKH = value; }
        public string MaVoucher1 { get => MaVoucher; set => MaVoucher = value; }
        public string MaHD1 { get => MaHD; set => MaHD = value; }
    }
}
