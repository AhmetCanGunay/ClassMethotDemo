using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethotDemo
{
    class MusteriManager
    {
        public void MusteriSorgula(Musteri musteri)
        {
            Console.WriteLine("Ad:{0}\nSoyadı:{1}\nMüşteri No:{2}",musteri.MusteriAdi,musteri.MusteriSoyadi,musteri.MusteriNo);
        }
        public void MüsteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Başarıyla Eklendi! " + musteri.MusteriAdi+" "+musteri.MusteriSoyadi);
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müşteri({0}) Başarıyla Silinmiştir!",musteri.MusteriAdi);
        }
        
    }
}
