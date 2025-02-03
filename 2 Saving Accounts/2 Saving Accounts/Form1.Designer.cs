
namespace _2_Saving_Accounts
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCompute = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtWeeks = new System.Windows.Forms.TextBox();
            this.lblDepositHeading = new System.Windows.Forms.Label();
            this.lblWeeksHeading = new System.Windows.Forms.Label();
            this.lblTotalHeading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(52, 113);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(80, 25);
            this.btnCompute.TabIndex = 0;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);

            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(154, 113);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 25);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtDeposit
            // 
            this.txtDeposit.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeposit.Location = new System.Drawing.Point(114, 28);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(165, 22);
            this.txtDeposit.TabIndex = 2;
            this.txtDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(114, 82);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(165, 22);
            this.txtTotal.TabIndex = 3;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtWeeks
            // 
            this.txtWeeks.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeeks.Location = new System.Drawing.Point(114, 56);
            this.txtWeeks.Name = "txtWeeks";
            this.txtWeeks.Size = new System.Drawing.Size(165, 22);
            this.txtWeeks.TabIndex = 4;
            this.txtWeeks.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDepositHeading
            // 
            this.lblDepositHeading.AutoSize = true;
            this.lblDepositHeading.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepositHeading.Location = new System.Drawing.Point(28, 29);
            this.lblDepositHeading.Name = "lblDepositHeading";
            this.lblDepositHeading.Size = new System.Drawing.Size(80, 16);
            this.lblDepositHeading.TabIndex = 5;
            this.lblDepositHeading.Text = "Weekly Deposit";
            // 
            // lblWeeksHeading
            // 
            this.lblWeeksHeading.AutoSize = true;
            this.lblWeeksHeading.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeeksHeading.Location = new System.Drawing.Point(28, 58);
            this.lblWeeksHeading.Name = "lblWeeksHeading";
            this.lblWeeksHeading.Size = new System.Drawing.Size(67, 16);
            this.lblWeeksHeading.TabIndex = 6;
            this.lblWeeksHeading.Text = "Total Amount";
            // 
            // lblTotalHeading
            // 
            this.lblTotalHeading.AutoSize = true;
            this.lblTotalHeading.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHeading.Location = new System.Drawing.Point(28, 88);
            this.lblTotalHeading.Name = "lblTotalHeading";
            this.lblTotalHeading.Size = new System.Drawing.Size(72, 16);
            this.lblTotalHeading.TabIndex = 7;
            this.lblTotalHeading.Text = "Total Savings";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 150);
            this.Controls.Add(this.lblTotalHeading);
            this.Controls.Add(this.lblWeeksHeading);
            this.Controls.Add(this.lblDepositHeading);
            this.Controls.Add(this.txtWeeks);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDeposit);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCompute);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Savings Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtWeeks;
        private System.Windows.Forms.Label lblDepositHeading;
        private System.Windows.Forms.Label lblWeeksHeading;
        private System.Windows.Forms.Label lblTotalHeading;
    }
}

