using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace OOP8_Autoverwaltung.src
{
    public partial class GUI : Form
    {
        private IFachkonzept einFachkonzept;

        public GUI()
        {
            einFachkonzept = new Fachkonzept1();
            //einFachkonzept = new Fachkonzept2();

            Application.EnableVisualStyles();
            InitializeComponent();
            ladeStandorte();
            ladeMarken();
            Application.Run(this);
            
            
        }

        public void ladeStandorte()
        {
            //List<Standort> standorte = einFachkonzept.GetAlleStandorte();


            //fuer tests
            
            List<Standort> standorte = new List<Standort>();
            Standort teststandort1 = new Standort(1,"test1");
            Standort teststandort2 = new Standort(2, "test2");
            Standort teststandort3 = new Standort(3, "test3");
            Standort teststandort4 = new Standort(4, "test4");
            standorte.Add(teststandort1);
            standorte.Add(teststandort2);
            standorte.Add(teststandort3);
            standorte.Add(teststandort4);
           
            foreach (var standort in standorte)
            {
                lb_standorte.Items.Add(standort.GetStandortName());
            } 
        }

        public void ladeMarken()
        {
            //List<Auto> autos = einFachkonzept.GetAlleAutos();


            //fuer tests

            List<Auto> autos = new List<Auto>();
            Auto testauto1 = new Auto(1, "test1");
            Auto testauto2 = new Auto(2, "test2");
            Auto testauto3 = new Auto(3, "test3");
            Auto testauto4 = new Auto(4, "test4");
            autos.Add(testauto1);
            autos.Add(testauto2);
            autos.Add(testauto3);
            autos.Add(testauto4);

            foreach (var auto in autos)
            {
                lb_marken.Items.Add(auto.GetAutoMarke());
            }
        }

        private void GUI_Load(object sender, EventArgs e)
        {

        }

        private void btn_neuerStandort_Click(object sender, EventArgs e)
        {

           string neuerStandortName = erzeugeEingabeFeld("Neuer Standort","Bitte geben Sie einen Standortname ein");
           einFachkonzept.SpeichereNeuenStandort(new Standort(neuerStandortName));

        }


        private void btn_aendereStandort_Click(object sender, EventArgs e)
        {
            if (lb_standorte.SelectedItem != null)
            {
                string ausgewaehlterStandort = lb_standorte.SelectedItem.ToString();
                string neuerStandortName = erzeugeEingabeFeld("Neuer Standort", "Bitte geben Sie einen Standortname ein");

                einFachkonzept.AendereStandort(ausgewaehlterStandort, neuerStandortName);
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
                string ausgewaehlterStandort = lb_standorte.SelectedItem.ToString();
                //einFachkonzept.LoescheSTandort();
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
            einFachkonzept.SpeichereNeuesAuto(new Auto(neuesAuto));
        }

        private void btn_aendereAuto_Click(object sender, EventArgs e)
        {
            if (lb_marken.SelectedItem != null)
            {
                string ausgewaehltesAutot = lb_marken.SelectedItem.ToString();
                //einFachkonzept.AendereAuto();
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
                string ausgewaehlterStandort = lb_marken.SelectedItem.ToString();
                //einFachkonzept.LoescheAuto();
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie eine Auto aus", "Fehler",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string erzeugeEingabeFeld(string caption, string text)
        {
            Form prompt = new Form();
            prompt.Width = 280;
            prompt.Height = 160;
            prompt.Text = caption;
            Label textLabel = new Label() { Left = 16, Top = 20, Width = 240, Text = text };
            TextBox textBox = new TextBox() { Left = 16, Top = 40, Width = 240, TabIndex = 0, TabStop = true };
            Button confirmation = new Button() { Text = "Specihern", Left = 16, Width = 80, Top = 88, TabIndex = 1, TabStop = true };
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
