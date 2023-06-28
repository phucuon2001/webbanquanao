using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webbanhangnhom8.Appcode;

namespace webbanhangnhom8
{
    public partial class dangky : System.Web.UI.Page
    {
        database db = new database();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        

        protected void Button1_Click(object sender, EventArgs e)
        {
            String taikhoan = txttk.Text;
            String matkhau = txtmk.Text;
            String fullname = txthoten.Text;
            String gioitinh = txtgt.Text;
            String quyen = txtquyen.Text;
            dstaikhoan s = new dstaikhoan(taikhoan, matkhau, fullname, gioitinh, quyen);
            if (db.themtk(s) == true)
            {
                Label1.Text = "Đăng kí thành công";
            }
            else
            {
                Label1.Text = "Tài khoản này đã tồn tại";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
    }
}