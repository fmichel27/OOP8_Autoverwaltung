using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP8_Autoverwaltung.src
{
    class Fachkonzept1 : IFachkonzept
    {
        private IDatenhaltung eineDatenhaltung;

        public Fachkonzept1(IDatenhaltung eineDatenhaltung)
        {
            this.eineDatenhaltung = eineDatenhaltung;
        }

        public List<Auto> GetAlleAutos()
        { 
            List<Auto> autos = eineDatenhaltung.LiesAlleAutos();
            autos.Reverse();
            return autos;
        }

        public List<Standort> GetAlleStandorte()
        {
            List<Standort> standorte = eineDatenhaltung.LiesAlleStandorte();
            standorte.Reverse();
            return standorte;
        }

        public List<Auto> FilterAutosNachAutomarke(string gesuchteMArke)
        {
            List<Auto> autos = eineDatenhaltung.LiesAutoMarke(gesuchteMArke);
            autos.Reverse();
            return autos;
        }
        public List<Auto> FilterAutosNachStandort(int standortid)
        {
            List<Auto> autos = eineDatenhaltung.LiesStandort(standortid);
            autos.Reverse();
            return autos;
        }

        public void SpeichereNeuesAuto(string automarke, int standortid)
        {
            eineDatenhaltung.SpeichereAuto(automarke, standortid);
        }

        public void AendereAuto(int autoNr, string automarke, int standortid)
        {
            Auto auto = new Auto(standortid, automarke);
            eineDatenhaltung.AendereAuto(autoNr, auto.GetAutoMarke(),auto.GetStandortId());
        }
        public void LoescheAuto(int autoNr)
        {
            eineDatenhaltung.LoescheAuto(autoNr);
        }
        public void SpeichereNeuenStandort(string neuerStandortName)
        {
            eineDatenhaltung.SpeichereStandort(neuerStandortName);
        }

        public void AendereStandort(int standortid, string neuerStandortName)
        {
            eineDatenhaltung.AendereStandort(standortid, neuerStandortName);
        }
        public void LoescheStandort(int standortNr)
        {
            eineDatenhaltung.LoescheStandort(standortNr);
        }

        public Standort getStandortDesAutos(int standortid)
        {
            Standort standortDesAutos = eineDatenhaltung.getStandortDesAutos(standortid);

            return standortDesAutos;
        }
    }
}
