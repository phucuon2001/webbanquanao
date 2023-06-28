using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webbanhangnhom8.user;

namespace webbanhangnhom8
{
    public partial class chitietsanpham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=nhom8;Integrated Security=True");
            conn.Open();
            string query = "SELECT * FROM kho WHERE mahang = @mahang";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@mahang", Request.QueryString["mahang"]);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Image1.ImageUrl = "~/anh/" + reader["hinhanh"].ToString();
                txtmahang.Text =   reader["mahang"].ToString();
                txttenhang.Text =  reader["tenhang"].ToString();
                txtchitiet.Text =  reader["chitiet"].ToString();           
                txtdongia.Text = reader["dongiaban"].ToString();
                reader.Close();
                conn.Close();
            }    
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string mahang = txtmahang.Text;
            int soluong = Convert.ToInt32(txtsoluong.Text);
            int dongia = Convert.ToInt32(txtdongia.Text);
            string hinhanh = Image1.ImageUrl;
            if (Session["Cart"] == null)
            {
               
                DataTable cart = new DataTable();
                cart.Columns.Add("mahang");
                cart.Columns.Add("soluong");
                cart.Columns.Add("dongia");
                cart.Columns.Add("hinhanh");
                cart.Columns.Add("thanhtien");
                int thanhtien = soluong * dongia;

                cart.Rows.Add(mahang,soluong, dongia, hinhanh, thanhtien);

               
                Session["Cart"] = cart;
            }
            else
            {

               DataTable cart = (DataTable)Session["Cart"];
                int thanhtien = soluong * dongia;
                cart.Rows.Add(mahang, soluong, dongia, hinhanh, thanhtien);
                Session["Cart"] = cart;
            }

       
            Response.Redirect("giohang.aspx");
        }
    }    
}
