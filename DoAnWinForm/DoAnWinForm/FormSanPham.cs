using DAL;
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
    public partial class FormSanPham : Form
    {
        public FormSanPham()
        {
            InitializeComponent();
        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            dtgvSanPham.DataSource = Function.getData("SELECT * FROM DODUNG");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtgvSanPham.DataSource = Function.getData("SELECT * FROM DODUNG WHERE MaLoaiDoDung='" + txtTenSanPham.Text + "'");
            this.txtTenSanPham.ResetText();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dtgvSanPham.DataSource = Function.getData("SELECT * FROM DODUNG");
        }
    }
}
