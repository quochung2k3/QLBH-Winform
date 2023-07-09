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
    public class D_Ban
    {
        public static DataTable getData(string cmd)
        {
            SqlConnection conn = new SqlConnection(dbConnection.HamKetNoi());
            if (conn.State == ConnectionState.Open)
                conn.Open();
            SqlDataAdapter daBan = new SqlDataAdapter(cmd, conn);
            DataTable dtBan = new DataTable();
            dtBan.Clear();
            daBan.Fill(dtBan);
            return dtBan;
        }
        public static void ThemBan(string txtMaBan, string txtTenBan, string txtMaKV)
        {
            try
            {
                SqlConnection conn = new SqlConnection(dbConnection.HamKetNoi());
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "[dbo].[ThemBan]";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = conn;
                command.Parameters.Add("@MaBan", SqlDbType.VarChar).Value = txtMaBan;
                command.Parameters.Add("@TenBan", SqlDbType.VarChar).Value = txtTenBan;
                command.Parameters.Add("@MaKV", SqlDbType.VarChar).Value = txtMaKV;
                command.Parameters.Add("@TrangThai", SqlDbType.VarChar).Value = "Trống";
                int rowCount = command.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
        }
        public static void CapnhatBan(string txtTenBan, string txtMaKV)
        {
            try
            {
                SqlConnection conn = new SqlConnection(dbConnection.HamKetNoi());
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "[dbo].[CapnhatBan]";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = conn;
                command.Parameters.Add("@TenBan", SqlDbType.VarChar).Value = txtTenBan;
                command.Parameters.Add("@MaKV", SqlDbType.VarChar).Value = txtMaKV;
                int rowCount = command.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
        }
    }
}


