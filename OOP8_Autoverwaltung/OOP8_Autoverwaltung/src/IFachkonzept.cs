using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP8_Autoverwaltung.src
{
    interface IFachkonzept
    {

        void InitialisiereSpeichermedium(string speichermedium);
        void SpeichereNeuesAuto(Auto neuesAuto);
        void AendereAutoStandort(int autoNr, Standort standort);
        void LoescheAuto(int autoNr);
        Standort GetAutoStandort();
        int GetAutoNr();
        List<Auto> GetAlleAutos();

        void LoescheStandort(int standortNr);
        int GetStandortNr();
        List<Auto> GetAutosAnStandort();
        List<Standort> GetAlleStandorte();
    }
}
