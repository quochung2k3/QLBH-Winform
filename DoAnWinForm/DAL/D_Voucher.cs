using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class D_Voucher
    {

        public static string TimKiemVoucher(string txtMaVC)
        {
            SqlConnection conn = new SqlConnection(dbConnection.HamKetNoi());
            SqlDataAdapter daNhanVien = new SqlDataAdapter("-SELECT * FROM TimKiemVoucher('" + txtMaVC + "'", conn);
            DataTable dtNhanVien = new DataTable();
            dtNhanVien.Clear();
            daNhanVien.Fill(dtNhanVien);
            return dtNhanVien.Rows[0][0].ToString();
        }
        public static void ThemVoucher(string txtMaVC, string txtTenVC, string txtPTGiam, string txtNgayBD,
            string txtNgayKT, string txtSoLuong)
        {
            try
            {
                SqlConnection conn = new SqlConnection(dbConnection.HamKetNoi());
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "spThemVoucher";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = conn;
                command.Parameters.Add("@MaVoucher", SqlDbType.VarChar).Value = txtMaVC;
                command.Parameters.Add("@TenVoucher", SqlDbType.VarChar).Value = txtTenVC;
                command.Parameters.Add("@PhanTramGiam", SqlDbType.Float).Value = txtPTGiam;
                command.Parameters.Add("@NgayBatDau", SqlDbType.DateTime).Value = txtNgayBD;
                command.Parameters.Add("@NgayKetThuc", SqlDbType.DateTime).Value = txtNgayKT;
                command.Parameters.Add("@SoLuong", SqlDbType.Int).Value = txtSoLuong;
                int rowCount = command.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
        }
        public static void SuaVoucher(string txtMaVC, string txtTenVC, string txtPTGiam, string txtNgayBD,
            string txtNgayKT, string txtSoLuong)
        {
            try
            {
                SqlConnection conn = new SqlConnection(dbConnection.HamKetNoi());
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "SuaVoucher";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = conn;
                command.Parameters.Add("@MaVoucher", SqlDbType.VarChar).Value = txtMaVC;
                command.Parameters.Add("@TenVoucher", SqlDbType.VarChar).Value = txtTenVC;
                command.Parameters.Add("@PhanTramGiam", SqlDbType.Float).Value = txtPTGiam;
                command.Parameters.Add("@NgayBatDau", SqlDbType.DateTime).Value = txtNgayBD;
                command.Parameters.Add("@NgayKetThuc", SqlDbType.DateTime).Value = txtNgayKT;
                command.Parameters.Add("@SoLuong", SqlDbType.Int).Value = txtSoLuong;
                int rowCount = command.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
        }
        public static void XoaVoucher(string txtMaVC)
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
        }


        public static void ThemVoucher()
        {
            throw new NotImplementedException();
        }
        public static void SuaVoucher()
        {
            throw new NotImplementedException();
        }
        public static void XoaVoucher()
        {
            throw new NotImplementedException();
        }

    }
}
