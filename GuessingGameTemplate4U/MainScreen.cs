using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GuessingGameTemplate4U
{
    public partial class MainScreen : UserControl
    {

        //creates a random number between 1 and 100 and stores it in a global 
        //variable that can be used throughout the program 
        public static Random randNum = new Random();
        public static int rand = randNum.Next(1, 101);
        public static int guessCount = 0;

        public static List<int> guessList = new List<int>();
        public MainScreen()
        {
            InitializeComponent();
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            
            int guess = Convert.ToInt16(inputBox.Text);

            //TODO add guess to List of guesses on Form1
            guessList.Add(guess);

            if (guess < rand)
            {
                outputLabel.Text = "Too Low!";
                guessCount += 1;
            }
            else if (guess > rand)
            {
                outputLabel.Text = "Too High!";
                guessCount += 1;
            }
            else
            {
                outputLabel.Text = "You Got it!";
                guessCount += 1;
                Refresh();
                Thread.Sleep(1000);

                //TODO close this screen and open a Results Screen (you need to create this)//)
                Form1.ChangeScreen(this, new ResultScreen());
            }

            inputBox.Text = "";
            inputBox.Focus();
        }

    }
}
