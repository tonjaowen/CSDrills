using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _7.ChallengePostageCalculatorHelperMethod
{
    public partial class Default : System.Web.UI.Page
    {
        public object AirRadioButtton { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void HandleChange(object sender, EventArgs e)
        {
                                      
                // Do the values in the textboxes and checkboxes exist
                if (!valuesExist()) return;
                // What is the volume?
                int volume = 0;
                if (!tryGetVolume(out volume)) return;

                // What radio button was selected (multiplier)?
                double postageMultiplier = getPostageMultiplier();
                // Determin the cost.
                double cost = volume * postageMultiplier;
                // Show the user.
                ResultLabel.Text = string.Format("Your parcel will cost {0:C} to ship.", cost);
            }

        private bool valuesExist()
        {
            throw new NotImplementedException();
        }

        private double getPostageMultiplier()
        {
            throw new NotImplementedException();
        }

        private bool ValuesExist()
            {

                if (!AirRadioButton.Checked
                    && !GroundRadioButton.Checked
                    && !NextDayRadioButton.Checked)
                    return false;

                if (WidthTextBox.Text.Trim().Length == 0
                    || HeightTextBox.Text.Trim().Length == 0)
                    return false;

                return true;

            }

            private bool tryGetVolume(out int volume)
            {

                volume = 0;
                int width = 0;
                int height = 0;
                int length = 0;

                if (!int.TryParse(WidthTextBox.Text.Trim(), out width)) return false;
                if (!int.TryParse(HeightTextBox.Text.Trim(), out height)) return false;
                if (!int.TryParse(LengthTexBox.Text.Trim(), out length)) length = 1;

                volume = width * height * length;
                return true;
            }
            private double GetPostageMultiplier()
            {

                if (GroundRadioButton.Checked) return .15;
                else if (AirRadioButton.Checked) return .25;
                else if (NextDayRadioButton.Checked) return .45;
                else return 0;

            }

        protected void handleChange(object sender, EventArgs e)
        {

        }
    }
}


              


        
        
    
    





        