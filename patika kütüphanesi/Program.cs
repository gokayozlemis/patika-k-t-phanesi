using System;

namespace Kutuphane
{
    class Kitap
    {
        public string Ad { get; set; }
        public string YazarAdi { get; set; }
        public string YazarSoyadi { get; set; }
        public int SayfaSayisi { get; set; }
        public string Yayinevi { get; set; }
        public DateTime KayitTarihi { get; set; }

        public Kitap()
        {
            Ad = "Adı Aylin";
            YazarAdi = "Ayşe";
            YazarSoyadi = "Kulin";
            SayfaSayisi = 398;
            Yayinevi = "Remzi Kitapevi";
            KayitTarihi = DateTime.Now; 
        }
        // parametreli constructor 
        public Kitap(string ad, string yazarAdi, string yazarSoyadi, int sayfaSayisi, string yayinevi)
        {
            Ad = ad;
            YazarAdi = yazarAdi;
            YazarSoyadi = yazarSoyadi;
            SayfaSayisi = sayfaSayisi;
            Yayinevi = yayinevi;
            KayitTarihi = DateTime.Now; 
        }
        // bilgi yazdırma 
        public void BilgiYazdir()
        {
            Console.WriteLine($"Ad: {Ad}, Yazar: {YazarAdi} {YazarSoyadi}, Sayfa Sayısı: {SayfaSayisi}, Yayınevi: {Yayinevi}, Kayıt Tarihi: {KayitTarihi}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // default constructor ile nesne
            Kitap varsayilanKitap = new Kitap();
            varsayilanKitap.BilgiYazdir();

            // parametreli constructor ile nesne 
            Kitap adiAylin = new Kitap("Adı Aylin", "Ayşe", "Kulin", 398, "Remzi Kitabevi");
            adiAylin.BilgiYazdir();
        }
    }
}
 