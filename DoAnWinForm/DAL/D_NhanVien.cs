using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace DAL
{
    public class D_NhanVien
    {
        public static void ThemNhanVien(string txtMaNV, string txtTenNV, string txtNgaySinhNV, string txtDiaChiNV,
         string txtsdtNV, string txtMaChiNhanh, string txtChucVuNV)
        {
            try
            {
                SqlConnection conn = new SqlConnection(dbConnection.HamKetNoi());
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "[dbo].[ThemNhanVien]";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = conn;
                command.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = txtMaNV;
                command.Parameters.Add("@Ten", SqlDbType.VarChar).Value = txtTenNV;
                command.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = txtNgaySinhNV;
                command.Parameters.Add("@DiaChi", SqlDbType.VarChar).Value = txtDiaChiNV;
                command.Parameters.Add("@SDT", SqlDbType.VarChar).Value = txtsdtNV;
                command.Parameters.Add("@MaChiNhanh", SqlDbType.VarChar).Value = txtMaChiNhanh;
                command.Parameters.Add("@LoaiNhanVien", SqlDbType.VarChar).Value = txtChucVuNV;
                command.Parameters.Add("@LuongCoBan", SqlDbType.Float).Value = "0";
                command.Parameters.Add("@LuongTheoGio", SqlDbType.Float).Value = "0";
                command.Parameters.Add("@SoGioLam", SqlDbType.Float).Value = "0";

                int rowCount = command.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
        }
        public static void SuaNhanVien(string txtMaNV, string txtTenNV, string txtNgaySinhNV, string txtDiaChiNV,
         string txtsdtNV, string txtMaChiNhanh, string txtChucVuNV)
        {
            try
            {
                SqlConnection conn = new SqlConnection(dbConnection.HamKetNoi());
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "[dbo].[UpdateNhanVien]";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = conn;
                command.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = txtMaNV;
                command.Parameters.Add("@Ten", SqlDbType.VarChar).Value = txtTenNV;
                command.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = txtNgaySinhNV;
                command.Parameters.Add("@DiaChi", SqlDbType.VarChar).Value = txtDiaChiNV;
                command.Parameters.Add("@SDT", SqlDbType.VarChar).Value = txtsdtNV;
                command.Parameters.Add("@MaChiNhanh", SqlDbType.VarChar).Value = txtMaChiNhanh;
                command.Parameters.Add("@LoaiNhanVien", SqlDbType.VarChar).Value = txtChucVuNV;
                int rowCount = command.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
        }
        /*public static void XoaVoucher(string txtMaVC)
        {
            try
            {

                SqlConnection conn = new SqlConnection(dbConnection.HamKetNoi());
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "XoaVoucher";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = conn;
                command.Parameters.Add("@MaVoucher", SqlDbType.VarChar).Value = txtMaVC;
                int rowCount = command.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
        }*/


        public static void ThemNhanVien()
        {
            throw new NotImplementedException();
        }
        public static void SuaNhanVien()
        {
            throw new NotImplementedException();
        }
        /*public static void XoaVoucher()
        {
            throw new NotImplementedException();
        }*/
    }
}
