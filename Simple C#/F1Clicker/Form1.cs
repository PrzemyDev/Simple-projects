using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker
{
    public partial class Form1 : Form
    {
        int PointsPerClick, PointsPerSecond, Points;
        bool uComs, uTools, uTmate, uSuit, uWheels, uSWheel, EndGame=false;

        private Repository _repository;
        public Form1()
        {
            InitializeComponent();
            _repository = new Repository();
            LoadAll();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Points += PointsPerSecond;
            UpdateScore();
            if (Points >= 10000 && EndGame == false)
            {
                timer1.Enabled = false;

                var result = MessageBox.Show("Congratulations! You are the world champion of 2021 formula one season!" +
                    " Thank you for playing! You can still grind points if you want or restart the game :)","Game Finished!");
                if (result == DialogResult.OK)
                {
                    timer1.Enabled = true;
                    EndGame = true;
                }
            }
        }
        private void bttnUpgradesPPC_Click(object sender, EventArgs e)
        {
            gboxPPS.Visible = false;
            gboxPPC.Visible = true;
            bttnUpgradesPPS.Enabled = true;
            bttnUpgradesPPC.Enabled = false;
        }

        private void bttnUpgradesPPS_Click(object sender, EventArgs e)
        {
            gboxPPC.Visible = false;
            gboxPPS.Visible = true;
            bttnUpgradesPPC.Enabled = true;
            bttnUpgradesPPS.Enabled = false;
        }

        private void bttnSaveGame1_Click(object sender, EventArgs e)
        {
           var result =  _repository.UpdateSave(new Save()
            {
                Points = Points,
                PointsPerClick = PointsPerClick,
                PointsPerSecond = PointsPerSecond,
                UpgrSuit = uSuit,
                UpgrWheels = uWheels,
                UpgrSteeringWheel = uSWheel,
                UpgrCommunications = uComs,
                UpgrTools = uTools,
                UpgrTeammate = uTmate
           });

            if (result)
                MessageBox.Show("The game state has been saved successfully!", "Confirmation");
            else
                MessageBox.Show("An error occurred while saving the game state!", "Error");
        }
        private void LoadAll()
        {
            int pts = LoadPTS();
            int ppc = LoadPPC();
            int pps = LoadPPS();

            Points = pts;
            PointsPerClick = ppc;
            PointsPerSecond = pps;
            UpdateScore();
            LoadUpgrades();
        }
        private int LoadPTS()
        {
            var data = _repository.GetPTS();
            return data;
        }
        private int LoadPPC()
        {
            var data = _repository.GetPPC();
            return data;
        }
        private int LoadPPS()
        {
            var data = _repository.GetPPS();
            return data;
        }
        private bool LoadUpgrades()
        {
            var data = _repository.GetUpgradesSuit();
            if (data == true) 
            {
                uSuit = true;
                lblSuitBuy.Text = "1/1\n + 5PPC";
                picboxSuit.Enabled = false;
            }
            data = _repository.GetUpgradesWheels();
            if (data == true) 
            {
                uWheels = true;
                lblWheelsBuy.Text = "1/1\n + 15PPC";
                picboxWheels.Enabled = false;
            }
            data = _repository.GetUpgradesSteeringWheel();
            if (data == true) 
            {
                uSWheel = true;
                lblSteeringWheelBuy.Text = "1/1\n + 30PPC";
                picboxSteeringWheel.Enabled = false;
            }
            data = _repository.GetUpgradesCommunications();
            if (data == true) 
            {
                uComs = true;
                lblCommunicationsBuy.Text = "1/1\n + 5PPS";
                picboxCommunications.Enabled = false;
            }
            data = _repository.GetUpgradesTools();
            if (data == true) 
            { 
                uTools = true;
                lblToolsBuy.Text = "1/1\n + 15PPS";
                picboxTools.Enabled = false;
            }
            data = _repository.GetUpgradesTeammate();
            if (data == true) 
            { 
                uTmate = true;
                lblTeammateBuy.Text = "1/1\n + 30PPS";
                picboxTeammate.Enabled = false;
            }
            return true;    
        }

        private void bttnReset_Click(object sender, EventArgs e)
        {
            var BoxResult = MessageBox.Show("Are you sure you want to reset game progess?\n" +
                "You will start from the beginng.", "Confirmation", 
                MessageBoxButtons.YesNo);
            if (BoxResult == DialogResult.Yes) { 
                uComs = uTools = uTmate = uSuit = uWheels = uSWheel = EndGame = false;
                Points = PointsPerSecond = 0; 
                PointsPerClick = 1;
                ResetBuyLabels();
                UpdateScore();

                var result = _repository.UpdateSave(new Save()
            {
                Points = 0,
                PointsPerClick = PointsPerClick,
                PointsPerSecond = PointsPerSecond,
                UpgrSuit = uSuit,
                UpgrWheels = uWheels,
                UpgrSteeringWheel = uSWheel,
                UpgrCommunications = uComs,
                UpgrTools = uTools,
                UpgrTeammate = uTmate
            });

            if (result)
                MessageBox.Show("The game state has been reset successfully!", "Confirmation");
            }
        }

        private void picboxClickArea_MouseDown(object sender, MouseEventArgs e)
        {
            Points += PointsPerClick;
            UpdateScore();
        }

        private void picboxCommunications_Click(object sender, EventArgs e)
        {
            if (Points >= 25)
            {
                MessageBox.Show("Upgrade purchased!");
                uComs = true;
                PointsPerSecond += 5;
                lblCommunicationsBuy.Text = "1/1\n + 5PPS";
                Points -= 25;
                picboxCommunications.Enabled = false;
            }
            else
                MessageBox.Show("Can't afford that yet!");
        }

        private void picboxTeammate_Click(object sender, EventArgs e)
        {
            if (Points >= 1760)
            {
                MessageBox.Show("Upgrade purchased!");
                uTmate = true;
                PointsPerSecond += 30;
                lblTeammateBuy.Text = "1/1\n + 30PPS";
                Points -= 1760;
                picboxTeammate.Enabled = false;
            }
            else
                MessageBox.Show("Can't afford that yet!");
        }

        private void picboxSuit_Click(object sender, EventArgs e)
        {
            if (Points >= 25)
            {
                MessageBox.Show("Upgrade purchased!");
                uSuit = true;
                PointsPerClick += 5;
                lblSuitBuy.Text = "1/1\n + 5PPC";
                Points -= 25;
                picboxSuit.Enabled = false;
            }
            else
                MessageBox.Show("Can't afford that yet!");
        }

        private void picboxWheels_Click(object sender, EventArgs e)
        {
            
            if (Points >= 500)
            {
                MessageBox.Show("Upgrade purchased!");
                uWheels = true;
                PointsPerClick += 15;
                lblWheelsBuy.Text = "1/1\n + 15PPC";
                Points -= 500;
                picboxWheels.Enabled = false;
            }
            else
                MessageBox.Show("Can't afford that yet!");
        }

        private void picboxTools_Click(object sender, EventArgs e)
        {
            
            if (Points >= 500)
            {
                MessageBox.Show("Upgrade purchased!");
                uTools = true;
                PointsPerSecond += 15;
                lblToolsBuy.Text = "1/1\n + 15PPS";
                Points -= 500;
                picboxTools.Enabled = false;
            }
            else
                MessageBox.Show("Can't afford that yet!");
        }

        private void picboxSteeringWheel_Click(object sender, EventArgs e)
        {
            
            if (Points >= 1760)
            {
                MessageBox.Show("Upgrade purchased!");
                uSWheel = true;
                PointsPerClick += 30;
                lblSteeringWheelBuy.Text = "1/1\n + 30PPC";
                Points -= 1760;
                picboxSteeringWheel.Enabled = false;
            }
            else
                MessageBox.Show("Can't afford that yet!");
        }

        private void UpdateScore()
        {
            lblScore.Text = $"Points: {Points} | {PointsPerClick} / click  | {PointsPerSecond} / sec";
        }

        private void ResetBuyLabels()
        {
            lblSuitBuy.Text = "0/1\r\n25pts\r\n+5PPC";
            lblWheelsBuy.Text = "0/1\r\n500pts\r\n+15PPC";
            lblSteeringWheelBuy.Text = "0/1\r\n1760pts\r\n+30PPC";
            lblCommunicationsBuy.Text = "0/1\r\n25pts\r\n+5PPS";
            lblToolsBuy.Text = "0/1\r\n500pts\r\n+15PPS";
            lblTeammateBuy.Text = "0/1\r\n1760pts\r\n+30PPS";
        }
    }
}
