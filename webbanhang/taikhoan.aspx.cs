using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webbanhangnhom8.Appcode;

namespace webbanhangnhom8
{
    public partial class taikhoan : System.Web.UI.Page
    {
        database db = new database();
        void loaddata()
        {
            dgv.DataSource = db.Traveds();
            dgv.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loaddata();
            }
        }

        protected void Thêm_Click(object sender, EventArgs e)
        {
            String taikhoan = txttk.Text;
            String matkhau = txtmk.Text;
            String fullname = txthoten.Text;
            String gioitinh = txtgt.Text;
            String quyen = txtquyen.Text;
            dstaikhoan s = new dstaikhoan(taikhoan, matkhau, fullname, gioitinh, quyen);
            if (db.themtk(s) == true)
            {
                Label1.Text = "Thêm thành công";
                loaddata();
            }
            else
            {
                Label1.Text = "Tài khoản này đã tồn tại";
            }
        }

        protected void dgv_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label lbltaikhoan = (Label)dgv.Rows[e.RowIndex].FindControl("Label1");
            string taikhoan = lbltaikhoan.Text;
            db.xoatk(taikhoan);
            Label1.Text = "Xóa Thành Công";
            loaddata();
        }

        protected void dgv_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow && dgv.EditIndex == -1)
            {
                ((LinkButton)e.Row.Cells[5].Controls[2]).OnClientClick = "return confirm('Bạn chắc chắn muốn xóa tài khoản này không'); ";
            }
        }

        protected void dgv_RowEditing(object sender, GridViewEditEventArgs e)
        {
            dgv.EditIndex = e.NewEditIndex;
            loaddata();
        }

        protected void dgv_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            dgv.EditIndex = -1;
            loaddata();
        }

        protected void dgv_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label lbltaikhoan = (Label)dgv.Rows[e.RowIndex].FindControl("Label1");
            string taikhoan = lbltaikhoan.Text;
            String matkhau = ((TextBox)dgv.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
            String fullname = ((TextBox)dgv.Rows[e.RowIndex].Cells[2].Controls[0]).Text;
            string gioitinh = ((TextBox)dgv.Rows[e.RowIndex].Cells[3].Controls[0]).Text;
            //DropDownList DropDownList1 = new DropDownList();
            //DropDownList1.Items.Add(gioitinh);
            String quyen = ((TextBox)dgv.Rows[e.RowIndex].Cells[4].Controls[0]).Text;
            dstaikhoan s = new dstaikhoan(taikhoan, matkhau, fullname, gioitinh, quyen);
            db.suatk(s);
            dgv.EditIndex = -1;
            Label1.Text = "Sửa thành công";
            loaddata();
        }

        protected void Thoát_Click(object sender, EventArgs e)
        {
            Response.Redirect("quanli.aspx");
        }
    }
}