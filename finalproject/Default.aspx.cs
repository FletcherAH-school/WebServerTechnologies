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
                Response.Write("Here");
                showTable();

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

            int UAddID = Convert.ToInt32(Session["useraddressid"]);

            int UTypeID = Convert.ToInt32(Session["usertypeid"]);



            Users myUser = new Users();
            myUser.insertNewUser(UName, FName, LName, UKey, UMail, UAddID, UTypeID);


            showTable();
        }

        private void showTable()
        {
            Users myUser = new Users();
            DataSet myDataSet = myUser.getAllUsers();

            gvUsers.DataSource = myDataSet.Tables[0];
            gvUsers.DataBind();
        }
    }


}