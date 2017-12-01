using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP8_Autoverwaltung.src
{
    class Fachkonzept1 : IFachkonzept
    {
        public void AendereAutoStandort(int autoNr, Standort standort)
        {
            throw new NotImplementedException();
        }

        public List<Auto> GetAlleAutos()
        { 
            Datenbankverwaltung datenbankverwaltung = new Datenbankverwaltung();
            List<Auto> autos = datenbankverwaltung.LiesAlleAutos();
            return autos;
        }

        public List<Standort> GetAlleStandorte()
        {
            throw new NotImplementedException();
        }

        public int GetAutoNr()
        {
            throw new NotImplementedException();
        }

        public List<Auto> GetAutosAnStandort()
        {
            throw new NotImplementedException();
        }

        public Standort GetAutoStandort()
        {
            throw new NotImplementedException();
        }

        public int GetStandortNr()
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
            throw new NotImplementedException();
        }

        public void SpeichereNeuesAuto(Auto neuesAuto)
        {
            Datenbankverwaltung datenbankverwaltung = new Datenbankverwaltung();
            datenbankverwaltung.SpeichereAuto(neuesAuto);
        }
    }
}
