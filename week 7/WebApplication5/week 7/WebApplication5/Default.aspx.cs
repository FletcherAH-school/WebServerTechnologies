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

namespace WebApplication5
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

          //  Response.Write("In button click");
            /// how to communicate between pages
            /// 1. QueryString
            /// 2. Cookies
            /// 3. Sessions
            /// 4. Databases

            // retrieve first name from textbox
            string FName = txtFirstName.Text;

            // retrieve last name from textbox
            string LName = txtLastName.Text;

            string HKey = txtHKey.Text;

            Users myUser = new Users();
            myUser.insertNewUser(FName, LName, HKey);


            // insert...
           // string connection = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

         //   string query = "spInsertNewUser";
          //  SqlParameter[] sqlParameters = new SqlParameter[3];
           /* sqlParameters[0] = new SqlParameter("firstname", FName);
            sqlParameters[1] = new SqlParameter("lastname", LName);
            sqlParameters[2] = new SqlParameter("coursename", courseName);
            */

            // variable for database connection
          //  SqlConnection myConnection;

           // myConnection = new SqlConnection(connection);
            // open a connection to the database
            //myConnection.Open();

           // SqlCommand myCommand = new SqlCommand(query);
          // myCommand.Connection = myConnection;
           // myCommand.CommandType = CommandType.StoredProcedure;
           // myCommand.Parameters.AddRange(sqlParameters);
            //myCommand.Parameters.Add(new SqlParameter("lastname", LName));
            //myCommand.Parameters.Add(new SqlParameter("coursename", courseName));

           // myCommand.ExecuteNonQuery();

            // what is this?
          //  myConnection.Close();
            // Response.Write(query);
            // create a cookie object
            //  HttpCookie myCookie = new HttpCookie("lastName_cook");
            // add the value to the cookie
            //  myCookie.Value = LName;
            // add the cookie to the cookies
            //            Response.Cookies.Add(myCookie);

            //          string hidden_key = txtPassword.Text;

            // added a session
            //        Session.Add("hidden_key", hidden_key);

            // Response.Write(hidden_key);

            // Response.Write("HI" + txtFirstName);

            //      Response.Redirect("SecondPage.aspx?FName=" + FName + "&blah=1");

            // always called first
            // Response.Write("HI in page load");

            // connection string, server name, username, password - here too
            // will I have to change this?
            showTable();
        }

        private void showTable()
        {
            // always called first
            // Response.Write("HI in page load");

            // connection string, server name, username, password - here too
            // will I have to change this?
            // string connection = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

            // variable for database connection
            // SqlConnection myConnection;

            // myConnection = new SqlConnection(connection);
            // open a connection to the database
            // myConnection.Open();

            //  string query = "spSelectAllUsers"; // one should feel itchy here..

            //  DataSet myDataSet = new DataSet();
            // SqlCommand myCommand = new SqlCommand(query);
            //myCommand.Connection = myConnection;
            // myCommand.CommandType = CommandType.StoredProcedure;

            // SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
            // myAdapter.Fill(myDataSet);

            // what is this?
            // myConnection.Close();

            Users myUser = new Users();
            DataSet myDataSet = myUser.getAllUsers();

            gvUsers.DataSource = myDataSet.Tables[0];
            gvUsers.DataBind();
        }
    }


}