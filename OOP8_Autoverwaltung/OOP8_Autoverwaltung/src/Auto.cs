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

        string GetAutoMarke()
        {
            return autoMarke;
        }

        void SetAutoMarke(string autoMarke)
        {
            this.autoMarke = autoMarke;
        }

        int GetAutoID()
        {
            return autoID;
        }
        void SetAutoID(int autoID)
        {
            this.autoID = autoID;
        }
    }
}
