using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP8_Autoverwaltung.src
{
    class Fachkonzept2 : IFachkonzept
    {
        public void AendereAuto(int autoNr, Auto auto)
        {
            throw new NotImplementedException();
        }

        public void AendereStandort(string alterStandortName, string neuerName)
        {
            throw new NotImplementedException();
        }

        public List<Auto> FilterAutosNachAutomarke(string gesuchteMArke)
        {
            throw new NotImplementedException();
        }

        public List<Auto> FilterAutosNachStandort(string gesuchterStandort)
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

        public void InitialisiereSpeichermedium(string speichermedium)
        {
            throw new NotImplementedException();
        }

        public void LoescheAuto(int autoNr)
        {
            throw new NotImplementedException();
        }

        public void LoescheSTandort(int standortNr)
        {
            throw new NotImplementedException();
        }

        public void SpeichereNeuenStandort(Standort neuerStandort)
        {
            throw new NotImplementedException();
        }

        public void SpeichereNeuesAuto(Auto neuesAuto)
        {
            throw new NotImplementedException();
        }
    }
}
