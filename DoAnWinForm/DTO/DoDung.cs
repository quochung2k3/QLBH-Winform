using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DoDung
    {
        private String MaDoDung;
        private String TenDoDung;
        private String TenLoaiDoDung;
        private float Gia;
        private String TrangThai;

        public DoDung(DataRow row)
        {
            this.MaDoDung = row["MaDoDung"].ToString();
            this.TenDoDung= row["TenDoDung"].ToString();
            this.TenLoaiDoDung = row["TenLoaiDoDung"].ToString();
            this.Gia = (float)row["Gia"];
            this.TrangThai = row["TrangThai"].ToString();
        }
        public DoDung(string maDoDung, string tenDoDung, string tenLoaiDoDung, float gia, string trangThai)
        {
            MaDoDung = maDoDung;
            TenDoDung = tenDoDung;
            TenLoaiDoDung = tenLoaiDoDung;
            Gia = gia;
            TrangThai = trangThai;
        }

        public string MaDoDung1 { get => MaDoDung; set => MaDoDung = value; }
        public string TenDoDung1 { get => TenDoDung; set => TenDoDung = value; }
        public string TenLoaiDoDung1 { get => TenLoaiDoDung; set => TenLoaiDoDung = value; }
        public float Gia1 { get => Gia; set => Gia = value; }
        public string TrangThai1 { get => TrangThai; set => TrangThai = value; }

        public static List<DoDung> loadDoDungList()
        {
            throw new NotImplementedException();
        }
    }
}