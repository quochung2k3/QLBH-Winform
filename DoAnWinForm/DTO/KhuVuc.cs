using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhuVuc
    {
        private String MaKV;
        private String TenKV;

        public KhuVuc(string maKV, string tenKV)
        {
            MaKV = maKV;
            TenKV = tenKV;
        }

        public string MaKV1 { get => MaKV; set => MaKV = value; }
        public string TenKV1 { get => TenKV; set => TenKV = value; }
    }
}
