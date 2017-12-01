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

        public Auto LiesAuto(int autoNummer)
        {
            throw new NotImplementedException();
        }

        public Standort LiesStandort(int standortNummer)
        {
            throw new NotImplementedException();
        }

        public void LoescheAuto(int autoNummer)
        {
            throw new NotImplementedException();
        }

        public void LoescheStandort(int standortNummer)
        {
            throw new NotImplementedException();
        }

        public void SpeichereAuto(Auto auto)
        {
            throw new NotImplementedException();
        }

        public void SpeichereStandort(Standort standort, int a)
        {
            throw new NotImplementedException();
        }
    }
}
