using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace webbanhangnhom8.Appcode
{
    public class database2
    {
        SqlConnection con;
        public void mocsdl()
        {
            String diachi = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=nhom8;Integrated Security=True";
            con = new SqlConnection(diachi);
            con.Open();
        }
        public void dongcsdl()
        {
            con.Close();
        }
        public DataTable Traveds()
        {
            mocsdl();
            String sql = "select * from hoadon1";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dongcsdl();
            return dt;
        }
        public void xoahang(string mahang)
        {
            mocsdl();
            string sql = "delete from hoadon1 where mahang=@mahang";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("mahang", mahang);
            cmd.ExecuteNonQuery();
            dongcsdl();
        }
    }
}