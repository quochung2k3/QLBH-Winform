using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Ban
    {
        private String MaBan;
        private String TenBan;
        private String MaKV;

        public Ban(string maBan, string tenBan, string maKV)
        {
            MaBan = maBan;
            TenBan = tenBan;
            MaKV = maKV;
        }

        public string MaBan1 { get => MaBan; set => MaBan = value; }
        public string TenBan1 { get => TenBan; set => TenBan = value; }
        public string MaKV1 { get => MaKV; set => MaKV = value; }
    }
}
