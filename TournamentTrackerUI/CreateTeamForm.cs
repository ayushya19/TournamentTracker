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
        public CreateTeamForm()
        {
            InitializeComponent();
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
            if(validateForm())
            {
                
                PersonModel person = new PersonModel();
                person.firstName = FirstNameValueTextBox.Text;
                person.lastName = LastNameValueTextBox.Text;
                person.emailAddress = EmailtextBox.Text;
                person.cellPhoneNumber =long.Parse(CellPhoneNumbertextBox.Text);

                GlobalConfig.Connections.CreatePerson(person);

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

        private bool validateForm()
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
    }
}
