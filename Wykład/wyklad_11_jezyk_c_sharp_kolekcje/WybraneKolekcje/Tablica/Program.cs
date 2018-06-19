using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablica
{
    class Pies
    {
        private string imie;
        private string rasa;
        private int wiek;
        public Pies(string imie, string rasa, int wiek)
        {
            this.imie = imie;
            this.rasa = rasa;
            this.wiek = wiek;
        }
        public void Wypisz()
        {
            Console.WriteLine("{0}, {1}, {2}", imie, rasa, wiek);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pies p1 = new Pies("Reksio", "kundel", 2);
            Pies p2 = new Pies("Szarik", "wilczur", 4);
            Pies p3 = new Pies("Lessie", "owczarek", 6);
            Pies[] psy = { p1, p2, p3 };
            for (int i = 0; i < psy.Length; i++)
            {
                psy[i].Wypisz();
            }
            Console.WriteLine();
            Pies[] nowe_psy = new Pies[] { p1, p2, p3, new Pies("Pluto", "rysunkowy", 8) };
            foreach (Pies p in nowe_psy)
            {
                p.Wypisz();
            }
            Console.WriteLine();

            Console.Write("Podaj długść tablicy: ");
            int n = int.Parse(Console.ReadLine());
            string[] lancuchy = new string[n];
            lancuchy[0] = "Ala";
            for (int i = 1; i < n; i++)
            {
                Console.Write("Podaj łańcuch: ");
                lancuchy[i] = Console.ReadLine();
            }

            Program.Wypisz(lancuchy);
            Program.Wypisz("Wykład", "z", "programowania", "w", "C#");
        }

        private static void Wypisz(params string[] lancuchy)
        {
            foreach (string s in lancuchy)
            {
                Console.Write("{0} ", s);
            }
            Console.WriteLine();
        }
    }
}
