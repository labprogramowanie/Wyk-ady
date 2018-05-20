using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podstawy_C_Sharp
{
    enum DniPracy
    {
        pon, wto, sro, czw = 100, pia
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę: ");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("i = {0}", i);

            Console.Write("Podaj znak: ");
            char c = char.Parse(Console.ReadLine());
            Console.WriteLine("c = {0}", c);

            Console.Write("Podaj łańcuch: ");
            string s = Console.ReadLine();
            Console.WriteLine("s = {0}", s);

            var ii = 2;
            var jj = Math.E;
            var kk = "Ala ma kota";
            Console.WriteLine("ii = {1}, jj = {2}, kk = {0}", ii, jj, kk);

            DniPracy dzien;
            Console.Write("Podaj dzień: ");
            string d = Console.ReadLine();
            switch(d)
            {
                case "pon":
                    {
                        dzien = DniPracy.pon;
                        Console.WriteLine(dzien);
                        break;
                    }
                case "wto":
                case "sro":
                    {
                        dzien = DniPracy.sro;
                        Console.WriteLine(dzien.ToString());
                        break;
                    }
                case "pia":
                    {
                        dzien = DniPracy.pia;
                        Console.WriteLine((int)dzien);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            string[] tablica = { "Ala", "ma", "kota" };
            WypiszTablice(tablica);

        }

        static void WypiszTablice(string[] tablica)
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.WriteLine(tablica[i]);
            }
            Console.WriteLine();
            foreach(string str in tablica)
            {
                Console.WriteLine(str);
            }
        }
    }
}
