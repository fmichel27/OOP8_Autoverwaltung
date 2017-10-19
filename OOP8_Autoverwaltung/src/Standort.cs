using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP8_Autoverwaltung.src
{
    class Standort
    {
        int standortID;
        string standortName;

        string GetStandortName()
        {
            return standortName;
        }

        void SetStandortName(string standortName)
        {
            this.standortName = standortName;
        }

        int GetStandortID()
        {
            return standortID;
        }
        void SetStandortID(int standortID)
        {
            this.standortID = standortID;
        }
    }
}
