using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace finalproject 
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
           
            if(!Page.IsPostBack)
            {
                fillUsers();
                showTable();
            }
            else
            {
                
                /// this gets user id from dropdownlist
                int userID = Convert.ToInt32(ddlUsers.SelectedValue);
                // prevents insert from crashing first time
                if(userID > 0 && Session["userid"] == null)
                {
                    Session["userid"] = userID;
                  //  Response.Write(Convert.ToBoolean(Session["dontdothis"]));
                   // if (Convert.ToBoolean(Session["dontdothis"]) == false)
                        // use this to fill textboxes
                        fillSpecificUser(userID);

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
            ddlUsers.DataValueField = "userID";
            ddlUsers.DataBind();
          // add a choice
            ddlUsers.Items.Insert(0,new ListItem("-- choose --","-1"));

            Session["dontdothis"] = false;
        }

        private void fillSpecificUser(int userID)
        {


            /// fix this so that it uses the getdata with parameters
            string connection = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

            // variable for database connection
            SqlConnection myConnection;

            myConnection = new SqlConnection(connection);
            // open a connection to the database
            myConnection.Open();

            string query = "SELECT firstname, lastname, userkey, userid, usertypeid, useremail, username FROM PAH_signup WHERE userID = " + userID; // one should feel itchy here..

            DataSet myDataSet = new DataSet();
            SqlCommand myCommand = new SqlCommand(query);
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.Text;

            SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
            myAdapter.Fill(myDataSet);

            // what is this?
            myConnection.Close();

            txtFirstName.Text = myDataSet.Tables[0].Rows[0]["firstName"].ToString();
            txtLastName.Text = myDataSet.Tables[0].Rows[0]["lastName"].ToString();
            txtHKey.Text = myDataSet.Tables[0].Rows[0]["userKey"].ToString();
            txtUserType.Text = myDataSet.Tables[0].Rows[0]["usertypeid"].ToString();
            txtUserEmail.Text = myDataSet.Tables[0].Rows[0]["useremail"].ToString();
            txtUserName.Text = myDataSet.Tables[0].Rows[0]["username"].ToString();

            // Session["dontdothis"] = true;
        }

        //update stuff
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // retrieve first name from textbox
            string FName = txtFirstName.Text;

            // retrieve last name from textbox
            string LName = txtLastName.Text;

            string UKey = txtHKey.Text;

            string UName = txtUserName.Text;

            string UMail = txtUserEmail.Text;

            int UTypeID = Convert.ToInt32(Session["usertypeid"]);

            int UserID = Convert.ToInt32(Session["userid"]);


            //string UAddID = txtUserAddress.Text;

            // insert...
            Users myUser = new Users();
            myUser.updateUser(UName, FName, LName, UKey, UMail, UTypeID, UserID);
            
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

            string UKey = txtHKey.Text;

            string UName = txtUserName.Text;

            string UMail = txtUserEmail.Text;

            //string UAddID = txtUserAddress.Text;

            int UTypeID = Convert.ToInt32(Session["usertypeid"]);

            Users myUser = new Users();
            myUser.insertNewUser(UName, FName, LName, UKey, UMail, UTypeID);

            fillUsers();

            // do something here.. to remove the contents of our textboxes
            Response.Write("Insert Successful!");
            resetStuff();
        }


        // delete
        protected void DeleteButton_Click(object sender, EventArgs e)
        {


            //string UKey = txtHKey.Text;

            int userID = Convert.ToInt32(Session["userid"]);
            // delete?
            Users myUser = new Users();
            myUser.deleteUser(userID);

            fillUsers();
            Response.Write("Delete Successful");
            resetStuff();
        }

        private void showTable()
        {
            Users myUser = new Users();
            DataSet myDataSet = myUser.getAllUsers();

            gvUsers.DataSource = myDataSet.Tables[0];
            gvUsers.DataBind();
        }

        private void resetStuff()
        {
    
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtHKey.Text = "";
            txtUserName.Text = "";
            txtUserEmail.Text = "";
            txtUserType.Text = "";
            Session["userid"] = null;
        }

    }
}