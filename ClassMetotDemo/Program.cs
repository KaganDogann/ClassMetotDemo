using System;


//Bir bankada müşteri takibi yapmak istiyorsunuz.
//Musteri isimli bir Class oluşturunuz. Müşteriye istediğiniz özellikleri ekleyiniz. (Id, Ad, Soyad....)
//MusteriManager sınıfı oluşturunuz. Musteri parametresi alarak Musteri ekleme, listeleme, silme gibi metotları simule ediniz.


namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 000001;
            musteri1.MusteriAdi = "Bekir";
            musteri1.MusteriSoyAdi = "DEMİR";
            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 000002;
            musteri2.MusteriAdi = "Ayça";
            musteri2.MusteriSoyAdi = "ERSOY";
            Musteri musteri3 = new Musteri();
            musteri3.MusteriId = 000003;
            musteri3.MusteriAdi = "Ayhan";
            musteri3.MusteriSoyAdi = "GÜLTEKİN";


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri3);

            Musteri[] Musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            musteriManager.Listele(Musteriler);
        }
    }
}
