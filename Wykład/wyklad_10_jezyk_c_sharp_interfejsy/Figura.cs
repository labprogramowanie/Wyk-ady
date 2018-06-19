using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakcja_Interfejsy_VS2015
{
    abstract class Figura : IWyznaczanieParametrow
    {
        private int x;
        private int y;

        public Figura(int x,int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public abstract double ObliczObwod();

        public abstract double ObliczPole();

        public abstract void WypiszObwod();

        public abstract void WypiszPole();
    }
}
