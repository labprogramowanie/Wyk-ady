using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy
{
    class Pies
    {
        private static int liczbaPsow;
        public static int LiczbaPsow
        {
            get { return liczbaPsow; }
        }

        private string imie;
        public string Imie
        {
            get { return imie; }
            set { imie = value; }
        }

        private string rasa;
        public string Rasa
        {
            get { return rasa; }
            set { rasa = value; }
        }

        private int wiek;
        public int Wiek
        {
            get { return wiek; }
            set { wiek = value; }
        }

        static Pies()
        {
            liczbaPsow = 0;
            Console.WriteLine("Wywołanie konstruktora statycznego w dniu: {0}-{1}-{2} o godz. {3}.{4}.{5}\n",
                DateTime.Now.Day,
                DateTime.Now.Month,
                DateTime.Now.Year,
                DateTime.Now.Hour,
                DateTime.Now.Minute,
                DateTime.Now.Second);
        }

        public Pies(string imie, string rasa, int wiek)
        {
            this.imie = imie;
            this.rasa = rasa;
            this.wiek = wiek;
            liczbaPsow++;
        }

        public Pies(string imie, string rasa)
        {
            this.imie = imie;
            this.rasa = rasa;
            this.wiek = 10;
            liczbaPsow++;
        }

        public Pies() : this("Szarik", "Wilczur")
        {
            Console.WriteLine("Konstruktor domyślny.");
            //liczbaPsow++;
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
            Console.WriteLine("Liczba psów = {0}", Pies.LiczbaPsow);
            Pies p1 = new Pies("Reksio", "kundel", 10);
            p1.Wypisz(); //this odnosi się do p1
            Console.WriteLine("Liczba psów = {0}", Pies.LiczbaPsow);
            Console.WriteLine();

            Pies p2 = new Pies("Pluto", "rysunkowy");
            p2.Wypisz(); //this odnosi się do p2
            Console.WriteLine("Liczba psów = {0}", Pies.LiczbaPsow);
            Console.WriteLine();

            Pies p3 = new Pies();
            p3.Wypisz(); //this odnosi się do p3
            Console.WriteLine("Liczba psów = {0}", Pies.LiczbaPsow);
            Console.WriteLine();

            Console.WriteLine();

            Console.Write("Podaj nowe imie dla p2: ");
            p2.Imie = Console.ReadLine(); //akcesor set
            p2.Rasa = "Pekińczyk"; //akcesor set
            Console.WriteLine();
            Console.WriteLine("Imie p2: {0}", p2.Imie); //akcesor get
            Console.WriteLine("Rasa p2: {0}", p2.Rasa); //akcesor get
            Console.WriteLine();

            p1.Wypisz();
            Program.ZmienDanePsa(p1);
            p1.Wypisz();

            int i = 1;
            char j = 'a';
            string k = "programowanie";
            Console.WriteLine("i = {0}, j = {1}, k = {2}", i, j, k);
            Console.WriteLine();

            Program.PrzesylaniePrzezWartosc(i, j, k);
            Console.WriteLine("i = {0}, j = {1}, k = {2}", i, j, k);
            Console.WriteLine();

            Program.PrzesylaniePrzezReferencje(ref i, ref j, ref k);
            Console.WriteLine("i = {0}, j = {1}, k = {2}", i, j, k);
            Console.WriteLine();

            int x;
            char y;
            string z;
            Program.PrzesylaniePrzezRefOut(out x, out y, out z);
            Console.WriteLine("x = {0}, y = {1}, z = {2}", x, y, z);
            Console.WriteLine();
        }

        private static void PrzesylaniePrzezRefOut(out int x, out char y, out string z)
        {
            x = 123;
            y = 's';
            z = "wykład";
        }

        private static void PrzesylaniePrzezReferencje(ref int i, ref char j, ref string k)
        {
            i = -5;
            j = 'X';
            k = "inny";
        }

        private static void PrzesylaniePrzezWartosc(int i, char j, string k)
        {
            i = -5;
            j = 'X';
            k = "inny";
        }

        private static void ZmienDanePsa(Pies p1)
        {
            p1.Imie = "Nowy";
            p1.Rasa = "jakaś";
            p1.Wiek = -5;
        }
    }
}
