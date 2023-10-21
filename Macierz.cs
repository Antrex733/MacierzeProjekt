using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Macierze
{
    internal class Macierz 
    {
        float[,] macierz;
        public Macierz(ushort LiczbaWierszy, ushort LiczbaKolumn)
        {
            macierz = new float[LiczbaWierszy, LiczbaKolumn];
        }

        public ushort LiczbaWierszy
        {
            get { return (ushort)macierz.GetLength(0); }
        }

        public ushort LiczbaKolumn
        {
            get { return (ushort)macierz.GetLength(1); }
        }

        public float this[ushort NrWierszy, ushort NrKolumn]
        {
            set
            {
                macierz[NrWierszy, NrKolumn] = value;
            }
            get { return macierz[NrWierszy, NrKolumn]; }       
        }

        //deklaracje metod i przeciążeń operatorów arytmetycznych: +, *, -, ...

        //przeciążenie operatora '+'
        public static Macierz operator +(Macierz a, Macierz b)
        {
            if (a.LiczbaWierszy != b.LiczbaWierszy || a.LiczbaKolumn != b.LiczbaKolumn)
            {
                throw new Exception("ERROR: wymiary macierzy nie są takie same");
            }
            Macierz c = new Macierz(a.LiczbaWierszy, a.LiczbaKolumn);

            for (ushort i = 0; i < a.LiczbaWierszy; i++)
                for (ushort j = 0; j < a.LiczbaKolumn; j++)
                    c.macierz[i, j] = a.macierz[i, j] + b.macierz[i, j];

            return c;
        }

        //przeciążenie operatora '-'
        public static Macierz operator -(Macierz a, Macierz b)
        {
            if (a.LiczbaWierszy != b.LiczbaWierszy || a.LiczbaKolumn != b.LiczbaKolumn)
            {
                throw new Exception("ERROR: wymiary macierzy nie są takie same");
            }
            Macierz c = new Macierz(a.LiczbaWierszy, a.LiczbaKolumn);

            for (ushort i = 0; i < a.LiczbaWierszy; i++)
                for (ushort j = 0; j < a.LiczbaKolumn; j++)
                    c.macierz[i, j] = a.macierz[i, j] - b.macierz[i, j];

            return c;
        }
        public static Macierz operator *(Macierz a, Macierz b)
        {
            //sprawdzenie warunku dla wykonalności mnożenia macierzy
            if (a.LiczbaKolumn != b.LiczbaWierszy)
            {
                //sygnalizacja błędu-sygnalizacja wyjątku
                throw new System.ArgumentException("ERROR: nie zgodność rozmiarów macierzy");
            }
            Macierz C = new Macierz(a.LiczbaWierszy, b.LiczbaKolumn);
            //wykonujemy mnożenie
            for (ushort i = 0; i < a.LiczbaWierszy; i++)
                for (ushort j = 0; j < b.LiczbaKolumn; j++)
                {
                    C.macierz[i, j] = 0.0f;
                    //oblliczenie sumy iloczynów
                    for (ushort k = 0; k < b.LiczbaWierszy; k++)
                        C.macierz[i, j] += a.macierz[i, k] * b.macierz[k, j];
                }
            //zwrotne zwrócenie wyniku
            return C;
        }

        
        //przeciążenie operatora '=='

        //przeciążenie operatora '!='
    }
    
}
