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
        public User(string userid, string userName, string firstName, string lastName, string password, string dateBirth, string contactNumber, string email, string secretQuestion,
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
            _secretQuestion = secretQuestion;
            _secretAnswer = secretAnswer;
        }

        // constructor that takes in all keys except id
        public User(string userName, string firstName, string lastName, string password, string dateBirth, string contactNumber, string email, string secretQuestion,
            string secretAnswer)
        {
            _userName = userName;
            _firstName = firstName;
            _lastName = lastName;
            _password = password;
            _dateBirth = dateBirth;
            _contactNumber = contactNumber;
            _email = email;
            _secretQuestion = secretQuestion;
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
            cmd.Parameters.AddWithValue("@SecretQuestion", SecretQuestion);
            cmd.Parameters.AddWithValue("@SecretAnswer", SecretAnswer);
            connection.Open();
            int nofRow = 0;
            nofRow = cmd.ExecuteNonQuery();
            connection.Close();
            return nofRow;
        }

        // retrieve password base on UserName
        public string retrievePassword(string inUserName)
        {
            string password = null;
            try
            {
                SqlConnection connection = new SqlConnection(_connectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "retrievePasswordForLogin";
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@UserName", inUserName);
                connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    password = dr["Password"].ToString();
                }
                dr.Close();
                dr.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return password;
        }

        // check if user exist in database 
        public bool isUserExist(string inUserName)
        {
            bool isUserPresent = false;
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "isUserExist";
            cmd.Connection = connection;
            cmd.Parameters.AddWithValue("@UserName", inUserName);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                isUserPresent = true;
            }
            dr.Close();
            dr.Dispose();
            connection.Close();
            return isUserPresent;
        }

        // retrieve user profile base on user login name
        public User retrieveUserProfile(string inUserName)
        {
            string userid, userName, firstName, dateBirth, lastName, password, contactNumber, email, secretQuestion,
                secretAnswer;

            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "retrieveUserProfile";
            cmd.Connection = connection;
            cmd.Parameters.AddWithValue("@UserName", inUserName);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                userid = dr["UserID"].ToString();
                userName = dr["UserName"].ToString();
                firstName = dr["FirstName"].ToString();
                lastName = dr["LastName"].ToString();
                password = dr["Password"].ToString();
                dateBirth = dr["DateBirth"].ToString();
                contactNumber = dr["ContactNumber"].ToString();
                email = dr["Email"].ToString();
                secretQuestion = dr["SecretQuestion"].ToString();
                secretAnswer = dr["SecretAnswer"].ToString();

                User user = new User(userid, userName, firstName, lastName, password, dateBirth, contactNumber, email, secretQuestion,
                secretAnswer);
                dr.Close();
                dr.Dispose();
                connection.Close();
                return user;
            }
            return new User();
        }

        // private instance variables 
        private string _connectionString = Properties.Settings.Default.DBConnStr;
        private string _userID = "";
        private string _userName = "";
        private string _firstName = "";
        private string _lastName = "";
        private string _password = "";
        private string _dateBirth = "";
        private string _contactNumber = "";
        private string _email = "";
        private string _secretQuestion = "";
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
        public string SecretQuestion { get { return _secretQuestion; } set { _secretQuestion = value; } }
        public string SecretAnswer { get { return _secretAnswer; } set { _secretAnswer = value; } }

    }
}
