using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoanApplicationForm
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
           // string result = String.Format ("Thank you, {0}, for your business", NameTextBox.Text);
           // ResultLabel.Text = result;
        }
            int ssn = int.Parse (SsnTextBox.Text)
            string result = String.Format("Thank you, {0}, for your business.  Your Social Security number is: {1}", NameTextBox.Text, SsnTextBox.Text);
            ResultLabel.Text = result;
    }
}