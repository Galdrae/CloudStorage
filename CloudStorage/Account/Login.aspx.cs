using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using CloudStorage.Models;
using DataAccessLayer;
using BusinessLogicLayer;

namespace CloudStorage.Account
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["NoLoginMessage"] != null) { lbMessage.Text = Session["NoLoginMessage"].ToString(); }

            // clear messages
            if (!IsPostBack)
            {
                Session.Abandon();
            }
        }

        protected void LogIn(object sender, EventArgs e)
        {
            // Attribute declaration for controls
            string userName;
            string password;

            // Initilize controls
            userName = tbUserName.Text;
            password = tbPassword.Text;

            // Call method from logic class
            UserLogic userLogic = new UserLogic();

            // Check if user exist in database
            if (!userLogic.isUserExist(userName))
            {
                lbMessage.Text = "Wrong login name or password.";
            }
            else if (password != userLogic.retreivePassword(userName))
            {
                lbMessage.Text = "Wrong username or password.";
            }
            // if correct password
            else if (password == userLogic.retreivePassword(userName))
            {
                // retrieve data from database and store in session
                User user = userLogic.retrieveUserProfile(userName);
                // These are individual fields from database that can be used to pass around.
                // *NOTE* Session duration is currently set at 20 mins after idle,
                // after which it will clear all sessions and force user to relog.
                // change settings at web.config file
                Session["UserID"] = user.UserID;
                Session["UserName"] = user.UserName;

                lbMessage.Text = "Logged In";
                Response.Redirect("~/Home(LoggedIn).aspx");
            }
        }
    }
}