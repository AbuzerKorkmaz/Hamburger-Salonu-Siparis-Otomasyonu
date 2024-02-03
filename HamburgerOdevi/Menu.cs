using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerOdevi
{
     public class Menu
    {
        public string MenuIsmi  { get; set; }
        public double Fiyat { get; set; }

        public override string ToString()
        {
            return $"{MenuIsmi}";
        }

    }
}
