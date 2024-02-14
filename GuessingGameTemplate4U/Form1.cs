using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// A template to be used to practice creating user screens and passing 
/// values between screens through a basic guessing game.
/// </summary>

namespace GuessingGameTemplate4U
{
    public partial class Form1 : Form
    {
        //TODO create global list to store user guesses

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //launch the Main Screen
            MainScreen ms = new MainScreen();
            this.Controls.Add(ms);
        }
        public static void ChangeScreen(object sender, UserControl nextScreen)
        {
            Form f;
            if (sender is Form)
            {
                f = (Form)sender;
            }
            else
            {
                UserControl current = (UserControl)sender;
                f = current.FindForm();
                f.Controls.Remove(current);
            }

            nextScreen.Location = new Point((f.Width - nextScreen.Width) / 2, (f.Height - nextScreen.Height) / 2);
            f.Controls.Add(nextScreen);
        }
    }
}
