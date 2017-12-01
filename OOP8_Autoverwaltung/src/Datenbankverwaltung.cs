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
        string connectionString = Properties.Settings.Default.AutoverwaltungdbConnectionString;

        public void CreateSpeichermedium(string a, string b)
        {
         
        }

        public List<Auto> LiesAlleAutos()
        {
            List<Auto> autos = new List<Auto>();
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
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
        public void SpeichereAuto(Auto auto)
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                Console.WriteLine("YYYYYYYYYYYY");
                Console.WriteLine("hier1: "+ auto.GetAutoMarke() + auto.GetStandortId());
                SqlCommand command = new SqlCommand("INSERT INTO Autos (Marke, F_Standort_id) VALUES("+ auto.GetAutoMarke() + ","+ auto.GetStandortId() + ");", connection);
                //command.Parameters.AddWithValue("@marke", auto.GetAutoMarke());
                //command.Parameters.AddWithValue("@standortId", auto.GetStandortId());
                Console.WriteLine("hier2: "+ auto.GetAutoMarke()+ " - - "+ auto.GetStandortId()+ "...XXX");
                int test = command.ExecuteNonQuery();
                Console.WriteLine(test);
                Console.ReadLine();
                command.Dispose();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }
        }

        public Auto LiesAuto(int autoNummer)
        {
            throw new NotImplementedException();
        }

        public Standort LiesStandort(int standotrNummer)
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



        public void SpeichereStandort(Standort standort, int a)
        {
            throw new NotImplementedException();
        }
    }
}
