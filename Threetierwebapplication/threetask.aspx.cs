using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace Threetierwebapplication
{
    public partial class threetask : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            CLSBUSSLayer objBLL = new CLSBUSSLayer();
            objBLL.InsertUser(txtname.Text, txtcity.Text, txtemail.Text);
            GridView1.DataSource = objBLL.SelectUser();
            GridView1.DataBind();

        }
    }
}