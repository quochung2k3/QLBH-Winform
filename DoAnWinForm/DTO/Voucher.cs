using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Voucher
    {
        private String MaVoucher;
        private String TenVoucher;
        private float PhanTramGiam;
        private DateTime NgayBatDau;
        private DateTime NgayKetThuc;
        private int SoLuong;

        public Voucher(string maVoucher, string tenVoucher, float phanTramGiam, DateTime ngayBatDau, DateTime ngayKetThuc, int soLuong)
        {
            MaVoucher = maVoucher;
            TenVoucher = tenVoucher;
            PhanTramGiam = phanTramGiam;
            NgayBatDau = ngayBatDau;
            NgayKetThuc = ngayKetThuc;
            SoLuong = soLuong;
        }

        public string MaVoucher1 { get => MaVoucher; set => MaVoucher = value; }
        public string TenVoucher1 { get => TenVoucher; set => TenVoucher = value; }
        public float PhanTramGiam1 { get => PhanTramGiam; set => PhanTramGiam = value; }
        public DateTime NgayBatDau1 { get => NgayBatDau; set => NgayBatDau = value; }
        public DateTime NgayKetThuc1 { get => NgayKetThuc; set => NgayKetThuc = value; }
        public int SoLuong1 { get => SoLuong; set => SoLuong = value; }
    }
}
