using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakcja_Interfejsy_VS2015
{
    class Program
    {
        static void Main(string[] args)
        {
            //Figura f = null;
            //f = new Kolo(1, 1, 3, "zielony");
            //IWyznaczanieParametrow iwp;
            //if (f is IWyznaczanieParametrow)
            //{
            //    iwp = f;
            //    Operacje(iwp);
            //}
            //Console.WriteLine();
            //f = new Trojkat(2, 2, 4, 5, 6, 3);
            //iwp = f as IWyznaczanieParametrow;
            //if (iwp != null)
            //{
            //    Operacje(iwp);
            //    Console.WriteLine();
            //    Operacje(f);
            //}
            //Console.WriteLine();

            Kolo k0 = new Kolo(0, 0, 4, "biały");
            //if (k0 is IWyznaczanieParametrow)
            //{
            //    iwp = k0;
            //    Operacje(iwp);
            //    Console.WriteLine();
            //    Operacje(k0);
            //}
            //Console.WriteLine();
            //iwp = new Trojkat(9, 9, 4, 5, 6, 7);
            //Operacje(iwp);

            //Console.WriteLine();

            Kolo k1 = new Kolo(1, 1, 2, "żółty");
            Kolo k2 = new Kolo(2, 2, 3, "zielony");
            Kolo k3 = new Kolo(3, 3, 4, "czerwony");
            Kolo k4 = new Kolo(4, 4, 5, "czarny");
            Kolo k5 = new Kolo(5, 5, 6, "niebieski");

            ArrayList al = new ArrayList();
            al.Add(k0);
            al.Add(k1);
            al.Add(k2);
            al.Add(k3);
            al.Add(k4);
            al.Add(k5);
            Console.WriteLine("Przed sortowaniem:");
            foreach (Kolo k in al)
            {
                Console.WriteLine(k);
            }
            //al.Sort();
            //Console.WriteLine();
            //Console.WriteLine("Po sortowaniu:");
            //foreach (Kolo k in al)
            //{
            //    Console.WriteLine(k);
            //}

            IComparer ic = new Kolo.PoKolorze();
            al.Sort(ic);
            Console.WriteLine();
            Console.WriteLine("Po sortowaniu:");
            foreach (Kolo k in al)
            {
                Console.WriteLine(k);
            }

            ic = new Kolo.PoPromieniu();           
            al.Sort(ic);
            Console.WriteLine();
            Console.WriteLine("Po sortowaniu:");
            foreach (Kolo k in al)
            {
                Console.WriteLine(k);
            }
        }

        private static void Operacje(IWyznaczanieParametrow iwz)
        {
            iwz.WypiszObwod();
            iwz.WypiszPole();
        }
    }
}
