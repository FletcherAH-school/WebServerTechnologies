using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sept9
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string txtFirstName = Request.QueryString["txtFirstName"];
           

            //get the cookie out!
            HttpCookie myCookie = Request.Cookies["lastName_cook"];
            string txtLastName = myCookie.Value;

            string hidden_key = Session["hidden_key"].ToString();  

            Response.Write(txtFirstName + " " + txtLastName + " : " + hidden_key);
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //retrieve first name from textbox control
            string txtFirstName = txtFName.Text;

            Response.Redirect("week3.aspx?txtFirstName=" + txtFirstName);

            //retrieve last name from textbox control
            string txtLastName = txtLName.Text;

            // create a cookie object
            HttpCookie myCookie = new HttpCookie("lastName_cook");
            //add the value to the cookie
            myCookie.Value = txtLastName;
            //add the cookie to the cookies
            Response.Cookies.Add(myCookie);

            
            string hidden_key = txtPassword.Text;

            //Response.Write(hidden_key);

            //add a session
            Session.Add("hidden_key", hidden_key);
        }
    }
}