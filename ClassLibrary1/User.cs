using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccessLayer
{
    public class User
    {
        // default constructor
        public User() { }

        // constructor that takes in only userid
        public User(String userid)
        {
            _userID = userid;
        }

        // constructor that takes in all keys
        public User(string userid, string userName, string firstName, string lastName, string password, string dateBirth, string contactNumber, string email,
            string secretAnswer)
        {
            _userID = userid;
            _userName = userName;
            _firstName = firstName;
            _lastName = lastName;
            _password = password;
            _dateBirth = dateBirth;
            _contactNumber = contactNumber;
            _email = email;
            _secretAnswer = secretAnswer;
        }

        // constructor that takes in all keys except id
        public User(string userName, string firstName, string lastName, string password, string dateBirth, string contactNumber, string email,
            string secretAnswer)
        {
            _userName = userName;
            _firstName = firstName;
            _lastName = lastName;
            _password = password;
            _dateBirth = dateBirth;
            _contactNumber = contactNumber;
            _email = email;
            _secretAnswer = secretAnswer;
        }

        // Insert User
        public int createUser()
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "createUser";
            cmd.Connection = connection;
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@DateBirth", DateBirth);
            cmd.Parameters.AddWithValue("@ContactNumber", ContactNumber);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@SecretAnswer", SecretAnswer);
            connection.Open();
            int nofRow = 0;
            nofRow = cmd.ExecuteNonQuery();
            connection.Close();
            return nofRow;
        }

        // private instance variables 
        // private string oldConnectionString = Properties.Settings.Default.DBConnStr;
        private string _connectionString = ConfigurationManager.ConnectionStrings["DbConnectionString"].ToString();
        private string _userID = "";
        private string _userName = "";
        private string _firstName = "";
        private string _lastName = "";
        private string _password = "";
        private string _dateBirth = "";
        private string _contactNumber = "";
        private string _email = "";
        private string _secretAnswer = "";

        // getters and setters
        public string UserID { get { return _userID; } set { _userID = value; } }
        public string UserName { get { return _userName; } set { _userName = value; } }
        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        public string LastName { get { return _lastName; } set { _lastName = value; } }
        public string Password { get { return _password; } set { _password = value; } }
        public string DateBirth { get { return _dateBirth; } set { _dateBirth = value; } }
        public string ContactNumber { get { return _contactNumber; } set { _contactNumber = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string SecretAnswer { get { return _secretAnswer; } set { _secretAnswer = value; } }

    }
}
