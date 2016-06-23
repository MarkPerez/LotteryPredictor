using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotteryPredictor
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        List<int> lotteryNumbers = new List<int>();
        int lotteryMaximum = 49;

        public Form1()
        {
           InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= lotteryMaximum; i++)
            {
                lotteryNumbers.Add(i);
            }

            foreach (Control control in Controls)
            {
                Label numberLabel = control as Label;

                if (numberLabel != null)
                {
                    //choose a random number
                    int randomNumber = random.Next(1, lotteryNumbers.Count);
                    //use the random number to get a number from the lottery
                    //numbers list
                    int numberChosen = lotteryNumbers[randomNumber];
                    //remove the chosen number from the list so it can't be
                    //chosen again
                    lotteryNumbers.Remove(numberChosen);
                    //display the chosen number 
                    numberLabel.Text = numberChosen.ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
