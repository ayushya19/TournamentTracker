using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TournamentTrackerUI
{
    public partial class CreateTournamentForm : Form,IPrizeRequester,ITeamRequester
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All(); 
        List<TeamModel> selectedTeams = new List<TeamModel>()   ; 
        List<PrizeModel> selectedPrizes=new List<PrizeModel>() ;
        public CreateTournamentForm()
        {
            InitializeComponent();
            WireUpList();
            
        }

        private void TeamOneScoreLabel_Click(object sender, EventArgs e)
        {

        }

        private void RoundLabel_Click(object sender, EventArgs e)
        {

        }

        private void SelectTeamDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void WireUpList()
        {
            SelectTeamDropDown.DataSource = null;
            SelectTeamDropDown.DataSource= availableTeams;
            SelectTeamDropDown.DisplayMember = "TeamName";

            TournamentTeamsListbox.DataSource = null;
            TournamentTeamsListbox.DataSource = selectedTeams;
            TournamentTeamsListbox.DisplayMember="TeamName";

            PrizesListBox.DataSource = null;
            PrizesListBox.DataSource = selectedPrizes;
            PrizesListBox.DisplayMember = "PlaceName";

        }

        private void TournamentTeamsListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel model = (TeamModel)SelectTeamDropDown.SelectedValue;
            availableTeams.Remove(model);
            selectedTeams.Add(model);
            WireUpList();
        }

        private void CreateTournamentButton_Click(object sender, EventArgs e)
        {
            decimal fee = 0;
            bool feeAcceptable = decimal.TryParse(EntryFeeTextBox.Text, out fee);
            if(!feeAcceptable)
            {
                MessageBox.Show("You need to enter a valid fee.", "Invalid Fee",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            TournamentModel model=new TournamentModel();
            model.TournamentName = TournamentNameTextBox.Text;
            model.EntryFee = fee;
            model.EnteredTeam = selectedTeams;
            model.prizes= selectedPrizes;

            TournamentLogic.CreateRounds(model);



            model = GlobalConfig.Connection.CreateTournament(model);
        }

        private void CreateNewlinkLabel_LinkClicked(object sender, EventArgs e)
        {
            CreateTeamForm teamForm=new CreateTeamForm(this);
            teamForm.Show();
        }

        private void AddPrizeButton_Click(object sender, EventArgs e)
        {
            // Call the Create PrizeForm
            CreatePrizeForm createprizeform=new CreatePrizeForm(this);

            //Open the create prize form
            createprizeform.Show();
            //Get back a prizemodel from the form

            //Add it into the prizemodels list
            // add the prizemodel in the prizelistbox
        }

        public void PrizeComplete(PrizeModel model)
        {
            //Get back from the form a prize model
            //take the prizemodel and put into our list of selected prizes

            selectedPrizes.Add(model);
            WireUpList();
        }

        public void TeamComplete(TeamModel model)
        {
            availableTeams.Add(model);
            WireUpList();
        }

        private void DeleteTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel model= (TeamModel)TournamentTeamsListbox.SelectedValue;
            if (model != null)
            {
                selectedTeams.Remove(model);
                availableTeams.Add(model);
                WireUpList();
            }
        }

        private void DeletePrizeButton_Click(object sender, EventArgs e)
        {
            PrizeModel model = (PrizeModel)PrizesListBox.SelectedValue;
            if (model != null)
            {
                selectedPrizes.Remove(model);
                WireUpList();
            }
        }
    }
}
