using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP8_Autoverwaltung.src
{
    class Auto
    {
        string autoMarke;
        int autoID;

        public Auto()
        {

        }
        public Auto(int autoID, string autoMarke )
        {
            this.autoID = autoID;
            this.autoMarke = autoMarke;
        }


        public string GetAutoMarke()
        {
            return autoMarke;
        }

        public void SetAutoMarke(string autoMarke)
        {
            this.autoMarke = autoMarke;
        }

        public int GetAutoID()
        {
            return autoID;
        }
        public void SetAutoID(int autoID)
        {
            this.autoID = autoID;
        }
    }
}
