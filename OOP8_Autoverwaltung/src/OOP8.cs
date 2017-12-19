using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP8_Autoverwaltung.src
{
    class OOP8
    {
        public static void Main()
        {
            GUI eineGui = new GUI(new Fachkonzept1(new Datenbankverwaltung()));
            //GUI eineGui = new GUI(new Fachkonzept2(new Datenbankverwaltung()));
            //GUI eineGui = new GUI(new Fachkonzept1(new Dateiverwaltung()));
            //GUI eineGui = new GUI(new Fachkonzept2(new Dateiverwaltung()));
           // TUI eineTui = new TUI(new Fachkonzept1(new Datenbankverwaltung()));
            //TUI eineTui = new TUI(new Fachkonzept2(new Datenbankverwaltung()));
            //TUI eineTui = new TUI(new Fachkonzept1(new Dateiverwaltung()));
            //TUI eineTui = new TUI(new Fachkonzept2(new Dateiverwaltung()));

        }
    }
}
