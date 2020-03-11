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
    public partial class AdminMainMenu : Form
    {
        public AdminMainMenu()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Clearing my table
            dgv.Rows.Clear();
            //Setting up my column headers
            dgv.ColumnCount = 5;
            dgv.Columns[0].Name = "Event Name";
            dgv.Columns[1].Name = "Event Date";
            dgv.Columns[2].Name = "Event Type";
            //dgv.Columns[3].Name = "Requester";
            dgv.Columns[3].Name = "Club Name";
            dgv.Columns[4].Name = "Attendees";
            //dgv.Columns[4].Name = "Food";
            //dgv.Columns[5].Name = "Food: High Risk";
            //dgv.Columns[6].Name = "Alcohol";
            //dgv.Columns[7].Name = "Music";

            List<Request> allActiveRequests = RequestsDA.RetrieveAllActiveRequests();
            foreach (var request in allActiveRequests)
            {
                //Populating each row in the table with data from the database
                dgv.Rows.Add(request.TITLE, request.DATE, request.TYPE, request.CLUBNAME, request.NUMBERATT);
            }
        }

        private void AdminMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
