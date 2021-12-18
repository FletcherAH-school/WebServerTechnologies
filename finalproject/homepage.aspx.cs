using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace finalproject
{
    public partial class homepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void GotoSignup_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }


        protected void GotoLognin_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
    }
}