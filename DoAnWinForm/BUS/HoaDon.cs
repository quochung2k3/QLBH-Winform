using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HoaDon
    {
        public static string autoMaHoaDon()
        {
            SqlConnection Conn = new SqlConnection(dbConnection.HamKetNoi());
            if (Conn.State == ConnectionState.Open)
                Conn.Close();
            Conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT [dbo].[AUTO_MAHD]()";
            command.Connection= Conn;
            string cmd = command.ExecuteScalar().ToString();
            Conn.Close();
            return cmd;
        }
    }
}
