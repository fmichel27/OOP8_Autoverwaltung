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
            Console.WriteLine("Beenden (x)");
            Console.WriteLine();
            LiesEingabe();
        }
        void LiesEingabe()
        {
            bool wiederholung = false;
            Console.WriteLine(wiederholung);
            string eingabe = "";
            do
            {
                if (wiederholung)
                    Console.WriteLine("Bitte nur Buchstaben von a bis j eingeben, x zum Beenden.");
                Console.Write("Eingabe (Bestätigen mit [Enter]): ");
                eingabe = Console.ReadLine();
                //Console.Clear();
                wiederholung = true;
            } while (!Regex.IsMatch(eingabe, "^[a-jx]$"));

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
            Console.WriteLine(" Auto ID | Automarke | Standort");
            foreach (Auto auto in ausgabeListe)
            {
                string autoMarke = auto.GetAutoMarke();
                int autoId = auto.GetAutoId();
                int standortId = auto.GetStandortId();
                string standortName = einFachkonzept.getStandortDesAutos(standortId).GetStandortName();
                Console.WriteLine(string.Format("{0,8} | {1,10} | {2,-14}", autoId, autoMarke, standortName));
            }
        }
        void ErzeugeAusgabeListeStandort(List<Standort> ausgabeListe)
        {
            Console.WriteLine(" ID | Standortname");
            foreach (Standort standort in ausgabeListe)
            {
                int standortId = standort.GetStandortID();
                string standortName = standort.GetStandortName();
                Console.WriteLine(string.Format("{0,3} | {1,-14}", standortId, standortName));
            }
        }
        void ZeigeAlleAutos()
        {
            PrintUeberschrift();
            Console.WriteLine("Alle Autos:");
            Console.WriteLine("");
            List<Auto> alleAutos = einFachkonzept.GetAlleAutos();
            ErzeugeAusgabeListeAuto(alleAutos);
            Console.WriteLine("");
            Console.WriteLine("Zum Fortfahren beliebige Taste drücken..");
            Console.ReadKey();
            ZeigeMenue();
        }
        void ZeigeAlleStandorte()
        {
            PrintUeberschrift();
            Console.WriteLine("Alle Standorte:");
            Console.WriteLine("");
            List<Standort> alleStandorte = einFachkonzept.GetAlleStandorte();
            ErzeugeAusgabeListeStandort(alleStandorte);
            Console.WriteLine("");
            Console.WriteLine("Zum Fortfahren beliebige Taste drücken..");
            Console.ReadKey();
            ZeigeMenue();
        }
        void FilternNachAutoMarke()
        {

        }
        void FilternNachStandortName()
        {

        }
        void AutoAnlegen()
        {
            string eingabe;
            string eingabe2;
            PrintUeberschrift();
            Console.WriteLine("Bitte geben Sie einen Namen für das neue Auto an.");
            do
            {
                Console.WriteLine("Es sind Buchstaben und Zahlen erlaubt.");
                Console.Write("Bitte einen Namen eingeben: ");
                eingabe = Console.ReadLine();
                Console.Write("Bitte die StandortID eingeben: ");
                eingabe2 = Console.ReadLine();
            } while (!Regex.IsMatch(eingabe, "[a-zA-Z0-9 ]+") && !Regex.IsMatch(eingabe, "[0-9 ]+"));
            einFachkonzept.SpeichereNeuesAuto(eingabe, Convert.ToInt32(eingabe2));
            Console.WriteLine("Neues Auto angelegt.");
            Console.WriteLine("");
            ZeigeMenue();
        }
        void AutoLoeschen()
        {
            string eingabe;
            PrintUeberschrift();
            Console.WriteLine("Welches Auto möchten Sie löschen?");
            Console.Write("Bitte ID eingeben: ");
            do
            {
                eingabe = Console.ReadLine();

            } while (!Regex.IsMatch(eingabe, "[0-9]+"));
            einFachkonzept.LoescheAuto(Convert.ToInt32(eingabe));
            Console.WriteLine("Auto gelöscht.");
            Console.WriteLine("");
            ZeigeMenue();
        }
        void AutoAendern()
        {

        }
        void StandortAnlegen()
        {
            string eingabe;
            PrintUeberschrift();
            Console.WriteLine("Bitte geben Sie einen Namen für den neuen Standort an.");
            do
            {
                Console.WriteLine("Es sind Buchstaben und Zahlen erlaubt.");
                Console.Write("Bitte einen Namen eingeben: ");
                eingabe = Console.ReadLine();
            } while (!Regex.IsMatch(eingabe, "[a-zA-Z0-9 ]+"));
            einFachkonzept.SpeichereNeuenStandort(eingabe);
            Console.WriteLine("Neuen Standort angelegt.");
            Console.WriteLine("");
            ZeigeMenue();
        }
        void StandortLoeschen()
        {
            string eingabe;
            PrintUeberschrift();
            Console.WriteLine("Welchen Standort möchten Sie löschen?");
            Console.Write("Bitte ID eingeben: ");
            do
            {
                eingabe = Console.ReadLine();

            } while (!Regex.IsMatch(eingabe, "[0-9]+"));
            einFachkonzept.LoescheStandort(Convert.ToInt32(eingabe));
            Console.WriteLine("Standort gelöscht.");
            Console.WriteLine("");
            ZeigeMenue();
        }
        void StandortAendern()
        {
            List<Standort> alleStandorte = einFachkonzept.GetAlleStandorte();
            ErzeugeAusgabeListeStandort(alleStandorte);
            string eingabe;
            PrintUeberschrift();
            Console.WriteLine("Welchen Standort möchten Sie bearbeiten?");
            Console.Write("Bitte ID eingeben: ");
            do
            {
                eingabe = Console.ReadLine();

            } while (!Regex.IsMatch(eingabe, "[0-9]+"));
            int standortId = Convert.ToInt32(eingabe);
            do
            {
                Console.WriteLine("Es sind Buchstaben und Zahlen erlaubt.");
                Console.Write("Bitte einen neuen Namen eingeben: ");
                eingabe = Console.ReadLine();
            } while (!Regex.IsMatch(eingabe, "[a-zA-Z0-9 ]+"));
            einFachkonzept.AendereStandort(standortId, eingabe);
            Console.WriteLine("Standort geändert.");
            Console.WriteLine("");
            ZeigeMenue();
        }
        void PrintUeberschrift()
        {
            Console.WriteLine("AUTO-VERWALTUNGSSYSTEM");
            Console.WriteLine("");
        }

    }
}
