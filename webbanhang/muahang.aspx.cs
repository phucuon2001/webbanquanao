using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webbanhangnhom8.Appcode;

namespace webbanhangnhom8.user
{
    public partial class muahang : System.Web.UI.Page
    {
        database1 db = new database1();
        void loaddata()
        {
            DataList1.DataSource = db.Traveds();
            DataList1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                loaddata();
             
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string timkiem = txttimkiem.Text;
            database1 db = new database1();
            DataList1.DataSource = db.timkiem(timkiem);
            DataList1.DataBind();

        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
      

        protected void DataList1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("giohang.aspx");
        }
    }

}