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

        // used for login
        public String retreivePassword(string userName)
        {
            return user.retrievePassword(userName);
        }

        // check if user exist in database
        public bool isUserExist(string userid)
        {
            return user.isUserExist(userid);
        }

        // pull user profile from database
        public User retrieveUserProfile(string userLoginName)
        {
            return user.retrieveUserProfile(userLoginName);
        }
    }
}
