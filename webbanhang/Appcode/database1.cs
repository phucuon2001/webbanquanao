using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using webbanhangnhom8.user;

namespace webbanhangnhom8.Appcode
{
    public class database1
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
            String sql = "select * from kho";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dongcsdl();
            return dt;
        }
        public Boolean KTmahang(String mahang)
        {
            mocsdl();
            String sql = "select * from kho where mahang='" + mahang + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dongcsdl();
            if (dt.Rows.Count > 0) return true;
            return false;
        }
        public Boolean themmoi(khohang s)
        {
            if (KTmahang(s.Mahang) == false)
            {
                mocsdl();
                string sql = "insert into kho values (@mahang, @tenhang, @ncc, @soluong, @dongianhap,@dongiaban,@chitiet,@hinhanh)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("mahang", s.Mahang);
                cmd.Parameters.AddWithValue("tenhang", s.Tenhang);
                cmd.Parameters.AddWithValue("ncc", s.Ncc);
                cmd.Parameters.AddWithValue("soluong", s.Soluong);
                cmd.Parameters.AddWithValue("dongianhap", s.Dongianhap);
                cmd.Parameters.AddWithValue("dongiaban", s.Dongiaban);
                cmd.Parameters.AddWithValue("chitiet", s.Chitiet);
                cmd.Parameters.AddWithValue("hinhanh", s.Hinhanh);
                cmd.ExecuteNonQuery();
                dongcsdl();
                return true;
            }
            return false;
        }
        public void xoahang(string mahang)
        {
            mocsdl();
            string sql = "delete from kho where mahang=@mahang";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("mahang", mahang);
            cmd.ExecuteNonQuery();
            dongcsdl();
        }
        public void sua(khohang s)
        {
            mocsdl();
            string sql = "UPDATE kho SET tenhang = @tenhang, ncc = @ncc, soluong = @soluong, dongianhap = @dongianhap,dongiaban = @dongiaban,chitiet = @chitiet,hinhanh = @hinhanh WHERE mahang = @mahang";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("mahang", s.Mahang);
            cmd.Parameters.AddWithValue("tenhang", s.Tenhang);
            cmd.Parameters.AddWithValue("ncc", s.Ncc);
            cmd.Parameters.AddWithValue("soluong", s.Soluong);
            cmd.Parameters.AddWithValue("dongianhap", s.Dongianhap);
            cmd.Parameters.AddWithValue("dongiaban", s.Dongiaban);
            cmd.Parameters.AddWithValue("chitiet", s.Chitiet);
            cmd.Parameters.AddWithValue("hinhanh", s.Hinhanh);
            cmd.ExecuteNonQuery();
            dongcsdl();
        }
        public DataTable timkiem(string mahang)
        {
            mocsdl();
            string sql = "SELECT * FROM kho WHERE mahang LIKE '%" + mahang + "%'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dongcsdl();
            return dt;
        }
    }
}