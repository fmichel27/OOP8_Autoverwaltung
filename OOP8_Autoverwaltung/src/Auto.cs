﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP8_Autoverwaltung.src
{
    class Auto
    {
        public string autoMarke;
        public int autoId;
        public int standortId;

        public Auto()
        {

        }
        public Auto(string autoMarke)
        {
            this.autoMarke = autoMarke;
        }
        public Auto(int standortId, string autoMarke)
        {
            this.standortId = standortId;
            this.autoMarke = autoMarke;
        }
        public Auto(int autoId, string autoMarke, int standortId)
        {
            this.autoId = autoId;
            this.standortId = standortId;
            this.autoMarke = autoMarke;
        }

        public int GetStandortId()
        {
            return standortId;
        }
        public void SetStandortId(int standortId)
        {
            this.standortId = standortId;
        }
        public string GetAutoMarke()
        {
            return autoMarke;
        }

        public void SetAutoMarke(string autoMarke)
        {
            this.autoMarke = autoMarke;
        }

        public int GetAutoId()
        {
            return autoId;
        }
        public void SetAutoId(int autoId)
        {
            this.autoId = autoId;
        }
    }
}
