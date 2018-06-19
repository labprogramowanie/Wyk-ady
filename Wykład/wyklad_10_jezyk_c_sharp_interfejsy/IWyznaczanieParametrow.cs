using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakcja_Interfejsy_VS2015
{
    interface IObliczanieParametrow
    {
        double ObliczPole();
        double ObliczObwod();
    }

    interface IWypisywanieParametrow
    {
        void WypiszPole();
        void WypiszObwod();
    }

    interface IWyznaczanieParametrow : IObliczanieParametrow, IWypisywanieParametrow
    {
        int X { get; set; }
        int Y { get; set; }
    }
}
