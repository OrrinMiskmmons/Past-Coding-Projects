using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_Guess_the_Number_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int theNumber;
        int myGuess;
        Random myRandom = new Random();



        private void btnPick_Click(object sender, EventArgs e)
        {
            if (btnPick.Text == "Pick Number")
            {
                //Get new number and set controls
                theNumber = myRandom.Next(101);
                txtMessage.Text = "I'm thinking of a number between 0 and 100";
                nudGuess.Value = 50;
                nudGuess.Enabled = true;
                btnCheck.Enabled = true;
                btnPick.Text = "Show Answer";
            }
            else
            {
                //Just show the anser and re-set controls
                txtMessage.Text = "The answer is" + Convert.ToString(theNumber);
                nudGuess.Value = theNumber;
                nudGuess.Enabled = false;
                btnCheck.Enabled = false;
                btnPick.Text = "Puck NNumber";
            }

            
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //Guess is the updown control Value
            myGuess = (int)nudGuess.Value;
            if (myGuess == theNumber)
            {
                //Correct Guess
                txtMessage.Text = "That's it!!";
                btnPick.Enabled = false;
                btnCheck.Enabled = false;
                btnPick.Text = "Pick Number";
            }
            else if (myGuess < theNumber)
            {
                //Guess is too low
                txtMessage.Text = "Too Low!";
            }
            else
            {
                //Guess is too high
                txtMessage.Text = "Too High";
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
