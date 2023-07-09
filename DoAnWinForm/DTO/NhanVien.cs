using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        private String MaNV;
        private String Ten;
        private DateTime NgaySinh;
        private String DiaChi;
        private String SDT;
        private String MaChiNhanh;
        private String LoaiNhanVien;
        private float LuongCoBan;
        private float LuongTheoGio;
        private float SoGioLam;

        public NhanVien(string maNV, string ten, DateTime ngaySinh, string diaChi, string sDT, string maChiNhanh, string loaiNhanVien, float luongCoBan, float luongTheoGio, float soGioLam)
        {
            MaNV = maNV;
            Ten = ten;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            SDT = sDT;
            MaChiNhanh = maChiNhanh;
            LoaiNhanVien = loaiNhanVien;
            LuongCoBan = luongCoBan;
            LuongTheoGio = luongTheoGio;
            SoGioLam = soGioLam;
        }

        public string MaNV1 { get => MaNV; set => MaNV = value; }
        public string Ten1 { get => Ten; set => Ten = value; }
        public DateTime NgaySinh1 { get => NgaySinh; set => NgaySinh = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
        public string MaChiNhanh1 { get => MaChiNhanh; set => MaChiNhanh = value; }
        public string LoaiNhanVien1 { get => LoaiNhanVien; set => LoaiNhanVien = value; }
        public float LuongCoBan1 { get => LuongCoBan; set => LuongCoBan = value; }
        public float LuongTheoGio1 { get => LuongTheoGio; set => LuongTheoGio = value; }
        public float SoGioLam1 { get => SoGioLam; set => SoGioLam = value; }
    }
}
