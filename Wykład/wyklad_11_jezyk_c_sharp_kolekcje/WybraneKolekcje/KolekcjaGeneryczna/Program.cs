using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolekcjaGeneryczna
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ls = new List<string>();
            ls.Add("Ala");
            ls.Add("ma");
            ls.Add("kota");
            ls.Add("a");
            ls.Add("kot");
            ls.Add("ma");
            ls.Add("Alę");
            ls.Add("i");
            ls.Add("mleko");

            Program.Wypisz(ls);
            Console.WriteLine();

            ls.Sort();
            Program.Wypisz(ls);
            Console.WriteLine();

            ls.Reverse();
            Program.Wypisz(ls);
            Console.WriteLine();

            Console.WriteLine(ls[3]);
            Console.WriteLine();

            ls.RemoveAt(2);
            Program.Wypisz(ls);
            Console.WriteLine();

            ls.Insert(4, "NOWY");
            Program.Wypisz(ls);
            Console.WriteLine();

            //var str_a = ls.FindAll(x => x.StartsWith("A"));
            var str_a = ls.FindAll(x => x.Contains("a"));
            foreach (var v in str_a)
            {
                Console.Write("{0} ", v);
            }
            Console.WriteLine();
        }

        private static void Wypisz(List<string> ls)
        {
            foreach (string s in ls)
            {
                Console.Write("{0} ", s);
            }
            Console.WriteLine();
        }
    }
}
