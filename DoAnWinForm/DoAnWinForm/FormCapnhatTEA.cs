using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnWinForm
{
    public partial class FormCapnhatTEA : Form
    {
        public FormCapnhatTEA()
        {
            InitializeComponent();
        }

        private void FormCapnhatTEA_Load(object sender, EventArgs e)
        {
            string filePath = @"CapNhatTEA.txt";
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File does not exist :{0} ", filePath);
                return;
            }

            string[] textFromFile = File.ReadAllLines(filePath);
            txtTenTEA = new TextBox[] { txtTenCF1, txtTenCF2, txtTenCF3, txtTenCF4, txtTenCF5 };
            txtGiaTEA = new TextBox[] { txtGia1, txtGia2, txtGia3, txtGia4, txtGia5 };


            for (int i = 0; i < textFromFile.ToArray().Length; i++)
            {
                string[] arrRes = textFromFile[i].Split('-');
                txtTenTEA[i].Text = arrRes[0];
                txtGiaTEA[i].Text = arrRes[1];


            }

            string filePathanh1 = @"anhTEA1.txt";
            if (!File.Exists(filePathanh1))
            {
                Console.WriteLine("File does not exist :{0} ", filePathanh1);
                return;
            }

            string[] textFromFileanh1 = File.ReadAllLines(filePathanh1);
            txttenanh1 = new TextBox[] { txtanh1 };
            for (int i = 0; i < textFromFileanh1.ToArray().Length; i++)
            {
                string[] arrRes11 = textFromFileanh1[i].Split('/');
                txttenanh1[i].Text = arrRes11[0];
            }
            string filePath1 = txtanh1.Text;
            pictureBox1.Image = Image.FromFile(@"resources\\" + filePath1);


            string filePathanh22 = @"anhTEA2.txt";
            if (!File.Exists(filePathanh22))
            {
                Console.WriteLine("File does not exist :{0} ", filePathanh22);
                return;
            }

            string[] textFromFileanh22 = File.ReadAllLines(filePathanh22);
            txttenanh2 = new TextBox[] { txtanh2 };
            for (int i = 0; i < textFromFileanh22.ToArray().Length; i++)
            {
                string[] arrRes22 = textFromFileanh22[i].Split('/');
                txttenanh2[i].Text = arrRes22[0];
            }
            string filePath22 = txtanh2.Text;
            pictureBox2.Image = Image.FromFile(@"resources\\" + filePath22);


            string filePathanh33 = @"anhTEA3.txt";
            if (!File.Exists(filePathanh33))
            {
                Console.WriteLine("File does not exist :{0} ", filePathanh33);
                return;
            }

            string[] textFromFileanh33 = File.ReadAllLines(filePathanh33);
            txttenanh3 = new TextBox[] { txtanh3 };
            for (int i = 0; i < textFromFileanh33.ToArray().Length; i++)
            {
                string[] arrRes33 = textFromFileanh33[i].Split('/');
                txttenanh3[i].Text = arrRes33[0];
            }
            string filePath33 = txtanh3.Text;
            pictureBox3.Image = Image.FromFile(@"resources\\" + filePath33);



            string filePathanh44 = @"anhTEA4.txt";
            if (!File.Exists(filePathanh44))
            {
                Console.WriteLine("File does not exist :{0} ", filePathanh44);
                return;
            }

            string[] textFromFileanh44 = File.ReadAllLines(filePathanh44);
            txttenanh4 = new TextBox[] { txtanh4 };
            for (int i = 0; i < textFromFileanh44.ToArray().Length; i++)
            {
                string[] arrRes44 = textFromFileanh44[i].Split('/');
                txttenanh4[i].Text = arrRes44[0];
            }
            string filePath44 = txtanh4.Text;
            pictureBox4.Image = Image.FromFile(@"resources\\" + filePath44);

            // Load anh 5
            string filePathanh55 = @"anhTEA5.txt";
            if (!File.Exists(filePathanh55))
            {
                Console.WriteLine("File does not exist :{0} ", filePathanh55);
                return;
            }

            string[] textFromFileanh55 = File.ReadAllLines(filePathanh55);
            txttenanh5 = new TextBox[] { txtanh5 };
            for (int i = 0; i < textFromFileanh55.ToArray().Length; i++)
            {
                string[] arrRes55 = textFromFileanh55[i].Split('/');
                txttenanh5[i].Text = arrRes55[0];
            }
            string filePath55 = txtanh5.Text;
            pictureBox5.Image = Image.FromFile(@"resources\\" + filePath55);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
            FormCapnhatTEA f = new FormCapnhatTEA();
            f.Hide();
        }

        TextBox[] txtTenTEA;
        TextBox[] txtGiaTEA;


        TextBox[] txttenanh1;
        TextBox[] txttenanh2;
        TextBox[] txttenanh3;
        TextBox[] txttenanh4;
        TextBox[] txttenanh5;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nleft,
            int ntop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int NHeightEllipse
        );

        private void btnThayAnh1_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*.png)|*.png|All fileS(*.*)|*.*";
            if (f.ShowDialog() == DialogResult.OK)
            {
                txtanh1.Text = f.FileName;
                pictureBox1.Image = new Bitmap(f.FileName);
                txtanh1.Text = f.FileName;
            }
        }

        private void btnThayAnh2_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*.png)|*.png|All fileS(*.*)|*.*";
            if (f.ShowDialog() == DialogResult.OK)
            {
                txtanh2.Text = f.FileName;
                pictureBox2.Image = new Bitmap(f.FileName);
                txtanh2.Text = f.FileName;
            }
        }

        private void btnThayAnh3_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*.png)|*.png|All fileS(*.*)|*.*";
            if (f.ShowDialog() == DialogResult.OK)
            {
                txtanh3.Text = f.FileName;
                pictureBox3.Image = new Bitmap(f.FileName);
                txtanh3.Text = f.FileName;
            }
        }

        private void btnThayAnh4_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*.png)|*.png|All fileS(*.*)|*.*";
            if (f.ShowDialog() == DialogResult.OK)
            {
                txtanh4.Text = f.FileName;
                pictureBox4.Image = new Bitmap(f.FileName);
                txtanh4.Text = f.FileName;
            }
        }

        private void btnThayAnh5_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*.png)|*.png|All fileS(*.*)|*.*";
            if (f.ShowDialog() == DialogResult.OK)
            {
                txtanh5.Text = f.FileName;
                pictureBox5.Image = new Bitmap(f.FileName);
                txtanh5.Text = f.FileName;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (chbXacNhan1.Checked || chbXacNhan2.Checked || chbXacNhan3.Checked || chbXacNhan4.Checked || chbXacNhan5.Checked)
            {
                if (chbXacNhan1.Checked)
                {

                    string filePath1 = txtanh1.Text;
                    int vitri1 = filePath1.LastIndexOf("\\");
                    string ten = filePath1.Substring(vitri1 + 1);

                    using (StreamWriter w = new StreamWriter("anhTEA1.txt"))
                    {

                        w.WriteLine(ten);
                    }
                }
                if (chbXacNhan2.Checked)
                {
                    string filePath2 = txtanh2.Text;
                    int vitri2 = filePath2.LastIndexOf("\\");
                    string ten2 = filePath2.Substring(vitri2 + 1);

                    using (StreamWriter w2 = new StreamWriter("anhTEA2.txt"))
                    {

                        w2.WriteLine(ten2);
                    }
                }

                if (chbXacNhan3.Checked)
                {
                    string filePath3 = txtanh3.Text;
                    int vitri3 = filePath3.LastIndexOf("\\");
                    string ten3 = filePath3.Substring(vitri3 + 1);

                    using (StreamWriter w = new StreamWriter("anhTEA3.txt"))
                    {

                        w.WriteLine(ten3);
                    }
                }

                if (chbXacNhan4.Checked)
                {
                    string filePath4 = txtanh4.Text;
                    int vitri4 = filePath4.LastIndexOf("\\");
                    string ten4 = filePath4.Substring(vitri4 + 1);

                    using (StreamWriter w = new StreamWriter("anhTEA4.txt"))
                    {

                        w.WriteLine(ten4);
                    }
                }

                if (chbXacNhan5.Checked)
                {

                    string filePath5 = txtanh5.Text;
                    int vitri5 = filePath5.LastIndexOf("\\");
                    string ten5 = filePath5.Substring(vitri5 + 1);

                    using (StreamWriter w = new StreamWriter("anhTEA5.txt"))
                    {
                        w.WriteLine(ten5);
                    }

                }
                MessageBox.Show("Lưu thành công");
            }
            else
            {
                MessageBox.Show("Không thay đổi ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            Close();
            FormCapnhatTEA f = new FormCapnhatTEA();
            f.Hide();
        }
    }
}
