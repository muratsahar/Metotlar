using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete eklendi --> " + urun.Adi);
        }
        public void Ekle2(string ad,string aciklama,int fiyat,int stokAdedi)
        {
            Console.WriteLine("Sepete eklendi --> " + ad+" "+aciklama+" "+ fiyat.ToString());
        }
    }
}
