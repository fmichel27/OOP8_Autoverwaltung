using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OOP8_Autoverwaltung.src
{
    class Dateiverwaltung:IDatenhaltung
    {
        private XmlDocument xmlDocument;
        string pfadZuStandortXml = "C:\\Users\\Philipp\\source\\repos\\OOP8_Autoverwaltung\\OOP8_Autoverwaltung\\src\\datenhaltungXML.xml";


        public void AendereAuto(int id, string neuerName, int neueStandortid)
        {
            xmlDocument = new XmlDocument();
            xmlDocument.Load(pfadZuStandortXml);
            XmlNode neuesAuto = xmlDocument.CreateElement("Fehler");
            XmlNode neuerStandort = xmlDocument.CreateElement("Fehler");
            foreach (XmlNode standorte in xmlDocument.DocumentElement)
            {
                if (Convert.ToInt32(standorte.SelectSingleNode("StandortId").InnerText) == neueStandortid)
                {
                    neuerStandort = standorte.SelectSingleNode("Autos");
                }
                foreach (XmlNode auto in standorte.SelectSingleNode("Autos"))
                {
                    if (Convert.ToInt32(auto.SelectSingleNode("AutoId").InnerText) == id)
                    {
                        auto.SelectSingleNode("Marke").InnerText = neuerName;
                        neuesAuto = auto;
                        standorte.SelectSingleNode("Autos").RemoveChild(auto);
                    }
                }
            }
            try
            {
                neuerStandort.AppendChild(neuesAuto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler! Node nicht gefunden: " + ex.Message);
            }
            xmlDocument.Save(pfadZuStandortXml);
        }

        public void AendereStandort(int standortid, string neuerStandortName)
        {
            xmlDocument = new XmlDocument();
            xmlDocument.Load(pfadZuStandortXml);
            int aktuelleStandortId = 0;
            foreach (XmlNode standorte in xmlDocument.DocumentElement)
            {
                aktuelleStandortId = Convert.ToInt32(standorte.SelectSingleNode("StandortId").InnerText);
                if (aktuelleStandortId == standortid)
                {
                    standorte.SelectSingleNode("Name").InnerText = neuerStandortName;
                    xmlDocument.Save(pfadZuStandortXml);
                    break;
                }
            }
        }

        public Standort getStandortDesAutos(int standortid)
        {
            xmlDocument = new XmlDocument();
            xmlDocument.Load(pfadZuStandortXml);
            int aktuelleStandortId = 0;
            foreach (XmlNode standorte in xmlDocument.DocumentElement)
            {
                aktuelleStandortId = Convert.ToInt32(standorte.SelectSingleNode("StandortId").InnerText);
                if (aktuelleStandortId == standortid)
                {
                    return new Standort(aktuelleStandortId, standorte.SelectSingleNode("Name").InnerText);
                }
            }
            return new Standort(aktuelleStandortId, "Standort nicht gefunden.");
        }

        public List<Auto> LiesAlleAutos()
        {
            xmlDocument = new XmlDocument();
            xmlDocument.Load(pfadZuStandortXml);
            List<Auto> autoListe = new List<Auto>();
            foreach (XmlNode standorte in xmlDocument.DocumentElement)
            {
                foreach (XmlNode auto in standorte.SelectSingleNode("Autos"))
                {
                    try
                    {
                        int autoId = Convert.ToInt32(auto.SelectSingleNode("AutoId").InnerText);
                        string autoMarke = auto.SelectSingleNode("Marke").InnerText;
                        int standortId = Convert.ToInt32(standorte.SelectSingleNode("StandortId").InnerText);
                        autoListe.Add(new Auto(autoId, autoMarke, standortId));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Fehler! Node nicht gefunden: " + ex.Message);
                    }
                }
            }
            return autoListe;
        }

        public List<Standort> LiesAlleStandorte()
        {
            xmlDocument = new XmlDocument();
            xmlDocument.Load(pfadZuStandortXml);
            List<Standort> standortListe = new List<Standort>();
            foreach (XmlNode standorte in xmlDocument.DocumentElement)
            {
                try
                {
                    standortListe.Add(new Standort(Convert.ToInt32(standorte.SelectSingleNode("StandortId").InnerText), standorte.SelectSingleNode("Name").InnerText));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler! Node nicht gefunden: " + ex.Message);
                }
        }
            return standortListe;
        }

        public List<Auto> LiesAutoMarke(string gesuchteMarke)
        {
            xmlDocument = new XmlDocument();
            xmlDocument.Load(pfadZuStandortXml);
            List<Auto> autoListe = new List<Auto>();
            foreach (XmlNode standorte in xmlDocument.DocumentElement)
            {
                foreach (XmlNode auto in standorte.SelectSingleNode("Autos"))
                {
                    if (auto.SelectSingleNode("Marke").InnerText == gesuchteMarke)
                    {
                        try
                        {
                            int autoId = Convert.ToInt32(auto.SelectSingleNode("AutoId").InnerText);
                            string autoMarke = auto.SelectSingleNode("Marke").InnerText;
                            int standortId = Convert.ToInt32(standorte.SelectSingleNode("StandortId").InnerText);
                            autoListe.Add(new Auto(autoId, autoMarke, standortId));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Fehler! Node nicht gefunden: " + ex.Message);
                        }
                    }
                    break;
                }
            }
            return autoListe;
        }

        public List<Auto> LiesStandort(int standortid)
        {
            xmlDocument = new XmlDocument();
            xmlDocument.Load(pfadZuStandortXml);
            List<Auto> autoListe = new List<Auto>();
            foreach (XmlNode standorte in xmlDocument.DocumentElement)
            {
                if ((Convert.ToInt32(standorte.SelectSingleNode("StandortId").InnerText)) == standortid)
                {
                    foreach (XmlNode auto in standorte.SelectSingleNode("Autos"))
                    {
                        try
                        {
                            int autoId = Convert.ToInt32(auto.SelectSingleNode("AutoId").InnerText);
                            string autoMarke = auto.SelectSingleNode("Marke").InnerText;
                            int standortId = Convert.ToInt32(standorte.SelectSingleNode("StandortId").InnerText);
                            autoListe.Add(new Auto(autoId, autoMarke, standortId));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Fehler! Node nicht gefunden: " + ex.Message);
                        }
                    }
                    break;
                }
            }
            return autoListe;
        }

        public void LoescheAuto(int id)
        {
            xmlDocument = new XmlDocument();
            xmlDocument.Load(pfadZuStandortXml);
            foreach (XmlNode standorte in xmlDocument.DocumentElement)
            {
                foreach (XmlNode auto in standorte.SelectSingleNode("Autos"))
                {
                    if (Convert.ToInt32(auto.SelectSingleNode("AutoId").InnerText) == id)
                    {
                        standorte.SelectSingleNode("Autos").RemoveChild(auto);
                        xmlDocument.Save(pfadZuStandortXml);
                    }
                }
            }
        }

        public void LoescheStandort(int id)
        {
            xmlDocument = new XmlDocument();
            xmlDocument.Load(pfadZuStandortXml);
            foreach (XmlNode standorte in xmlDocument.DocumentElement)
            {
                if (Convert.ToInt32(standorte.SelectSingleNode("StandortId").InnerText) == id)
                {
                    xmlDocument.DocumentElement.RemoveChild(standorte);
                    xmlDocument.Save(pfadZuStandortXml);
                }
            }
        }

        public void SpeichereAuto(string autoMarke, int standortid)
        {
            int autoIdZaehler = 0;
            xmlDocument = new XmlDocument();
            xmlDocument.Load(pfadZuStandortXml);
            XmlNode neuesAuto = xmlDocument.CreateElement("Auto");
            XmlNode marke = xmlDocument.CreateElement("Marke");
            XmlNode autoId = xmlDocument.CreateElement("AutoId");
            XmlNode neuerStandort = xmlDocument.CreateElement("Fehler");
            foreach (XmlNode standorte in xmlDocument.DocumentElement)
            {
                if (Convert.ToInt32(standorte.SelectSingleNode("StandortId").InnerText) == standortid)
                    neuerStandort = standorte.SelectSingleNode("Autos");
                foreach (XmlNode auto in standorte.SelectSingleNode("Autos"))
                {
                    //autoId bestimmen
                    if (Convert.ToInt32(auto.SelectSingleNode("AutoId").InnerText) > autoIdZaehler) 
                    autoIdZaehler = Convert.ToInt32(auto.SelectSingleNode("AutoId").InnerText);
                }
            }
            marke.InnerText = autoMarke;
            autoId.InnerText = Convert.ToString(autoIdZaehler + 1);
            neuesAuto.AppendChild(autoId);
            neuesAuto.AppendChild(marke);
            neuerStandort.AppendChild(neuesAuto);
            xmlDocument.Save(pfadZuStandortXml);
        }

        public void SpeichereStandort(string standortName)
        {
            int standortIdZaehler = 0;
            xmlDocument = new XmlDocument();
            xmlDocument.Load(pfadZuStandortXml);
            XmlNode standort = xmlDocument.CreateElement("Standort");
            XmlNode standortId = xmlDocument.CreateElement("StandortId");
            XmlNode name = xmlDocument.CreateElement("Name");
            XmlNode autos = xmlDocument.CreateElement("Autos");
            // groesste StandortID bestimmen
            foreach (XmlNode standortContainer in xmlDocument.GetElementsByTagName("Standort"))
            {
                if (Convert.ToInt32(standortContainer.SelectSingleNode("StandortId").InnerText) > standortIdZaehler)
                standortIdZaehler = Convert.ToInt32(standortContainer.SelectSingleNode("StandortId").InnerText);
            }
            standortId.InnerText = Convert.ToString(standortIdZaehler + 1);
            name.InnerText = standortName;
            standort.AppendChild(standortId);
            standort.AppendChild(name);
            standort.AppendChild(autos);
            xmlDocument.DocumentElement.AppendChild(standort);
            xmlDocument.Save(pfadZuStandortXml);
        }
    }
}
