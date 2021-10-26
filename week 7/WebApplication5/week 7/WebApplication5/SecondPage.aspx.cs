using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class SecondPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string FName = Request.QueryString["FName"];
            string blah = Request.QueryString["blah"];

            // get the cookie out!
            HttpCookie myCookie = Request.Cookies["lastName_cook"];
            string LName = myCookie.Value;

            string hidden_key = Session["hidden_key"].ToString();

            Response.Write(FName + ":" + blah + ":" + LName + ":" + hidden_key);

          //  Response.Redirect("Default.aspx");
        }
    }
}