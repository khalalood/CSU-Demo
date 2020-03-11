using CSU_Solution.DA_Layer;
using CSU_Solution.Helper;
using CSU_Solution.PD_Layer;
using CSU_Solution.View_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSU_Solution
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
            DBHelper.EstablishConnection();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string role = "System Customer";
;              

            Users aUser = UsersDA.RetrieveUser(username);
            Users userRole = UsersDA.RetrieveRole(username);
            if(aUser.Password.Equals(password))
            {
                MessageBox.Show("Login Success");
                if (userRole.Role.Equals(role))
                {
                    View_Layer.MainMenu m = new View_Layer.MainMenu();
                    m.Show();
                }
                else
                {
                    View_Layer.AdminMainMenu n = new View_Layer.AdminMainMenu();
                    n.Show();
                }

                //                View_Layer.MainMenu m = new View_Layer.MainMenu();
                //               m.Show();
            }
            else
            {
                MessageBox.Show("Login Failed. Please try again");
                txtUsername.Text = "";
                txtPassword.Text = "";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SignInForm_Load(object sender, EventArgs e)
        {

        }
    }
}
