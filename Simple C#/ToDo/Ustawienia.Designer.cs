
namespace WindowsFormsApp1
{
    partial class Ustawienia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ustawienia));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxBackground = new System.Windows.Forms.ComboBox();
            this.cBoxText = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DefaultSettingsButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelText = new System.Windows.Forms.Panel();
            this.panelBg = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tło (Kolor)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Napisy (Kolor)";
            // 
            // cboxBackground
            // 
            this.cboxBackground.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxBackground.FormattingEnabled = true;
            this.cboxBackground.Items.AddRange(new object[] {
            "ActiveCaption",
            "ControlDarkDark",
            "Red",
            "White",
            "Silver",
            "Gray",
            "Black",
            "Maroon",
            "Yellow",
            "Olive",
            "Lime",
            "Green",
            "Aqua",
            "Teal",
            "Blue",
            "Navy",
            "Fuchsia",
            "Purple"});
            this.cboxBackground.Location = new System.Drawing.Point(114, 21);
            this.cboxBackground.Name = "cboxBackground";
            this.cboxBackground.Size = new System.Drawing.Size(121, 23);
            this.cboxBackground.TabIndex = 2;
            this.cboxBackground.DropDownClosed += new System.EventHandler(this.cboxBackground_DropDown);
            // 
            // cBoxText
            // 
            this.cBoxText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxText.FormattingEnabled = true;
            this.cBoxText.Items.AddRange(new object[] {
            "ActiveCaption",
            "ControlDarkDark",
            "Red",
            "White",
            "Silver",
            "Gray",
            "Black",
            "Maroon",
            "Yellow",
            "Olive",
            "Lime",
            "Green",
            "Aqua",
            "Teal",
            "Blue",
            "Navy",
            "Fuchsia",
            "Purple"});
            this.cBoxText.Location = new System.Drawing.Point(114, 67);
            this.cBoxText.Name = "cBoxText";
            this.cBoxText.Size = new System.Drawing.Size(121, 23);
            this.cBoxText.TabIndex = 3;
            this.cBoxText.DropDownClosed += new System.EventHandler(this.cboxBackground_DropDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Przywróć ustawienia domyślne";
            // 
            // DefaultSettingsButton
            // 
            this.DefaultSettingsButton.Location = new System.Drawing.Point(19, 138);
            this.DefaultSettingsButton.Name = "DefaultSettingsButton";
            this.DefaultSettingsButton.Size = new System.Drawing.Size(75, 23);
            this.DefaultSettingsButton.TabIndex = 5;
            this.DefaultSettingsButton.Text = "Przywróć";
            this.DefaultSettingsButton.UseVisualStyleBackColor = true;
            this.DefaultSettingsButton.Click += new System.EventHandler(this.DefaultSettingsButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Zatwierdź";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelText
            // 
            this.panelText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelText.Location = new System.Drawing.Point(267, 67);
            this.panelText.Name = "panelText";
            this.panelText.Size = new System.Drawing.Size(23, 23);
            this.panelText.TabIndex = 7;
            // 
            // panelBg
            // 
            this.panelBg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelBg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBg.Location = new System.Drawing.Point(267, 21);
            this.panelBg.Name = "panelBg";
            this.panelBg.Size = new System.Drawing.Size(23, 23);
            this.panelBg.TabIndex = 8;
            // 
            // Ustawienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 173);
            this.Controls.Add(this.panelBg);
            this.Controls.Add(this.panelText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DefaultSettingsButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cBoxText);
            this.Controls.Add(this.cboxBackground);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ustawienia";
            this.Text = "Ustawienia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxBackground;
        private System.Windows.Forms.ComboBox cBoxText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DefaultSettingsButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelText;
        private System.Windows.Forms.Panel panelBg;
    }
}