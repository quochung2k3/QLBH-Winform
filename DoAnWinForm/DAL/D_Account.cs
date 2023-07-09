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
    public class D_Account
    {

        public static void ThemAccount(string txtUsername, string txtPass, string txtLoaiTK, string txtMaNV)
        {
            try
            {
                SqlConnection conn = new SqlConnection(dbConnection.HamKetNoi());
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "ThemmAccount";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = conn;
                command.Parameters.Add("@Username", SqlDbType.VarChar).Value = txtUsername;
                command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = txtPass;
                command.Parameters.Add("@Type", SqlDbType.Int).Value = txtLoaiTK;
                command.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = txtMaNV;

                /*    command.Parameters.Add("@LuongCoBan", SqlDbType.Float).Value = 0;*/
                int rowCount = command.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
        }
        public static void SuaAccount(string txtUsername, string txtPass, string txtLoaiTK, string txtMaNV)
        {
            try
            {
                SqlConnection conn = new SqlConnection(dbConnection.HamKetNoi());
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "SuaAccount";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = conn;
                command.Parameters.Add("@Username", SqlDbType.VarChar).Value = txtUsername;
                command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = txtPass;
                command.Parameters.Add("@Type", SqlDbType.Int).Value = txtLoaiTK;
                command.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = txtMaNV;
                int rowCount = command.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
        }

        public static void XoaAccount(string txtUsername)
        {
            try
            {

                SqlConnection conn = new SqlConnection(dbConnection.HamKetNoi());
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "XoaAccount";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = conn;
                command.Parameters.Add("@Username", SqlDbType.VarChar).Value = txtUsername;
                int rowCount = command.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
        }
        public static void ThemAccount()
        {
            throw new NotImplementedException();
        }
        public static void SuaAccount()
        {
            throw new NotImplementedException();
        }
        public static void XoaAccount()
        {
            throw new NotImplementedException();
        }
    }
}
