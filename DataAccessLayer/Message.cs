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
    public class Message
    {
        // default constructor
        public Message() { }

        // constructor that takes in only userid
        public Message(String messageID)
        {
            _messageID = messageID;
        }
        // constructor that takes in all keys
        public Message(string messageID, string sentTo, string sentFrom, string subject, string message, string date, string time, string encryption)
        {
            _messageID = messageID;
            _sentTo = sentTo;
            _sentFrom = sentFrom;
            _subject = subject;
            _message = message;
            _date = date;
            _time = time;
            _encryption = encryption;
        }

        // constructor that takes in all keys except id
        public Message(string sentTo, string sentFrom, string subject, string messages, string date, string time, string encryption)
        {
            _sentTo = sentTo;
            _sentFrom = sentFrom;
            _subject = subject;
            _message = messages;
            _date = date;
            _time = time;
            _encryption = encryption;
        }

        // create message
        public int createMessage()
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "createMessage";
            cmd.Connection = connection;
            cmd.Parameters.AddWithValue("@SentTo", SentTo);
            cmd.Parameters.AddWithValue("@SentFrom", SentFrom);
            cmd.Parameters.AddWithValue("@Subject", Subject);
            cmd.Parameters.AddWithValue("@Message", Messages);
            cmd.Parameters.AddWithValue("@Date", Date);
            cmd.Parameters.AddWithValue("@Time", Time);
            cmd.Parameters.AddWithValue("@Encryption", Encryption);
            connection.Open();
            int nofRow = 0;
            nofRow = cmd.ExecuteNonQuery();
            connection.Close();
            return nofRow;
        }

        // private instance variables 
        private string _connectionString = Properties.Settings.Default.DBConnStr;
        private string _messageID = "";
        private string _sentTo = "";
        private string _sentFrom = "";
        private string _subject = "";
        private string _message = "";
        private string _date = "";
        private string _time = "";
        private string _encryption = "";

        // getters and setters
        public string MessageID { get { return _messageID; } set { _messageID = value; } }
        public string SentTo { get { return _sentTo; } set { _sentTo = value; } }
        public string SentFrom { get { return _sentFrom; } set { _sentFrom = value; } }
        public string Subject { get { return _subject; } set { _subject = value; } }
        public string Messages { get { return _message; } set { _message = value; } }
        public string Date { get { return _date; } set { _date = value; } }
        public string Time { get { return _time; } set { _time = value; } }
        public string Encryption { get { return _encryption; } set { _encryption = value; } }

    }
}
