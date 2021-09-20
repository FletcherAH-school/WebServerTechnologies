using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QueryCookieSession
{
    public partial class page2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string FName = Request.QueryString["txtName"];

            //////// get cookie
            HttpCookie myCookie = Request.Cookies["lastName_cook"];
            string lName = myCookie.Value;

            //////// get session 
            string hKey = Session["hKey"].ToString();

            Response.Write(FName + " : " + lName);
        }
    }
}
