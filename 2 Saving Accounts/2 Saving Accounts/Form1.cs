﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_Saving_Accounts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int deposit;
        int weeks;
        int total;

        private void btnCompute_Click(object sender, EventArgs e)
        {
            // Get deposit amount 
            deposit = Convert.ToInt32(txtDeposit.Text);
            // Get number of weeks 
            weeks = Convert.ToInt32(txtWeeks.Text);
            // Compute total savings 
            total = deposit*weeks;
            // Display Total 
            txtTotal.Text = "$" + Convert.ToString(total);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        
    }
}
