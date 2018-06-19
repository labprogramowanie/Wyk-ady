using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            Control c = new Control(12, 34);
            c.Rysuj();
            Console.WriteLine();
            Console.WriteLine();
            Label l = new Label(45, 56, "Nazwisko");
            l.Rysuj();
            Console.WriteLine();
            Button b = new Button(67, 78, "Zapisz");
            b.Rysuj();
            Console.WriteLine();
            ListBox lb = new ListBox(78, 98, "zielony", "czerwony", "żółty", "niebieski");
            lb.Rysuj();
            Console.WriteLine();
            Console.WriteLine();

            Control ctr = null;
            Console.Write("Podaj wybór: ");
            char wybor = char.Parse(Console.ReadLine());
            switch(wybor)
            {
                case 'l':
                    {
                        ctr = new Label(12, 34, "Imię");
                        break;
                    }
                case 'b':
                    {
                        ctr = new Button(45, 57, "Otwórz");
                        break;
                    }
                case 'x':
                    {
                        ctr = new ListBox(67, 78, "Programowanie", "w", "języku", "C#");
                        break;
                    }
                default:
                    {
                        ctr = new Control(0, 0);
                        break;
                    }
            }
            ctr.Rysuj();

            Console.WriteLine();
            if (ctr is Label)
            {
                //Console.WriteLine(ctr.ToString());
                Console.WriteLine(ctr);
            }
            if(ctr is ListBox)
            {
                //
            }
        }
    }
}
