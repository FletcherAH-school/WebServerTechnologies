using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
           
            if(!Page.IsPostBack)
            {
                fillUsers();
            }
            else
            {
                
                /// this gets user id from dropdownlist
                int userLoginID = Convert.ToInt32(ddlUsers.SelectedValue);
                // prevents insert from crashing first time
                if(userLoginID > 0 && Session["userloginid"] == null)
                {
                    Session["userloginid"] = userLoginID;
                  //  Response.Write(Convert.ToBoolean(Session["dontdothis"]));
                   // if (Convert.ToBoolean(Session["dontdothis"]) == false)
                        // use this to fill textboxes
                        fillSpecificUser(userLoginID);

                }
            }
            
        }
        private void fillUsers()
        {

            Users myUser = new Users();
           

            DataSet myDataSet = myUser.getAllUsers();

            // fill our dropdown
            ddlUsers.DataSource = myDataSet.Tables[0];
            ddlUsers.DataTextField = "FullName";
            ddlUsers.DataValueField = "userLoginID";
            ddlUsers.DataBind();
          // add a choice
            ddlUsers.Items.Insert(0,new ListItem("-- choose --","-1"));

            Session["dontdothis"] = false;
        }

        private void fillSpecificUser(int userLoginID)
        {


            /// fix this so that it uses the getdata with parameters
            /// ..... you can do it!
            /// I believe in you.
            string connection = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

            // variable for database connection
            SqlConnection myConnection;

            myConnection = new SqlConnection(connection);
            // open a connection to the database
            myConnection.Open();

            string query = "SELECT FirstName, LastName, HKey, userLoginID FROM Fletcher_login WHERE userLoginID = " + userLoginID; // one should feel itchy here..

            DataSet myDataSet = new DataSet();
            SqlCommand myCommand = new SqlCommand(query);
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.Text;

            SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
            myAdapter.Fill(myDataSet);

            // what is this?
            myConnection.Close();

            txtFirstName.Text = myDataSet.Tables[0].Rows[0]["FirstName"].ToString();
            txtLastName.Text = myDataSet.Tables[0].Rows[0]["LastName"].ToString();
            txtHKey.Text = myDataSet.Tables[0].Rows[0]["HKey"].ToString();

           // Session["dontdothis"] = true;
        }

        //update stuff
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // retrieve first name from textbox
            string FName = txtFirstName.Text;

            // retrieve last name from textbox
            string LName = txtLastName.Text;

            string HKey = txtHKey.Text;

            int userLoginID = Convert.ToInt32(Session["userloginid"]);
            // insert...
            Users myUser = new Users();
            myUser.updateUser(FName, LName, HKey, userLoginID);
            
            fillUsers();

            Response.Write("Update Successful!");
            resetStuff();

            // Server.Transfer("admin.aspx");

        }

        // insert button
        protected void Button1_Click(object sender, EventArgs e)
        {
            // retrieve first name from textbox
            string FName = txtFirstName.Text;

            // retrieve last name from textbox
            string LName = txtLastName.Text;

            string HKey = txtHKey.Text;

            Users myUser = new Users();
            myUser.insertNewUser(FName, LName, HKey);

            fillUsers();

            // do something here.. to remove the contents of our textboxes
            Response.Write("Insert Successful!");
            resetStuff();
        }


        // delete
        protected void DeleteButton_Click(object sender, EventArgs e)
        {

            // retrieve first name from textbox
            string FName = txtFirstName.Text;

            // retrieve last name from textbox
            string LName = txtLastName.Text;

            string HKey = txtHKey.Text;

            int userLoginID = Convert.ToInt32(Session["userloginid"]);
            // delete?
            Users myUser = new Users();
            myUser.deleteUser(FName, LName, HKey, userLoginID);

            fillUsers();
            Response.Write("Delete Successful");
            resetStuff();
        }

        private void resetStuff()
        {
    
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtHKey.Text = "";
            Session["userloginid"] = null;
        }
    }
}