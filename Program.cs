using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriBilgi musteri1 = new MusteriBilgi();
            musteri1.MusteriAdi = "Ahmet Şen";
            musteri1.MusteriID = 0;
            musteri1.MusteriTel = 123;
            musteri1.MusteriBakiye = 2100.99;

            MusteriBilgi musteri2 = new MusteriBilgi();
            musteri2.MusteriAdi = "İbrahim Halil Acar";
            musteri2.MusteriID = 1;
            musteri2.MusteriTel = 124;
            musteri2.MusteriBakiye = 4380.75;

            MusteriBilgi musteri3 = new MusteriBilgi();
            musteri3.MusteriAdi = "Gülsüm İnan Acar";
            musteri3.MusteriID = 2;
            musteri3.MusteriTel = 125;
            musteri3.MusteriBakiye = 2389.76;

            MusteriBilgi[] musteriler = new MusteriBilgi[] {musteri1,musteri2,musteri3 };

            foreach (MusteriBilgi musteri in musteriler)
            {
                Console.WriteLine("Müşterinin Adı: "+ musteri.MusteriAdi);
                Console.WriteLine("Müşteri ID: "+musteri.MusteriID);
                Console.WriteLine("Müşteri Telefon Numarası: "+musteri.MusteriTel);
                Console.WriteLine("Müşteri Bakiye: "+musteri.MusteriBakiye);
                Console.WriteLine();
                Console.WriteLine("---------------");
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Cikar(musteri1);

        }
    }
}
