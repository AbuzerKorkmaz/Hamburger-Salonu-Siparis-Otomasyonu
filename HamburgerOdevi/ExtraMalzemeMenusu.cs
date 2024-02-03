using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerOdevi
{
    public class EkstraMalzemeMenusu
    {
        public string MalzemeIsmi { get; set; }
        public double  Fiyat { get; set; }
        public override string ToString()
        {
            return $"{MalzemeIsmi} {Fiyat}";
        }

    }
}
