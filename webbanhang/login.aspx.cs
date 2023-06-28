using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webbanhangnhom8
{
    public partial class login : System.Web.UI.Page
    {
        public static string mod = "";
        SqlConnection sqlcon;
        public void connect()
        {
            string ketnoi;
            ketnoi = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=nhom8;Integrated Security=True";
            sqlcon = new SqlConnection();
            sqlcon.ConnectionString = ketnoi;
            sqlcon.Open();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string user = txttdn.Text;
            string pass = txtmk.Text;
            if (user == "")
            {
                Label3.Text="Tài Khoản không được để trống, Bạn hãy nhập vào!";
                txttdn.Focus();
            }
            else

               if (pass == "")
            {
                Label3.Text="Mật khẩu không được để trống, Bạn hãy nhập vào!";
                txtmk.Focus();
            }
            else
            {
                try
                {
                    connect();
                    string sql;
                    sql = "select * from taikhoan where taikhoan='" + user + "' and matkhau='" + pass + "'";
                    SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                    SqlDataReader sqldr = sqlcom.ExecuteReader();
                    DataTable dt = new DataTable();
                    if (sqldr.Read() == true)
                    {
                        string role = sqldr.GetString(4);
                        if (role == "admin")
                        {
                            Response.Redirect("quanli.aspx");
                        }
                        else if (role == "user")
                        {
                            Response.Redirect("muahang.aspx");
                        }

                    }
                    else
                    {
                        Label3.Text="Sai tài khoản hoặc mật khẩu,kiểm tra lại";
                       
                        txttdn.Focus();
                    }
                }
                catch (Exception ex)
                {
                    Label3.Text="Bạn chưa đăng nhập thành công, có thể tài khoản chưa có, hoặc sai tên đăng nhập hoặc mật khẩu";
                }
                finally
                {
                    sqlcon.Close();
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("dangky.aspx");
        }
    }
}