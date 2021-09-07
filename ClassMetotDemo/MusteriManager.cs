using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri sistemimize kaydedildi.");
        }

        public void Sil(Musteri musteri)
        {

            Console.WriteLine("Müşteri sistemimizden silindi");
        }

        public void Listele(Musteri[] musteriler)
        {
            Console.WriteLine("---Sistemimize kayıtlı Müşteriler---");
            foreach (var musteri in musteriler)
            {
                
                Console.WriteLine("Müşteri ID:"+musteri.MusteriId+"  Müşteri Adı:"+musteri.MusteriAdi+"  Müşteri Soy Adı:"+musteri.MusteriSoyAdi);
            }

        }
    }
}
