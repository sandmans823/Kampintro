﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    //operasyon tutuyor(manager..)
    class SepetManager
    {
        //naming convention-isimlendirme kuralı(Ekle)
        // () işareti varsa bir metotu işaret eder
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler, Sepete Eklendi! : " +  urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int StokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + urunAdi);
        }
    }
}
