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
            }
            if(placeNumber<1)
            {
                output = false;
            }

            if (placeNameValue.Text.Length == 0)
            {
                output = false;
            }

                

            if (true)
            {
                output = false;
            }
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
                model.PrizeAmount = int.Parse(prizeAmountValue.Text);
                model.Percentage = int.Parse(PrizePercentageValue.Text);

                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreatePrize(model);
                }
            }
        }
    }
}
