using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using CloudStorage.Models;
using DataAccessLayer;
using BusinessLogicLayer;

namespace CloudStorage.Account
{
    public partial class Register : Page
    {
        protected void CreateUser_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            UserLogic userLogic = new UserLogic();

            errorMessage = userLogic.createUser(tbUserName.Text, tbFirstName.Text, tbLastName.Text, tbPassword.Text, tbBirthDate.Text,
                tbContactNo.Text, tbEmail.Text, ddlSecretQuestion.Text, tbSecretAnswer.Text);

            lbErrorMessage.Text = errorMessage;

            if (lbErrorMessage.Text == "User Created.") { Response.Redirect("Login.aspx"); }
        }
    }
}