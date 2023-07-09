using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiDoDung
    {
        private String MaLoaiDoDung;
        private String TenLoaiDoDung;

        public LoaiDoDung(string maLoaiDoDung, string tenLoaiDoDung)
        {
            MaLoaiDoDung = maLoaiDoDung;
            TenLoaiDoDung = tenLoaiDoDung;
        }

        public string MaLoaiDoDung1 { get => MaLoaiDoDung; set => MaLoaiDoDung = value; }
        public string TenLoaiDoDung1 { get => TenLoaiDoDung; set => TenLoaiDoDung = value; }
    }
}
