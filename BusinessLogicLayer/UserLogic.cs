using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;


namespace BusinessLogicLayer
{
    public class UserLogic
    {
        User user = new User();
        string errorMessage = "";

        // create user method
        public string createUser(string userName, string firstName, string lastName, string password, string dateBirth, string contactNumber, string email, string secretQuestion,
            string secretAnswer)
        {
            // Validations

            // if validations are correct
            if (errorMessage.Length == 0)
            {
                User user = new User(userName, firstName, lastName, password, dateBirth, contactNumber, email, secretQuestion,
                    secretAnswer);

                int noOfRows = 0;

                noOfRows = user.createUser();

                if (noOfRows != 0)
                {
                    errorMessage = "User Created.";
                }
                else
                    errorMessage = "Error!";
            }
            return errorMessage;
        }
    }
}
