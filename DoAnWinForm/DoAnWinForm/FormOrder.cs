using BUS;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAnWinForm
{
    public partial class FormOrder : Form
    {
        public static string MaKH;
        public static string MaBan;
        public FormOrder()
        {
            InitializeComponent();
            loadTable();
        }
        private void FormOrder_Load(object sender, EventArgs e)
        {
            loadTable();
        }
        void loadTable()
        {
            dtgvKV1.DataSource = B_Ban.GetAllKV1();
            dtgvKV2.DataSource = B_Ban.GetAllKV2();
            dtgvKV3.DataSource = B_Ban.GetAllKV3();
            dtgvDoDung.DataSource = B_DoDung.GetAllDoDung("SELECT MaDoDung, TenDoDung, Gia, TrangThai FROM DODUNG inner join LOAIDODUNG on DODUNG.MaLoaiDoDung=LOAIDODUNG.MaLoaiDoDung");   
            txtNgayThang.Text = System.DateTime.Now.ToString();
            txtMaNV.Text = Login.maNVLogin;
            txtTenNV.Text = Function.getTenNV(txtMaNV.Text);
            dtgvDoDung.Enabled = false;
            lviDanhMucOrder.Enabled = false;
            btnChon.Enabled = false;
            btnHuy.Enabled = false;
            btnXacNhan.Enabled = false;
            txtMaBan.Enabled = false;
            txtMaHD.Enabled = false;
            txtMaNV.Enabled = false;
            txtTenNV.Enabled = false;
        }
        private void dtgvKV1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtgvKV1.CurrentCell.RowIndex;
            txtMaBan.Text = dtgvKV1.Rows[r].Cells[0].Value.ToString();
            if(CheckBan() == false)
            {
                txtMaHD.Text = Function.LayMaHDTheoBan(dtgvKV1.Rows[r].Cells[0].Value.ToString());
                txtMaKH.Text = Function.LayMaKHTheoHD(txtMaHD.Text);
                txtTenKH.Text = Function.LayTenKH(txtMaKH.Text);
            }
            else
            {
                txtMaKH.Clear();
                txtTenKH.Clear();
                txtMaHD.Clear();
            }    
        }

        private void dtgvKV2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtgvKV2.CurrentCell.RowIndex;
            txtMaBan.Text = dtgvKV2.Rows[r].Cells[0].Value.ToString();
            if (CheckBan() == false)
            {
                txtMaHD.Text = Function.LayMaHDTheoBan(dtgvKV2.Rows[r].Cells[0].Value.ToString());
                txtMaKH.Text = Function.LayMaKHTheoHD(txtMaHD.Text);
                txtTenKH.Text = Function.LayTenKH(txtMaKH.Text);
            }
            else
            {
                txtMaKH.Clear();
                txtTenKH.Clear();
                txtMaHD.Clear();
            }
        }

        private void dtgvKV3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtgvKV3.CurrentCell.RowIndex;
            txtMaBan.Text = dtgvKV3.Rows[r].Cells[0].Value.ToString();
            if (CheckBan() == false)
            {
                txtMaHD.Text = Function.LayMaHDTheoBan(dtgvKV1.Rows[r].Cells[0].Value.ToString());
                txtMaKH.Text = Function.LayMaKHTheoHD(txtMaHD.Text);
                txtTenKH.Text = Function.LayTenKH(txtMaKH.Text);
            }
            else
            {
                txtMaKH.Clear();
                txtTenKH.Clear();
                txtMaHD.Clear();
            }
        }

        private void btnChonBan_Click(object sender, EventArgs e)
        {
            if (CheckBan() == false)
                MessageBox.Show("Bàn đã có khách");
            else
            {
                MessageBox.Show("Chọn bàn thành công");
                txtMaHD.Text = HoaDon.autoMaHoaDon();
                Function.ThemHoaDon(txtMaHD.Text, txtNgayThang.Text, txtMaBan.Text);
                Function.ThemVaoBangThanhToan(txtMaNV.Text, txtMaKH.Text, txtMaHD.Text);
                btnChonBan.Enabled = false;
                tabBan.Enabled= false;
                dtgvDoDung.Enabled = true;
                lviDanhMucOrder.Enabled = true;
                cboLoaiDoDung.Enabled = true;
                btnChon.Enabled = true;
                btnHuy.Enabled = true;
                btnXacNhan.Enabled = true;
            }    
        }
        public bool CheckBan()
        {
            if (tabBan.SelectedTab.Text == "Tầng 1")
            {
                int r = dtgvKV1.CurrentCell.RowIndex;
                if (dtgvKV1.Rows[r].Cells[1].Value.ToString() == "Có Khách")
                    return false;
            }
            else if (tabBan.SelectedTab.Text == "Tầng 2")
            {
                int r2 = dtgvKV2.CurrentCell.RowIndex;
                if (dtgvKV2.Rows[r2].Cells[1].Value.ToString() == "Có Khách")
                    return false;
            }
            else if (tabBan.SelectedTab.Text == "Ban Công")
            {
                int r3 = dtgvKV3.CurrentCell.RowIndex;
                if (dtgvKV3.Rows[r3].Cells[1].Value.ToString() == "Có Khách")
                    return false;
            }
            return true;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(dbConnection.HamKetNoi());
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            int r = dtgvDoDung.CurrentCell.RowIndex;
            Function.ThemVaoChiTietHoaDon(txtMaHD.Text, dtgvDoDung.Rows[r].Cells[0].Value.ToString());
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT MaDoDung, TenDoDung, Gia FROM DODUNG WHERE MaDoDung= '" + dtgvDoDung.Rows[r].Cells[0].Value.ToString() + "'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem lvi = new ListViewItem(reader.GetString(0) + "");
                lvi.SubItems.Add(reader.GetString(1) + "");
                lvi.SubItems.Add(reader.GetDouble(2) + "");
                lviDanhMucOrder.Items.Add(lvi);
            }
            reader.Close();
        }

        private void lviDanhMucOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void loadData()
        {
            dtgvKV1.DataSource = B_Ban.GetAllKV1();
            dtgvKV2.DataSource = B_Ban.GetAllKV2();
            dtgvKV3.DataSource = B_Ban.GetAllKV3();
            dtgvDoDung.DataSource = B_DoDung.GetAllDoDung("SELECT MaDoDung, TenDoDung, Gia, TrangThai FROM DODUNG inner join LOAIDODUNG on DODUNG.MaLoaiDoDung=LOAIDODUNG.MaLoaiDoDung");
            txtNgayThang.Text = System.DateTime.Now.ToString();
            txtMaNV.Text = Login.maNVLogin;
            txtTenNV.Text = Function.getTenNV(txtMaNV.Text);
            txtTenKH.Enabled = false;
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtMaHD.Clear();
            tabBan.Enabled = true;
            dtgvDoDung.Enabled = false;
            lviDanhMucOrder.Items.Clear();
            btnChon.Enabled = false;
            btnChonBan.Enabled = true;
            btnHuy.Enabled = false;
            btnXacNhan.Enabled = false;
            txtMaBan.ResetText();
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            Function.CapNhatTrangThaiBan(txtMaBan.Text);
            MessageBox.Show("Thêm thành công");
            loadData();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (CheckBan() == false)
            {
                MaBan = txtMaBan.Text;
                MaKH = txtMaKH.Text;
                Form frm = new FormThanhToan();
                frm.ShowDialog();
                loadData();
            }
            else
                MessageBox.Show("Bàn này chưa có hóa đơn");
        }

        private void txtMaKH_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                MaKH = txtMaKH.Text;
                txtTenKH.Text = Function.LayTenKH(txtMaKH.Text);
            }
        }

        private void tvDanhSachBan_Click(object sender, EventArgs e)
        {

        }
        private void btnTim_Click_1(object sender, EventArgs e)
        {
            string currentText = cboLoaiDoDung.Text;
            if(currentText == "ALL")
            {
                dtgvDoDung.DataSource = B_DoDung.GetAllDoDung("SELECT MaDoDung, TenDoDung, Gia, TrangThai FROM DODUNG inner join LOAIDODUNG on DODUNG.MaLoaiDoDung=LOAIDODUNG.MaLoaiDoDung");
            }   
            else
                dtgvDoDung.DataSource = B_DoDung.GetAllDoDung("SELECT MaDoDung, TenDoDung, Gia, TrangThai FROM DODUNG inner join LOAIDODUNG on DODUNG.MaLoaiDoDung=LOAIDODUNG.MaLoaiDoDung WHERE LOAIDODUNG.TenLoaiDoDung='" + currentText + "'");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}