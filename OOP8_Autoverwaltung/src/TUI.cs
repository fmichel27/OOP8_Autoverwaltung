using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP8_Autoverwaltung.src
{
    
    class TUI
    {
        public TUI()
        {
            ZeigeMenue();
        }
        public void ZeigeMenue() {
            int space = -30;
            Console.WriteLine("AUTO-VERWALTUNGS-SYSTEM");
            Console.WriteLine("");
            Console.WriteLine("{0," + space + "}{1}", " Alle Standorte anzeigen", "(a)");
            Console.WriteLine("{0," + space + "}{1}", " Alle Autos anzeigen", "(b)");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("{0," + space + "}{1}", " Alle Standorte anzeigen", "(c)");
            Console.WriteLine("{0," + space + "}{1}", " Alle Autos anzeigen", "(d)");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("{0," + space + "}{1}", " Alle Standorte anzeigen", "(e)");
            Console.WriteLine("{0," + space + "}{1}", " Alle Autos anzeigen", "(f)");
            Console.WriteLine("{0," + space + "}{1}", " Alle Autos anzeigen", "(g)");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("{0," + space + "}{1}", " Alle Standorte anzeigen", "(h)");
            Console.WriteLine("{0," + space + "}{1}", " Alle Autos anzeigen", "(i)");
            Console.WriteLine("{0," + space + "}{1}", " Alle Autos anzeigen", "(j)");
            Console.ReadLine();
        }
        void ZeigeAutos()
        {

        }
        void ZeigeStandorte()
        {

        }
    }
}
