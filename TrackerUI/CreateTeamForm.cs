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
    public partial class CreateTeamForm : Form
    {

        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        public CreateTeamForm()
        {
            InitializeComponent();
            wiredUpList();
        }

        private void wiredUpList()
        {
            selectTeamMembers.DataSource = null;

            selectTeamMembers.DataSource = availableTeamMembers;
            selectTeamMembers.DisplayMember = "FullName";

            SelectedTeamMemberList.DataSource = null;

            SelectedTeamMemberList.DataSource = selectedTeamMembers;
            SelectedTeamMemberList.DisplayMember = "FullName";
        }

        private void CreateMember_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();
                p.FirstName = FirstName.Text;
                p.LastName = LastName.Text;
                p.Email = Email.Text;
                p.PhoneNumber = PhoneNumber.Text;

            
             GlobalConfig.Connection.CreatePerson(p);
                selectedTeamMembers.Add(p);
                wiredUpList();


                MessageBox.Show("You have successfuly created a member");

                FirstName.Text = "";
                LastName.Text = "";
                Email.Text = "";
                PhoneNumber.Text = "";
            }

            else
            {
                MessageBox.Show("You input the wrong text filed kindly check and retype");
            }

        }

        private bool ValidateForm()
        {
            if (FirstName.Text.Length == 0)
            {
                return false;
            }
            if (LastName.Text.Length == 0)
            {
                return false;
            }
            if (Email.Text.Length == 0)
            {
                return false;
            }
            if (PhoneNumber.Text.Length == 0)
            {
                return false ;
            }
            
           
            return true;
        }

        private void CreateTeamForm_Load(object sender, EventArgs e)
        {

        }

        private void addMember_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamMembers.SelectedItem;
            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);
                wiredUpList();
            }

        }

        private void removeSelected_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)SelectedTeamMemberList.SelectedItem;
            if (p!= null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                wiredUpList();
            }

        }

        private void CreateTeam_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();

            t.TeamName = teamNameText.Text;
            t.TeamMember = selectedTeamMembers;
            t =  GlobalConfig.Connection.CreateTeam(t);
        }
    }
}
