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
        string tmpAutosDateiName;
        string tmpStandorteDateiName;
        string pfadZuStandortXml = "C:\\Users\\Philipp\\source\\repos\\OOP8_Autoverwaltung\\OOP8_Autoverwaltung\\src\\datenhaltungXML.xml";


        public void AendereAuto(int id, string neuerName, int neueStandortid)
        {
            throw new NotImplementedException();
        }

        public void AendereStandort(string alterStandortName, string neuerName)
        {
            throw new NotImplementedException();
        }

        public void AendereStandort(int standortid, string neuerStandortName)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public List<Auto> LiesStandort(int standortid)
        {
            throw new NotImplementedException();
        }

        public void LoescheAuto(int id)
        {
            xmlDocument = new XmlDocument();
            xmlDocument.Load(pfadZuStandortXml);
            foreach (XmlNode standorte in xmlDocument.DocumentElement)
            {
                foreach (XmlNode auto in standorte.SelectSingleNode("Autos"))
                {
                    if (Convert.ToInt32(auto.SelectSingleNode("AutoId")) == id)
                    {
                        xmlDocument.DocumentElement.RemoveChild(auto);
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
                if (Convert.ToInt32(standorte.SelectSingleNode("Xml/Standort/id")) == id)
                {
                    xmlDocument.DocumentElement.RemoveChild(standorte);
                }
            }
        }

        public void SpeichereAuto(string autoMarke, int standortid)
        {
            throw new NotImplementedException();
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
            foreach (var standortContainer in xmlDocument.GetElementsByTagName("Standort"))
            {
                standortIdZaehler += 1;
            }
            standortId.InnerText = Convert.ToString(standortIdZaehler + 1);
            name.InnerText = standortName;
            standort.AppendChild(standortId);
            standort.AppendChild(name);
            xmlDocument.DocumentElement.AppendChild(standort);
            xmlDocument.Save(pfadZuStandortXml);
        }
    }
}
