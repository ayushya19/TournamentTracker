using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TournamentTrackerUI
{
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();

        public CreateTeamForm()
        {   
            InitializeComponent();
            //CreateSampleData();

            WireUpList();
        }

        private void WireUpList()
        {
            // TODO - Find a better solution for refreshing the data source of these list box and drop down.
            //This is a work around to refresh the data source of these drop down and listbox
            TournamentPlayerListBox.DataSource = null;

            TournamentPlayerListBox.DataSource= selectedTeamMembers;
            TournamentPlayerListBox.DisplayMember = "FullName";

            //This is a work around to refresh the data source of these drop down and listbox
            SelectTeamMemberDropDown.DataSource = null;

            SelectTeamMemberDropDown.DataSource= availableTeamMembers;
            SelectTeamMemberDropDown.DisplayMember = "FullName";
        }

      
        private void CreateSampleData ()
        {
            availableTeamMembers.Add(new PersonModel() {firstName="abc",lastName="def" });
            availableTeamMembers.Add(new PersonModel() {firstName="ghi",lastName="jkl" });
            selectedTeamMembers.Add(new PersonModel() {firstName="lmn",lastName="opq" });
            selectedTeamMembers.Add(new PersonModel() {firstName="urs",lastName="twx" });
        }

        private void HeaderLabel_Click(object sender, EventArgs e)
        {

        }

        private void CreateTeamForm_Load(object sender, EventArgs e)
        {

        }

        private void FirstNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void CreateMemberButton_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                
                PersonModel person = new PersonModel();
                person.firstName = FirstNameValueTextBox.Text;
                person.lastName = LastNameValueTextBox.Text;
                person.emailAddress = EmailtextBox.Text;
                person.cellPhoneNumber =long.Parse(CellPhoneNumbertextBox.Text);

                person=GlobalConfig.Connection.CreatePerson(person);
                availableTeamMembers.Add(person);
                WireUpList();

                FirstNameValueTextBox.Text = "";
                LastNameValueTextBox.Text = "";
                EmailtextBox.Text = "";
                CellPhoneNumbertextBox.Text = "";

            }
            else
            {
                MessageBox.Show("You need to fill in all of the fields");
            }
        }

        private bool ValidateForm()
        {
            if(FirstNameValueTextBox.Text.Length==0)
            {
                return false;
            }
            if (LastNameValueTextBox.Text.Length == 0)
            {
                return false;
            }
            if (EmailtextBox.Text.Length == 0)
            {
                return false;
            }
            if (CellPhoneNumbertextBox.Text.Length == 0)
            {
                return false;
            }
            // TODO - Add Validation to the form
            return true;
        }

        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel memberToAdd = (PersonModel)SelectTeamMemberDropDown.SelectedItem;
            if (memberToAdd!=null)
            {
                availableTeamMembers.Remove(memberToAdd);
                selectedTeamMembers.Add(memberToAdd);

                WireUpList(); 
            }
        }

        private void RemoveSelectedTournamentPlayerButton_Click(object sender, EventArgs e)
        {
            PersonModel memberToDelete=(PersonModel)TournamentPlayerListBox.SelectedValue;
            if (memberToDelete!=null)
            {
                selectedTeamMembers.Remove(memberToDelete);
                availableTeamMembers.Add(memberToDelete);

                WireUpList(); 
            }
        }

        private void CreateTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t= new TeamModel();
            t.teamName = TeamNameTextBox.Text;
            t.TeamMember = selectedTeamMembers;
            t = GlobalConfig.Connection.CreateTeam(t);
        }

        private void TeamNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void TeamNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SelectTeamLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddNewMemberGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void EmailtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailLabel_Click(object sender, EventArgs e)
        {

        }

        private void CellPhoneNumbertextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CellPhoneNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void LastNameValueTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void FirstNameValueTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TournamentPlayerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SelectTeamMemberDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SelectTeamLabel_Click_1(object sender, EventArgs e)
        {

        }
    }
}

