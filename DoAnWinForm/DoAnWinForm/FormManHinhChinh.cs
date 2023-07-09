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
    public partial class FormManHinhChinh : Form
    {
        public FormManHinhChinh()
        {
            InitializeComponent();
        }


        private void btnOrder_Click(object sender, EventArgs e)
        {
            Form frm = new FormOrder();
            frm.ShowDialog();
        }

        private void btnQuanLySanPham_Click(object sender, EventArgs e)
        {
            Form frm = new FormSanPham();
            frm.ShowDialog();
        }

        private void btnQuanLyBan_Click(object sender, EventArgs e)
        {
            Form frm = new FormQuanLyBan();
            frm.ShowDialog();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Form frm = new FormAdmin();
            frm.ShowDialog();
        }

        private void btnNhanVienQuanLy_Click(object sender, EventArgs e)
        {
            Form frm = new FormNVQuanLy();
            frm.ShowDialog();
        }

        private void btnCapNhatSanPham_Click(object sender, EventArgs e)
        {
            Form frm = new FormCapNhatSanPham();
            frm.ShowDialog();
        }

        private void FormManHinhChinh_Load(object sender, EventArgs e)
        {
            if(Login.loaiTK == 0)
            {
                btnAdmin.Enabled = false;
                btnNhanVienQuanLy.Enabled = false;
                btnCapNhatSanPham.Enabled = false;
                btnQuanLyBan.Enabled = false;
            }
            else if(Login.loaiTK == 1)
            {
                btnOrder.Enabled = false;
                btnQuanLySanPham.Enabled = false;
                btnAdmin.Enabled = false;
            }
            else
            {
                btnOrder.Enabled = false;
                btnQuanLySanPham.Enabled = false;
                btnQuanLyBan.Enabled = false;
                btnNhanVienQuanLy.Enabled = false;
                btnCapNhatSanPham.Enabled = false;
            }    
        }

    }
}