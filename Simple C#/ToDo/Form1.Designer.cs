using System.IO;
namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.L_Nowe = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.L_DodajEdytuj = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gBox_DodajEdytuj = new System.Windows.Forms.GroupBox();
            this.L_Anuluj = new System.Windows.Forms.Button();
            this.L_Usuń = new System.Windows.Forms.Button();
            this.L_Wyczyść = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.L_Zapisz = new System.Windows.Forms.Button();
            this.L_Edytuj = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.L_Wczytaj = new System.Windows.Forms.ComboBox();
            this.L_Rozszerz = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.R_Rozszerz = new System.Windows.Forms.Button();
            this.longNote = new System.Windows.Forms.RichTextBox();
            this.R_Zapisz = new System.Windows.Forms.Button();
            this.R_Wczytaj = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsm_Ustawienia = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Pomoc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Autor = new System.Windows.Forms.ToolStripMenuItem();
            this.gBox_DodajEdytuj.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Witaj";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // L_Nowe
            // 
            this.L_Nowe.Enabled = false;
            this.L_Nowe.Location = new System.Drawing.Point(5, 44);
            this.L_Nowe.Name = "L_Nowe";
            this.L_Nowe.Size = new System.Drawing.Size(75, 25);
            this.L_Nowe.TabIndex = 2;
            this.L_Nowe.Text = "Nowe";
            this.L_Nowe.UseVisualStyleBackColor = true;
            this.L_Nowe.MouseClick += new System.Windows.Forms.MouseEventHandler(this.L_Nowe_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Enabled = false;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.HorizontalScrollbar = true;
            this.checkedListBox1.Location = new System.Drawing.Point(87, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(255, 364);
            this.checkedListBox1.TabIndex = 3;
            // 
            // L_DodajEdytuj
            // 
            this.L_DodajEdytuj.Location = new System.Drawing.Point(6, 41);
            this.L_DodajEdytuj.Name = "L_DodajEdytuj";
            this.L_DodajEdytuj.Size = new System.Drawing.Size(75, 25);
            this.L_DodajEdytuj.TabIndex = 4;
            this.L_DodajEdytuj.Text = "Dodaj";
            this.L_DodajEdytuj.UseVisualStyleBackColor = true;
            this.L_DodajEdytuj.Click += new System.EventHandler(this.L_DodajEdytuj_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 23);
            this.textBox1.TabIndex = 5;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // gBox_DodajEdytuj
            // 
            this.gBox_DodajEdytuj.BackColor = System.Drawing.SystemColors.Control;
            this.gBox_DodajEdytuj.Controls.Add(this.L_Anuluj);
            this.gBox_DodajEdytuj.Controls.Add(this.textBox1);
            this.gBox_DodajEdytuj.Controls.Add(this.L_DodajEdytuj);
            this.gBox_DodajEdytuj.Location = new System.Drawing.Point(110, 80);
            this.gBox_DodajEdytuj.Name = "gBox_DodajEdytuj";
            this.gBox_DodajEdytuj.Size = new System.Drawing.Size(200, 70);
            this.gBox_DodajEdytuj.TabIndex = 6;
            this.gBox_DodajEdytuj.TabStop = false;
            this.gBox_DodajEdytuj.Visible = false;
            // 
            // L_Anuluj
            // 
            this.L_Anuluj.Location = new System.Drawing.Point(119, 41);
            this.L_Anuluj.Name = "L_Anuluj";
            this.L_Anuluj.Size = new System.Drawing.Size(75, 25);
            this.L_Anuluj.TabIndex = 6;
            this.L_Anuluj.Text = "Anuluj";
            this.L_Anuluj.UseVisualStyleBackColor = true;
            this.L_Anuluj.Click += new System.EventHandler(this.L_Anuluj_Click);
            // 
            // L_Usuń
            // 
            this.L_Usuń.Enabled = false;
            this.L_Usuń.Location = new System.Drawing.Point(5, 102);
            this.L_Usuń.Name = "L_Usuń";
            this.L_Usuń.Size = new System.Drawing.Size(75, 25);
            this.L_Usuń.TabIndex = 7;
            this.L_Usuń.Text = "Usuń";
            this.L_Usuń.UseVisualStyleBackColor = true;
            this.L_Usuń.Click += new System.EventHandler(this.L_Usuń_Click);
            // 
            // L_Wyczyść
            // 
            this.L_Wyczyść.Enabled = false;
            this.L_Wyczyść.Location = new System.Drawing.Point(5, 131);
            this.L_Wyczyść.Name = "L_Wyczyść";
            this.L_Wyczyść.Size = new System.Drawing.Size(75, 25);
            this.L_Wyczyść.TabIndex = 8;
            this.L_Wyczyść.Text = "Wyczyść ";
            this.L_Wyczyść.UseVisualStyleBackColor = true;
            this.L_Wyczyść.Click += new System.EventHandler(this.L_Wyczyść_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ładowanie...";
            // 
            // L_Zapisz
            // 
            this.L_Zapisz.Location = new System.Drawing.Point(5, 160);
            this.L_Zapisz.Name = "L_Zapisz";
            this.L_Zapisz.Size = new System.Drawing.Size(75, 25);
            this.L_Zapisz.TabIndex = 10;
            this.L_Zapisz.Text = "Zapisz";
            this.L_Zapisz.UseVisualStyleBackColor = true;
            this.L_Zapisz.Click += new System.EventHandler(this.L_Zapisz_Click);
            // 
            // L_Edytuj
            // 
            this.L_Edytuj.Enabled = false;
            this.L_Edytuj.Location = new System.Drawing.Point(6, 73);
            this.L_Edytuj.Name = "L_Edytuj";
            this.L_Edytuj.Size = new System.Drawing.Size(75, 25);
            this.L_Edytuj.TabIndex = 12;
            this.L_Edytuj.Text = "Edytuj";
            this.L_Edytuj.UseVisualStyleBackColor = true;
            this.L_Edytuj.Click += new System.EventHandler(this.L_Edytuj_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.L_Wczytaj);
            this.panel1.Controls.Add(this.gBox_DodajEdytuj);
            this.panel1.Controls.Add(this.checkedListBox1);
            this.panel1.Controls.Add(this.L_Nowe);
            this.panel1.Controls.Add(this.L_Rozszerz);
            this.panel1.Controls.Add(this.L_Edytuj);
            this.panel1.Controls.Add(this.L_Usuń);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.L_Wyczyść);
            this.panel1.Controls.Add(this.L_Zapisz);
            this.panel1.Location = new System.Drawing.Point(12, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 402);
            this.panel1.TabIndex = 13;
            // 
            // L_Wczytaj
            // 
            this.L_Wczytaj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.L_Wczytaj.FormattingEnabled = true;
            this.L_Wczytaj.Items.AddRange(new object[] {
            "Lista_1",
            "Lista_2",
            "Lista_3",
            "Lista_4",
            "Lista_5"});
            this.L_Wczytaj.Location = new System.Drawing.Point(6, 191);
            this.L_Wczytaj.Name = "L_Wczytaj";
            this.L_Wczytaj.Size = new System.Drawing.Size(74, 23);
            this.L_Wczytaj.TabIndex = 15;
            this.L_Wczytaj.SelectedIndexChanged += new System.EventHandler(this.L_Wczytaj_SelectedIndexChanged);
            // 
            // L_Rozszerz
            // 
            this.L_Rozszerz.Location = new System.Drawing.Point(6, 11);
            this.L_Rozszerz.Name = "L_Rozszerz";
            this.L_Rozszerz.Size = new System.Drawing.Size(75, 25);
            this.L_Rozszerz.TabIndex = 14;
            this.L_Rozszerz.Tag = "";
            this.L_Rozszerz.Text = "Rozszerz ->";
            this.L_Rozszerz.UseVisualStyleBackColor = true;
            this.L_Rozszerz.Click += new System.EventHandler(this.L_Rozszerz_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.R_Rozszerz);
            this.panel2.Controls.Add(this.longNote);
            this.panel2.Controls.Add(this.R_Zapisz);
            this.panel2.Controls.Add(this.R_Wczytaj);
            this.panel2.Location = new System.Drawing.Point(375, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 433);
            this.panel2.TabIndex = 16;
            // 
            // R_Rozszerz
            // 
            this.R_Rozszerz.Location = new System.Drawing.Point(289, 11);
            this.R_Rozszerz.Name = "R_Rozszerz";
            this.R_Rozszerz.Size = new System.Drawing.Size(75, 25);
            this.R_Rozszerz.TabIndex = 20;
            this.R_Rozszerz.Text = "<- Rozszerz";
            this.R_Rozszerz.UseVisualStyleBackColor = true;
            this.R_Rozszerz.Click += new System.EventHandler(this.R_Rozszerz_Click);
            // 
            // longNote
            // 
            this.longNote.Enabled = false;
            this.longNote.Location = new System.Drawing.Point(9, 42);
            this.longNote.Name = "longNote";
            this.longNote.Size = new System.Drawing.Size(355, 365);
            this.longNote.TabIndex = 0;
            this.longNote.Text = resources.GetString("longNote.Text");
            // 
            // R_Zapisz
            // 
            this.R_Zapisz.Location = new System.Drawing.Point(117, 11);
            this.R_Zapisz.Name = "R_Zapisz";
            this.R_Zapisz.Size = new System.Drawing.Size(75, 25);
            this.R_Zapisz.TabIndex = 19;
            this.R_Zapisz.Text = "Zapisz";
            this.R_Zapisz.UseVisualStyleBackColor = true;
            this.R_Zapisz.Click += new System.EventHandler(this.R_Zapisz_Click);
            // 
            // R_Wczytaj
            // 
            this.R_Wczytaj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.R_Wczytaj.FormattingEnabled = true;
            this.R_Wczytaj.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.R_Wczytaj.Items.AddRange(new object[] {
            "Notatka_1",
            "Notatka_2",
            "Notatka_3",
            "Notatka_4",
            "Notatka_5",
            "Notatka_6",
            "Notatka_7",
            "Notatka_8",
            "Notatka_9",
            "Notatka_10"});
            this.R_Wczytaj.Location = new System.Drawing.Point(9, 13);
            this.R_Wczytaj.Name = "R_Wczytaj";
            this.R_Wczytaj.Size = new System.Drawing.Size(91, 23);
            this.R_Wczytaj.TabIndex = 18;
            this.R_Wczytaj.SelectedIndexChanged += new System.EventHandler(this.R_Wczytaj_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Ustawienia,
            this.tsm_Pomoc,
            this.tsm_Autor});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(763, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // tsm_Ustawienia
            // 
            this.tsm_Ustawienia.Name = "tsm_Ustawienia";
            this.tsm_Ustawienia.Size = new System.Drawing.Size(76, 20);
            this.tsm_Ustawienia.Text = "Ustawienia";
            // 
            // tsm_Pomoc
            // 
            this.tsm_Pomoc.Name = "tsm_Pomoc";
            this.tsm_Pomoc.Size = new System.Drawing.Size(57, 20);
            this.tsm_Pomoc.Text = "Pomoc";
            // 
            // tsm_Autor
            // 
            this.tsm_Autor.Name = "tsm_Autor";
            this.tsm_Autor.Size = new System.Drawing.Size(49, 20);
            this.tsm_Autor.Text = "Autor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(763, 499);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Pomocnik ToDo";
            this.gBox_DodajEdytuj.ResumeLayout(false);
            this.gBox_DodajEdytuj.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button L_Nowe;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button L_DodajEdytuj;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gBox_DodajEdytuj;
        private System.Windows.Forms.Button L_Usuń;
        private System.Windows.Forms.Button L_Wyczyść;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button L_Zapisz;
        private System.Windows.Forms.Button L_Anuluj;
        private System.Windows.Forms.Button L_Edytuj;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button L_Rozszerz;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsm_Ustawienia;
        private System.Windows.Forms.ToolStripMenuItem tsm_Autor;
        private System.Windows.Forms.ToolStripMenuItem tsm_Pomoc;
        private System.Windows.Forms.ComboBox R_Wczytaj;
        private System.Windows.Forms.Button R_Zapisz;
        private System.Windows.Forms.Button R_Rozszerz;
        private System.Windows.Forms.RichTextBox longNote;
        private System.Windows.Forms.ComboBox L_Wczytaj;
    }
}

