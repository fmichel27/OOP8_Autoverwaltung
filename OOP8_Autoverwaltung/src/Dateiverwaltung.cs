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
                standortListe.Add(new Standort(Convert.ToInt32(xmlDocument.SelectSingleNode("Xml/Standort/Id")), Convert.ToString(xmlDocument.SelectSingleNode("Xml/Standort/Name"))));
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
            throw new NotImplementedException();
        }

        public void SpeichereAuto(string autoMarke, int standortid)
        {
            throw new NotImplementedException();
        }

        public void SpeichereStandort(string standortName)
        {
            throw new NotImplementedException();
        }

        List<Auto> IDatenhaltung.LiesStandort(int stndortid)
        {
            throw new NotImplementedException();
        }
    }
}
