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
            Console.WriteLine("---------------------------------");
            Console.WriteLine();
            LiesEingabe();
        }
        void LiesEingabe()
        {
            Console.Write("Eingabe: ");
            string eingabe = Console.ReadLine();
            Console.Clear();

            //Fehlerueberpruefung REGEX wenn das geht =)


            //switch case blöcke
            //switch (eingabe)
            //{
            //    case "a":
            //        ZeigeAlleStandorte();
            //        break;
            //    case "b":
            //        ZeigeAlleAutos();
            //        break;
            //    case "c":
            //        ZeigeAlleStandorte();
            //        break;
            //    case "d":
            //        ZeigeAlleStandorte();
            //        break;
            //    case "e":
            //        ();
            //        break;
            //    case "f":
            //        ZeigeAlleStandorte();
            //        break;
            //    case "g":
            //        ZeigeAlleStandorte();
            //        break;
            //    case "h":
            //        ZeigeAlleStandorte();
            //        break;
            //    case "i":
            //        ZeigeAlleStandorte();
            //        break;
            //    case "j":
            //        ZeigeAlleStandorte();
            //        break;
            //    default:
            //        break;
            //}

            if (eingabe == "b")
            {
                Fachkonzept1 fachkonzept1 = new Fachkonzept1();
                List<Auto> autos = fachkonzept1.GetAlleAutos();
                foreach (var item in autos)
                {
                    ErzeugeAusgabe(item.GetAutoMarke());
                }
            }
            if (eingabe == "e")
            {
                Fachkonzept1 fachkonzept1 = new Fachkonzept1();
                fachkonzept1.SpeichereNeuesAuto("ferraritest");
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
            //for each
            //ErzeugeAusgabeListeAuto();
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
        void PrintUeberschrift()
        {
            Console.WriteLine("AUTO-VERWALTUNGS-SYSTEM");
            Console.WriteLine("");
        }

    }
}
