using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolekcjaArray
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] tablica = { 'd', 'e', 'q', 'w', 's', 'a', 'x', 'z' };
            Program.Wypisz(tablica);
            Array.Sort(tablica);
            Program.Wypisz(tablica);
            Array.Reverse(tablica);
            Program.Wypisz(tablica);
            Array.Clear(tablica, 2, 2);
            Program.Wypisz(tablica);
            Array nowa = Array.CreateInstance(typeof(char), 3);
            Array.Copy(tablica, nowa, 2);
            Program.Wypisz(nowa);
        }

        public static void Wypisz(Array a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0} ", a.GetValue(i));
            }
            Console.WriteLine();
        }
    }
}
