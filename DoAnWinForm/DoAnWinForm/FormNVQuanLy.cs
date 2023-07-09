using BUS;
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
    public partial class FormNVQuanLy : Form
    {
        bool Them;
        public FormNVQuanLy()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            dgvNhanVien.DataSource = B_NhanVien.GetNhanVien();
            dgvKhachHang.DataSource = B_KhachHang.GetKhachHang();
            txtMaNV.Enabled = false;
            txtTenNV.Enabled = false;
            txtNgaySinhNV.Enabled = false;
            txtDiaChiNV.Enabled = false;
            txtsdtNV.Enabled = false;
            txtMaChiNhanh.Enabled = false;
            txtNgaySinhNV.Enabled = false;
            txtChucVuNV.Enabled = false;


            txtMaKH.Enabled = false;
            txtTenKH.Enabled = false;
            txtSDT.Enabled = false;
            txtNgaySinh.Enabled = false;
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        public bool checkNhanVien()
        {
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã Nhan Vien", "Thông báo",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTenNV.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên Voucher", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtChucVuNV.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã Phan Tram", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtChucVuNV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtDiaChiNV.Text))
            {
                MessageBox.Show("Bạn chưa nhập ngày bắt đầu", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChiNV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtsdtNV.Text))
            {
                MessageBox.Show("Bạn chưa nhập ngày bắt đầu", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsdtNV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNgaySinhNV.Text))
            {
                MessageBox.Show("Bạn chưa nhập ngày bắt đầu", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNgaySinhNV.Focus();
                return false;
            }
            return true;
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void FormNVQuanLy_Load(object sender, EventArgs e)
        {

        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvNhanVien.CurrentCell.RowIndex;
            txtMaNV.Text = dgvNhanVien.Rows[index].Cells[0].Value.ToString();
            txtTenNV.Text = dgvNhanVien.Rows[index].Cells[1].Value.ToString();
            txtChucVuNV.Text = dgvNhanVien.Rows[index].Cells[2].Value.ToString();
            txtDiaChiNV.Text = dgvNhanVien.Rows[index].Cells[3].Value.ToString();
            txtsdtNV.Text = dgvNhanVien.Rows[index].Cells[4].Value.ToString();
            txtMaChiNhanh.Text = dgvNhanVien.Rows[index].Cells[5].Value.ToString();
            DateTime ngaySinh = (DateTime)dgvNhanVien.Rows[index].Cells[6].Value;
            Console.WriteLine(ngaySinh.ToString());
            txtNgaySinhNV.Text = ngaySinh.ToString("dd/MM/yyyy");
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvKhachHang.CurrentCell.RowIndex;
            txtMaKH.Text = dgvKhachHang.Rows[index].Cells[0].Value.ToString();
            txtTenKH.Text = dgvKhachHang.Rows[index].Cells[1].Value.ToString();
            txtNgaySinh.Text = dgvKhachHang.Rows[index].Cells[2].Value.ToString();
            txtSDT.Text = dgvKhachHang.Rows[index].Cells[3].Value.ToString();
        }

        private void btnThemNV_Click_1(object sender, EventArgs e)
        {
            D_NhanVien.ThemNhanVien(txtMaNV.Text, txtTenNV.Text, txtNgaySinhNV.Text, txtDiaChiNV.Text, txtsdtNV.Text, txtMaChiNhanh.Text, txtChucVuNV.Text);
            MessageBox.Show("Thêm Nhan Vien thành công");
            dgvNhanVien.DataSource = B_NhanVien.GetNhanVien();
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            txtMaNV.Enabled = true;
            txtTenNV.Enabled = true;
            txtNgaySinhNV.Enabled = true;
            txtDiaChiNV.Enabled = true;
            txtsdtNV.Enabled = true;
            txtMaChiNhanh.Enabled = true;
            txtNgaySinhNV.Enabled = true;
            txtChucVuNV.Enabled = true;
        }

        private void btnLuuNV_Click(object sender, EventArgs e)
        {
            D_NhanVien.SuaNhanVien(txtMaNV.Text, txtTenNV.Text, txtNgaySinhNV.Text, txtDiaChiNV.Text, txtsdtNV.Text, txtMaChiNhanh.Text, txtChucVuNV.Text);
            MessageBox.Show("Cập nhật Nhan Vien thành công");
            dgvNhanVien.DataSource = B_NhanVien.GetNhanVien();
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            txtMaKH.Enabled = true;
            txtTenKH.Enabled = true;
            txtSDT.Enabled = true;
            txtNgaySinh.Enabled = true;
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            Function.ThemKhachHang(txtMaKH.Text, txtTenKH.Text, txtNgaySinh.Text, txtSDT.Text);
            MessageBox.Show("Thêm khách hàng thành công");
            dgvKhachHang.DataSource = B_KhachHang.GetKhachHang();
        }

        private void btnLuuKH_Click(object sender, EventArgs e)
        {
            Function.UpdateKhachHang(txtMaKH.Text, txtTenKH.Text, txtNgaySinh.Text, txtSDT.Text);
            MessageBox.Show("Cập nhật khách hàng thành công");
            dgvKhachHang.DataSource = B_KhachHang.GetKhachHang();
        }
    }
}
