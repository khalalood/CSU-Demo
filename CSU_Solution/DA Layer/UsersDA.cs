using CSU_Solution.PD_Layer;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSU_Solution.Helper;

namespace CSU_Solution.DA_Layer
{
    public static class UsersDA
    {
        private static MySqlCommand cmd = null;
        private static DataTable dt;
        private static MySqlDataAdapter sda;

        public static Users RetrieveUser(string username)
        {
            string query = "SELECT * FROM mydb.users where userName = (@username) limit 1";
            cmd = DBHelper.RunQuery(query, username);
            Users aUser = null;
            if(cmd != null)
            {
                dt = new DataTable();
                sda = new MySqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach(DataRow dr in dt.Rows)
                {
                    string uName = dr["username"].ToString();
                    string password = dr["password"].ToString();
                    aUser = new Users(uName, password);
                }
            }
            return aUser;
        }

        public static void SubmitRequest(Request aRequest)
        {
            string query = "INSERT INTO mydb.Request(clubname, numatt  ) VALUES (@cn, @na)";
            MySqlCommand cmd = new MySqlCommand();
            if (DBHelper.Connetion != null)
            {
                cmd = DBHelper.Connetion.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@cn", aRequest.CLUBNAME);
                cmd.Parameters.AddWithValue("@na", aRequest.NUMBERATT);

                DBHelper.ExecuteCommand(cmd);
            }
        }

        public static List<Users> RetrieveAllUsers()
        {
            //Create a list to hold the student object in it.
            List<Users> allUsers = null;
            string query = "SELECT * FROM Users";
            cmd = DBHelper.RunQuery(query);
            Users aUser = null;
            if (cmd != null)
            {
                //initialize out list of students
                allUsers = new List<Users>();
                dt = new DataTable();
                sda = new MySqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
              
                    string UserName = dr["UserName"].ToString();
                    string Password = dr["Password"].ToString();

                    //Create the student object
                    aUser = new Users(UserName, Password);
                    //All the student to our list of allStudents
                    allUsers.Add(aUser);
                }
            }
            return allUsers;

        }




        public static Users RetrieveRole(string username)
        {
            string query = "SELECT * FROM mydb.userroles where userName = (@username) limit 1";
            cmd = DBHelper.RunQuery(query, username);
            Users aUser = null;
            if (cmd != null)
            {
                dt = new DataTable();
                sda = new MySqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    string uRole = dr["RoleName"].ToString();
                    aUser = new Users(uRole);
                }
            }
            return aUser;
        }


    }
}
