
namespace Sandwich_Maker
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
            this.grpBread = new System.Windows.Forms.GroupBox();
            this.rdoRye = new System.Windows.Forms.RadioButton();
            this.rdoWheat = new System.Windows.Forms.RadioButton();
            this.rdoWhite = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpCheese = new System.Windows.Forms.GroupBox();
            this.rdoSwiss = new System.Windows.Forms.RadioButton();
            this.rdoAmerican = new System.Windows.Forms.RadioButton();
            this.rodNone = new System.Windows.Forms.RadioButton();
            this.grpMeats = new System.Windows.Forms.GroupBox();
            this.chkSalami = new System.Windows.Forms.CheckBox();
            this.chkPastrami = new System.Windows.Forms.CheckBox();
            this.chkTurkey = new System.Windows.Forms.CheckBox();
            this.chkHam = new System.Windows.Forms.CheckBox();
            this.chkRoastBeef = new System.Windows.Forms.CheckBox();
            this.grpCondiments = new System.Windows.Forms.GroupBox();
            this.chkPickles = new System.Windows.Forms.CheckBox();
            this.chkOnions = new System.Windows.Forms.CheckBox();
            this.chkTomato = new System.Windows.Forms.CheckBox();
            this.chkLettuce = new System.Windows.Forms.CheckBox();
            this.chkMayo = new System.Windows.Forms.CheckBox();
            this.chkMustard = new System.Windows.Forms.CheckBox();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.lblOrder = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpBread.SuspendLayout();
            this.grpCheese.SuspendLayout();
            this.grpMeats.SuspendLayout();
            this.grpCondiments.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBread
            // 
            this.grpBread.Controls.Add(this.rdoRye);
            this.grpBread.Controls.Add(this.rdoWheat);
            this.grpBread.Controls.Add(this.rdoWhite);
            this.grpBread.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBread.Location = new System.Drawing.Point(34, 27);
            this.grpBread.Name = "grpBread";
            this.grpBread.Size = new System.Drawing.Size(141, 147);
            this.grpBread.TabIndex = 0;
            this.grpBread.TabStop = false;
            this.grpBread.Text = "Bread";
            // 
            // rdoRye
            // 
            this.rdoRye.AutoSize = true;
            this.rdoRye.Checked = true;
            this.rdoRye.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoRye.Location = new System.Drawing.Point(12, 68);
            this.rdoRye.Name = "rdoRye";
            this.rdoRye.Size = new System.Drawing.Size(57, 19);
            this.rdoRye.TabIndex = 2;
            this.rdoRye.TabStop = true;
            this.rdoRye.Text = "Regular";
            this.rdoRye.UseVisualStyleBackColor = true;
            // 
            // rdoWheat
            // 
            this.rdoWheat.AutoSize = true;
            this.rdoWheat.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoWheat.Location = new System.Drawing.Point(12, 45);
            this.rdoWheat.Name = "rdoWheat";
            this.rdoWheat.Size = new System.Drawing.Size(50, 19);
            this.rdoWheat.TabIndex = 1;
            this.rdoWheat.Text = "Wheat";
            this.rdoWheat.UseVisualStyleBackColor = true;
            // 
            // rdoWhite
            // 
            this.rdoWhite.AutoSize = true;
            this.rdoWhite.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoWhite.Location = new System.Drawing.Point(11, 22);
            this.rdoWhite.Name = "rdoWhite";
            this.rdoWhite.Size = new System.Drawing.Size(47, 19);
            this.rdoWhite.TabIndex = 0;
            this.rdoWhite.Text = "White";
            this.rdoWhite.UseVisualStyleBackColor = true;
            // 
            // grpCheese
            // 
            this.grpCheese.Controls.Add(this.rdoSwiss);
            this.grpCheese.Controls.Add(this.rdoAmerican);
            this.grpCheese.Controls.Add(this.rodNone);
            this.grpCheese.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCheese.Location = new System.Drawing.Point(204, 27);
            this.grpCheese.Name = "grpCheese";
            this.grpCheese.Size = new System.Drawing.Size(141, 147);
            this.grpCheese.TabIndex = 1;
            this.grpCheese.TabStop = false;
            this.grpCheese.Text = "Cheese";
            // 
            // rdoSwiss
            // 
            this.rdoSwiss.AutoSize = true;
            this.rdoSwiss.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSwiss.Location = new System.Drawing.Point(1, 68);
            this.rdoSwiss.Name = "rdoSwiss";
            this.rdoSwiss.Size = new System.Drawing.Size(51, 19);
            this.rdoSwiss.TabIndex = 5;
            this.rdoSwiss.TabStop = true;
            this.rdoSwiss.Text = "Swiss";
            this.rdoSwiss.UseVisualStyleBackColor = true;
            // 
            // rdoAmerican
            // 
            this.rdoAmerican.AutoSize = true;
            this.rdoAmerican.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAmerican.Location = new System.Drawing.Point(1, 45);
            this.rdoAmerican.Name = "rdoAmerican";
            this.rdoAmerican.Size = new System.Drawing.Size(64, 19);
            this.rdoAmerican.TabIndex = 4;
            this.rdoAmerican.TabStop = true;
            this.rdoAmerican.Text = "American";
            this.rdoAmerican.UseVisualStyleBackColor = true;
            // 
            // rodNone
            // 
            this.rodNone.AutoSize = true;
            this.rodNone.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rodNone.Location = new System.Drawing.Point(1, 22);
            this.rodNone.Name = "rodNone";
            this.rodNone.Size = new System.Drawing.Size(47, 19);
            this.rodNone.TabIndex = 3;
            this.rodNone.TabStop = true;
            this.rodNone.Text = "None";
            this.rodNone.UseVisualStyleBackColor = true;
            // 
            // grpMeats
            // 
            this.grpMeats.Controls.Add(this.chkSalami);
            this.grpMeats.Controls.Add(this.chkPastrami);
            this.grpMeats.Controls.Add(this.chkTurkey);
            this.grpMeats.Controls.Add(this.chkHam);
            this.grpMeats.Controls.Add(this.chkRoastBeef);
            this.grpMeats.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMeats.Location = new System.Drawing.Point(34, 188);
            this.grpMeats.Name = "grpMeats";
            this.grpMeats.Size = new System.Drawing.Size(141, 147);
            this.grpMeats.TabIndex = 1;
            this.grpMeats.TabStop = false;
            this.grpMeats.Text = "Meats";
            // 
            // chkSalami
            // 
            this.chkSalami.AutoSize = true;
            this.chkSalami.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSalami.Location = new System.Drawing.Point(12, 114);
            this.chkSalami.Name = "chkSalami";
            this.chkSalami.Size = new System.Drawing.Size(54, 19);
            this.chkSalami.TabIndex = 4;
            this.chkSalami.Text = "Salami";
            this.chkSalami.UseVisualStyleBackColor = true;
            // 
            // chkPastrami
            // 
            this.chkPastrami.AutoSize = true;
            this.chkPastrami.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPastrami.Location = new System.Drawing.Point(12, 91);
            this.chkPastrami.Name = "chkPastrami";
            this.chkPastrami.Size = new System.Drawing.Size(62, 19);
            this.chkPastrami.TabIndex = 3;
            this.chkPastrami.Text = "Pastrami";
            this.chkPastrami.UseVisualStyleBackColor = true;
            // 
            // chkTurkey
            // 
            this.chkTurkey.AutoSize = true;
            this.chkTurkey.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTurkey.Location = new System.Drawing.Point(12, 68);
            this.chkTurkey.Name = "chkTurkey";
            this.chkTurkey.Size = new System.Drawing.Size(56, 19);
            this.chkTurkey.TabIndex = 2;
            this.chkTurkey.Text = "Turkey";
            this.chkTurkey.UseVisualStyleBackColor = true;
            // 
            // chkHam
            // 
            this.chkHam.AutoSize = true;
            this.chkHam.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHam.Location = new System.Drawing.Point(12, 45);
            this.chkHam.Name = "chkHam";
            this.chkHam.Size = new System.Drawing.Size(45, 19);
            this.chkHam.TabIndex = 1;
            this.chkHam.Text = "Ham";
            this.chkHam.UseVisualStyleBackColor = true;
            // 
            // chkRoastBeef
            // 
            this.chkRoastBeef.AutoSize = true;
            this.chkRoastBeef.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRoastBeef.Location = new System.Drawing.Point(12, 22);
            this.chkRoastBeef.Name = "chkRoastBeef";
            this.chkRoastBeef.Size = new System.Drawing.Size(71, 19);
            this.chkRoastBeef.TabIndex = 0;
            this.chkRoastBeef.Text = "Roast Beef";
            this.chkRoastBeef.UseVisualStyleBackColor = true;
            // 
            // grpCondiments
            // 
            this.grpCondiments.Controls.Add(this.chkPickles);
            this.grpCondiments.Controls.Add(this.chkOnions);
            this.grpCondiments.Controls.Add(this.chkTomato);
            this.grpCondiments.Controls.Add(this.chkLettuce);
            this.grpCondiments.Controls.Add(this.chkMayo);
            this.grpCondiments.Controls.Add(this.chkMustard);
            this.grpCondiments.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCondiments.Location = new System.Drawing.Point(204, 188);
            this.grpCondiments.Name = "grpCondiments";
            this.grpCondiments.Size = new System.Drawing.Size(141, 166);
            this.grpCondiments.TabIndex = 1;
            this.grpCondiments.TabStop = false;
            this.grpCondiments.Text = "Condiments";
            // 
            // chkPickles
            // 
            this.chkPickles.AutoSize = true;
            this.chkPickles.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPickles.Location = new System.Drawing.Point(6, 137);
            this.chkPickles.Name = "chkPickles";
            this.chkPickles.Size = new System.Drawing.Size(56, 19);
            this.chkPickles.TabIndex = 10;
            this.chkPickles.Text = "Pickles";
            this.chkPickles.UseVisualStyleBackColor = true;
            // 
            // chkOnions
            // 
            this.chkOnions.AutoSize = true;
            this.chkOnions.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnions.Location = new System.Drawing.Point(6, 114);
            this.chkOnions.Name = "chkOnions";
            this.chkOnions.Size = new System.Drawing.Size(55, 19);
            this.chkOnions.TabIndex = 9;
            this.chkOnions.Text = "Onions";
            this.chkOnions.UseVisualStyleBackColor = true;
            // 
            // chkTomato
            // 
            this.chkTomato.AutoSize = true;
            this.chkTomato.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTomato.Location = new System.Drawing.Point(6, 91);
            this.chkTomato.Name = "chkTomato";
            this.chkTomato.Size = new System.Drawing.Size(57, 19);
            this.chkTomato.TabIndex = 8;
            this.chkTomato.Text = "Tomato";
            this.chkTomato.UseVisualStyleBackColor = true;
            // 
            // chkLettuce
            // 
            this.chkLettuce.AutoSize = true;
            this.chkLettuce.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLettuce.Location = new System.Drawing.Point(6, 68);
            this.chkLettuce.Name = "chkLettuce";
            this.chkLettuce.Size = new System.Drawing.Size(55, 19);
            this.chkLettuce.TabIndex = 7;
            this.chkLettuce.Text = "Lettuce";
            this.chkLettuce.UseVisualStyleBackColor = true;
            // 
            // chkMayo
            // 
            this.chkMayo.AutoSize = true;
            this.chkMayo.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMayo.Location = new System.Drawing.Point(6, 45);
            this.chkMayo.Name = "chkMayo";
            this.chkMayo.Size = new System.Drawing.Size(77, 19);
            this.chkMayo.TabIndex = 6;
            this.chkMayo.Text = "Mayonnaise";
            this.chkMayo.UseVisualStyleBackColor = true;
            // 
            // chkMustard
            // 
            this.chkMustard.AutoSize = true;
            this.chkMustard.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMustard.Location = new System.Drawing.Point(6, 22);
            this.chkMustard.Name = "chkMustard";
            this.chkMustard.Size = new System.Drawing.Size(59, 19);
            this.chkMustard.TabIndex = 5;
            this.chkMustard.Text = "Mustard";
            this.chkMustard.UseVisualStyleBackColor = true;
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(376, 43);
            this.txtOrder.Multiline = true;
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOrder.Size = new System.Drawing.Size(172, 241);
            this.txtOrder.TabIndex = 2;
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(373, 24);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(48, 16);
            this.lblOrder.TabIndex = 3;
            this.lblOrder.Text = "Order:";
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(376, 293);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(172, 28);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(376, 327);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(172, 28);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 367);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.txtOrder);
            this.Controls.Add(this.grpCheese);
            this.Controls.Add(this.grpMeats);
            this.Controls.Add(this.grpCondiments);
            this.Controls.Add(this.grpBread);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sandwich Maker";
            this.grpBread.ResumeLayout(false);
            this.grpBread.PerformLayout();
            this.grpCheese.ResumeLayout(false);
            this.grpCheese.PerformLayout();
            this.grpMeats.ResumeLayout(false);
            this.grpMeats.PerformLayout();
            this.grpCondiments.ResumeLayout(false);
            this.grpCondiments.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBread;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpCheese;
        private System.Windows.Forms.GroupBox grpMeats;
        private System.Windows.Forms.CheckBox chkSalami;
        private System.Windows.Forms.CheckBox chkPastrami;
        private System.Windows.Forms.CheckBox chkTurkey;
        private System.Windows.Forms.CheckBox chkHam;
        private System.Windows.Forms.CheckBox chkRoastBeef;
        private System.Windows.Forms.GroupBox grpCondiments;
        private System.Windows.Forms.CheckBox chkPickles;
        private System.Windows.Forms.CheckBox chkOnions;
        private System.Windows.Forms.CheckBox chkTomato;
        private System.Windows.Forms.CheckBox chkLettuce;
        private System.Windows.Forms.CheckBox chkMayo;
        private System.Windows.Forms.CheckBox chkMustard;
        private System.Windows.Forms.RadioButton rdoRye;
        private System.Windows.Forms.RadioButton rdoWheat;
        private System.Windows.Forms.RadioButton rdoWhite;
        private System.Windows.Forms.RadioButton rdoSwiss;
        private System.Windows.Forms.RadioButton rdoAmerican;
        private System.Windows.Forms.RadioButton rodNone;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnClear;
    }
}

