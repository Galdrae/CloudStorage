using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CloudStorage
{
    public partial class Home_LoggedIn_ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbUserName.Text = "Hello " + Session["UserName"].ToString() + "!";
        }
    }
}