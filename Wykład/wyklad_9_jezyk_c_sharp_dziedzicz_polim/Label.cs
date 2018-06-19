using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    class Label : Control
    {
        private string etykieta;

        public Label(int x, int y, string etykieta) : base(x, y)
        {
            this.etykieta = etykieta;
        }

        public override void Rysuj()
        {
            base.Rysuj();
            Console.WriteLine("{0} o etykiecie: {1}", this.GetType().Name, etykieta);
        }

        public override string ToString()
        {
            return String.Format("{0}-{1}", base.ToString(), etykieta);
        }
    }
}
