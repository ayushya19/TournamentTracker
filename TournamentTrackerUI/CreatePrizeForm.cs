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
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TournamentTrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    PlaceNumberTextBox.Text,
                    PlaceNameTextBox.Text,                    
                    PrizeAmountTextBox.Text,
                    PrizePercentagetextBox.Text
                    );
                foreach(IDataConnection db in GlobalConfig.Connections)
                {db.CreatePrize(model); }

                PlaceNumberTextBox.Text = "";
                PlaceNameTextBox.Text = "";
                PrizeAmountTextBox.Text="0";
                PrizePercentagetextBox.Text = "0";
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
        }
        private bool ValidateForm()
        {   bool output=true;
            int placeNumber=0;
            bool placeNumberValidNumber = int.TryParse(PlaceNumberTextBox.Text, out placeNumber);

            if (!placeNumberValidNumber)
            {
                output = false;
            }
            if(placeNumber<1)
            {
                output=false; 
            }
            if(PlaceNameTextBox.Text.Length==0)
            {
                output=false; 
            }
            decimal prizeAmount = 0;
            int prizePercentage = 0;
            bool prizeAmountValid=decimal.TryParse(PrizeAmountTextBox.Text, out prizeAmount); 
            bool prizePercentageValid=int.TryParse(PrizePercentagetextBox.Text, out prizePercentage);

            if(!prizeAmountValid||!prizePercentageValid)
            { }

            return output;
        }
    }
}
