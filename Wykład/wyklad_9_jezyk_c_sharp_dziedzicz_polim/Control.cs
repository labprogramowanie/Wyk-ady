using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    class Control
    {
        private int x;
        private int y;

        public Control(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual void Rysuj()
        {
            Console.Write("Rysowanie kontrolki o współrzędnych: ({0},{1}) typu ... ", x, y);
        }

        public override string ToString()
        {
            return String.Format("{0}-{1}", x, y);
        }
    }
}
