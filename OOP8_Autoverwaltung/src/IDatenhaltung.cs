using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP8_Autoverwaltung.src
{
    interface IDatenhaltung
    {
        List<Auto> LiesAlleAutos();
        List<Standort> LiesAlleStandorte();
        List<Auto> LiesAutoMarke(string gesuchteMarke);
        List<Auto> LiesStandort(int standortid);
        void SpeichereAuto(string autoMarke, int standortid);
        void AendereAuto(int id, string neuerName, int neueStandortid);
        void LoescheAuto(int id);
        void SpeichereStandort(string standortName);
        void AendereStandort(int standortid, string neuerStandortName);
        void LoescheStandort(int id);
        Standort getStandortDesAutos(int standortid);




    }
}
