using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnWinForm
{
    public partial class FormCapNhatSanPham : Form
    {
        public FormCapNhatSanPham()
        {
            InitializeComponent();
        }
        private void FormCapNhatSanPham_Load(object sender, EventArgs e)
        {

        }

        private void btncf_Click_1(object sender, EventArgs e)
        {
            FormCapnhatCF f = new FormCapnhatCF();
            f.ShowDialog();
        }

        private void btntea_Click_1(object sender, EventArgs e)
        {
            FormCapnhatTEA f = new FormCapnhatTEA();
            f.ShowDialog();
        }

        private void btncake_Click_1(object sender, EventArgs e)
        {
            FormCapnhatCAKE f = new FormCapnhatCAKE();
            f.ShowDialog();
        }
    }
}
