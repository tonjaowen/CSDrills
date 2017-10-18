using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _5.ChallengeEpicSpiesNewAssignmentForm
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                PreviousCalendar.SelectedDate = DateTime.Now.Date;
                NewCalendar.SelectedDate = DateTime.Now.Date.AddDays(14);
                EndCalendar.SelectedDate = DateTime.Now.Date.AddDays(21);

            }

            //protected void AssignButton_Click(object sender, EventArgs e)
            //{
                //Spies cost $500 per day
                //TimeSpan TotalDurationAssignment = EndCalendar.SelectedDate.Subtract(NewCalendar.SelectedDate);
                //double TotalCost = TotalDurationAssignment.TotalDays * 500.0;

                //if > 21 days then add $1000
               /* if (TotalDurationAssignment.TotalDays > 21)
                {
                    TotalCost += 1000.0;


                }

                ResultLabel.Text = String.Format("Assignment of {0} to assignment {1} is authorized. Budget total: {2:C}",
                
                        CodeNameTextBox.Text, 
                        NewAssignTextBox.Text,
                        TotalCost);

                TimeSpan TimeBetweenAssignments = NewCalendar.SelectedDate.Subtract(PreviousCalendar.SelectedDate);
                if (TimeBetweenAssignments.TotalDays < 14)
                {
                    ResultLabel.Text = "Error: Must allow atleast two weeks between " +
                        "previous assignment and new assignment.";

                    DateTime EarliestNewAssignementDate = PreviousCalendar.SelectedDate.AddDays(14);

                    NewCalendar.SelectedDate = EarliestNewAssignementDate;
                    NewCalendar.VisibleDate = EarliestNewAssignementDate;

                }

        }*/
    }

        protected void AssignButton_Click(object sender, EventArgs e)
        {
            //Spies cost $500 per day
            TimeSpan TotalDurationAssignment = EndCalendar.SelectedDate.Subtract(NewCalendar.SelectedDate);
            double TotalCost = TotalDurationAssignment.TotalDays * 500.0;

            //if > 21 days then add $1000
            if (TotalDurationAssignment.TotalDays > 21)
            {
                TotalCost += 1000.0;


            }

            ResultLabel.Text = String.Format("Assignment of {0} to assignment {1} is authorized. Budget total: {2:C}",

                    CodeNameTextBox.Text,
                    NewAssignTextBox.Text,
                    TotalCost);

            TimeSpan TimeBetweenAssignments = NewCalendar.SelectedDate.Subtract(PreviousCalendar.SelectedDate);
            if (TimeBetweenAssignments.TotalDays < 14)
            {
                ResultLabel.Text = "Error: Must allow atleast two weeks between " +
                    "previous assignment and new assignment.";

                DateTime EarliestNewAssignementDate = PreviousCalendar.SelectedDate.AddDays(14);

                NewCalendar.SelectedDate = EarliestNewAssignementDate;
                NewCalendar.VisibleDate = EarliestNewAssignementDate;

            }

        }
    }
}
    
