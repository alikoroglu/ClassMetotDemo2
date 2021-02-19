using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.isim = "Ali";
            musteri1.soyisim = "Veli";
            musteri1.ID = "00001";

            MusteriManager manager = new MusteriManager();

            manager.Ekle(musteri1);
            manager.Kaldır(musteri1);

            Musteri[] musteriler = new Musteri[] { musteri1 };
            manager.Listele(musteriler);
        }
    }
}
