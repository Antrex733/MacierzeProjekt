using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macierze
{
    public class Zespolona
    {
        public double czRzeczywista, czUrojona;

        public Zespolona(double czRzecz, double czUr)
        {
            czRzeczywista = czRzecz;
            czUrojona = czUr;
        }

        public string WyswietlWynik(Zespolona wynik)
        {
            string napis="";

            if (wynik.czUrojona == 0)
            {
                napis = "";
            }else
            {
                napis += $"{wynik.czUrojona}i";
            }

            if (wynik.czRzeczywista < 0 )
            {
                napis += $" {wynik.czRzeczywista}";
            }else if(wynik.czRzeczywista > 0)
            {
                napis += $" + {wynik.czRzeczywista}";
            }

            return napis;
        }
        public static Zespolona operator + (Zespolona X, Zespolona Y)
        {
            Zespolona wynik = new Zespolona(X.czRzeczywista + Y.czRzeczywista, X.czUrojona + Y.czUrojona);
            return wynik;
        }
        public static Zespolona operator -(Zespolona X, Zespolona Y)
        {
            Zespolona wynik = new Zespolona(X.czRzeczywista - Y.czRzeczywista, X.czUrojona - Y.czUrojona);
            return wynik;
        }
        public static Zespolona operator *(Zespolona X, Zespolona Y)
        {
            double IloczynCzUr = 1;
            if (X.czUrojona>0 && Y.czUrojona >0)
            {
                IloczynCzUr = -1;
            }
            Zespolona wynik = new Zespolona(X.czRzeczywista * Y.czRzeczywista,
                X.czUrojona * Y.czUrojona * IloczynCzUr 
                + X.czUrojona * Y.czRzeczywista + Y.czUrojona * X.czRzeczywista);

            return wynik;
        }
        public static Zespolona operator /(Zespolona X, Zespolona Y)
        {
            //Do zrobienia
            double IloczynCzUr = 1;
            if (X.czUrojona > 0 && Y.czUrojona > 0)
            {
                IloczynCzUr = -1;
            }
            Zespolona wynik = new Zespolona(X.czRzeczywista * Y.czRzeczywista,
                X.czUrojona * Y.czUrojona * IloczynCzUr
                + X.czUrojona * Y.czRzeczywista + Y.czUrojona * X.czRzeczywista);

            return wynik;
        }

    }
}
