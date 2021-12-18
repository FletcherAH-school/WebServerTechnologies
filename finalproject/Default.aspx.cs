using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//using System.Configuration;
//using System.Data;
//using System.Data.SqlClient;

namespace finalproject
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                // put in a loadin variable here

            }


        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            string UName = txtUserName.Text;

            // retrieve first name from textbox
            string FName = txtFirstName.Text;

            // retrieve last name from textbox
            string LName = txtLastName.Text;

            string UKey = txtHKey.Text;

            string UMail = txtEmail.Text;

            int UTypeID = Convert.ToInt32(Session["usertypeid"]);


            Users myUser = new Users();
            myUser.insertNewUser(UName, FName, LName, UKey, UMail, UTypeID);

    // Response.Redirect("homepage.aspx");


        }
 
    }

}