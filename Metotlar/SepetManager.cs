using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi:" + urun.Adi);
        }

        
        //ekstra bir parametre girilmek istendiği zaman aşağıda eklenin yapacağı iş de değişir.
        //Parametre değistiğinde metodun geçtiği her yer değişmek zorunda kalır.
        //Bu yuzden bu metodu bu şekilde yazmak tavsiye edilmez...
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stok)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi : " + urunAdi);
        }
    }
}
