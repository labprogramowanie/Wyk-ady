using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasaGeneryczna
{
    class Stos<T> where T : struct
    {
        private int max;
        private int akt;
        private T[] elementy;

        public Stos(int max)
        {
            this.max = max;
            akt = 0;
            elementy = new T[max];
        }

        public void Wstaw(T elem)
        {
            if (akt < max)
            {
                elementy[akt] = elem;
                akt++;
            }
            else
            {
                Console.WriteLine("Brak miejsca na stosie.");
            }
        }

        public T Usun()
        {
            T usuwany = elementy[akt - 1];
            elementy[akt - 1] = default(T);
            akt--;
            return usuwany;
        }

        public void Wypisz()
        {
            for (int i = 0; i < akt; i++)
            {
                Console.WriteLine(elementy[i]);
            }
            Console.WriteLine("***********************");
            Console.WriteLine();           
        }

        public T this[int indeks]
        {
            get { return elementy[indeks]; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stos<char> sc = new Stos<char>(10);
            sc.Wstaw('s');
            sc.Wstaw('a');
            sc.Wstaw('x');
            sc.Wstaw('f');
            sc.Wstaw('y');
            sc.Wstaw('o');
            sc.Wstaw('p');
            sc.Wypisz();
            Console.WriteLine(sc.Usun());
            Console.WriteLine();
            sc.Wypisz();

            Stos<double> sd = new Stos<double>(8);
            sd.Wstaw(Math.PI);
            sd.Wstaw(Math.E);
            sd.Wstaw(123.3445);
            sd.Wypisz();

            Stos<int> si = new Stos<int>(6);
            si.Wstaw(12);
            si.Wstaw(565);
            si.Wstaw(0);
            si.Wstaw(98794);
            si.Wstaw(-912);
            Console.WriteLine(si[3]);
            Console.WriteLine();
            si.Wypisz();
        }
    }
}
