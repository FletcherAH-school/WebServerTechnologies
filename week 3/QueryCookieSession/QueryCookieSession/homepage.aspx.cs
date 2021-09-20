using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QueryCookieSession
{
    public partial class homepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnter_Click(object sender, EventArgs e)
        {
            ///////////// pulling info from txt boxes 
            string fName = txtFirstName.Text;
            string lName = txtLastName.Text;

            ///////////// Cookie 
            HttpCookie myCookie = new HttpCookie("lastName_cook");
            myCookie.Value = lName;
            Response.Cookies.Add(myCookie);

            ///////////// Session x Password
            string hKey = txtPassword.Text;
            Session.Add("hKey", hKey);

            ////// query print
            Response.Redirect("page2.aspx?txtName=" + fName + " " + lName);

            

        }


        protected void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}