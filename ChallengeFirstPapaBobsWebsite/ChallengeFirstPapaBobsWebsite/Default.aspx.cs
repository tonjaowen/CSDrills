using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeFirstPapaBobsWebsite
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void PurchaseButton_Click(object sender, EventArgs e)
        {
            double total;

            if (BabyRadioButton.Checked)
                total = 10.0;
            else if (MamaRadioButton.Checked)
                total = 13.0;
            else
                total = 16.0;

            if (DeepRadioButton.Checked)
                total += 2.0;

            total = (PepperoniCheckBox.Checked) ? total + 1.5 : total;
            total = (OnionsCheckBox.Checked) ? total + .75 : total;
            total = (GreenPeppersCheckBox.Checked) ? total + .5 : total;
            total = (RedPeppersCheckBox.Checked) ? total + .75 : total;

            if (AnchoviesCheckBox.Checked) total += 2.0;

            if ((PepperoniCheckBox.Checked 
                && GreenPeppersCheckBox.Checked 
                && AnchoviesCheckBox.Checked)
                || (PepperoniCheckBox.Checked
                && RedPeppersCheckBox.Checked 
                && OnionsCheckBox.Checked))

            {

                total -= 2.0;

            }

            TotalLabel.Text = "$" + total.ToString();


        }
    }
}