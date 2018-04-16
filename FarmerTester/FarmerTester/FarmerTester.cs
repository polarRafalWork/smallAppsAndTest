using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmerTester
{
    public partial class FarmerTester : Form
    {

        Farmer farmer;

        public FarmerTester()
        {
            InitializeComponent();
            farmer = new Farmer(15, 30);
        }

        private void FarmerTester_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDownCowQuantity_ValueChanged(object sender, EventArgs e)
        {
            farmer.NumberOfCows = (int)numericUpDownCowQuantity.Value;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Potrzebuję {0} worków paszy do wykarmienia {1} krów", farmer.BagsOfFeed, farmer.NumberOfCows);
        }
    }
}
