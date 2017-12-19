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

        public List<Auto> FilterAutosNachAutomarke(string gesuchteMArke)
        {
            throw new NotImplementedException();
        }

        public List<Auto> FilterAutosNachStandort(int standortid)
        {
            throw new NotImplementedException();
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
