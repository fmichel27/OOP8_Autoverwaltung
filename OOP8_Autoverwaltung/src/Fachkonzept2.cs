using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP8_Autoverwaltung.src
{
    class Fachkonzept2 : IFachkonzept
    {
        private IDatenhaltung eineDatenhaltung;

        public Fachkonzept2(IDatenhaltung eineDatenhaltung)
        {
            this.eineDatenhaltung = eineDatenhaltung;
        }

        public void AendereAuto(int autoNr, string neueAutomarken, int standortid)
        {
            eineDatenhaltung.AendereAuto(autoNr, neueAutomarken, standortid);
        }

        public void AendereStandort(int standortid, string neuerStandortName)
        {
            eineDatenhaltung.AendereStandort(standortid, neuerStandortName);
        }

        public List<Auto> FilterAutosNachAutomarke(string gesuchteMarke)
        {
            return eineDatenhaltung.LiesAutoMarke(gesuchteMarke);
        }

        public List<Auto> FilterAutosNachStandort(int standortid)
        {
            return eineDatenhaltung.LiesStandort(standortid);
        }

        public List<Auto> GetAlleAutos()
        {
            return eineDatenhaltung.LiesAlleAutos();
        }

        public List<Standort> GetAlleStandorte()
        {
            return eineDatenhaltung.LiesAlleStandorte();
        }

        public Standort getStandortDesAutos(int standortid)
        {
            return eineDatenhaltung.getStandortDesAutos(standortid);
        }

        public void LoescheAuto(int autoNr)
        {
            eineDatenhaltung.LoescheAuto(autoNr);
        }

        public void LoescheStandort(int standortNr)
        {
            eineDatenhaltung.LoescheStandort(standortNr);
        }

        public void SpeichereNeuenStandort(string neuerStandortName)
        {
            eineDatenhaltung.SpeichereStandort(neuerStandortName);
        }

        public void SpeichereNeuesAuto(string automarke, int standortid)
        {
            eineDatenhaltung.SpeichereAuto(automarke, standortid);
        }
    }
}
