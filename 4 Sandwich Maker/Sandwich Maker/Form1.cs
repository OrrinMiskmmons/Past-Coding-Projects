using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sandwich_Maker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int breadChoice;
        int cheeseChoice;
        int numberMeats;
        int numberCondiments;

        private void Form1_Load(object sender, EventArgs e)
        {
            //Initialize bread and cheese choices
            breadChoice = 1;
            cheeseChoice = 0;
        }

        private void rdoWhite_CheckChanged(object sender, EventArgs e)
        {
            //White bread selected
            breadChoice = 1;
        }

        private void rdoWheat_CheckedChanged(object sender, EventArgs e)
        {
            //Wheat bread selected
            breadChoice = 2;
        }

        private void rdoYye_CheckedChanged(object sender, EventArgs e)
        {
            //Regular bread selected
            breadChoice = 3;
        }

        private void rdoNone_CheckedChanged(object sender, EventArgs e)
        {
            //No cheese selected
            cheeseChoice = 0;
        }

        private void rdoAmerica_CheckedChanged(object sender, EventArgs e)
        {
            //American cheese selected
            cheeseChoice = 1;
        }

        private void rdoSwiss_CheckedChanged(object sender, EventArgs e)
        {
            //Swiss cheese selected
            cheeseChoice = 2;
        }
        
        private void btnOrder_Click(object sender, EventArgs e)
        {
            //Start Text with bread type
            txtOrder.Text = "Sandwich Order:\r\n";
            switch(breadChoice)
            {
                case 1:
                    txtOrder.Text = txtOrder.Text + "White Bread\r\n";
                    break;
                case 2:
                    txtOrder.Text = txtOrder.Text + "Wheat Bread\r\n";
                    break;
                case 3:
                    txtOrder.Text = txtOrder.Text + "Rye Bread\r\n";
                    break;
            }
            //Add and count meats
            numberMeats = 0;
            if (chkRoastBeef.Checked)
            {
                numberMeats = numberMeats + 1;
                txtOrder.Text = txtOrder.Text + "Roast Beef\r\n";
            }
            if (chkHam.Checked)
            {
                numberMeats = numberMeats + 1;
                txtOrder.Text = txtOrder.Text + "ham\r\n";
            }
            if (chkTurkey.Checked)
            {
                numberMeats = numberMeats + 1;
                txtOrder.Text = txtOrder.Text + "Turkey\r\n";
            }
            if (chkPastrami.Checked)
            {
                numberMeats = numberMeats + 1;
                txtOrder.Text = txtOrder.Text + "Pastrami\r\n";
            }
            if (chkSalami.Checked)
            {
                numberMeats = numberMeats + 1;
                txtOrder.Text = txtOrder.Text + "Salami\r\n";
            }
            //If no meat picked, say so
            {
                txtOrder.Text = txtOrder.Text + "No Meta\r\n";
            }
            //Add cheese type
            switch (cheeseChoice)
            {
                case 0:
                    txtOrder.Text = txtOrder.Text + "No CHeese\r\n";
                    break;
                case 1:
                    txtOrder.Text = txtOrder.Text + "American Cheese\r\n";
                    break;
                case 2:
                    txtOrder.Text = txtOrder.Text + "Swiss Cheese\r\n";
                    break;
            }
            //Finally, add and count condiments
            numberCondiments = 0;
            if (chkMustard.Checked)
            {
                numberCondiments = numberCondiments + 1;
                txtOrder.Text = txtOrder.Text + "Mustard\r\n";
            }
            if (chkMayo.Checked)
            {
                numberCondiments = numberCondiments + 1;
                txtOrder.Text = txtOrder.Text + "Mayonnaise\r\n";
            }
            if (chkLettuce.Checked)
            {
                numberCondiments = numberCondiments + 1;
                txtOrder.Text = txtOrder.Text + "Lettuce\r\n";
            }
            if (chkTomato.Checked)
            {
                numberCondiments = numberCondiments + 1;
                txtOrder.Text = txtOrder.Text + "Tomato\r\n";
            }
            if (chkOnions.Checked)
            {
                numberCondiments = numberCondiments + 1;
                txtOrder.Text = txtOrder.Text + "Onions\r\n";
            }
            if (chkPastrami.Checked)
            {
                numberCondiments = numberCondiments + 1;
                txtOrder.Text = txtOrder.Text + "Pickles\r\n";
            }
            //If no condiments picked, say so
            if (numberCondiments == 0)
            
                txtOrder.Text = txtOrder.Text + "No Condiments\r\n";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Set bread to white
            breadChoice = 1;
            rdoWhite.Checked = true;
            //Clear all meat choices
            chkRoastBeef.Checked = false;
            chkHam.Checked = false;
            chkTurkey.Checked = false;
            chkPastrami.Checked = false;
            chkSalami.Checked = false;
            //Set cheese to none
            cheeseChoice = 0;
            rodNone.Checked = true;
            //Clear all condimant choices
            chkMustard.Checked = false;
            chkMayo.Checked = false;
            chkLettuce.Checked = false;
            chkTomato.Checked =false;
            chkOnions.Checked = false;
            chkPastrami.Checked = false;
            //Clear text box
            txtOrder.Text = "";
        }

    }
}
