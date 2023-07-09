using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BUS;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAnWinForm
{
    public partial class FormAdmin : Form
    {
        bool Them;
        public FormAdmin()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            dgvQuanLy.DataSource = B_NhanVienQL.GetNhanVienQL();
            dgvVoucher.DataSource = B_Voucher.GetVoucher();
            dgvLuong.DataSource = B_TaiChinh.GetLuong();
            dgvAcc.DataSource = B_Account.GetAccount();

        }
        public bool checkVoucher()
        {
            if (string.IsNullOrEmpty(txtMaVC.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã Voucher", "Thông báo",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaVC.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTenVC.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên Voucher", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenVC.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtPTGiam.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã Phan Tram", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPTGiam.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNgayBD.Text))
            {
                MessageBox.Show("Bạn chưa nhập ngày bắt đầu", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNgayBD.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNgayKT.Text))
            {
                MessageBox.Show("Bạn chưa nhập ngày kết thúc", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNgayKT.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSoLuong.Text))
            {
                MessageBox.Show("Bạn chưa nhập số lượng", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Focus();
                return false;
            }
            return true;

        }
        public bool checkAccount()
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã Voucher", "Thông báo",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên Voucher", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPass.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtLoaiTK.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã Phan Tram", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLoaiTK.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Bạn chưa nhập ngày bắt đầu", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNV.Focus();
                return false;
            }
            return true;
        }



        private void btnResetVoucher_Click(object sender, EventArgs e)
        {
            LoadData();
            this.txtMaVC.ResetText();
            this.txtTenVC.ResetText();
            this.txtPTGiam.ResetText();
            this.txtNgayBD.ResetText();
            this.txtNgayKT.ResetText();
            this.txtSoLuong.ResetText();

        }
        private void btnSuaAcc_Click(object sender, EventArgs e)
        {
            D_Account.SuaAccount(txtUsername.Text, txtPass.Text, txtLoaiTK.Text, txtMaNV.Text);
            MessageBox.Show("Sua Account thanh cong");
            dgvAcc.DataSource = B_Account.GetAccount();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnThemVoucher_Click_1(object sender, EventArgs e)
        {
            Them = true;
            if (checkVoucher())
            {
                D_Voucher.ThemVoucher(txtMaVC.Text, txtTenVC.Text, txtPTGiam.Text, txtNgayBD.Text, txtNgayKT.Text, txtSoLuong.Text);
                MessageBox.Show("Thêm Voucher thành công");
                dgvVoucher.DataSource = B_Voucher.GetVoucher();
            }
        }

        private void btnSuaVoucher_Click_1(object sender, EventArgs e)
        {
            D_Voucher.SuaVoucher(txtMaVC.Text, txtTenVC.Text, txtPTGiam.Text, txtNgayBD.Text, txtNgayKT.Text, txtSoLuong.Text);
            MessageBox.Show("Sua Voucher thanh cong");
            dgvVoucher.DataSource = B_Voucher.GetVoucher();
        }

        private void btnXoaVoucher_Click_1(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn xoá ?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                if (dgvVoucher.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = dgvVoucher.SelectedCells[0].OwningRow.Index;
                    dgvVoucher.Rows.RemoveAt(selectedRowIndex);
                    D_Voucher.XoaVoucher(txtMaVC.Text);
                }
            }
        }

        private void btnResetVoucher_Click_1(object sender, EventArgs e)
        {
            LoadData();
            this.txtUsername.ResetText();
            this.txtPass.ResetText();
            this.txtLoaiTK.ResetText();
            this.txtMaNV.ResetText();
        }

        private void dgvVoucher_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvVoucher.CurrentCell.RowIndex;
            txtMaVC.Text =
                dgvVoucher.Rows[index].Cells[0].Value.ToString();
            txtTenVC.Text =
                dgvVoucher.Rows[index].Cells[1].Value.ToString();
            txtPTGiam.Text =
                dgvVoucher.Rows[index].Cells[2].Value.ToString();
            /* txtNgayBD.Text =
                 dgvVoucher.Rows[index].Cells[3].Value.ToString();*/
            DateTime ngaybd = (DateTime)dgvVoucher.Rows[index].Cells[3].Value;
            Console.WriteLine(ngaybd.ToString());
            txtNgayBD.Text = ngaybd.ToString("dd/MM/yyyy");
            /*txtNgayKT.Text =
                dgvVoucher.Rows[index].Cells[4].Value.ToString();*/
            DateTime ngaykt = (DateTime)dgvVoucher.Rows[index].Cells[3].Value;
            Console.WriteLine(ngaykt.ToString());
            txtNgayKT.Text = ngaykt.ToString("dd/MM/yyyy");
            txtSoLuong.Text =
                dgvVoucher.Rows[index].Cells[5].Value.ToString();
        }

        private void btnThemAcc_Click_1(object sender, EventArgs e)
        {
            Them = true;
            if (checkAccount())
            {
                D_Account.ThemAccount(txtUsername.Text, txtPass.Text, txtLoaiTK.Text, txtMaNV.Text);
                MessageBox.Show("Thêm Account thành công");
                dgvAcc.DataSource = B_Account.GetAccount();
            }
        }

        private void btnSuaAcc_Click_1(object sender, EventArgs e)
        {
            D_Account.SuaAccount(txtUsername.Text, txtPass.Text, txtLoaiTK.Text, txtMaNV.Text);
            MessageBox.Show("Sua Account thanh cong");
            dgvAcc.DataSource = B_Account.GetAccount();
        }

        private void btnXoaAcc_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn xoá ?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                if (dgvAcc.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = dgvAcc.SelectedCells[0].OwningRow.Index;
                    dgvAcc.Rows.RemoveAt(selectedRowIndex);
                    D_Account.XoaAccount(txtUsername.Text);
                }
            }
        }

        private void btnResetAcc_Click(object sender, EventArgs e)
        {
            LoadData();
            this.txtUsername.ResetText();
            this.txtPass.ResetText();
            this.txtLoaiTK.ResetText();
            this.txtMaNV.ResetText();
        }

        private void dgvAcc_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvAcc.CurrentCell.RowIndex;
            txtUsername.Text =
                dgvAcc.Rows[index].Cells[0].Value.ToString();
            txtPass.Text =
                dgvAcc.Rows[index].Cells[1].Value.ToString();
            txtLoaiTK.Text =
                dgvAcc.Rows[index].Cells[2].Value.ToString();
            txtMaNV.Text =
                dgvAcc.Rows[index].Cells[3].Value.ToString();
        }

        private void btnTimVoucher_Click(object sender, EventArgs e)
        {
            dgvVoucher.DataSource = Function.getData("SELECT * FROM VOUCHER WHERE MaVoucher='"+ txtTimVoucher.Text+"'");
        }

        private void btnTimAcc_Click(object sender, EventArgs e)
        {
            dgvAcc.DataSource = Function.getData("SELECT * FROM ACCOUNT WHERE Username='" + txtTimAcc.Text + "'");
        }

        private void btnResetQL_Click(object sender, EventArgs e)
        {
            dgvQuanLy.DataSource = B_NhanVienQL.GetNhanVienQL();
            cbChiNhanh.Items.Clear();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string currentText = cbChiNhanh.Text;
            dgvQuanLy.DataSource = Function.getData("SELECT * FROM NHANVIEN WHERE MaChiNhanh='"+currentText+ "' and LoaiNhanVien = 'Quan ly'");
        }

        private void btnOK2_Click(object sender, EventArgs e)
        {
            string currentText = cbChiNhanh2.Text;
            dgvLuong.DataSource = Function.getData("SELECT MaNV, Ten, MaChiNhanh, LuongCoBan FROM NHANVIEN WHERE MaChiNhanh='" + currentText + "'");
        }

        private void btnReset2_Click(object sender, EventArgs e)
        {
            dgvLuong.DataSource = B_TaiChinh.GetLuong();
            cbChiNhanh2.Items.Clear();
        }

        private void dgvQuanLy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            int index = dgvQuanLy.CurrentCell.RowIndex;
            txtMaQL.Text =
                dgvQuanLy.Rows[index].Cells[0].Value.ToString();
            txtTenQL.Text =
                dgvQuanLy.Rows[index].Cells[1].Value.ToString();
            txtNgaySinh.Text =
                dgvQuanLy.Rows[index].Cells[2].Value.ToString();
            txtDiaChi.Text =
                dgvQuanLy.Rows[index].Cells[3].Value.ToString();
            txtSDT.Text =
                dgvQuanLy.Rows[index].Cells[3].Value.ToString();
            */
        }
    }
}