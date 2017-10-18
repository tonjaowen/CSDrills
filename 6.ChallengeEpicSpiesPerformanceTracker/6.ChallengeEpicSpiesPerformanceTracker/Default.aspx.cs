using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _6.ChallengeEpicSpiesPerformanceTracker
{
    public partial class Default : System.Web.UI.Page
    {
        private readonly int newIndex;

        public object ResultLabel { get; private set; }
        public object Assets { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] assets = new string[0];
                int[] elections = new int[0];
                int[] acts = new int[0];

                ViewState.Add("Assets", assets);
                ViewState.Add("Elections", elections);
                ViewState.Add("Acts", acts);


                /*protected void AddButton_Click(object sender, EventArgs e)
                {

                    }
                }

                protected void AddButton_Click(object sender, EventArgs e)
                */
                {


                }

            }
        }

        protected void AddButton_Click(object sender, EventArgs e)
        {
            string[] assets = (string[])ViewState["Assets"];
            int[] elections = (int[])ViewState["Elections"];
            int[] acts = (int[])ViewState["Acts"];

            int NewLength = assets.Length + 1;

            Array.Resize(ref assets, NewLength);
            Array.Resize(ref elections, NewLength);
            Array.Resize(ref acts, NewLength);

            int NewIndex = assets.GetUpperBound(0);

            assets[NewIndex] = AssetTextBox.Text;
            elections[NewIndex] = int.Parse(ElectionsTextBox.Text);
            acts[NewIndex] = int.Parse(ActsTextBox.Text);

            ViewState["Assets"] = assets;
            ViewState["Elections"] = elections;
            ViewState["Acts"] = acts;

            ResultLabel.Text = String.Format("Total Elections Rigged: {0}<br />Average Acts of Subterfuge per Asset: {1:N2}<br />(Last Asset you Added: {2})",
               elections.Sum(),
               acts.Average(),
               assets [newIndex]);

            AssetTextBox.Text = "";
            ElectionsTextBox.Text = "";
            ActsTextBox.Text = "";







        }
    }

}


