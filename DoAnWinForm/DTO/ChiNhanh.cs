using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiNhanh
    {
        private String maChiNhanh;
        private String diaChi;

        public ChiNhanh(string maChiNhanh, string diaChi)
        {
            this.maChiNhanh = maChiNhanh;
            this.diaChi = diaChi;
        }

        public string MaChiNhanh { get => maChiNhanh; set => maChiNhanh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
    }
}
