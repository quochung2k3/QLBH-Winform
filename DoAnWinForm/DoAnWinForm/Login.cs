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
using BUS;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DoAnWinForm
{
    public partial class Login : Form
    {

        public static string connectString = "";
        // Đối tượng kết nối
        public static SqlConnection conn = null;
        public static string maNVLogin;
        public static int loaiTK;
        public static string Username;

        public Login()
        {
            InitializeComponent();
        }
        void login()
        {
            connectString = "Data Source=DESKTOP-8C0E5N3;" +
                   "Initial Catalog=Winform;" +
                   "Integrated Security=True";
            conn = new SqlConnection(connectString);
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    //thanh cong
                    Console.WriteLine("Connection successful.");
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ACCOUNT WHERE Username = '" + txtUsername.Text + "'", conn);
                    DataTable dtAcc = new DataTable();
                    dtAcc.Clear();
                    da.Fill(dtAcc);    
                    maNVLogin = dtAcc.Rows[0]["MaNV"].ToString();
                    loaiTK = Convert.ToInt32(dtAcc.Rows[0]["Type"].ToString());
                    Username = txtUsername.Text;
                    this.Hide();
                    Form frm;
                    switch (loaiTK)
                    {
                        case 0:
                            frm = new FormManHinhChinh();
                            frm.ShowDialog();
                            break;
                        case 1:
                            frm = new FormManHinhChinh();
                            frm.ShowDialog();
                            break;
                        case 2:
                            frm = new FormManHinhChinh();
                            frm.ShowDialog();
                            break;
                    }
                    this.Show();
                }
                else
                {
                    //that bai
                    Console.WriteLine("Connection failed.");

                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Sai mật khẩu hoặc tên tài khoản!", "Sai mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            login();
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = !txtPass.UseSystemPasswordChar;
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            FormDoiMatKhau frm = new FormDoiMatKhau();
            frm.ShowDialog();
        }
    }
}
