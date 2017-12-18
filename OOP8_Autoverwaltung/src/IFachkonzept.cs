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
        List<Auto> FilterAutosNachStandort(string gesuchterStandort);
        void SpeichereNeuesAuto(Auto neuesAuto);
        void AendereAuto(int autoNr, Auto auto);
        void LoescheAuto(int autoNr);
        void SpeichereNeuenStandort(Standort neuerStandort);
        void AendereStandort(string alterStandortName, string neuerStandortName);
        void LoescheSTandort(int standortNr);




    }
}
