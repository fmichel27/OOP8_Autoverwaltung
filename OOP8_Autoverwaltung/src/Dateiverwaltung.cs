using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }

        public List<Auto> LiesAlleAutos()
        {
            throw new NotImplementedException();
        }

        public List<Standort> LiesAlleStandorte()
        {
            xmlDocument = new XmlDocument();
            xmlDocument.Load(pfadZuStandortXml);
            List<Standort> standortListe = new List<Standort>();
            foreach (XmlNode Standorte in xmlDocument.DocumentElement)
            {
                standortListe.Add(new Standort(Convert.ToInt32(Standorte.SelectSingleNode("Xml/Standort/Id")), Convert.ToString(Standorte.SelectSingleNode("Xml/Standort/Name"))));
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
            throw new NotImplementedException();
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
