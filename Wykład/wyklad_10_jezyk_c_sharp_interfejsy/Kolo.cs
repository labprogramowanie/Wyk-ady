using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakcja_Interfejsy_VS2015
{
    class Kolo : Figura, IComparable
    {
        private double promien;
        public double Promien
        {
            get { return promien; }
        }

        private string kolor;
        public string Kolor
        {
            get { return kolor; }
        }

        public Kolo(int x, int y, double promien, string kolor) : base(x, y)
        {
            this.promien = promien;
            this.kolor = kolor;
        }

        public override double ObliczObwod()
        {
            return 2 * Math.PI * promien;
        }

        public override double ObliczPole()
        {
            return Math.PI * promien * promien;
        }

        public override void WypiszObwod()
        {
            Console.WriteLine("Obwod koła wynosi: {0}", this.ObliczObwod());
        }

        public override void WypiszPole()
        {
            Console.WriteLine("Pole koła wynosi: {0}", this.ObliczPole());
        }

        public override string ToString()
        {
            return String.Format("{0}-{1}", promien, kolor);
        }

        public int CompareTo(object obj)
        {
            int rezultat;
            Kolo k = (Kolo)obj;
            rezultat = this.Promien.CompareTo(k.Promien);
            //rezultat = this.Kolor.CompareTo(k.Kolor);
            return rezultat;
        }

        public class PoPromieniu : IComparer
        {
            public int Compare(object x, object y)
            {
                Kolo k1 = (Kolo)x;
                Kolo k2 = (Kolo)y;
                return k1.promien.CompareTo(k2.promien);
            }
        }

        public class PoKolorze : IComparer
        {
            public int Compare(object x, object y)
            {
                Kolo k1 = (Kolo)x;
                Kolo k2 = (Kolo)y;
                int rezultat = k1.kolor.CompareTo(k2.kolor);
                return rezultat;
            }
        }
    }
}
