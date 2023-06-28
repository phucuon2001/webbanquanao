using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webbanhangnhom8.Appcode;
using webbanhangnhom8.user;

namespace webbanhangnhom8
{
    public partial class kho : System.Web.UI.Page
    {
        database1 db = new database1();
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
            String mahang = txtma.Text;
            String tenhang = txtten.Text;
            String ncc = txtncc.Text;
            int soluong = int.Parse(txtsl.Text);
            int dongianhap = int.Parse(txtdgnhap.Text);
            int dongiaban = int.Parse(txtdgban.Text);
            String chitiet = txtchitiet.Text;
            String hinhanh = txtha.FileName;
            khohang s = new khohang(mahang, tenhang, ncc, soluong, dongianhap, dongiaban, chitiet, hinhanh);
            if(db.themmoi(s) == true)
            {
                Label1.Text = "Thêm thành công";
                loaddata();
            }
            else
            {
                Label1.Text = "Đã tồn tại";
            }



        }

        protected void Thoát_Click(object sender, EventArgs e)
        {
            Response.Redirect("quanli.aspx");
        }

        protected void dgv_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label lblkho = (Label)dgv.Rows[e.RowIndex].FindControl("Label1");
            string khohang = lblkho.Text;
            db.xoahang(khohang);
            Label1.Text = "Xóa Thành Công";
            loaddata();
        }

        protected void dgv_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow && dgv.EditIndex == -1)
            {
                ((LinkButton)e.Row.Cells[8].Controls[2]).OnClientClick = "return confirm('Bạn chắc chắn muốn xóa không'); ";
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
            Label lblkho = (Label)dgv.Rows[e.RowIndex].FindControl("Label1");
            string mahang = lblkho.Text;
            String tenhang = ((TextBox)dgv.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
            String ncc = ((TextBox)dgv.Rows[e.RowIndex].Cells[2].Controls[0]).Text;
            string soluong = ((TextBox)dgv.Rows[e.RowIndex].Cells[3].Controls[0]).Text;
            int soluong1 = int.Parse(soluong);
            string dongianhap = ((TextBox)dgv.Rows[e.RowIndex].Cells[4].Controls[0]).Text;
            int dongianhap1 = int.Parse(dongianhap);
            string dongiaban = ((TextBox)dgv.Rows[e.RowIndex].Cells[5].Controls[0]).Text;
            int dongiaban1 = int.Parse(dongiaban);
            string chitiet = ((TextBox)dgv.Rows[e.RowIndex].Cells[6].Controls[0]).Text;
            string hinhanh = "";
            FileUpload fuHinhAnh = (FileUpload)dgv.Rows[e.RowIndex].FindControl("fuHinhAnh");
            if (fuHinhAnh.HasFile)
            {
                hinhanh = Guid.NewGuid().ToString() + Path.GetExtension(fuHinhAnh.FileName);
                fuHinhAnh.SaveAs(Server.MapPath("~/anh/" + hinhanh));
            }
            else
            {
                HiddenField hfHinhAnh = (HiddenField)dgv.Rows[e.RowIndex].FindControl("hfHinhAnh");
                hinhanh = hfHinhAnh.Value;
            }
            khohang s = new khohang(mahang, tenhang, ncc, soluong1, dongianhap1, dongiaban1, chitiet, hinhanh);
            db.sua(s);
            dgv.EditIndex = -1;
            Label1.Text = "Sua thanh cong";
            loaddata();

        }
    }
}