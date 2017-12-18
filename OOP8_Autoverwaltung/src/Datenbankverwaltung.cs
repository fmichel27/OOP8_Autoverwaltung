using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OOP8_Autoverwaltung.src
{
    class Datenbankverwaltung:IDatenhaltung
    {
        string datenbankName;
        SqlConnection connection;
        string connectionString = Properties.Settings.Default.AutoverwaltungdbConnectionString;

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
                MessageBox.Show("Verbindungsfehler beim Lesen aller Autos!: " + ex.Message);
            }
            return autos;
        }

        public List<Standort> LiesAlleStandorte()
        {
            List<Standort> standorte = new List<Standort>();
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlCommand command;
                string sql = null;
                SqlDataReader dataReader;
                sql = "Select * from Standorte";
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    standorte.Add(new Standort(Convert.ToInt32(dataReader.GetValue(0)), dataReader.GetValue(1).ToString()));

                }
                dataReader.Close();
                command.Dispose();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verbindungsfehler beim Lesen aller Standorte!: " + ex.Message);
            }
            return standorte;
        }


        public List<Auto> LiesAutoMarke(string gesuchteMarke)
        {
            List<Auto> autos = new List<Auto>();
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlCommand command;
                string sql = null;
                SqlDataReader dataReader;
                sql = "Select * from Autos WHERE Marke Like '"+ gesuchteMarke +"'";
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
                MessageBox.Show("Verbindungsfehler beim Lesen der Automarke " + gesuchteMarke + "!: " + ex.Message);
            }
            return autos;
        }

        public List<Auto> LiesStandort(string gesuchterStandort)
        {
            List<Auto> autos = new List<Auto>();
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlCommand command;
                string sql = null;
                SqlDataReader dataReader;
                sql = "Select * from Standort WHERE Name Like '" + gesuchterStandort + "'";
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                int standortid = Convert.ToInt32(dataReader.GetValue(0));
                dataReader.Close();
                command.Dispose();


                sql = "Select * from Autos WHERE F_Standort_id Like '" + standortid + "'";
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
                MessageBox.Show("Verbindungsfehler beim Lesen des Standortes " + gesuchterStandort + "!: " + ex.Message);
            }
            return autos;
        }
        public void SpeichereAuto(string autoMarke, int standortid)
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Autos (Marke, F_Standort_id) VALUES ('"+ autoMarke + "'," + standortid + ")", connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Speichern des Autos "+ autoMarke + " mit der Standort-ID "+ standortid + " ! " + ex.Message);
            }
        }
        public void AendereAuto(int id,string neuerName,int neueStandortid)
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE Autos SET Marke = '"+ neuerName + "', F_Standort_id = '"+ neueStandortid + "' WHERE Auto_id = " + id , connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Aendern des Autos mit der Auto-ID " + id + " ! " + ex.Message);
            }
        }
        public void LoescheAuto(int id)
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Autos WHERE Auto_id = " + id, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Loeschen des Autos mit der Auto-ID " + id + " ! " + ex.Message);
            }
        }
        public void SpeichereStandort(string standortName)
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Standorte (NAme) VALUES ('" + standortName + "')", connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Speichern des Standortes " + standortName + " ! " + ex.Message);
            }
        }
        public void AendereStandort(string alterStandortName, string neuerName)
        {
            //TODO
            // Überprüfung ob name schon in der Datenbank vorhanden damit keine doppelten einträge
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE Standorte SET Name = '" + neuerName + "' WHERE Name = " + alterStandortName, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Aendern des Standortes mit dem Name " + alterStandortName + " ! " + ex.Message);
            }
        }
        public void LoescheStandort(int id)
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Standorte WHERE Standort_id = " + id, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Loeschen des Standortes mit der Standort-ID " + id + " ! " + ex.Message);
            }
        }
    }
}
