using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerOdevi
{
    internal class Siparis
    {
        public string MenuTipi { get; set; }
      public string EkMalzeme { get; set; }
        public string MenuBoyutu { get; set; }
        public int MenuAdeti { get; set; }
        public double Hesapla() 
        { return 100; }
        public override string ToString()
        {
            return $"{MenuAdeti} adet {MenuTipi}, {MenuBoyutu}, {EkMalzeme}, => Toplam Fiyat : {Hesapla()}";
        }

    }
}
