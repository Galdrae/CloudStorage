using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using BusinessLogicLayer;

namespace CloudStorage
{
    public partial class Message : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            // string sendTo, recipient, subject, message, dateTime, encryption;
            string errorMessage = "";
            string date, time;

            date = System.DateTime.Today.ToString("dd MMMM, yyyy");
            time = System.DateTime.Now.ToString("h.mm tt");

            MessageLogic messageLogic = new MessageLogic();

            errorMessage = messageLogic.createMessage(tbSendTo.Text, Session["UserName"].ToString(), tbSubject.Text, tbMessage.Text,
                System.DateTime.Today.ToString("dd MMMM, yyyy"), time, "test");

            lbMessage.Text = errorMessage;

        }
        protected void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}