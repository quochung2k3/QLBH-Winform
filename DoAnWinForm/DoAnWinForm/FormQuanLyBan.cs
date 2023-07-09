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
    public partial class FormQuanLyBan : Form
    {
        B_Ban ban = new B_Ban();
        public FormQuanLyBan()
        {
            InitializeComponent();
        }
        bool Themm;
        private void FormQuanLyBan_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            try
            {

                dtgvQuanLyBan.DataSource = B_Ban.GetAllBan();

                dtgvQuanLyBan_CellClick(null, null);

                this.btnThem.Enabled = true;
                this.btnLuu.Enabled = true;
                this.btnCapNhat.Enabled = true;
                this.btnXoa.Enabled = true;
                txtMaBan.Enabled = true;
                txtTenBan.Enabled = true;
                txtMaKV.Enabled = true;
                txtNgayCapNhat.Text = System.DateTime.Now.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public bool checkban()
        {
            if (string.IsNullOrEmpty(txtMaBan.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã bàn", "Thông báo",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaBan.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTenBan.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên bàn", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenBan.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtMaKV.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã khu vực", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNgayCapNhat.Text))
            {
                MessageBox.Show("Bạn chưa nhập ngày cập nhật", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNgayCapNhat.Focus();
                return false;
            }
            return true;

        }


        private void dtgvQuanLyBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtgvQuanLyBan.CurrentCell.RowIndex;
            this.txtMaBan.Text = dtgvQuanLyBan.Rows[r].Cells[0].Value.ToString();
            this.txtTenBan.Text = dtgvQuanLyBan.Rows[r].Cells[1].Value.ToString();
            this.txtMaKV.Text = dtgvQuanLyBan.Rows[r].Cells[2].Value.ToString();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            //Ban table = new Ban(txtMaBan.Text, txtTenBan.Text, txtMaKV.Text);
            Themm = true;
            if (checkban())
            {
                D_Ban.ThemBan(txtMaBan.Text, txtTenBan.Text, txtMaKV.Text);
                dtgvQuanLyBan.DataSource = B_Ban.GetAllBan();
                MessageBox.Show("Thêm bàn thành công");
            }
        }

        private void btnCapNhat_Click_1(object sender, EventArgs e)
        {
            if (checkban())
            {
                int index = dtgvQuanLyBan.CurrentRow.Index;
                dtgvQuanLyBan.Rows[index].Cells[0].Value = txtMaBan.Text.ToString();
                dtgvQuanLyBan.Rows[index].Cells[1].Value = txtTenBan.Text.ToString();
                dtgvQuanLyBan.Rows[index].Cells[2].Value = txtMaKV.Text.ToString();
                D_Ban.CapnhatBan(txtTenBan.Text, txtMaKV.Text);
            }
            MessageBox.Show("Cập nhật thành công");
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn xoá ?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                if (dtgvQuanLyBan.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = dtgvQuanLyBan.SelectedCells[0].OwningRow.Index;
                    dtgvQuanLyBan.Rows.RemoveAt(selectedRowIndex);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void dtgvQuanLyBan_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgvQuanLyBan.CurrentCell.RowIndex;
            txtMaBan.Text = dtgvQuanLyBan.Rows[index].Cells[0].Value.ToString();
            txtTenBan.Text = dtgvQuanLyBan.Rows[index].Cells[1].Value.ToString();
            txtMaKV.Text = dtgvQuanLyBan.Rows[index].Cells[2].Value.ToString();
        }
    }
}