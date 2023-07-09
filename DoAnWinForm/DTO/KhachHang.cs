using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang
    {
        private String MaKH;
        private String Ten;
        private DateTime NgaySinh;
        private String SDT;
        private float TongTienDaMua;

        public KhachHang(string maKH, string ten, DateTime ngaySinh, string sDT, float tongTienDaMua)
        {
            MaKH = maKH;
            Ten = ten;
            NgaySinh = ngaySinh;
            SDT = sDT;
            TongTienDaMua = tongTienDaMua;
        }

        public string MaKH1 { get => MaKH; set => MaKH = value; }
        public string Ten1 { get => Ten; set => Ten = value; }
        public DateTime NgaySinh1 { get => NgaySinh; set => NgaySinh = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
        public float TongTienDaMua1 { get => TongTienDaMua; set => TongTienDaMua = value; }
    }
}
