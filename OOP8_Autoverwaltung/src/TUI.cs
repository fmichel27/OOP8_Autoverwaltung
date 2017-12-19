using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace OOP8_Autoverwaltung.src
{

    class TUI
    {
        private IFachkonzept einFachkonzept;
        public TUI(IFachkonzept einFachkonzept)
        {
            this.einFachkonzept = einFachkonzept;
            ZeigeMenue();
        }
        public void ZeigeMenue()
        {
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
            Console.WriteLine("---------------------------------");
            Console.WriteLine();
            LiesEingabe();
        }
        void LiesEingabe()
        {
            bool wiederholung = false;
            string eingabe;
            do
            {
                if (wiederholung)
                    Console.WriteLine("Bitte nur Buchstaben von a bis j eingeben, x zum Beenden.");
                Console.Write("Eingabe: ");
                eingabe = Console.ReadLine();
                //Console.Clear();
                wiederholung = true;
            } while (!Regex.IsMatch(eingabe, "^[a-j,x]$"));

            switch (eingabe)
            {
                case "a":
                    ZeigeAlleStandorte();
                    break;
                case "b":
                    ZeigeAlleAutos();
                    break;
                case "c":
                    FilternNachAutoMarke();
                    break;
                case "d":
                    FilternNachStandortName();
                    break;
                case "e":
                    AutoAnlegen();
                    break;
                case "f":
                    AutoAendern();
                    break;
                case "g":
                    AutoLoeschen();
                    break;
                case "h":
                    StandortAnlegen();
                    break;
                case "i":
                    StandortAendern();
                    break;
                case "j":
                    StandortLoeschen();
                    break;
                case "x":
                    break;
                default:
                    break;
            }
        }
        void ErzeugeAusgabe(string ausgabestring)
        {
            Console.WriteLine(ausgabestring);
            Console.ReadLine();
            //Konsolenausgabe

        }
        void ErzeugeAusgabeListeAuto(List<Auto> ausgabeListe)
        {
            //Konsolenausgabe

        }
        void ErzeugeAusgabeListeStandort(List<Standort> ausgabeListe)
        {
            //Konsolenausgabe

        }
        void ZeigeAlleAutos()
        {
            PrintUeberschrift();
            Console.WriteLine("Alle Autos:");
            Console.WriteLine("");
            //aufruf fachkonzept gibt liste zurück
            //List<Auto> autos = einFachkonzept.ZeigeAlleAutos();
            //for each
            //ErzeugeAusgabeListeAuto();
        }
        void ZeigeAlleStandorte()
        {

        }
        void FilternNachAutoMarke()
        {

        }
        void FilternNachStandortName()
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
            string eingabe;
            Console.WriteLine("Welchen Standort möchten Sie löschen?");
            Console.Write("Bitte ID eingeben: ");
            do
            {
                eingabe = Console.ReadLine();

            } while (!Regex.IsMatch(eingabe, "[0-9]+"));
            einFachkonzept.LoescheStandort(Convert.ToInt32(eingabe));
        }
        void StandortAendern()
        {

        }
        void PrintUeberschrift()
        {
            Console.WriteLine("AUTO-VERWALTUNGSSYSTEM");
            Console.WriteLine("");
        }

    }
}
