using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablice
{
    static class Konsola
    {
        public static void WypiszPsy(params Pies[] psy)
        {
            foreach (Pies p in psy)
            {
                p.Wypisz();
            }
        }

        public static void WypiszLancuchy(params string[] lancuchy)
        {
            int i = 0;
            while (i < lancuchy.Length)
            {
                Console.Write("{0} ", lancuchy[i]);
                i++;
            }
        }
    }
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
            p1.Wypisz();
            Pies p2 = new Pies("Pluto", "pekińczyk", 5);
            Pies p3 = new Pies("Szarik", "owczarek", 7);

            Pies[] psy = { p1, p2, p3 };
            Pies[] psy1 = new Pies[3] { p1, p2, p3 };
            int i;
            for (i = 0; i < psy.Length; i++)
            {
                psy[i].Wypisz();
            }

            Konsola.WypiszPsy(psy);
            Console.WriteLine();
            Konsola.WypiszPsy(p1, p3);
            Console.WriteLine();

            Console.Write("Podaj liczbę elementów: ");
            int n = int.Parse(Console.ReadLine());

            string[] lancuchy = new string[n];
            lancuchy[0] = "Ala";
            i = 1;
            do
            {
                Console.Write("Podaj łańcuch: ");
                lancuchy[i] = Console.ReadLine();
                i++;
            }
            while (i < n);
            Konsola.WypiszLancuchy(lancuchy);
            Console.WriteLine();
            Konsola.WypiszLancuchy("Programowanie", "w", "j.", "C#");
            Console.WriteLine();

            foreach (string s in lancuchy)
            {
                Console.WriteLine(s);
            }

            Object[] elementy = { 1, Math.PI, lancuchy[1], p1, 'a' };
            i = 0;
            while (i < elementy.Length)
            {
                Console.WriteLine(elementy[i]);
                i++;
            }
        }
    }
}