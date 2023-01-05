using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class CreateTournamentForm : Form
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All(); 
        List<TeamModel> selectedTeams = new List<TeamModel>()   ; 
        List<PrizeModel> prizeModels=new List<PrizeModel>() ;
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
            PrizesListBox.DataSource = prizeModels;
            PrizesListBox.DisplayMember = "PlaceName";

        }

        private void TournamentTeamsListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel teamToAdd = (TeamModel)SelectTeamDropDown.SelectedItem;
            if (teamToAdd != null)
            {
                availableTeams.Remove(teamToAdd);
                selectedTeams.Add(teamToAdd);

                WireUpList();
            }
        }
    }
}
