using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    class ListBox : Control
    {
        private string[] elementy;

        public ListBox(int x, int y, params string[] elementy) : base(x, y)
        {
            this.elementy = new string[elementy.Length];
            for (int i = 0; i < elementy.Length; i++)
            {
                this.elementy[i] = elementy[i];
            }
        }

        public override void Rysuj()
        {
            base.Rysuj();
            Console.WriteLine("{0} o elementach:", this.GetType().Name);
            foreach (string s in elementy)
            {
                Console.WriteLine(" - {0}", s);
            }
        }
    }
}
