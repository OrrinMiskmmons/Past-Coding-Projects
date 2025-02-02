
namespace Miskimmons__Orrin___AS_SSD_Coursework
{
    partial class FrmGame3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGame3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.HealthBarTimer = new System.Windows.Forms.Timer(this.components);
            this.FuelBar = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.pbHelp = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.picFuelCan = new System.Windows.Forms.PictureBox();
            this.picCar1 = new System.Windows.Forms.PictureBox();
            this.picCar2 = new System.Windows.Forms.PictureBox();
            this.picExplosion = new System.Windows.Forms.PictureBox();
            this.picRewardBanner = new System.Windows.Forms.PictureBox();
            this.picPlayerCar = new System.Windows.Forms.PictureBox();
            this.picRoad2 = new System.Windows.Forms.PictureBox();
            this.picRoad = new System.Windows.Forms.PictureBox();
            this.GasCan = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFuelCan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExplosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRewardBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoad2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GasCan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.picFuelCan);
            this.panel1.Controls.Add(this.picCar1);
            this.panel1.Controls.Add(this.picCar2);
            this.panel1.Controls.Add(this.picExplosion);
            this.panel1.Controls.Add(this.picRewardBanner);
            this.panel1.Controls.Add(this.picPlayerCar);
            this.panel1.Controls.Add(this.picRoad2);
            this.panel1.Controls.Add(this.picRoad);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 598);
            this.panel1.TabIndex = 0;
            // 
            // btnStartGame
            // 
            this.btnStartGame.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.Location = new System.Drawing.Point(22, 671);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(158, 48);
            this.btnStartGame.TabIndex = 1;
            this.btnStartGame.Text = "Start game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.restartGame);
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(12, 641);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(480, 22);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score: 0";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // HealthBarTimer
            // 
            this.HealthBarTimer.Interval = 10;
            this.HealthBarTimer.Tick += new System.EventHandler(this.HealthBarTimer_Tick);
            // 
            // FuelBar
            // 
            this.FuelBar.BackColor = System.Drawing.Color.LawnGreen;
            this.FuelBar.Location = new System.Drawing.Point(0, 0);
            this.FuelBar.Name = "FuelBar";
            this.FuelBar.Size = new System.Drawing.Size(440, 35);
            this.FuelBar.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Controls.Add(this.FuelBar);
            this.panel3.Location = new System.Drawing.Point(52, 616);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(440, 23);
            this.panel3.TabIndex = 6;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(118, 722);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(267, 20);
            this.lblInstructions.TabIndex = 15;
            this.lblInstructions.Text = "Use A to move left and use D to move right";
            // 
            // pbHelp
            // 
            this.pbHelp.Image = global::Miskimmons__Orrin___AS_SSD_Coursework.Properties.Resources.help_page_image;
            this.pbHelp.Location = new System.Drawing.Point(233, 680);
            this.pbHelp.Name = "pbHelp";
            this.pbHelp.Size = new System.Drawing.Size(49, 28);
            this.pbHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHelp.TabIndex = 14;
            this.pbHelp.TabStop = false;
            this.pbHelp.Click += new System.EventHandler(this.pbHelp_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.LightBlue;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLogout.Location = new System.Drawing.Point(383, 671);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(84, 48);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // picFuelCan
            // 
            this.picFuelCan.BackColor = System.Drawing.Color.Black;
            this.picFuelCan.Image = ((System.Drawing.Image)(resources.GetObject("picFuelCan.Image")));
            this.picFuelCan.Location = new System.Drawing.Point(424, 558);
            this.picFuelCan.Name = "picFuelCan";
            this.picFuelCan.Size = new System.Drawing.Size(40, 40);
            this.picFuelCan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFuelCan.TabIndex = 3;
            this.picFuelCan.TabStop = false;
            this.picFuelCan.Tag = "FuelCan";
            // 
            // picCar1
            // 
            this.picCar1.BackColor = System.Drawing.Color.Black;
            this.picCar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picCar1.Image = global::Miskimmons__Orrin___AS_SSD_Coursework.Properties.Resources.Yellow_car;
            this.picCar1.Location = new System.Drawing.Point(84, 44);
            this.picCar1.Name = "picCar1";
            this.picCar1.Size = new System.Drawing.Size(49, 96);
            this.picCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCar1.TabIndex = 2;
            this.picCar1.TabStop = false;
            this.picCar1.Tag = "LeftCar";
            // 
            // picCar2
            // 
            this.picCar2.BackColor = System.Drawing.Color.Black;
            this.picCar2.Image = global::Miskimmons__Orrin___AS_SSD_Coursework.Properties.Resources.White_Car;
            this.picCar2.InitialImage = ((System.Drawing.Image)(resources.GetObject("picCar2.InitialImage")));
            this.picCar2.Location = new System.Drawing.Point(266, 64);
            this.picCar2.Name = "picCar2";
            this.picCar2.Size = new System.Drawing.Size(47, 96);
            this.picCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCar2.TabIndex = 2;
            this.picCar2.TabStop = false;
            this.picCar2.Tag = "RightCar";
            // 
            // picExplosion
            // 
            this.picExplosion.BackColor = System.Drawing.Color.Black;
            this.picExplosion.Image = ((System.Drawing.Image)(resources.GetObject("picExplosion.Image")));
            this.picExplosion.Location = new System.Drawing.Point(104, 457);
            this.picExplosion.Name = "picExplosion";
            this.picExplosion.Size = new System.Drawing.Size(64, 64);
            this.picExplosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picExplosion.TabIndex = 2;
            this.picExplosion.TabStop = false;
            // 
            // picRewardBanner
            // 
            this.picRewardBanner.BackColor = System.Drawing.Color.Black;
            this.picRewardBanner.Image = ((System.Drawing.Image)(resources.GetObject("picRewardBanner.Image")));
            this.picRewardBanner.Location = new System.Drawing.Point(104, 285);
            this.picRewardBanner.Name = "picRewardBanner";
            this.picRewardBanner.Size = new System.Drawing.Size(267, 55);
            this.picRewardBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRewardBanner.TabIndex = 2;
            this.picRewardBanner.TabStop = false;
            this.picRewardBanner.Tag = "Reward";
            // 
            // picPlayerCar
            // 
            this.picPlayerCar.BackColor = System.Drawing.Color.Black;
            this.picPlayerCar.Image = global::Miskimmons__Orrin___AS_SSD_Coursework.Properties.Resources.Purple_car;
            this.picPlayerCar.Location = new System.Drawing.Point(205, 493);
            this.picPlayerCar.Name = "picPlayerCar";
            this.picPlayerCar.Size = new System.Drawing.Size(52, 102);
            this.picPlayerCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayerCar.TabIndex = 2;
            this.picPlayerCar.TabStop = false;
            this.picPlayerCar.Tag = "PlayerCar";
            // 
            // picRoad2
            // 
            this.picRoad2.BackColor = System.Drawing.Color.Black;
            this.picRoad2.Image = ((System.Drawing.Image)(resources.GetObject("picRoad2.Image")));
            this.picRoad2.Location = new System.Drawing.Point(0, -598);
            this.picRoad2.Name = "picRoad2";
            this.picRoad2.Size = new System.Drawing.Size(480, 598);
            this.picRoad2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRoad2.TabIndex = 1;
            this.picRoad2.TabStop = false;
            // 
            // picRoad
            // 
            this.picRoad.BackColor = System.Drawing.Color.Black;
            this.picRoad.Image = ((System.Drawing.Image)(resources.GetObject("picRoad.Image")));
            this.picRoad.Location = new System.Drawing.Point(0, 0);
            this.picRoad.Name = "picRoad";
            this.picRoad.Size = new System.Drawing.Size(480, 598);
            this.picRoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRoad.TabIndex = 0;
            this.picRoad.TabStop = false;
            // 
            // GasCan
            // 
            this.GasCan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GasCan.BackColor = System.Drawing.Color.Transparent;
            this.GasCan.Image = ((System.Drawing.Image)(resources.GetObject("GasCan.Image")));
            this.GasCan.Location = new System.Drawing.Point(12, 607);
            this.GasCan.Name = "GasCan";
            this.GasCan.Size = new System.Drawing.Size(34, 44);
            this.GasCan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GasCan.TabIndex = 7;
            this.GasCan.TabStop = false;
            // 
            // FrmGame3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(504, 741);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.pbHelp);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.GasCan);
            this.KeyPreview = true;
            this.Name = "FrmGame3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rally Racers";
            this.Load += new System.EventHandler(this.FrmGame3_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFuelCan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExplosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRewardBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoad2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GasCan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox picExplosion;
        private System.Windows.Forms.PictureBox picCar2;
        private System.Windows.Forms.PictureBox picCar1;
        private System.Windows.Forms.PictureBox picRewardBanner;
        private System.Windows.Forms.PictureBox picPlayerCar;
        private System.Windows.Forms.PictureBox picRoad2;
        private System.Windows.Forms.PictureBox picRoad;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Timer HealthBarTimer;
        private System.Windows.Forms.Panel FuelBar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox GasCan;
        private System.Windows.Forms.PictureBox picFuelCan;
        private System.Windows.Forms.PictureBox pbHelp;
        private System.Windows.Forms.Label lblInstructions;
    }
}