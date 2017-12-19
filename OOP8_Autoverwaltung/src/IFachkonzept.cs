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
        List<Auto> GetAlleAutos();
        List<Standort> GetAlleStandorte();
        List<Auto> FilterAutosNachAutomarke(string gesuchteMArke);
        List<Auto> FilterAutosNachStandort(int standortid);
        void SpeichereNeuesAuto(string automarke);
        void AendereAuto(int autoNr, string neueAutomarke, int standortid);
        void LoescheAuto(int autoNr);
        void SpeichereNeuenStandort(string neuerStandortName);
        void AendereStandort(int standortid, string neuerStandortName);
        void LoescheStandort(int standortNr);

        Standort getStandortDesAutos(int standortid);


    }
}
