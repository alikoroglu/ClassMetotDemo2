using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {


            Console.WriteLine("Müşteri Eklendi");

        }
        public void Kaldır(Musteri musteri)
        {

            Console.WriteLine("Müşteri Kaldırıldı");

        }
        public void Listele(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Ad: " + musteri.isim + ", Soyad: " + musteri.soyisim + ", ID: " + musteri.ID);
            }
        }
    }
}
