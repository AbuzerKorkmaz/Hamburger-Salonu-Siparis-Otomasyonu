using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerOdevi
{
    public class Siparis
    {
        public string MenuTipi { get; set; }
      public string EkMalzeme { get; set; }
        public string MenuBoyutu { get; set; }
        public int MenuAdeti { get; set; }
        public double Tutar { get; set; }
        public double Hesapla(Siparis siparis) 
        {
           
            double menuPrice;
            double ekMalzemefiyat;
            double boyFiyati;
            if (siparis.MenuTipi == "Big Mac Menu") menuPrice = 100;
            else  menuPrice = 80;

            if (EkMalzeme == "Ketçap" || EkMalzeme == "Mayonez") ekMalzemefiyat = 5;
            else ekMalzemefiyat = 10;
            
            if (MenuBoyutu =="Küçük") boyFiyati = menuPrice*1;
            else if (MenuBoyutu == "Orta") boyFiyati = menuPrice * 1.2;
            else  boyFiyati = menuPrice * 1.5;
            siparis.Tutar = (ekMalzemefiyat + boyFiyati) * MenuAdeti;
            return Tutar;
             }
        public  override string ToString()
        {
            return $"{MenuAdeti} adet {MenuTipi}, {MenuBoyutu}, {EkMalzeme}, => Toplam Fiyat : {Tutar}";
        }

    }
}
