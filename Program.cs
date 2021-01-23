using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.Id = 1;
            musteri.Adi = "Deniz";
            musteri.Soyadi = "Kırıtoğlu";
            musteri.musteriNo = "453658";
            musteri.subeKod = 012;
            musteri.tcNo = "11111111111";
            musteri.iletisimBilgileri = "5356392358";
            musteri.islemiYapan = "Ayşe Yılmaz";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Eren";
            musteri2.Soyadi = "Kırıtoğlu";
            musteri2.musteriNo = "455856";
            musteri2.subeKod = 012;
            musteri2.tcNo = "222222222222";
            musteri2.iletisimBilgileri = "5356699358";
            musteri2.islemiYapan = "Fatma Öztürk";
            //instance-örnek
            //MusteriManager sınıfının örneğini oluşturduk
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri);
            musteriManager.Sil(musteri);
            musteriManager.Güncelle(musteri2);
        }
    }
}
