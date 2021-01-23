using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        //naming convention-isimlendirme kuralı
        //metodların isimlerinin ilk harfi büyük yazılır
       public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi+' '+musteri.Soyadi+' '+"sisteme eklendi.");
        }

        public void Güncelle(Musteri musteri2)
        {
            Console.WriteLine(musteri2.Adi+' '+musteri2.Soyadi+' '+"nun Tc kimlik numarası "+musteri2.tcNo+ " olarak değiştirilmiştir." );
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Id+"id'li müşteri hesabi silinmiştir.");
        }
    }
}
