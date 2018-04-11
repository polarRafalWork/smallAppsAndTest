using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinnerPartySimpleApp
{
    public partial class Form_DinnerPartyPlanner : Form
    {
        DinnerParty dinnerParty;

        public Form_DinnerPartyPlanner()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty();
            dinnerParty.SetNumberOfPeople((int)numericUpDownIloscOsob.Value);
            dinnerParty.SetHealthyOption(checkBoxHealthyOption.Checked);
            dinnerParty.CalculateCostOfDecorations(checkBoxFancy.Checked);
            DisplayDinnerPartyCost();

        }

        private void Form_DinnerPartyPlanner_Load(object sender, EventArgs e)
        {

        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost();
            labelKoszt.Text = Cost.ToString("c");
        }

        private void numericUpDownIloscOsob_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.SetNumberOfPeople((int)numericUpDownIloscOsob.Value);
            DisplayDinnerPartyCost();
        }

        private void checkBoxFancy_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecorations(checkBoxFancy.Checked);
            DisplayDinnerPartyCost();
        }

        private void checkBoxHealthyOption_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOption(checkBoxHealthyOption.Checked);
            DisplayDinnerPartyCost();
        }
    }
}
