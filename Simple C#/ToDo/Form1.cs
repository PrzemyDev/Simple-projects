using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly string znacznik = "~%X%~";
        bool AddTr_EdtFl;

        public Form1()
        {
            InitializeComponent();
            readSettings();

            if (R_Wczytaj.SelectedIndex == -1)
            {
                R_Zapisz.Enabled = false;
            }
            if (L_Wczytaj.SelectedIndex == -1)
            {
                L_Zapisz.Enabled = false;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            /*var date1 = System.DateTime.Now;
            this.label1.Text = (date1.ToString());*/
            label1.Text = (System.DateTime.Now.ToString());
            label2.Text = "Lista zadań: " + checkedListBox1.Items.Count +
                " | Wykonanych: " + checkedListBox1.CheckedItems.Count + "/" + checkedListBox1.Items.Count;
        }

        private void L_Nowe_Click(object sender, MouseEventArgs e)
        {   //Nowe
            AddTr_EdtFl = true;
            L_DodajEdytuj.Text = "Dodaj";
            gBox_DodajEdytuj.Visible = true;
        }
        private void L_Edytuj_Click(object sender, EventArgs e)
        {

            if (checkedListBox1.SelectedIndex != -1)
            {
                gBox_DodajEdytuj.Visible = true;
                AddTr_EdtFl = false;
                string TEXTTest = checkedListBox1.Items[checkedListBox1.SelectedIndex].ToString();
                textBox1.Text = TEXTTest;
                L_DodajEdytuj.Text = "Edytuj";
            }
            else
            {
                MessageBox.Show("Musisz wskazać zadanie, które\nchcesz edytować, zanim wciśniesz przycisk.", "Wskazówka"); //Debug
            }
        }
        private void L_DodajEdytuj_Click(object sender, EventArgs e)
        { 
            if (AddTr_EdtFl == true)
            {
                checkedListBox1.Items.Add(textBox1.Text, false);
                textBox1.Clear();
            }
            else
            {
                this.checkedListBox1.Items[checkedListBox1.SelectedIndex] = textBox1.Text;
            }
            textBox1.Clear();
            gBox_DodajEdytuj.Visible = false;
        }
        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (AddTr_EdtFl == true)
                {
                    checkedListBox1.Items.Add(textBox1.Text, false);
                    textBox1.Clear();
                    gBox_DodajEdytuj.Visible = false;
                }
                else
                {
                    this.checkedListBox1.Items[checkedListBox1.SelectedIndex] = textBox1.Text;
                }
                textBox1.Clear();
                gBox_DodajEdytuj.Visible = false;
            }
        }
        private void L_Anuluj_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            gBox_DodajEdytuj.Visible = false;
        }
        private void L_Usuń_Click(object sender, EventArgs e)
        {   
            if (checkedListBox1.SelectedIndex != -1)
            {
                checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Musisz wskazać zadanie, które\nchcesz usunąć, zanim wciśniesz przycisk.", "Wskazówka");
            }
        }

        private void L_Wyczyść_Click(object sender, EventArgs e)
        {  
            if (MessageBox.Show("Czy na pewno chcesz wyczyścić listę?", "Uwaga", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                checkedListBox1.Items.Clear();
            }
        }
        private void L_Zapisz_Click(object sender, EventArgs e)
        {
            try
            {
                string nameChecked0 = L_Wczytaj.SelectedItem.ToString();
                using (StreamWriter streamW = new StreamWriter(nameChecked0, false)) 
                {
                    if (R_Wczytaj.SelectedIndex <= 5) 
                    {
                        foreach (object item in checkedListBox1.Items)
                        {
                            if (!checkedListBox1.CheckedItems.Contains(item))
                            {
                                streamW.WriteLine((item.ToString()));
                            }
                            else
                            {
                                streamW.WriteLine((item.ToString() + znacznik));
                            }
                        }
                    }
                    streamW.Flush();
                }
            }
            catch (Exception ex_zapis)
            {
                MessageBox.Show("Coś poszło nie tak", ex_zapis.Message); //Debug
            }
        }
        private void L_Wczytaj_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBox1.Enabled = true;
            L_Zapisz.Enabled = true;
            L_Nowe.Enabled = true;
            L_Edytuj.Enabled = true;
            L_Wyczyść.Enabled = true;
            L_Usuń.Enabled = true;
            try
            {
                checkedListBox1.Items.Clear();
                string nameChecked1 = L_Wczytaj.SelectedItem.ToString();
                if (File.Exists(nameChecked1))
                { 
                using (StreamReader streamR = new StreamReader(nameChecked1))
                    {
                    string line = "";
                    while ((line = streamR.ReadLine()) != null)
                     {
                        if (line.Contains(znacznik))
                            {
                            checkedListBox1.Items.Add(line.Substring(0, line.Length - znacznik.Length), true);
                            }
                        else
                            {
                            checkedListBox1.Items.Add(line);
                            }
                     }
                    streamR.Dispose();
                    }
                }
                else
                {   
                    using (StreamWriter streamW = new StreamWriter(nameChecked1, false))
                    {
                        //MessageBox.Show("Utworzyłem nowy plik!");
                    }
                }
            }
            catch (Exception ex_Wczytywanie)
            {
                MessageBox.Show(ex_Wczytywanie.Message, "Błąd -> Wczytaj"); //Debug
            } 
        }
        private void L_Rozszerz_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == false)
            {
                panel2.Visible = true;
                panel1.Width = 400;
                checkedListBox1.Width = 255;
                gBox_DodajEdytuj.Location = new System.Drawing.Point(110,80);
            }
            else
            {
                panel2.Visible = false;
                panel1.Width = 740;
                checkedListBox1.Width = 640;
                gBox_DodajEdytuj.Location = new System.Drawing.Point(300, 80);
            }
        }
        private void R_Zapisz_Click(object sender, EventArgs e)
        {
            try
            {
                string name0 = R_Wczytaj.SelectedItem.ToString();
                using (StreamWriter streamW = new StreamWriter(name0, false))
                {
                    if (R_Wczytaj.SelectedIndex <=10)
                    {
                        streamW.WriteLine(longNote.Text);
                    }
                    streamW.Flush();
                }
            }
            catch (Exception ex_R_zapis)
            {
                MessageBox.Show(ex_R_zapis.Message, "Błąd!");
            }
        }
        private void R_Wczytaj_SelectedIndexChanged(object sender, EventArgs e)
        {
            R_Zapisz.Enabled = true;
            longNote.Enabled = true;
            R0_Wczytaj();
        }
        private void R0_Wczytaj()
        {
            try
            {
                string name1 = R_Wczytaj.SelectedItem.ToString();
                if (File.Exists(name1))
                {

                    longNote.Text = "";
                    using (StreamReader streamR = new StreamReader(name1))
                    {
                        string line = "";
                        if (R_Wczytaj.SelectedIndex <= 10)
                        {
                            while ((line = streamR.ReadLine()) != null)
                            {
                                longNote.Text += line + "\n";
                            }
                        }
                        streamR.Dispose();
                    }
                }
                else
                {   
                    using (StreamWriter streamW = new StreamWriter(name1, false))
                    {
                        //MessageBox.Show("Utworzyłem nowy plik!");
                    }
                }
            }
            catch (Exception ex_R_odczyt)
            {
                MessageBox.Show(ex_R_odczyt.Message, "Błąd!");
            }
        }
        private void R_Rozszerz_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
                panel2.Location = new System.Drawing.Point(375, 55);
                panel2.Width = 375;
                longNote.Width = 355;
            }
            else
            {
                panel1.Visible = false;
                panel2.Location = new System.Drawing.Point(12, 65);
                panel2.Width = 740;
                longNote.Width = 721;
            }
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text=="Autor")
            { MessageBox.Show("PrzemyDev 2021", "Autor"); }
            if (e.ClickedItem.Text == "Pomoc")
            { MessageBox.Show("Lewa strona z przyciskami odwołuje się do listy zadań (operowanie zadaniami). \n" +
                "Prawa strona z przyciskami odwołuje się do notatek tekstowych (wybór i zapis tekstu). \n" +
                "Przycisk Rozszerz wypełnia wybrany rodzaj notatki na całą szerokość okienka. \n" +
                "Ustawienia pozwalają wybrać kolor tła aplikacji, napisów oraz przywrócić domyślny motyw.", "Pomoc"); }
            if (e.ClickedItem.Text == "Ustawienia")
            {
                Ustawienia settings = new Ustawienia();
                settings.FormClosed += Settings_FormClosed;
                settings.Show();
            }
        }
        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Ustawienia zapisane", "Komunikat");
            readSettings();
        }
        private void readSettings()
        {
            if (File.Exists("user_settings"))
            {
                try
                {
                    using (StreamReader streamR = new StreamReader("user_settings"))
                    {
                        string line;
                        while ((line = streamR.ReadLine()) != null)

                        {
                            if (line.Contains("Background:"))
                            {
                                line = line.Substring(11, line.Length - 11).ToString();
                                this.BackColor = ColorTranslator.FromHtml(line);
                            }
                            else if (line.Contains("Text:"))
                            {
                                line = line.Substring(5, line.Length - 5).ToString();
                                label1.ForeColor = ColorTranslator.FromHtml(line);
                                label2.ForeColor = ColorTranslator.FromHtml(line);
                            }
                        }
                        streamR.Dispose();
                    }
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message, "Błąd");
                }
            }
        }
    }
}