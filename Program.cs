using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GerçekMusteri musteri1 = new GerçekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.MusteriAdi = "ZEYNEP";
            musteri1.MusteriSoyadi="KARAKUŞ";
            musteri1.TcNo = "12345678912";


            //Kodlama.oi
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.oi";
            musteri2.VergiNo = "123456789";


            //iki nesne var gerçek müşteri/ tüzel müşreti


            Musteri musteri3 = new GerçekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Ekle(musteri3);
            customerManager.Ekle(musteri4);


        }
    }
}
