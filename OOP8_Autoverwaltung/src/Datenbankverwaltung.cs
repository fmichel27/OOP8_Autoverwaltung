using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP8_Autoverwaltung.src
{
    class Datenbankverwaltung:IDatenhaltung
    {
        string datenbankName;
        OleDbConnection connection;
        string connetionString = Properties.Settings.Default.AutoverwaltungdbConnectionString;

        public void CreateSpeichermedium(string a, string b)
        {
            connection = new OleDbConnection(connetionString);
            try
            {
                connection.Open();
                MessageBox.Show("Connection Open ! ");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! "+ ex.Message);
            }
        }

        public Auto LeseAuto(int autoNummer)
        {
            throw new NotImplementedException();
        }

        public Standort LeseStandort(int standotrNummer)
        {
            throw new NotImplementedException();
        }

        public void LoescheAuto(int autoNummer)
        {
            throw new NotImplementedException();
        }

        public void LoescheStandort(int standortNummer)
        {
            throw new NotImplementedException();
        }

        public void SpeichereAuto(Auto auto, int a)
        {
            throw new NotImplementedException();
        }

        public void SpeichereStandort(Standort standort, int a)
        {
            throw new NotImplementedException();
        }
    }
}
