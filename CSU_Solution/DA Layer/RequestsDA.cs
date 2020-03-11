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
    class RequestsDA
    {
        private static MySqlCommand cmd = null;
        private static DataTable dt;
        private static MySqlDataAdapter sda;

        public static List<Request> RetrieveAllActiveRequests()
        {
            //Create a list to hold the request object in it.
            List<Request> allRequests = null;
            string query = "SELECT * FROM REQUEST";
            cmd = DBHelper.RunQuery(query);
            Request aRequest = null;
            if (cmd != null)
            {
                //initialize out list of Requests
                allRequests = new List<Request>();
                dt = new DataTable();
                sda = new MySqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    string title = dr["event_title"].ToString();
                    DateTime date = Convert.ToDateTime(dr["event_date"]);
                    string type = dr["event_type"].ToString();
                    //string user = dr["user_UserName"].ToString();
                    string clubname = dr["clubname"].ToString();
                    int attendees = Convert.ToInt32(dr["numatt"]);
                    //Create the Request object
                    aRequest = new Request(title, date, type, clubname, attendees);
                    //All the request to our list of allRequests
                    allRequests.Add(aRequest);
                }
            }
            return allRequests;

        }
        public static void AddRequest(Request aRequest)
        {
            string query = "INSERT INTO REQUEST(event_title, event_date, event_type, clubname, numatt) VALUES(@title, @date, @type, @club, @numatt)";
            MySqlCommand cmd = new MySqlCommand();
            if (DBHelper.Connetion != null)
            {
                cmd = DBHelper.Connetion.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@title", aRequest.TITLE);
                cmd.Parameters.AddWithValue("@date", aRequest.DATE);
                cmd.Parameters.AddWithValue("@type", aRequest.TYPE);
                cmd.Parameters.AddWithValue("@club", aRequest.CLUBNAME);
                cmd.Parameters.AddWithValue("@numatt", aRequest.NUMBERATT);
                DBHelper.ExecuteCommand(cmd);
            }
        }
    }
}
