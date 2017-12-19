using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP8_Autoverwaltung.src
{
    class Standort
    {
        public int standortid;
        public string standortName;

        public Standort()
        {

        }
        public Standort(string standortName)
        {
            this.standortName = standortName;
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
            return standortid;
        }
        public void SetStandortID(int standortid)
        {
            this.standortid = standortid;
        }
    }
}
