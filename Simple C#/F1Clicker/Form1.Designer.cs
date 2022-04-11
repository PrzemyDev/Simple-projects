
namespace Clicker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gboxPPC = new System.Windows.Forms.GroupBox();
            this.lblTeammateBuy = new System.Windows.Forms.Label();
            this.lblSuitBuy = new System.Windows.Forms.Label();
            this.lblWheelsBuy = new System.Windows.Forms.Label();
            this.lblSteeringWheel = new System.Windows.Forms.Label();
            this.lblWheels = new System.Windows.Forms.Label();
            this.lblSuit = new System.Windows.Forms.Label();
            this.picboxSteeringWheel = new System.Windows.Forms.PictureBox();
            this.picboxWheels = new System.Windows.Forms.PictureBox();
            this.picboxSuit = new System.Windows.Forms.PictureBox();
            this.lblSteeringWheelBuy = new System.Windows.Forms.Label();
            this.gboxPPS = new System.Windows.Forms.GroupBox();
            this.lblToolsBuy = new System.Windows.Forms.Label();
            this.lblCommunicationsBuy = new System.Windows.Forms.Label();
            this.lblTeammate = new System.Windows.Forms.Label();
            this.lblTools = new System.Windows.Forms.Label();
            this.lblCommunications = new System.Windows.Forms.Label();
            this.picboxTeammate = new System.Windows.Forms.PictureBox();
            this.picboxTools = new System.Windows.Forms.PictureBox();
            this.picboxCommunications = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.picboxClickArea = new System.Windows.Forms.PictureBox();
            this.bttnUpgradesPPS = new System.Windows.Forms.Button();
            this.bttnUpgradesPPC = new System.Windows.Forms.Button();
            this.lblUpgradesSection = new System.Windows.Forms.Label();
            this.bttnSaveGame1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblScoreGoal = new System.Windows.Forms.Label();
            this.bttnReset = new System.Windows.Forms.Button();
            this.gboxPPC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSteeringWheel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxWheels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSuit)).BeginInit();
            this.gboxPPS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxTeammate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxTools)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxCommunications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClickArea)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxPPC
            // 
            this.gboxPPC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gboxPPC.Controls.Add(this.lblTeammateBuy);
            this.gboxPPC.Controls.Add(this.lblSuitBuy);
            this.gboxPPC.Controls.Add(this.lblWheelsBuy);
            this.gboxPPC.Controls.Add(this.lblSteeringWheel);
            this.gboxPPC.Controls.Add(this.lblWheels);
            this.gboxPPC.Controls.Add(this.lblSuit);
            this.gboxPPC.Controls.Add(this.picboxSteeringWheel);
            this.gboxPPC.Controls.Add(this.picboxWheels);
            this.gboxPPC.Controls.Add(this.picboxSuit);
            this.gboxPPC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gboxPPC.Location = new System.Drawing.Point(340, 10);
            this.gboxPPC.Name = "gboxPPC";
            this.gboxPPC.Size = new System.Drawing.Size(180, 420);
            this.gboxPPC.TabIndex = 0;
            this.gboxPPC.TabStop = false;
            this.gboxPPC.Text = "Points per click";
            // 
            // lblTeammateBuy
            // 
            this.lblTeammateBuy.AutoSize = true;
            this.lblTeammateBuy.Location = new System.Drawing.Point(5, 333);
            this.lblTeammateBuy.Name = "lblTeammateBuy";
            this.lblTeammateBuy.Size = new System.Drawing.Size(52, 45);
            this.lblTeammateBuy.TabIndex = 14;
            this.lblTeammateBuy.Text = "0/1\r\n1760pts\r\n+30PPS";
            // 
            // lblSuitBuy
            // 
            this.lblSuitBuy.AutoSize = true;
            this.lblSuitBuy.Location = new System.Drawing.Point(6, 74);
            this.lblSuitBuy.Name = "lblSuitBuy";
            this.lblSuitBuy.Size = new System.Drawing.Size(43, 45);
            this.lblSuitBuy.TabIndex = 15;
            this.lblSuitBuy.Text = "0/1\r\n25pts\r\n+5PPC";
            // 
            // lblWheelsBuy
            // 
            this.lblWheelsBuy.AutoSize = true;
            this.lblWheelsBuy.Location = new System.Drawing.Point(7, 188);
            this.lblWheelsBuy.Name = "lblWheelsBuy";
            this.lblWheelsBuy.Size = new System.Drawing.Size(50, 45);
            this.lblWheelsBuy.TabIndex = 16;
            this.lblWheelsBuy.Text = "0/1\r\n500pts\r\n+15PPC";
            // 
            // lblSteeringWheel
            // 
            this.lblSteeringWheel.AutoSize = true;
            this.lblSteeringWheel.Location = new System.Drawing.Point(56, 277);
            this.lblSteeringWheel.Name = "lblSteeringWheel";
            this.lblSteeringWheel.Size = new System.Drawing.Size(94, 15);
            this.lblSteeringWheel.TabIndex = 14;
            this.lblSteeringWheel.Text = "Steering Wheel";
            // 
            // lblWheels
            // 
            this.lblWheels.AutoSize = true;
            this.lblWheels.BackColor = System.Drawing.SystemColors.Control;
            this.lblWheels.Location = new System.Drawing.Point(56, 148);
            this.lblWheels.Name = "lblWheels";
            this.lblWheels.Size = new System.Drawing.Size(48, 15);
            this.lblWheels.TabIndex = 13;
            this.lblWheels.Text = "Wheels";
            // 
            // lblSuit
            // 
            this.lblSuit.AutoSize = true;
            this.lblSuit.Location = new System.Drawing.Point(56, 22);
            this.lblSuit.Name = "lblSuit";
            this.lblSuit.Size = new System.Drawing.Size(29, 15);
            this.lblSuit.TabIndex = 12;
            this.lblSuit.Text = "Suit";
            // 
            // picboxSteeringWheel
            // 
            this.picboxSteeringWheel.Image = ((System.Drawing.Image)(resources.GetObject("picboxSteeringWheel.Image")));
            this.picboxSteeringWheel.Location = new System.Drawing.Point(55, 277);
            this.picboxSteeringWheel.Name = "picboxSteeringWheel";
            this.picboxSteeringWheel.Size = new System.Drawing.Size(120, 120);
            this.picboxSteeringWheel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picboxSteeringWheel.TabIndex = 2;
            this.picboxSteeringWheel.TabStop = false;
            this.picboxSteeringWheel.Click += new System.EventHandler(this.picboxSteeringWheel_Click);
            // 
            // picboxWheels
            // 
            this.picboxWheels.Image = ((System.Drawing.Image)(resources.GetObject("picboxWheels.Image")));
            this.picboxWheels.Location = new System.Drawing.Point(55, 148);
            this.picboxWheels.Name = "picboxWheels";
            this.picboxWheels.Size = new System.Drawing.Size(120, 120);
            this.picboxWheels.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picboxWheels.TabIndex = 1;
            this.picboxWheels.TabStop = false;
            this.picboxWheels.Click += new System.EventHandler(this.picboxWheels_Click);
            // 
            // picboxSuit
            // 
            this.picboxSuit.Image = ((System.Drawing.Image)(resources.GetObject("picboxSuit.Image")));
            this.picboxSuit.Location = new System.Drawing.Point(55, 22);
            this.picboxSuit.Name = "picboxSuit";
            this.picboxSuit.Size = new System.Drawing.Size(120, 120);
            this.picboxSuit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picboxSuit.TabIndex = 3;
            this.picboxSuit.TabStop = false;
            this.picboxSuit.Click += new System.EventHandler(this.picboxSuit_Click);
            // 
            // lblSteeringWheelBuy
            // 
            this.lblSteeringWheelBuy.AutoSize = true;
            this.lblSteeringWheelBuy.Location = new System.Drawing.Point(5, 333);
            this.lblSteeringWheelBuy.Name = "lblSteeringWheelBuy";
            this.lblSteeringWheelBuy.Size = new System.Drawing.Size(52, 45);
            this.lblSteeringWheelBuy.TabIndex = 17;
            this.lblSteeringWheelBuy.Text = "0/1\r\n1760pts\r\n+30PPC";
            // 
            // gboxPPS
            // 
            this.gboxPPS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gboxPPS.Controls.Add(this.lblToolsBuy);
            this.gboxPPS.Controls.Add(this.lblSteeringWheelBuy);
            this.gboxPPS.Controls.Add(this.lblCommunicationsBuy);
            this.gboxPPS.Controls.Add(this.lblTeammate);
            this.gboxPPS.Controls.Add(this.lblTools);
            this.gboxPPS.Controls.Add(this.lblCommunications);
            this.gboxPPS.Controls.Add(this.picboxTeammate);
            this.gboxPPS.Controls.Add(this.picboxTools);
            this.gboxPPS.Controls.Add(this.picboxCommunications);
            this.gboxPPS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gboxPPS.Location = new System.Drawing.Point(340, 10);
            this.gboxPPS.Name = "gboxPPS";
            this.gboxPPS.Size = new System.Drawing.Size(180, 420);
            this.gboxPPS.TabIndex = 1;
            this.gboxPPS.TabStop = false;
            this.gboxPPS.Text = "Points per second";
            this.gboxPPS.Visible = false;
            // 
            // lblToolsBuy
            // 
            this.lblToolsBuy.AutoSize = true;
            this.lblToolsBuy.Location = new System.Drawing.Point(7, 188);
            this.lblToolsBuy.Name = "lblToolsBuy";
            this.lblToolsBuy.Size = new System.Drawing.Size(50, 45);
            this.lblToolsBuy.TabIndex = 13;
            this.lblToolsBuy.Text = "0/1\r\n500pts\r\n+15PPS";
            // 
            // lblCommunicationsBuy
            // 
            this.lblCommunicationsBuy.AutoSize = true;
            this.lblCommunicationsBuy.Location = new System.Drawing.Point(6, 74);
            this.lblCommunicationsBuy.Name = "lblCommunicationsBuy";
            this.lblCommunicationsBuy.Size = new System.Drawing.Size(43, 45);
            this.lblCommunicationsBuy.TabIndex = 12;
            this.lblCommunicationsBuy.Text = "0/1\r\n25pts\r\n+5PPS";
            // 
            // lblTeammate
            // 
            this.lblTeammate.AutoSize = true;
            this.lblTeammate.Location = new System.Drawing.Point(56, 279);
            this.lblTeammate.Name = "lblTeammate";
            this.lblTeammate.Size = new System.Drawing.Size(66, 15);
            this.lblTeammate.TabIndex = 11;
            this.lblTeammate.Text = "Teammate";
            // 
            // lblTools
            // 
            this.lblTools.AutoSize = true;
            this.lblTools.Location = new System.Drawing.Point(56, 150);
            this.lblTools.Name = "lblTools";
            this.lblTools.Size = new System.Drawing.Size(35, 15);
            this.lblTools.TabIndex = 10;
            this.lblTools.Text = "Tools";
            // 
            // lblCommunications
            // 
            this.lblCommunications.AutoSize = true;
            this.lblCommunications.Location = new System.Drawing.Point(56, 24);
            this.lblCommunications.Name = "lblCommunications";
            this.lblCommunications.Size = new System.Drawing.Size(99, 15);
            this.lblCommunications.TabIndex = 9;
            this.lblCommunications.Text = "Communications";
            // 
            // picboxTeammate
            // 
            this.picboxTeammate.Image = ((System.Drawing.Image)(resources.GetObject("picboxTeammate.Image")));
            this.picboxTeammate.Location = new System.Drawing.Point(56, 279);
            this.picboxTeammate.Name = "picboxTeammate";
            this.picboxTeammate.Size = new System.Drawing.Size(120, 120);
            this.picboxTeammate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picboxTeammate.TabIndex = 6;
            this.picboxTeammate.TabStop = false;
            this.picboxTeammate.Click += new System.EventHandler(this.picboxTeammate_Click);
            // 
            // picboxTools
            // 
            this.picboxTools.Image = ((System.Drawing.Image)(resources.GetObject("picboxTools.Image")));
            this.picboxTools.Location = new System.Drawing.Point(56, 150);
            this.picboxTools.Name = "picboxTools";
            this.picboxTools.Size = new System.Drawing.Size(120, 120);
            this.picboxTools.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picboxTools.TabIndex = 5;
            this.picboxTools.TabStop = false;
            this.picboxTools.Click += new System.EventHandler(this.picboxTools_Click);
            // 
            // picboxCommunications
            // 
            this.picboxCommunications.Image = ((System.Drawing.Image)(resources.GetObject("picboxCommunications.Image")));
            this.picboxCommunications.Location = new System.Drawing.Point(56, 24);
            this.picboxCommunications.Name = "picboxCommunications";
            this.picboxCommunications.Size = new System.Drawing.Size(120, 120);
            this.picboxCommunications.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picboxCommunications.TabIndex = 4;
            this.picboxCommunications.TabStop = false;
            this.picboxCommunications.Click += new System.EventHandler(this.picboxCommunications_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblScore.Location = new System.Drawing.Point(7, 5);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(52, 21);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "PTS: X";
            // 
            // picboxClickArea
            // 
            this.picboxClickArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.picboxClickArea.Image = ((System.Drawing.Image)(resources.GetObject("picboxClickArea.Image")));
            this.picboxClickArea.Location = new System.Drawing.Point(56, 68);
            this.picboxClickArea.Name = "picboxClickArea";
            this.picboxClickArea.Size = new System.Drawing.Size(250, 250);
            this.picboxClickArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxClickArea.TabIndex = 3;
            this.picboxClickArea.TabStop = false;
            this.picboxClickArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picboxClickArea_MouseDown);
            // 
            // bttnUpgradesPPS
            // 
            this.bttnUpgradesPPS.Location = new System.Drawing.Point(445, 433);
            this.bttnUpgradesPPS.Name = "bttnUpgradesPPS";
            this.bttnUpgradesPPS.Size = new System.Drawing.Size(75, 23);
            this.bttnUpgradesPPS.TabIndex = 4;
            this.bttnUpgradesPPS.Text = "PPS";
            this.bttnUpgradesPPS.UseVisualStyleBackColor = true;
            this.bttnUpgradesPPS.Click += new System.EventHandler(this.bttnUpgradesPPS_Click);
            // 
            // bttnUpgradesPPC
            // 
            this.bttnUpgradesPPC.Enabled = false;
            this.bttnUpgradesPPC.Location = new System.Drawing.Point(364, 433);
            this.bttnUpgradesPPC.Name = "bttnUpgradesPPC";
            this.bttnUpgradesPPC.Size = new System.Drawing.Size(75, 23);
            this.bttnUpgradesPPC.TabIndex = 5;
            this.bttnUpgradesPPC.Text = "PPC";
            this.bttnUpgradesPPC.UseVisualStyleBackColor = true;
            this.bttnUpgradesPPC.Click += new System.EventHandler(this.bttnUpgradesPPC_Click);
            // 
            // lblUpgradesSection
            // 
            this.lblUpgradesSection.AutoSize = true;
            this.lblUpgradesSection.BackColor = System.Drawing.Color.Transparent;
            this.lblUpgradesSection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUpgradesSection.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUpgradesSection.Location = new System.Drawing.Point(228, 435);
            this.lblUpgradesSection.Name = "lblUpgradesSection";
            this.lblUpgradesSection.Size = new System.Drawing.Size(133, 21);
            this.lblUpgradesSection.TabIndex = 6;
            this.lblUpgradesSection.Text = "Upgrades section:";
            // 
            // bttnSaveGame1
            // 
            this.bttnSaveGame1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttnSaveGame1.Location = new System.Drawing.Point(129, 343);
            this.bttnSaveGame1.Name = "bttnSaveGame1";
            this.bttnSaveGame1.Size = new System.Drawing.Size(95, 36);
            this.bttnSaveGame1.TabIndex = 7;
            this.bttnSaveGame1.Text = "Save Game";
            this.bttnSaveGame1.UseVisualStyleBackColor = true;
            this.bttnSaveGame1.Click += new System.EventHandler(this.bttnSaveGame1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblScoreGoal
            // 
            this.lblScoreGoal.AutoSize = true;
            this.lblScoreGoal.BackColor = System.Drawing.Color.Transparent;
            this.lblScoreGoal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblScoreGoal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblScoreGoal.Location = new System.Drawing.Point(119, 390);
            this.lblScoreGoal.Name = "lblScoreGoal";
            this.lblScoreGoal.Size = new System.Drawing.Size(118, 19);
            this.lblScoreGoal.TabIndex = 8;
            this.lblScoreGoal.Text = "Goal: 10 000 PTS!";
            // 
            // bttnReset
            // 
            this.bttnReset.Location = new System.Drawing.Point(12, 433);
            this.bttnReset.Name = "bttnReset";
            this.bttnReset.Size = new System.Drawing.Size(86, 23);
            this.bttnReset.TabIndex = 9;
            this.bttnReset.Text = "Reset Game";
            this.bttnReset.UseVisualStyleBackColor = true;
            this.bttnReset.Click += new System.EventHandler(this.bttnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 461);
            this.Controls.Add(this.bttnReset);
            this.Controls.Add(this.lblScoreGoal);
            this.Controls.Add(this.bttnSaveGame1);
            this.Controls.Add(this.lblUpgradesSection);
            this.Controls.Add(this.bttnUpgradesPPC);
            this.Controls.Add(this.bttnUpgradesPPS);
            this.Controls.Add(this.gboxPPC);
            this.Controls.Add(this.picboxClickArea);
            this.Controls.Add(this.gboxPPS);
            this.Controls.Add(this.lblScore);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Formula Clicker";
            this.gboxPPC.ResumeLayout(false);
            this.gboxPPC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSteeringWheel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxWheels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSuit)).EndInit();
            this.gboxPPS.ResumeLayout(false);
            this.gboxPPS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxTeammate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxTools)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxCommunications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClickArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxPPC;
        private System.Windows.Forms.GroupBox gboxPPS;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox picboxSteeringWheel;
        private System.Windows.Forms.PictureBox picboxWheels;
        private System.Windows.Forms.PictureBox picboxSuit;
        private System.Windows.Forms.PictureBox picboxTeammate;
        private System.Windows.Forms.PictureBox picboxTools;
        private System.Windows.Forms.PictureBox picboxCommunications;
        private System.Windows.Forms.PictureBox picboxClickArea;
        private System.Windows.Forms.Button bttnUpgradesPPS;
        private System.Windows.Forms.Button bttnUpgradesPPC;
        private System.Windows.Forms.Label lblUpgradesSection;
        private System.Windows.Forms.Button bttnSaveGame1;
        private System.Windows.Forms.Label lblSteeringWheel;
        private System.Windows.Forms.Label lblWheels;
        private System.Windows.Forms.Label lblSuit;
        private System.Windows.Forms.Label lblTeammate;
        private System.Windows.Forms.Label lblTools;
        private System.Windows.Forms.Label lblCommunications;
        private System.Windows.Forms.Label lblSuitBuy;
        private System.Windows.Forms.Label lblWheelsBuy;
        private System.Windows.Forms.Label lblSteeringWheelBuy;
        private System.Windows.Forms.Label lblTeammateBuy;
        private System.Windows.Forms.Label lblToolsBuy;
        private System.Windows.Forms.Label lblCommunicationsBuy;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblScoreGoal;
        private System.Windows.Forms.Button bttnReset;
    }
}

