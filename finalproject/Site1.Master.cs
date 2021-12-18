using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace finalproject
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            string validUserName = (string)Session["User"];
            if (validUserName == null)
            {
                
                btnMasterLogin.Visible = true;
                btnMasterSignup.Visible = true;
                btnMasterHomepage.Visible = true;
            }
            else
            {
                btnMasterLogin.Visible = false;
                btnMasterSignup.Visible = false;
                btnMasterHomepage.Visible = false;
            } 

                            /*
                        string validUserName = (string)Session["User"];



                        if ((string)Session["User"] == null) // if it will not find Session user it will redirect to login page.
                        {
                            if (Request.Cookies["LoginCookies"] != null)
                            {
                                Response.Redirect("Login.aspx");
                            }
                        }
                        else // if it will find Session it will write message on WelcomeLabel.
                        {
                            //WelcomeLabel.Text = "Hello, " + Session["User"].ToString() + "!";
                            // it will display on  WelcomeLabel
                            // Hello, MahadTECH!
                            // Now Taking Value From cookie as u wish..
                            //Label1.Text = "Its Taking from Cookies, Your name is " + Request.Cookies["LoginCookies"].Value;
                            // it will display on Label1
                            // Its Taking from Cookies, Your name is MahadTECH
                            Response.Redirect("homepage.aspx");
                       }
                        */


        }

    

        protected void Login_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void Signup_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void Homepage_Click(object sender, EventArgs e)
        {
            Response.Redirect("homepage.aspx");
        }

    }
    }
