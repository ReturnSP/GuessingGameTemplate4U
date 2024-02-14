using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGameTemplate4U
{
    public partial class ResultScreen : UserControl
    {
        public ResultScreen()
        {
            InitializeComponent();


        }

        private void ResultScreen_Load(object sender, EventArgs e)
        {
            resultLabel.Text = $"You have made {MainScreen.guessCount} guesses.";

            for (int i = 0; i < MainScreen.guessList.Count(); i++)

            {
                if (i == 0)
                {
                    origionalGuessOrder.Text += $" Your origional guess order was: \n {MainScreen.guessList[i]} ";
                }
                else
                {
                    origionalGuessOrder.Text += $" {MainScreen.guessList[i]} ";
                }
            }
            MainScreen.guessList.Sort();

            for(int i = 0;i < MainScreen.guessList.Count();i++) { 
            if (i == 0)
                {
                    sortedGuessOrder.Text += $"Your sorted guess order was: \n {MainScreen.guessList[i]}";
                }
                else
                {
                    sortedGuessOrder.Text += $" {MainScreen.guessList[i]}";
                }



            }
        }
    }
}
