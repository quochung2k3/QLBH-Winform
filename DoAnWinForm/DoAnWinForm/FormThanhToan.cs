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
    public partial class FormThanhToan : Form
    {
        public FormThanhToan()
        {
            InitializeComponent();
        }

        private void FormThanhToan_Load(object sender, EventArgs e)
        {
            loadData();
        }
        void loadData()
        {
            txtNgayThang.Enabled = false;
            txtMaBan.Enabled = false;
            txtMaNV.Enabled = false;
            txtMaKH.Enabled = false;
            txtTongTien.Enabled = false;
            txtThanhToan.Enabled = false;
            txtMaHD.Enabled = false;
            txtTienTraLai.Enabled = false;

            txtNgayThang.Text = System.DateTime.Now.ToString();
            txtMaBan.Text = FormOrder.MaBan.ToString();
            txtMaKH.Text=FormOrder.MaKH.ToString();
            txtMaNV.Text = Login.maNVLogin.ToString();
            txtMaHD.Text = Function.LayMaHD(txtMaBan.Text);
            txtTongTien.Text = Function.TinhTongTien(txtMaHD.Text);
            txtThanhToan.Text = txtTongTien.Text;

        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            Function.CapNhatBangHoaDon(txtMaHD.Text, txtThanhToan.Text, txtTienDaNhan.Text);
            Function.CapNhatTrangThaiBanKhiThanhToan(txtMaBan.Text);
            Function.CapNhatBangThanhToan(txtMaVoucher.Text, txtMaHD.Text);
            MessageBox.Show("Giao dịch thành công");
            this.Close();
        }

        private void txtMaVoucher_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (Function.CheckVoucher(txtMaVoucher.Text))
                {
                    float a = float.Parse(txtTongTien.Text);
                    float b = Function.TinhPhanTramGiam(txtMaVoucher.Text);
                    float temp = a - a * b / 100;
                    txtThanhToan.Text = temp.ToString();
                }
                else
                    MessageBox.Show("Voucher không tồn tại");
            }    
        }

        private void txtTienDaNhan_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                float a = float.Parse(txtTienDaNhan.Text);
                float b = float.Parse(txtThanhToan.Text);
                float temp = a - b;
                txtTienTraLai.Text = temp.ToString();
            }    
        }
    }
}
