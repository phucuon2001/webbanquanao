using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace webbanhangnhom8.Appcode
{
    public class database
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
            String sql = "select * from taikhoan";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dongcsdl();
            return dt;
        }
        public Boolean KTtaikhoan(String taikhoan)
        {
            mocsdl();
            String sql = "select * from taikhoan where taikhoan='" + taikhoan + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dongcsdl();
            if (dt.Rows.Count > 0) return true;
            return false;
        }
        public Boolean themtk(dstaikhoan s)
        {
            if (KTtaikhoan(s.Taikhoan) == false)
            {
                mocsdl();
                string sql = "insert into taikhoan values (@taikhoan, @matkhau, @fullname, @gioitinh, @quyen)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("taikhoan", s.Taikhoan);
                cmd.Parameters.AddWithValue("matkhau", s.Matkhau);
                cmd.Parameters.AddWithValue("fullname", s.Fullname);
                cmd.Parameters.AddWithValue("gioitinh", s.Gioitinh);
                cmd.Parameters.AddWithValue("quyen", s.Quyen);
                cmd.ExecuteNonQuery();
                dongcsdl();
                return true;
            }
            return false;
        }
        public void xoatk(string taikhoan)
        {
            mocsdl();
            string sql = "delete from taikhoan where taikhoan=@taikhoan";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("taikhoan", taikhoan);
            cmd.ExecuteNonQuery();
            dongcsdl();
        }
        public void suatk(dstaikhoan s)
        {
            mocsdl();
            string sql = "UPDATE taikhoan SET matkhau = @matkhau, fullname = @fullname, gioitinh = @gioitinh, quyen = @quyen WHERE taikhoan = @taikhoan";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@taikhoan", s.Taikhoan);
            cmd.Parameters.AddWithValue("@matkhau", s.Matkhau);
            cmd.Parameters.AddWithValue("@fullname", s.Fullname);
            cmd.Parameters.AddWithValue("@gioitinh", s.Gioitinh);
            cmd.Parameters.AddWithValue("@quyen", s.Quyen);
            cmd.ExecuteNonQuery();
            dongcsdl();
        }
    }
}