using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSU_Solution.PD_Layer
{
    public class Users
    {
        private string username, role;
        private string password;
        

        public Users(string username, string password)
        {
            UserName = username;
            Password = password;
       
        }

        public Users(string role)
        {
            Role = role;
        }

        public String UserName
        {
            get { return username; }
            set { username = value; }
        }

        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }
    }
}
