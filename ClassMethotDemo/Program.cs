using System;

namespace ClassMethotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.MusteriAdi = "Ömer";
            musteri1.MusteriSoyadi = "PARLAK";
            musteri1.MusteriNo = "1234567";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.MusteriAdi = "Ahmet Can";
            musteri2.MusteriSoyadi = "GÜNAY";
            musteri2.MusteriNo = "7654321";

            Musteri[] MusteriList = new Musteri[] { musteri1, musteri2 };
            MusteriManager customer = new MusteriManager();
            Console.WriteLine("Bankamıza Hoşgeldiniz Sayın {0}",musteri1.MusteriAdi+" "+musteri1.MusteriSoyadi);
            Console.WriteLine("Lütfen Aşağıdaki İşlemlerden Birini Seçiniz:\n1)Müşteri Sorgula\n2)Müşteri Ekle\n3)Müşteri Sil");
            int Islem=Convert.ToInt32(Console.ReadLine());
            if (Islem==1)
            {
                customer.MusteriSorgula(musteri1);
            }
            else if (Islem==2)
            {
                customer.MüsteriEkle(musteri1);
            }
            else
            {
                customer.MusteriSil(musteri1);
            }
        }
    }
    class Musteri
    {
        public int Id { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriSoyadi { get; set; }
        public string MusteriNo { get; set; }

    }
}
