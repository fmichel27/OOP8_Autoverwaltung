using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP8_Autoverwaltung.src
{
    class Fachkonzept1 : IFachkonzept
    {
        Datenbankverwaltung datenbankverwaltung = new Datenbankverwaltung();

        public List<Auto> GetAlleAutos()
        { 
            List<Auto> autos = datenbankverwaltung.LiesAlleAutos();
            return autos;
        }

        public List<Standort> GetAlleStandorte()
        {
            List<Standort> standorte = datenbankverwaltung.LiesAlleStandorte();
            return standorte;
        }

        public List<Auto> FilterAutosNachAutomarke(string gesuchteMArke)
        {
            List<Auto> autos = datenbankverwaltung.LiesAutoMarke(gesuchteMArke);
            return autos;
        }
        public List<Auto> FilterAutosNachStandort(string gesuchterStandort)
        {
            List<Auto> autos = datenbankverwaltung.LiesStandort(gesuchterStandort);
            return autos;
        }

        public void SpeichereNeuesAuto(Auto neuesAuto)
        {
            datenbankverwaltung.SpeichereAuto(neuesAuto.GetAutoMarke(), neuesAuto.GetStandortId());
        }

        public void AendereAuto(int autoNr, Auto auto)
        {
            datenbankverwaltung.AendereAuto(autoNr, auto.GetAutoMarke(),auto.GetStandortId());
        }
        public void LoescheAuto(int autoNr)
        {
            datenbankverwaltung.LoescheAuto(autoNr);
        }
        public void SpeichereNeuenStandort(Standort neuerStandort)
        {
            datenbankverwaltung.SpeichereStandort(neuerStandort.GetStandortName());
        }

        public void AendereStandort(int standortNr, Standort standort)
        {
            datenbankverwaltung.AendereStandort(standortNr, standort.GetStandortName());
        }
        public void LoescheSTandort(int standortNr)
        {
            datenbankverwaltung.LoescheStandort(standortNr);
        }






        public void InitialisiereSpeichermedium(string speichermedium)
        {
            throw new NotImplementedException();
        }



        public void LoescheStandort(int standortNr)
        {
            throw new NotImplementedException();
        }



    }
}
