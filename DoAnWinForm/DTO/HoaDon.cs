using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon
    {
        private String MaHD;
        private DateTime NgayIn;
        private String MaBan;
        private float TongTien;
        private float TienDaNhan;
        private float TienThoi;

        public HoaDon(string maHD, DateTime ngayIn, string maBan, float tongTien, float tienDaNhan, float tienThoi)
        {
            MaHD = maHD;
            NgayIn = ngayIn;
            MaBan = maBan;
            TongTien = tongTien;
            TienDaNhan = tienDaNhan;
            TienThoi = tienThoi;
        }

        public string MaHD1 { get => MaHD; set => MaHD = value; }
        public DateTime NgayIn1 { get => NgayIn; set => NgayIn = value; }
        public string MaBan1 { get => MaBan; set => MaBan = value; }
        public float TongTien1 { get => TongTien; set => TongTien = value; }
        public float TienDaNhan1 { get => TienDaNhan; set => TienDaNhan = value; }
        public float TienThoi1 { get => TienThoi; set => TienThoi = value; }
    }
}
