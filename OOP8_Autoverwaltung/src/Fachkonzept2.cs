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

        public void AendereAuto(int autoNr, Auto auto)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public List<Standort> GetAlleStandorte()
        {
            throw new NotImplementedException();
        }

        public Standort getStandortDesAutos(int standortid)
        {
            throw new NotImplementedException();
        }

        public void InitialisiereSpeichermedium(string speichermedium)
        {
            throw new NotImplementedException();
        }

        public void LoescheAuto(int autoNr)
        {
            throw new NotImplementedException();
        }

        public void LoescheStandort(int standortNr)
        {
            eineDatenhaltung.LoescheStandort(standortNr);
        }

        public void SpeichereNeuenStandort(string neuerStandortName)
        {
            throw new NotImplementedException();
        }

        public void SpeichereNeuenStandort(Standort neuerStandort)
        {
            throw new NotImplementedException();
        }

        public void SpeichereNeuesAuto(string automarke)
        {
            throw new NotImplementedException();
        }
    }
}
