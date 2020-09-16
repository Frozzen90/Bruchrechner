//Autor:        Sebastian Schmitz
//Datei:        eingabeAbfrage.cs
//Datum:        03.09.2020
//Klasse:       IA119
//Beschreibung: 
//Aenderungen:  

using System;

namespace KlasseModellieren
{
    partial class main
    {
        public static string eingabeAbfrage()
        {
            string Eingabe = "";
            Console.Clear();
            Console.WriteLine("Bitte wählen Sie die auszuführende Rechenoperation aus!");
            Console.WriteLine(" 1: Addition" + Environment.NewLine +
                                " 2: Subtraktion" + Environment.NewLine +
                                " 3: Multiplikation" + Environment.NewLine +
                                " 4: Division" + Environment.NewLine +
                                " x: Beenden");
            Eingabe = Console.ReadLine().ToLower();
            return Eingabe;
        }
    }
}

