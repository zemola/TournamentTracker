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
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void CreatePrizeForm_Load(object sender, EventArgs e)
        {

        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(placeNumberValue.Text, out placeNumber);
            if(!placeNumberValidNumber)
            {
                output = false;
                MessageBox.Show("placeNumber is invalid");
            }
            if(placeNumber<1)
            {
                output = false;
                MessageBox.Show("placeNumber should be greater than 1");
            }

            if (placeNameValue.Text.Length == 0)
            {
                output = false;
                MessageBox.Show("placeNamevalue should be greater than 1");
            }

            decimal prizeAmount = 0;
            int prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(prizeAmountValue.Text, out prizeAmount);
            bool prizePercentageValid = int.TryParse(PrizePercentageValue.Text, out prizePercentage);

            if (prizeAmountValid == false || prizePercentageValid == false)
            {
                MessageBox.Show("fill in the amount");
                output = false;
            }

            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                MessageBox.Show("your amount shouldnt be less than 0");
                output =false;
            }

            if (prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }
            output = true;
            return output;
        }



        private void placeNumberValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreatePrizeBtn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model= new PrizeModel();
                 model.PlaceName = placeNameValue.Text;
                model.PlaceNumber = int.Parse(placeNumberValue.Text);
                model.PrizeAmount = decimal.Parse(prizeAmountValue.Text);
                model.Percentage = float.Parse(PrizePercentageValue.Text);
                    
               GlobalConfig.Connection.CreatePrize(model);
    

                MessageBox.Show("You have successfuly created a prize");
                placeNameValue.Text = "";
                placeNumberValue.Text = "";
                prizeAmountValue.Text = "0";
                PrizePercentageValue.Text = "0";
            }
            else
            {
                MessageBox.Show("This form has invalid information. please check it and try again");
            }
        }

        private void CreatePrizeForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
