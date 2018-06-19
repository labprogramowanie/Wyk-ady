using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakcja_Interfejsy_VS2015
{
    class Trojkat : Figura
    {
        private double a, b, c;
        private double h;

        public Trojkat(int x, int y, double a, double b, double c, double h) : base(x, y)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.h = h;
        }

        public override double ObliczObwod()
        {
            return a + b + c;
        }

        public override double ObliczPole()
        {
            return a * h / 2;
        }

        public override void WypiszObwod()
        {
            Console.WriteLine("Obwod trojkata wynosi: {0}", this.ObliczObwod());
        }

        public override void WypiszPole()
        {
            Console.WriteLine("Pole trojkata wynosi: {0}", this.ObliczPole());
        }
    }
}
