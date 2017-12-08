using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP8_Autoverwaltung.src
{
    class Standort
    {
        int standortid;
        string standortName;

        public Standort()
        {

        }
        public Standort(int standortId, string standortName)
        {
            this.standortid = standortId;
            this.standortName = standortName;
        }
        public string GetStandortName()
        {
            return standortName;
        }

        public void SetStandortName(string standortName)
        {
            this.standortName = standortName;
        }

        public int GetStandortID()
        {
            return standortID;
        }
        public void SetStandortID(int standortID)
        {
            this.standortID = standortID;
        }
    }
}
