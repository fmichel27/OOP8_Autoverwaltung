using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OOP8_Autoverwaltung.src
{
    class Datenbankverwaltung:IDatenhaltung
    {
        string datenbankName;
        SqlConnection connection;
        string connetionString = Properties.Settings.Default.AutoverwaltungdbConnectionString;

        public void CreateSpeichermedium(string a, string b)
        {
         
        }

        public List<Auto> LeseAlleAutos()
        {
            List<Auto> autos = new List<Auto>();
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                MessageBox.Show("Connection Open ! ");
                SqlCommand command;
                string sql = null;
                SqlDataReader dataReader;
                sql = "Select * from Autos";
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    autos.Add(new Auto(Convert.ToInt32(dataReader.GetValue(0)), dataReader.GetValue(1).ToString()));
                    
                }
                dataReader.Close();
                command.Dispose();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }
            return autos;

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
