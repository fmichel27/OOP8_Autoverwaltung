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
            Console.WriteLine("{0," + space + "}{1}", " Filtern nach Automarke", "(c)");
            Console.WriteLine("{0," + space + "}{1}", " Filtern nach Standortname", "(d)");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("{0," + space + "}{1}", " Auto anlegen", "(e)");
            Console.WriteLine("{0," + space + "}{1}", " Auto aendern", "(f)");
            Console.WriteLine("{0," + space + "}{1}", " Auto loeschen", "(g)");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("{0," + space + "}{1}", " Standort anlegen", "(h)");
            Console.WriteLine("{0," + space + "}{1}", " Standort aendern", "(i)");
            Console.WriteLine("{0," + space + "}{1}", " Standort loeschen", "(j)");
            LeseEingabe();
        }
        void LeseEingabe()
        {
            string eingabe = Console.ReadLine();
            //Fehlerueberpruefung
            //switch case blöcke
        }
        void ErzeugeAusgabe(string ausgabestring)
        {
            //Konsolenausgabe
        }
        void ZeigeAlleAutos()
        {

        }
        void ZeigeAlleStandorte()
        {

        }
        void FilternNachAutoMarke(string marke)
        {

        }
        void FilternNachStandortName(string name)
        {

        }
        void AutoAnlegen()
        {
            //input
            //fachkonzept.autoanlegen()
        }
        void AutoLoeschen()
        {

        }
        void AutoAendern()
        {

        }
        void StandortAnlegen()
        {

        }
        void StandortLoeschen()
        {

        }
        void StandortAendern()
        {

        }

    }
}
