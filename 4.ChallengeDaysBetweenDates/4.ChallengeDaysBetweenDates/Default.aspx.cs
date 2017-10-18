using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _4.ChallengeDaysBetweenDates
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OkButton_Click(object sender, EventArgs e)
        {
            if (Calendar1.SelectedDate > Calendar2.SelectedDate)
            {
                ResultLabel.Text = Calendar1.SelectedDate
                    .Subtract(Calendar2.SelectedDate)
                    .TotalDays.ToString();
            }
            else
            {
                ResultLabel.Text = Calendar2.SelectedDate
                    .Subtract(Calendar1.SelectedDate)
                    .TotalDays.ToString();
            }





        }
    }

}

           
        






