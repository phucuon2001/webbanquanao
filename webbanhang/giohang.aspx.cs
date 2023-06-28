using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webbanhangnhom8
{
    public partial class giohang : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Cart"] != null)
                {
                    DataTable cart = (DataTable)Session["Cart"];
                    foreach (DataRow row in cart.Rows)
                    {
                        int soluong = Convert.ToInt32(row["soluong"]);
                        int dongia = Convert.ToInt32(row["dongia"]);
                        int thanhtien = soluong * dongia;
                        row["thanhtien"] = thanhtien;
                    }
                    GridView1.DataSource = cart;
                    GridView1.DataBind();

                    decimal totalPrice = 0;
                    foreach (GridViewRow row in GridView1.Rows)
                    {
                        decimal rowTotal = decimal.Parse(row.Cells[3].Text);
                        totalPrice += rowTotal;
                    }
                    lblTotalPrice.Text = "Tổng tiền: " + totalPrice.ToString();
                }
             }
        }
      



        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=nhom8;Integrated Security=True";

            foreach (GridViewRow row in GridView1.Rows)
            {
                string mahang = row.Cells[0].Text;
                int soluong = Convert.ToInt32(row.Cells[1].Text);
                int dongia = Convert.ToInt32(row.Cells[2].Text);
                int thanhtien = Convert.ToInt32(row.Cells[3].Text);
                string hinhanh = ((Image)row.FindControl("Image1")).ImageUrl;

            
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("INSERT INTO hoadon1 (mahang, soluong,dongia,thanhtien, hinhanh) VALUES (@mahang,  @soluong,@dongia,@thanhtien, @hinhanh)", connection);
                    command.Parameters.AddWithValue("@mahang", mahang);
                    command.Parameters.AddWithValue("@soluong", soluong);
                    command.Parameters.AddWithValue("@dongia", dongia);
                    command.Parameters.AddWithValue("@thanhtien", thanhtien);
                    command.Parameters.AddWithValue("@hinhanh", hinhanh);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            Response.Redirect("thanhcong.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("muahang.aspx");
        }
    }
}