using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(MusteriBilgi musteri)
        {
            Console.WriteLine(musteri.MusteriAdi+" Adlı Müşteri Eklendi. ");

        }


        public void Cikar(MusteriBilgi musteri)
        {
            Console.WriteLine(musteri.MusteriAdi +" Adlı Müşteri Çıkarıldı.");
        }

    }
}
