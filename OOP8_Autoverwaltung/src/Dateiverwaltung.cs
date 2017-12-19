using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP8_Autoverwaltung.src
{
    class Dateiverwaltung:IDatenhaltung
    {
        string tmpAutosDateiName;
        string tmpStandorteDateiName;

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

        public List<Auto> LiesAlleAutos()
        {
            throw new NotImplementedException();
        }

        public List<Standort> LiesAlleStandorte()
        {
            throw new NotImplementedException();
        }

        public List<Auto> LiesAutoMarke(string gesuchteMarke)
        {
            throw new NotImplementedException();
        }

        public Standort LiesStandort(string gesuchterStandort)
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

        List<Auto> IDatenhaltung.LiesStandort(string gesuchterStandort)
        {
            throw new NotImplementedException();
        }
    }
}
