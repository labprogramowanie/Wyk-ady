using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolekcjaArrayList
{
    class Osoba
    {
        private string nazwisko;
        public Osoba(string nazwisko)
        {
            this.nazwisko = nazwisko;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(Math.E);
            al.Add("Ala ma kota");
            al.Add('a');
            al.Add(-123);
            al.Insert(3, Math.PI);
            al.Add(new Osoba("Kowalski"));
            Program.Wypisz(al);
            al.Reverse();
            Program.Wypisz(al);
            Console.WriteLine(al[2]);
            Console.WriteLine();
            al[2] = "nowy";
            al.RemoveRange(2, 2);
            Program.Wypisz(al);
            al.Sort();
        }

        private static void Wypisz(ArrayList al)
        {
            foreach(Object o in al)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine("****************");
            Console.WriteLine();
        }
    }
}
