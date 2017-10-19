using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP8_Autoverwaltung.src
{
    interface IDatenhaltung
    {
        void CreateSpeichermedium(string a,string b);
        Auto LeseAuto(int autoNummer);
        void SpeichereAuto(Auto auto,int a);
        void LoescheAuto(int autoNummer);

        Standort LeseStandort(int standotrNummer);
        void SpeichereStandort(Standort standort, int a);
        void LoescheStandort(int standortNummer);
    }
}
