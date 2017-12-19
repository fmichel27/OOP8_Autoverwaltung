using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace OOP8_Autoverwaltung.src
{
    partial class GUI : Form
    {
        private IFachkonzept einFachkonzept;

        public GUI(IFachkonzept einFachkonzept)
        {
            this.einFachkonzept = einFachkonzept;

            Application.EnableVisualStyles();
            InitializeComponent();
            ladeStandorte();
            ladeMarken();
            Application.Run(this);
            
            
        }

        public void ladeStandorte()
        {
            lb_standorte.Items.Clear();
            List<Standort> standorte = einFachkonzept.GetAlleStandorte();

            foreach (var standort in standorte)
            {
                lb_standorte.Items.Add(standort.GetStandortID() + "   " + standort.GetStandortName());
            } 
        }

        public void ladeMarken()
        {
            lb_marken.Items.Clear();
            List<Auto> autos = einFachkonzept.GetAlleAutos();
            foreach (var auto in autos)
            {
                lb_marken.Items.Add(auto.GetAutoId() + "   " + auto.GetAutoMarke());
            }
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            //keine ahnung was das hier ist wurde automatisch erzeugt
        }

        private void btn_neuerStandort_Click(object sender, EventArgs e)
        {
           string neuerStandortName = erzeugeEingabeFeld("Neuer Standort","Bitte geben Sie einen Standortname ein");
           einFachkonzept.SpeichereNeuenStandort(new Standort(neuerStandortName));
           ladeStandorte();

        }


        private void btn_aendereStandort_Click(object sender, EventArgs e)
        {
            if (lb_standorte.SelectedItem != null)
            {
                string[] ausgewaehlterStandort = lb_standorte.SelectedItem.ToString().Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

                string neuerStandortName = erzeugeEingabeFeld("Neuer Standort", "Bitte geben Sie einen Standortname ein");

                einFachkonzept.AendereStandort(Convert.ToInt32(ausgewaehlterStandort[0]), neuerStandortName);

                ladeStandorte();
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie einen Standort aus", "Fehler",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_loescheStandort_Click(object sender, EventArgs e)
        {
            if (lb_standorte.SelectedItem != null)
            {
                string[] ausgewaehlterStandort = lb_standorte.SelectedItem.ToString().Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                einFachkonzept.LoescheStandort(Convert.ToInt32(ausgewaehlterStandort[0]));
                ladeStandorte();
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie einen Standort aus", "Fehler",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_neuesAuto_Click(object sender, EventArgs e)
        {
            string neuesAuto = erzeugeEingabeFeld("Neues Auto", "Bitte geben Sie eine Automarke ein");
            einFachkonzept.SpeichereNeuesAuto(neuesAuto);
            ladeMarken();
        }

        private void btn_aendereAuto_Click(object sender, EventArgs e)
        {
            if (lb_marken.SelectedItem != null)
            {
                string[] ausgewaehltesAuto = lb_marken.SelectedItem.ToString().Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

                string neueAutomarke = erzeugeEingabeFeld("Ändere Auto", "Bitte geben Sie eine Automarke ein");

                einFachkonzept.AendereAuto(Convert.ToInt32(ausgewaehltesAuto[0]), neueAutomarke);
                ladeMarken();
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie eine Auto aus", "Fehler",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_loescheAuto_Click(object sender, EventArgs e)
        {
            if (lb_marken.SelectedItem != null)
            {
                string[] ausgewaehltesAuto = lb_marken.SelectedItem.ToString().Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                einFachkonzept.LoescheAuto(Convert.ToInt32(ausgewaehltesAuto[0]));
                ladeMarken();
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie eine Auto aus", "Fehler",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lb_standorte_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_markenAnStandort.Items.Clear();
            string[] ausgewaehlterStandort = lb_standorte.SelectedItem.ToString().Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

            List<Auto> autos = einFachkonzept.FilterAutosNachStandort(Convert.ToInt32(ausgewaehlterStandort[0]));

            foreach (Auto auto in autos)
            {
                lb_markenAnStandort.Items.Add(auto.GetAutoId() + "   " + auto.GetAutoMarke());                  
            }
        }

        private void lb_marken_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_standortDerMarke.Items.Clear();
            string[] ausgewaehltesAuto = lb_marken.SelectedItem.ToString().Split(new char[0], StringSplitOptions.RemoveEmptyEntries);


            Standort standortDesAutos = einFachkonzept.getStandortDesAutos(Convert.ToInt32(ausgewaehltesAuto[0]));

            
            lb_standortDerMarke.Items.Add(standortDesAutos.GetStandortID() + "   " + standortDesAutos.GetStandortName());

        }


        private void tb_Standort_TextChanged(object sender, EventArgs e)
        {
        }

        public string erzeugeEingabeFeld(string caption, string text)
        {
            Form prompt = new Form();
            prompt.Width = 280;
            prompt.Height = 160;
            prompt.Text = caption;
            Label textLabel = new Label() { Left = 16, Top = 20, Width = 240, Text = text };
            TextBox textBox = new TextBox() { Left = 16, Top = 40, Width = 240, TabIndex = 0, TabStop = true };
            Button confirmation = new Button() { Text = "OK", Left = 16, Width = 80, Top = 88, TabIndex = 1, TabStop = true };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;
            prompt.StartPosition = FormStartPosition.CenterScreen;
            prompt.ShowDialog();
            return string.Format("{0}", textBox.Text);
        }


    }
}
