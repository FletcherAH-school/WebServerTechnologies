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
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
        
            
            //Session["userkey"] = txtHKey.Text;
            // Session["username"] = txtUserName.Text;

            
              string connection = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
             
           
              SqlConnection con = new SqlConnection(connection);
              SqlCommand cmd = new SqlCommand("select * from PAH_signup where username=@username and userkey=@userkey", con);
              cmd.Parameters.AddWithValue("@username", txtUserName.Text);
              cmd.Parameters.AddWithValue("@userkey", txtHKey.Text);
              SqlDataAdapter sda = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              sda.Fill(dt);
              con.Open();
              int i = cmd.ExecuteNonQuery();
              con.Close();
              if (dt.Rows.Count > 0)
              {
                  Session["User"] = txtUserName.Text;
                  Session.Timeout = 60; //60min
                  Session.RemoveAll();
                  //HttpCookie myCookies = new HttpCookie("LoginCookies");
                  //myCookies.Value = txtUserName.Text;
                  //myCookies.Expires = DateTime.Now.AddHours(1); // Making Cooki for 1 hour
                  //Response.Cookies.Add(myCookies);
                  Response.Redirect("homepage.aspx");
            }
              else
              {
                //Label1.Text = "You're username or password are incorrect";
                //Label1.ForeColor = System.Drawing.Color.Red;
                Response.Redirect("login.aspx");

              } 



            /*
            try
            {
                ConnectionString.Open();
                str = "select * from PAH_signup where UserName =@username  and Password =@password";
                cmd = new SqlCommand(str, con);
                cmd.Parameters.AddWithValue("@username", txtUserName.Text);
                cmd.Parameters.AddWithValue("@userkey", txtHKey.Text);

                sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    // If Username Password found in Database It will
                    // Storee Session
                    Session["User"] = txtUserName.Text;
                    Session.Timeout = 15; //15min
                                          // now Storing Cookies & config.
                    HttpCookie StudentCookies = new HttpCookie("LoginCookies");
                    LoginCookies.Value = txtUserName.Text;
                    LoginCookies.Expires = DateTime.Now.AddHours(1); // Making Cooki for 1 hour
                    Response.Cookies.Add(LoginCookies);
                    // Redirecting to Welcomepage.
                    Response.Redirect("homepage.aspx");
                }
                else
                {
                    // ErrorMessage.Text = "Invalid Username OR Password";
                    Response.Redirect("Default.aspx");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message + "<br/>" + ex.StackTrace);
            }
            finally
            {
                con.Close();
            }

          
            */

        }

    }
}




 