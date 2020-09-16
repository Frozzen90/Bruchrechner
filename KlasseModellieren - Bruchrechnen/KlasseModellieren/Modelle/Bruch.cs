//Autor:        Sebastian Schmitz
//Datei:        Bruch.cs
//Datum:        31.08.2020
//Klasse:       IA119
//Beschreibung: 
//Aenderungen:  03.09.2020

namespace KlasseModellieren
{
    public class Bruch
    {
        #region <Eigenschaften>
        private int _zaehler;
        private int _nenner;
        #endregion

        #region <Accessoren/Modifier>
        private int Zaehler { get => _zaehler; set => _zaehler = value; }
        private int Nenner { get => _nenner; set => _nenner = value; }
        #endregion

        #region <Konstruktoren>
        public Bruch()
        {
            Zaehler = 1;
            Nenner = 1;
        }

        public Bruch(int zaehler, int nenner)
        {
            this.Zaehler = zaehler;
            this.Nenner = nenner;
        }
        #endregion

        #region <Worker>
        public Bruch Addition(Bruch value)
        {
            Bruch ergebnis = new Bruch();

            ergebnis.Zaehler = this.Zaehler * value.Nenner + value.Zaehler * this.Nenner;
            ergebnis.Nenner = this.Nenner * value.Nenner;

            return ergebnis.Kuerzen();
        }

        public Bruch Subtraktion(Bruch value)
        {
            Bruch ergebnis = new Bruch();

            ergebnis.Zaehler = this.Zaehler * value.Nenner - value.Zaehler * this.Nenner;
            ergebnis.Nenner = this.Nenner * value.Nenner;

            return ergebnis.Kuerzen();
        }

        public Bruch Multiplikation(Bruch value)
        {
            Bruch ergebnis = new Bruch();

            ergebnis.Zaehler = this.Zaehler * value.Zaehler;
            ergebnis.Nenner = this.Nenner * value.Nenner;

            return ergebnis.Kuerzen();
        }

        public Bruch Division(Bruch value)
        {
            Bruch ergebnis = new Bruch();

            ergebnis.Zaehler = this.Zaehler * value.Nenner;
            ergebnis.Nenner = this.Nenner * value.Zaehler;

            return ergebnis.Kuerzen();
        }

        private Bruch Kuerzen()
        {
            if (this.Zaehler != 0)
            {
                int rest;
                int ggt = this.Zaehler;
                int divisor = this.Nenner;
                do
                {
                    rest = ggt % divisor;
                    ggt = divisor;
                    divisor = rest;
                } while (rest > 0);
                this.Zaehler = this.Zaehler / ggt;
                this.Nenner = this.Nenner / ggt;
            }
            return this;
        }

        public Bruch Zuweisung(Bruch value)
        {
            Bruch ergebnis = new Bruch();

            this.Zaehler = ergebnis.Zaehler = value.Zaehler;
            this.Nenner = ergebnis.Nenner = value.Nenner;

            return ergebnis;
        }
        #endregion
    }
}



