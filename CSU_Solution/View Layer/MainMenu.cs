using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSU_Solution.DA_Layer;
using CSU_Solution.PD_Layer;

namespace CSU_Solution.View_Layer
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {   
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string clubn;
            int natt;

            try
            {
                clubn = txtCname.Text;
          
                natt = int.Parse(txtNumAtt.Text.Trim());


                Request newRequest = new Request(clubn, natt);
                UsersDA.SubmitRequest(newRequest);
                MessageBox.Show("Your request has been successfuly sumbitted!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please check your input information and try again", "INVALID DATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /*
        private void button2_Click(object sender, EventArgs e)
        {
            //Clearing my table
            dgv.Rows.Clear();
            //Setting up my column headers
            dgv.ColumnCount = 5;
            dgv.Columns[0].Name = "UserName";
            dgv.Columns[1].Name = "Password";
     
            List<Users> allusers = UsersDA.RetrieveAllUsers();
            foreach (var user in allusers)
            {
                //Populating each row in the table with data from the database
                dgv.Rows.Add(user.UserName, user.Password);
            }
        }
*/
        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String eventname, clubname, type;
            int attnumber;
            DateTime date;
            try
            {
                eventname = txtEventName.Text;
                clubname = txtClubName.Text;
                type = txtTypeEvent.Text;
                attnumber = int.Parse(txtNumberAtt.Text.Trim());
                date = this.dateTimePicker1.Value.Date;
                Request newRequest = new Request(eventname, date, type, clubname, attnumber);
                RequestsDA.AddRequest(newRequest);
                MessageBox.Show("Request is added successfully", "REQUEST ADDED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearAll();
                //refreshTableBtn_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. Please enter valid data", "INVALID DATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clearAll()
        {
            txtEventName.Text = "";
            txtClubName.Text = "";
            txtTypeEvent.Text = "";
            txtNumberAtt.Text = "";
       
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
