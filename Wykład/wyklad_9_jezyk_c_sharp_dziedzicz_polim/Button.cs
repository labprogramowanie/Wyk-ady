using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    class Button : Control
    {
        private string napis;

        public Button(int x, int y, string napis) : base(x, y)
        {
            this.napis = napis;
        }

        public override void Rysuj()
        {
            base.Rysuj();
            Console.WriteLine("{0} o napisie: {1}", this.GetType().Name, napis);
        }

        public override string ToString()
        {
            return String.Format("{0}-{1}", base.ToString(), napis);
        }
    }
}
