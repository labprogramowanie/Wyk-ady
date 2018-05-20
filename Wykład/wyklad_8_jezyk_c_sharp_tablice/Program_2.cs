using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolekcjaTablica
{
    class TablicaLancuchow
    {
        private int max;
        public int Max
        {
            get { return max; }
        }

        private int licznik;
        public int Licznik
        {
            get { return licznik; }
        }

        private string[] elementy;

        public TablicaLancuchow(int max)
        {
            this.max = max;
            this.licznik = 0;
            elementy = new string[max];
        }

        public void Dodaj(string s)
        {
            if (licznik < max)
            {
                elementy[licznik] = s;
                licznik++;
            }
            else
            {
                //Powieksz(10);
                Console.WriteLine("Brak miejsca w tablicy.");
            }
        }

        public void Dodaj(string s, int indeks)
        {
            if (licznik < max && indeks <= licznik)
            {
                for (int i = licznik; i > indeks; i--)
                {
                    elementy[i] = elementy[i - 1];
                }
                elementy[indeks] = s;
                licznik++;
            }
            else
            {
                //Powieksz(10);
                Console.WriteLine("Brak miejsca w tablicy.");
            }
        }

        public int Znajdz(string s)
        {
            int i = 0;
            while (i < licznik)
            {
                if (elementy[i] == s)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }
        public void Wypisz()
        {
            int i = 0;
            do
            {
                Console.WriteLine(elementy[i]);
                i++;
            }
            while (i < licznik);
        }

        public string this[int indeks]
        {
            get { return elementy[indeks]; }
            set { elementy[indeks] = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TablicaLancuchow tl = new TablicaLancuchow(10);
            Console.WriteLine("Akt. liczba elementów: {0}", tl.Licznik);
            Console.WriteLine("Maks. liczba elementów: {0}", tl.Max);
            tl.Dodaj("Ala");
            tl.Dodaj("ma");
            tl.Dodaj("kota");
            tl.Dodaj("i psa", 3);
            tl.Dodaj("a");
            Console.WriteLine("Akt. liczba elementów: {0}", tl.Licznik);
            tl.Dodaj("kot");
            tl.Dodaj("ma");
            tl.Dodaj("Alę");
            tl.Wypisz();
            Console.WriteLine();
            tl[3] = "i konia";
            tl.Wypisz();
            Console.WriteLine();
            Console.WriteLine(tl[6]);
            int ind = tl.Znajdz("ma");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(ind);
        }
    }
}
