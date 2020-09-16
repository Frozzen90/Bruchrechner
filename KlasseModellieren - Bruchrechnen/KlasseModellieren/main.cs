//Autor:        Sebastian Schmitz
//Datei:        main.cs
//Datum:        31.08.2020
//Klasse:       IA119
//Beschreibung: 
//Aenderungen:  03.09.2020

using System;
using System.Threading;

namespace KlasseModellieren
{
    partial class main
    {
        static void Main(string[] args)
        {
            //Instanz
            Bruch Bruch1 = new Bruch();     //Standardkonstruktor
            Bruch Bruch2 = new Bruch(1, 2); //Spezialkonstruktor
            Bruch Bruch3 = new Bruch(2, 3);

            #region <Test>
            bool running = true;

            while (running)
            {
                string Eingabe = eingabeAbfrage();
                switch (Eingabe)
                {
                    case "1":
                        Bruch1.Zuweisung(Bruch2.Addition(Bruch3));
                        break;
                    case "2":
                        Bruch1.Zuweisung(Bruch2.Subtraktion(Bruch3));
                        break;
                    case "3":
                        Bruch1.Zuweisung(Bruch2.Multiplikation(Bruch3));
                        break;
                    case "4":
                        Bruch1.Zuweisung(Bruch2.Division(Bruch3));
                        break;
                    case "x":
                        running = false;
                        break;
                    default:
                        Console.WriteLine(" \"" + Eingabe + "\"" + "ist eine ungültige Eingabe! Bitte Wiederholen!");
                        Thread.Sleep(1500);
                        break;
                }
            }
            #endregion
        }
    }
}



