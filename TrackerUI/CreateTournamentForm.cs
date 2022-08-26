using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class CreateTournamentForm : Form
    {
        List<TeamModel> availableTeams = new List<TeamModel>();
        public CreateTournamentForm()
        {
            InitializeComponent();
            initializeList();
            
        }
          
            private void initializeList()
        {
            TeamListDropdown.DataSource = availableTeams;
            TeamListDropdown.DisplayMember = "TeamName";
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CreateTournamentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
