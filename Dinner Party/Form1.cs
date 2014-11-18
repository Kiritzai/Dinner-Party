using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinner_Party
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerparty;

        public Form1()
        {
            InitializeComponent();

            dinnerparty = new DinnerParty(); // { NumberOfPeople = 5 };
            dinnerparty.SetPartyOptions(5, checkBox1.Checked);
            numericUpDown1.Value = dinnerparty.GetNumberOfPeople();
            dinnerparty.SetHealthyOption(checkBox2.Checked);
            //dinnerparty.CalculateCostOfDecorations(true);
            DisplayDinnerPartyCost();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerparty.SetPartyOptions((int)numericUpDown1.Value, checkBox1.Checked);
            DisplayDinnerPartyCost();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dinnerparty.CalculateCostOfDecorations(checkBox1.Checked);
            DisplayDinnerPartyCost();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            dinnerparty.SetHealthyOption(checkBox2.Checked);
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerparty.CalculateCost();
            labelCost.Text = Cost.ToString("c");
        }
    }
}
