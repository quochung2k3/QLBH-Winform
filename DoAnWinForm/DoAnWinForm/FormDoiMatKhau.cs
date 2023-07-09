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
    public partial class FormDoiMatKhau : Form
    {
        public FormDoiMatKhau()
        {
            InitializeComponent();
        }

        private void FormDoiMatKhau_Load(object sender, EventArgs e)
        {

        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Function.ChangePassword(txtUsername.Text, txtMatKhauMoi.Text, txtMatKhauCu.Text))
            {
                MessageBox.Show("Đổi mật khẩu thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thông tin không chính xác!");
            }
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            txtMatKhauCu.UseSystemPasswordChar = !txtMatKhauCu.UseSystemPasswordChar;
        }

        private void btnShowPass2_Click(object sender, EventArgs e)
        {
            txtMatKhauMoi.UseSystemPasswordChar = !txtMatKhauMoi.UseSystemPasswordChar;
        }
    }
}
