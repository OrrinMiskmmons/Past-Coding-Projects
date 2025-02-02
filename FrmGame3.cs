using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Miskimmons__Orrin___AS_SSD_Coursework
{
    public partial class FrmGame3 : Form
    {
        #region Basic workings
        public FrmGame3()
        {
            InitializeComponent();
            restartGame();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            //saving score
            MechanicLoggedIn.publicCurrentUser.SaveScore(score);

            DialogResult result = MessageBox.Show("Do you want to leave the game?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                FrmMainMenu newForm = new FrmMainMenu();
                newForm.Show();
                this.Hide();
            }
        }

        #endregion

        #region Car Game Code

        Random random = new Random(); //this random variable will save a random number inside of the carImage variable to change the image of the car picture boxes
        Random carLocationOnRoad = new Random(); //This will generate a random position on the road for the two different cars within the game allowing them to be in a different spot everytime

        // private member variables
        int trafficSpeed; //Speed of the traffic
        int score; //Score which is calculate by the timer as it pluses 1 for every second
        int carImage; // Allows the picture boxes to change depending on the random number generator
        int roadSpeed; //Speed of the road  
        int playerSpeed = 8; //Speed of the player

        bool cargoleft; // Move the player left aswell as set a limit to how far the player can move before being stopped
        bool cargoright;// Move the player rigth aswell as set a limit to how far the player can move before being stopped
        bool noFuelMessageBoxShown = false;

        private void keyisdown(object sender, KeyEventArgs e) // doesn't work when i press the left or right key
         {
            if (e.KeyCode == Keys.A) // setting the keys for the user to move the car
            {
                cargoleft = true;
            }
            if (e.KeyCode == Keys.D)
            {
                cargoright = true;
            }
        }
        
        private void keyisup(object sender, KeyEventArgs e) 
        {
            if (e.KeyCode == Keys.A) //when the keys are released they will make the car stop moving
            {
                cargoleft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                cargoright = false;
            }
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            lblScore.Text = "Score " + score; // Displaying the score value
            score++; //Adding to the score

            if (cargoleft == true && picPlayerCar.Left > 10) // moving the car left
            {
                picPlayerCar.Left -= playerSpeed;
            }
            if (cargoright == true && picPlayerCar.Left < 415) //moving the car rigth
            {
                picPlayerCar.Left += playerSpeed;
            }

            //making it look like the road look like its moving
            picRoad.Top += roadSpeed;
            picRoad2.Top += roadSpeed;

            // getting the road to cycle between each other to make it look like its moving
            if (picRoad2.Top > 584)
            {
                picRoad2.Top = -584;
            }
            if (picRoad.Top > 584)
            {
                picRoad.Top = -584;
            }
            
            // making the cars and fuelcan move with the traffic speed value
            picCar1.Top += trafficSpeed;
            picCar2.Top += trafficSpeed;
            picFuelCan.Top += trafficSpeed;

            //Changing car image to a different one everytime
            if (picCar1.Top > 598)
            {
                changepicCars(picCar1);
            }

            if (picCar2.Top > 598)
            {
                changepicCars(picCar2);
            }
            // Check if the fuel can has moved past the bottom of the screen
            if (picFuelCan.Top > 700)
            {
                // Reset the position of the fuel can
                ResetFuelCanPosition();
            }

            // it the player hits the boundary of a car or the fuel can it will execute the code
            if (picPlayerCar.Bounds.IntersectsWith(picCar1.Bounds) || picPlayerCar.Bounds.IntersectsWith(picCar2.Bounds))
            {
                gameOver();
            }
            // it the player's car hits the boundary fo the fuel can it will reset the fuelbar
            if (picPlayerCar.Bounds.IntersectsWith(picFuelCan.Bounds))
            {
                FuelBar.Width = 440;
                FuelBar.Height = 35;
                picFuelCan.Visible = false;
            }
            // Changing the speed based on the score the player has achieved
            if (score > 100 && score < 500)
            {
                picRewardBanner.Image = Properties.Resources.Bronze;
            }

            if (score > 500 && score < 1000)
            {
                picRewardBanner.Image = Properties.Resources.Silver;
                trafficSpeed = 13;
                roadSpeed = 13;
            }

            if (score > 1000)
            {
                picRewardBanner.Image = Properties.Resources.gold;
                trafficSpeed = 20;
                roadSpeed = 20;
            }
        }

        private void ResetFuelCanPosition()
        {
            // Setting the max coordinates for the fuel can to move too
            int maxX = 400;
            int maxY = 200;

            // Generate random X and Y coordinates within reasonable ranges
            int randomX = random.Next(0, maxX);
            int randomY = random.Next(0, maxY);

            // Set the fuel can's location
            picFuelCan.Visible = true;
            picFuelCan.Location = new Point(randomX, randomY);
        }

        private void changepicCars(PictureBox car)
        {

            carImage = random.Next(1, 7);

            switch (carImage) // Setting the pictuer box to differnt cars using a switch statement and a random number generator with values from 1 to 7
            {

                case 1:
                    car.Image = Properties.Resources.ambulance;
                    break;
                case 2:
                    car.Image = Properties.Resources.brown_car;
                    break;
                case 3:
                    car.Image = Properties.Resources.Greencar;
                    break;
                case 4:
                    car.Image = Properties.Resources.fire_truck;
                    break;
                case 5:
                    car.Image = Properties.Resources.truck;
                    break;
                case 6:
                    car.Image = Properties.Resources.White_Car;
                    break;
                case 7:
                    car.Image = Properties.Resources.Yellow_car;
                    break;
            }

            car.Top = carLocationOnRoad.Next(100, 400) * -1;
            
            // taking the car image out of the switch statement and setting it equal to the a corresponding car
            if ((string)car.Tag == "LeftCar")
            {
                //setting the area of where the cars can spawn
                car.Left = carLocationOnRoad.Next(5, 230);
            }
            if ((string)car.Tag == "RightCar")
            {
                //setting the area of where the cars can spawn
                picCar2.Left = carLocationOnRoad.Next(245, 430);
            }
        }

        private void restartGame()
        {
            // Resetting all the values to make sure the game starts from scratch
            btnStartGame.Enabled = false;
            picExplosion.Visible = false;
            picRewardBanner.Visible = false;
            cargoleft = false;
            cargoright = false;
            score = 0;
            picRewardBanner.Image = Properties.Resources.Bronze;
            FuelBar.Width = 480;
            roadSpeed = 8;
            trafficSpeed = 10;
            noFuelMessageBoxShown = false;

            // Randomly position the cars on the road
            picCar1.Top = carLocationOnRoad.Next(200, 460) * -1;
            picCar1.Left = carLocationOnRoad.Next(5, 200);

            picCar2.Top = carLocationOnRoad.Next(200, 460) * -1;
            picCar2.Left = carLocationOnRoad.Next(245, 283);

            // Randomly position the fuel can on the road
            int maxX = this.ClientSize.Width - picFuelCan.Width;
            int maxY = this.ClientSize.Height - picFuelCan.Height;
            picFuelCan.Location = new Point(random.Next(maxX), random.Next(maxY));
        

            // Start the game timers
            GameTimer.Start();
            HealthBarTimer.Start();
        }

        private void playCrashSound()
        {
            System.Media.SoundPlayer playCrashSound = new System.Media.SoundPlayer(Properties.Resources.Crash_sound);
            playCrashSound.Play();
        }

        private void gameOver()
        {
            playCrashSound();
            GameTimer.Stop();
            HealthBarTimer.Stop();
            picExplosion.Visible = true;
            picPlayerCar.Controls.Add(picExplosion);
            picExplosion.Location = new Point(-8, 5);
            picExplosion.BackColor = Color.Transparent;

            if (FuelBar.Width == 0 && noFuelMessageBoxShown == false)
            {
                MessageBox.Show("You ran out of fuel. Make sure to collect the fuel cans to extend your range of the car.");
                noFuelMessageBoxShown = true;
            }

            #region score messagebox
            //Sending a messagebox based on the score the user achieves
            if (score < 500)
            {
                MessageBox.Show("Nice try, you got a bronze medal! To improve your score try avoid the cars! Press the restart button to have another go");
            }
            if (score > 500 && score < 1000)
            {
                MessageBox.Show("Congratulations!! You have dodged enough cars to rewared a silver medal. However there still a gold medal up for grabs. Press start game to have another go.");
            }
            if (score > 1000)
            {
                MessageBox.Show("Well Done!! You have achieved a gold medal. Press the start game button to have another go.");
            }
            #endregion

            //making sure the user can see the reward banner
            picRewardBanner.Visible = true;
            picRewardBanner.BringToFront();

            // enabling the user to restart the game
            btnStartGame.Enabled = true;
        }

        private void restartGame(object sender, EventArgs e)
        {
            //Being able to restart the game
            picPlayerCar.Visible = true;
            picFuelCan.Visible = true;
            restartGame();
        }

        private void HealthBarTimer_Tick(object sender, EventArgs e)
        {
            FuelBar.Size = new Size(FuelBar.Size.Width - 1, 23);
            if (FuelBar.Width == 0 && noFuelMessageBoxShown == false)
            {
                gameOver();
                //noFuelMessageBoxShown = true;
            }
        }

        private void pbHelp_Click(object sender, EventArgs e)
        {
            FrmHelpGame3 frmHelpGame3 = new FrmHelpGame3();
            frmHelpGame3.ShowDialog();
        }
        #endregion

        private void FrmGame3_Load(object sender, EventArgs e)
        {
            GameTimer.Stop();
            HealthBarTimer.Stop();
            btnStartGame.Enabled = true;
            picFuelCan.Visible = false;
            picPlayerCar.Visible = false;
        }
    }
}
