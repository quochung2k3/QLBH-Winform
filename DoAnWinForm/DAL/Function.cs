using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Microsoft.SqlServer.Server;

namespace DAL
{
    public class Function
    {
        public static DataTable getData(string cmd)
        {
            SqlConnection conn = new SqlConnection(dbConnection.HamKetNoi());
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            SqlDataAdapter daKVBan1 = new SqlDataAdapter(cmd, conn);
            DataTable dtKVBan1 = new DataTable();
            dtKVBan1.Clear();
            daKVBan1.Fill(dtKVBan1);
            return dtKVBan1;
        }
        public static void DatBan()
        {

        }
        public static bool checkTaiKhoan(string txtUsername, string txtMatKhauCu)
        {
            SqlConnection conn = new SqlConnection(dbConnection.HamKetNoi());
            SqlDataAdapter daAccount = new SqlDataAdapter("SELECT * FROM ACCOUNT WHERE Username='"+txtUsername+"' and Pass='"+txtMatKhauCu+"'", conn);
            DataTable dtAccount = new DataTable();
            dtAccount.Clear();
            daAccount.Fill(dtAccount);
            int temp = dtAccount.Rows.Count;
            if(temp>0)
                return true;
            return false;
        }
        public static bool ChangePassword(string txtUsername, string txtMatKhauMoi, string txtMatKhauCu)
        {
            SqlConnection conn = new SqlConnection(dbConnection.HamKetNoi());
            if (checkTaiKhoan(txtUsername, txtMatKhauCu))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UpdateAccount", conn);
                cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = txtUsername;
                cmd.Parameters.Add("@Pass", SqlDbType.VarChar).Value = txtMatKhauMoi;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            return false;
        }
        public static string getTenNV(string txtMaNV)
        {
            SqlConnection conn = new SqlConnection(dbConnection.HamKetNoi());
            SqlDataAdapter daNhanVien = new SqlDataAdapter("SELECT Ten FROM NHANVIEN WHERE MaNV='" + txtMaNV + "'", conn);
            DataTable dtNhanVien = new DataTable();
            dtNhanVien.Clear();
            daNhanVien.Fill(dtNhanVien);
            return dtNhanVien.Rows[0][0].ToString();
        }
        public static void ThemHoaDon(string txtMaHD, string txtNgayIn, string txtMaBan)
        {
            try
            {
                SqlConnection conn = new SqlConnection(dbConnection.HamKetNoi());
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "[dbo].[ThemHoaDon]";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = conn;
                command.Parameters.Add("@MaHD", SqlDbType.VarChar).Value = txtMaHD;
                command.Parameters.Add("@NgayIn", SqlDbType.DateTime).Value = txtNgayIn;
                command.Parameters.Add("@MaBan", SqlDbType.VarChar).Value = txtMaBan;
                command.Parameters.Add("@TongTien", SqlDbType.Float).Value = 0;
                command.Parameters.Add("@TienDaNhan", SqlDbType.Float).Value = 0;
                command.Parameters.Add("@TienThoi", SqlDbType.Float).Value = 0;
                int rowCount = command.ExecuteNonQuery();
            }
            catch(Exception)
            {
                
            }
        }
        public static void ThemVaoChiTietHoaDon(string txtMaHD, string txtMaDoDung)
        {
            try
            {
                SqlConnection conn = new SqlConnection(dbConnection.HamKetNoi());
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "[dbo].[ThemChiTietHD]";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = conn;
                command.Parameters.Add("@MaHD", SqlDbType.VarChar).Value = txtMaHD;
                command.Parameters.Add("@MaDoDung", SqlDbType.VarChar).Value = txtMaDoDung;
                int rowCount = command.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
        }
        public static void CapNhatTrangThaiBan(string txtMaBan)
        {
            try
            {
                SqlConnection conn = new SqlConnection(dbConnection.HamKetNoi());
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "UpdateTrangThaiBan";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = conn;
                command.Parameters.Add("@MaBan", SqlDbType.VarChar).Value = txtMaBan;
                command.Parameters.Add("@TrangThai", SqlDbType.VarChar).Value = "Có Khách";
                int rowCount = command.ExecuteNonQuery();
            }
            catch(Exception)
            {

            }
        }
        public static string LayMaHD(string txtMaBan)
        {
            SqlConnection conn = new SqlConnection(dbConnection.HamKetNoi());
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            SqlDataAdapter daThanhToan = new SqlDataAdapter("SELECT THANHTOAN.MaHD FROM THANHTOAN INNER JOIN HOADON on THANHTOAN.MaHD = HOADON.MaHD WHERE HOADON.MaBan='"+txtMaBan+"' and THANHTOAN.TrangThai='"+"Chua Thanh Toan"+"'", conn);
            DataTable dtThanhToan = new DataTable();
            dtThanhToan.Clear();
            daThanhToan.Fill(dtThanhToan);
            return dtThanhToan.Rows[0][0].ToString();
        }
        public static string TinhTongTien(string txtMaHD)
        {
            SqlConnection conn = new SqlConnection(dbConnection.HamKetNoi());
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            SqlDataAdapter daThanhToan = new SqlDataAdapter("SELECT sum(Gia) FROM CHITIET_HD INNER JOIN DODUNG on CHITIET_HD.MaDoDung = DODUNG.MaDoDung WHERE MaHD='"+txtMaHD+"'", conn);
            DataTable dtThanhToan = new DataTable();
            dtThanhToan.Clear();
            daThanhToan.Fill(dtThanhToan);
            return dtThanhToan.Rows[0][0].ToString();
        }
        public static bool CheckVoucher(string txtVoucher)
        {
            SqlConnection conn = new SqlConnection(dbConnection.HamKetNoi());
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            SqlDataAdapter daVoucher = new SqlDataAdapter("SELECT * FROM VOUCHER WHERE MaVoucher='"+txtVoucher+"'", conn);
            DataTable dtVoucher = new DataTable();
            dtVoucher.Clear();
            daVoucher.Fill(dtVoucher);
            if(dtVoucher.Rows.Count > 0)
                return true;
            return false;
        }
        public static float TinhPhanTramGiam(string txtVoucher)
        {
            SqlConnection conn = new SqlConnection(dbConnection.HamKetNoi());
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            SqlDataAdapter daVoucher = new SqlDataAdapter("SELECT PhanTramGiam FROM VOUCHER WHERE MaVoucher='" + txtVoucher + "'", conn);
            DataTable dtVoucher = new DataTable();
            dtVoucher.Clear();
            daVoucher.Fill(dtVoucher);
            return float.Parse(dtVoucher.Rows[0][0].ToString());
        }
        public static string LayMaHDTheoBan(string txtMaBan)
        {
            SqlConnection conn = new SqlConnection(dbConnection.HamKetNoi());
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            SqlDataAdapter daBan = new SqlDataAdapter("SELECT MaHD FROM HOADON WHERE MaBan='"+txtMaBan+"'", conn);
            DataTable dtBan = new DataTable();
            dtBan.Clear();
            daBan.Fill(dtBan);
            int n = dtBan.Rows.Count;
            return dtBan.Rows[n-1][0].ToString();
        }
        public static string LayMaKHTheoHD(string txtMaHD)
        {
            SqlConnection conn = new SqlConnection(dbConnection.HamKetNoi());
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            SqlDataAdapter daBan = new SqlDataAdapter("SELECT MaKH FROM HOADON INNER JOIN THANHTOAN on HOADON.MaHD=THANHTOAN.MaHD WHERE HOADON.MaHD='" + txtMaHD + "'", conn);
            DataTable dtBan = new DataTable();
            dtBan.Clear();
            daBan.Fill(dtBan);
            return dtBan.Rows[0][0].ToString();
        }
        public static void CapNhatBangThanhToan(string txtMaVoucher, string txtMaHD)
        {
            SqlConnection conn = new SqlConnection(dbConnection.HamKetNoi());
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "CapNhatBangThanhToan";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = conn;
            command.Parameters.Add("@MaVoucher", SqlDbType.VarChar).Value = txtMaVoucher;
            command.Parameters.Add("@MaHD", SqlDbType.VarChar).Value = txtMaHD;
            int rowCount = command.ExecuteNonQuery();
        }
        public static void ThemVaoBangThanhToan(string txtMaNV, string txtMaKH, string txtMaHD)
        {
            SqlConnection conn = new SqlConnection(dbConnection.HamKetNoi());
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "ThemVaoBangThanhToan";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = conn;
            command.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = txtMaNV;
            command.Parameters.Add("@MaKH", SqlDbType.VarChar).Value = txtMaKH;
            command.Parameters.Add("@MaHD", SqlDbType.VarChar).Value = txtMaHD;
            int rowCount = command.ExecuteNonQuery();
        }
        public static void CapNhatBangHoaDon(string txtMaHD, string txtThanhToan, string txtTienDaNhan)
        {
            try
            {
                SqlConnection conn = new SqlConnection(dbConnection.HamKetNoi());
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "UpdateBangHoaDon";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = conn;
                command.Parameters.Add("@MaHD", SqlDbType.VarChar).Value = txtMaHD;
                command.Parameters.Add("@TongTien", SqlDbType.Float).Value = txtThanhToan;
                command.Parameters.Add("@TienDaNhan", SqlDbType.Float).Value = txtTienDaNhan;
                int rowCount = command.ExecuteNonQuery();
            }
            catch
            {

            }
        }
        public static void CapNhatTrangThaiBanKhiThanhToan(string txtMaBan)
        {
            SqlConnection conn = new SqlConnection(dbConnection.HamKetNoi());
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "CapNhatTrangThaiBanKhiThanhToan";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = conn;
            command.Parameters.Add("@MaBan", SqlDbType.VarChar).Value = txtMaBan;
            int rowCount = command.ExecuteNonQuery();
        }
        public static string LayTenKH(string txtMaKH)
        {
            SqlConnection conn = new SqlConnection(dbConnection.HamKetNoi());
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            SqlDataAdapter daKhachHang = new SqlDataAdapter("SELECT Ten FROM KHACHHANG WHERE MaKH='" + txtMaKH + "'", conn);
            DataTable dtKhachHang = new DataTable();
            dtKhachHang.Clear();
            daKhachHang.Fill(dtKhachHang);
            return dtKhachHang.Rows[0][0].ToString();
        }
        public static void ThemKhachHang(string txtMaKH, string txtTenKH, string txtNgaySinh, string txtSDT)
        {
            SqlConnection conn = new SqlConnection(dbConnection.HamKetNoi());
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "ThemKhachHang";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = conn;
            command.Parameters.Add("@MaKH", SqlDbType.VarChar).Value = txtMaKH;
            command.Parameters.Add("@Ten", SqlDbType.VarChar).Value = txtTenKH;
            command.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = txtNgaySinh;
            command.Parameters.Add("@SDT", SqlDbType.VarChar).Value = txtSDT;
            int rowCount = command.ExecuteNonQuery();
        }
        public static void UpdateKhachHang(string txtMaKH, string txtTenKH, string txtNgaySinh, string txtSDT)
        {
            SqlConnection conn = new SqlConnection(dbConnection.HamKetNoi());
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "UpdateKhachHang";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = conn;
            command.Parameters.Add("@MaKH", SqlDbType.VarChar).Value = txtMaKH;
            command.Parameters.Add("@Ten", SqlDbType.VarChar).Value = txtTenKH;
            command.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = txtNgaySinh;
            command.Parameters.Add("@SDT", SqlDbType.VarChar).Value = txtSDT;
            int rowCount = command.ExecuteNonQuery();
        }
    }
}
