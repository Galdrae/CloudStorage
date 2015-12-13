using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class MessageLogic
    {
        Message message = new Message();
        string errorMessage = "";

        // create user method
        public string createMessage(string sendTo, string sentFrom, string subject, string messages, string date, string time, string encryption)
        {
            // Validations

            // if validations are correct
            if (errorMessage.Length == 0)
            {
                Message message = new Message(sendTo, sentFrom, subject, messages, date, time, encryption);

                int noOfRows = 0;

                noOfRows = message.createMessage();

                if (noOfRows != 0)
                {
                    errorMessage = "Message sent!";
                }
                else
                    errorMessage = "Error!";
            }
            return errorMessage;
        }
    }
}
