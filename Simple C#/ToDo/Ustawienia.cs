using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Ustawienia : Form
    {
        public Ustawienia()
        {
            InitializeComponent();
            OdczytUstawień();
        }
        private void OdczytUstawień()
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
                                cboxBackground.Text = line;
                            }
                            else if (line.Contains("Text:"))
                            {
                                line = line.Substring(5, line.Length - 5).ToString();
                                cBoxText.Text = line;
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
        private void cboxBackground_DropDown(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter streamW = new StreamWriter("user_settings", false))
                { 
                    streamW.WriteLine(("Background:" + cboxBackground.Text.ToString()));
                    panelBg.BackColor = ColorTranslator.FromHtml(cboxBackground.Text.ToString());
                    streamW.WriteLine(("Text:" + cBoxText.Text.ToString()));
                    panelText.BackColor = ColorTranslator.FromHtml(cBoxText.Text.ToString());
                    streamW.Flush();
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Błąd");
            }
        }
        private void DefaultSettingsButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter streamW = new StreamWriter("user_settings", false))
                {
                    streamW.WriteLine(("Background:ActiveCaption"));
                    panelBg.BackColor = ColorTranslator.FromHtml("ActiveCaption");
                    streamW.WriteLine(("Text:Black"));
                    panelText.BackColor = ColorTranslator.FromHtml("Black");
                    streamW.Flush();
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Błąd");
            }
            OdczytUstawień();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
 }

