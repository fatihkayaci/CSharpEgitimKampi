using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            // Müşteri listesini yazdıran metot
            //void MusteriListesi()
            //{
            //    Console.WriteLine("1. Ali Yıldız");
            //    Console.WriteLine("2. Ayşe Yıldız");
            //    Console.WriteLine("3. Hakan Öztürk");
            //    Console.WriteLine("4. Merve Çınar");
            //}

            //// Metodu birkaç kez çağırma
            //MusteriListesi();
            //MusteriListesi();
            //MusteriListesi();
            //MusteriListesi();

            //// Toplama işlemi yapan metot
            //void Topla()
            //{
            //    int x = 1, y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //// Metodu çağırma
            //Topla();

            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //// Müşteri ismini yazdıran metot
            //void YazMetodu(string musteriAdi)
            //{
            //    Console.WriteLine(musteriAdi);
            //}

            //// Metodu çağırma
            //YazMetodu("Mehmet Yıldırım");

            //// Müşteri kart bilgisi yazdıran metot
            //void MusteriKart(string isim, string soyisim)
            //{
            //    Console.WriteLine("Müşteri: " + isim + " " + soyisim);
            //}

            //// Metodu çağırma
            //MusteriKart("Mehmet", "Yıldız");
            //MusteriKart("Ayşegül", "Kaya");

            //#endregion

            //#region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //// Üç sayıyı toplayan metot
            //void Topla(int sayi1, int sayi2, int sayi3)
            //{
            //    int sonuc = sayi1 + sayi2 + sayi3;
            //    Console.WriteLine(sonuc);
            //}

            //// Metodu çağırma
            //Topla(4, 5, 6);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //// Müşteri adını döndüren metot
            //string MusteriAdi()
            //{
            //    return "Buse Yıldız";
            //}

            //// Metodu çağırma ve sonucu yazdırma
            //Console.WriteLine(MusteriAdi());

            //// Öğrenci kart bilgisi döndüren metot
            //string OgrenciKart()
            //{
            //    string ad = "Ali";
            //    string soyad = "Kaya";

            //    return ad + " " + soyad;
            //}

            //// Metodu çağırma ve sonucu yazdırma
            //Console.WriteLine(OgrenciKart());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //// Ülke bilgilerini döndüren metot
            //string UlkeKart(string ulkeAdi, string baskent, string bayrakRengi)
            //{
            //    string kartBilgisi = "Ülke: " + ulkeAdi + " - Başkent: " + baskent + " - Bayrak Rengi: " + bayrakRengi;
            //    return kartBilgisi;
            //}

            //// Kullanıcıdan veri alma ve metodu çağırma
            //string a, b, c;

            //Console.Write("Ülke adını giriniz: ");
            //a = Console.ReadLine();

            //Console.Write("Başkenti giriniz: ");
            //b = Console.ReadLine();

            //Console.Write("Bayrak rengini giriniz: ");
            //c = Console.ReadLine();

            //Console.WriteLine(UlkeKart(a, b, c));
            //Console.WriteLine(UlkeKart("Türkiye", "Ankara", "Kırmızı - Beyaz"));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //// İki sayıyı toplayıp sonucu döndüren metot
            //int Topla(int sayi1, int sayi2)
            //{
            //    int sonuc = sayi1 + sayi2;
            //    return sonuc;
            //}

            //// Metodu çağırma ve sonucu yazdırma
            //Console.WriteLine(Topla(45, 98));
            //Console.WriteLine(Topla(36, 25));
            //Console.WriteLine(Topla(44, 36));
            //Console.WriteLine(Topla(14, 20));

            //#endregion

            //#region Örnek Uygulama

            //// Öğrencinin sınav sonucunu hesaplayan ve döndüren metot
            //string SinavSonucu(string ogrenci, int sinav1, int sinav2, int sinav3)
            //{
            //    int ortalama = (sinav1 + sinav2 + sinav3) / 3;

            //    if (ortalama >= 50)
            //    {
            //        return ogrenci + " isimli öğrenci sınavı geçti. Ortalama: " + ortalama;
            //    }
            //    else
            //    {
            //        return ogrenci + " isimli öğrenci sınavı geçemedi. Ortalama: " + ortalama;
            //    }
            //}

            //// Metodu çağırma ve sonuçları yazdırma
            //Console.WriteLine(SinavSonucu("Ali", 78, 41, 85));
            //Console.WriteLine(SinavSonucu("Ayşe", 25, 41, 32));

            #endregion

            Console.Read();

        }
    }
}
