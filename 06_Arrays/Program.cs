using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Basit Dizi Örnekleri

            //string[] renkler = new string[4];
            //renkler[0] = "Kırmızı";
            //renkler[1] = "Turuncu";
            //renkler[2] = "Yeşil";
            //renkler[3] = "Mor";

            //Console.WriteLine(renkler[2]);

            //string[] sehirler = new string[5];

            //sehirler[0] = "Londra";
            //sehirler[1] = "Tokyo";
            //sehirler[2] = "Berlin";
            //sehirler[3] = "New York";
            //sehirler[4] = "İstanbul";

            //Console.WriteLine(sehirler[4]);

            //int[] sayilar = new int[10];

            //sayilar[0] = 12;
            //sayilar[1] = 34;
            //sayilar[2] = 567;
            //sayilar[3] = 89;
            //sayilar[7] = 678;

            //Console.WriteLine(sayilar[5]);

            //string[] sehirler2 = { "Paris", "Roma", "Madrid", "Atina", "Tokyo" };

            //Console.WriteLine(sehirler2[2]);

            #endregion

            #region Dizideki Tüm Öğeleri Listeleme

            //string[] renkler2 = { "Mor", "Turuncu", "Yeşil", "Kahverengi", "Gri", "Bordo", "Kırmızı" };

            //for (int i = 0; i < renkler2.Length; i++)
            //{
            //    Console.WriteLine(renkler2[i]);
            //}

            //int[] rakamlar = { 7, 54, 82, 19, 123, 651, 400, 7234, 2800, 1011 };

            //for (int i = 0; i < rakamlar.Length; i++)
            //{
            //    if (rakamlar[i] % 5 == 0)
            //    {
            //        Console.WriteLine(rakamlar[i]);
            //    }
            //}

            //char[] semboller = { '@', '#', '$', '%', '^', '&' };
            //for (int i = 0; i < semboller.Length; i++)
            //{
            //    Console.WriteLine(semboller[i]);
            //}

            //int[] dizi = { 98, 45, 72, 86, 39, 141, 695, 150 };

            //int enBuyukSayi = dizi[0];

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    if (dizi[i] > enBuyukSayi)
            //    {
            //        enBuyukSayi = dizi[i];
            //    }
            //}

            //Console.WriteLine(enBuyukSayi);

            //string[] isimler = { "mehmet", "ayşe", "esra", "mustafa", "deniz", "salih" };
            //Console.WriteLine(isimler.Length);

            //int[] rakamlar2 = { 2, 5, 77, 34, 56, 8, 41 };

            //Array.Sort(rakamlar2);  // Küçükten büyüğe sıralama

            //for (int i = 0; i < rakamlar2.Length; i++) 
            //{
            //    Console.WriteLine(rakamlar2[i]);
            //}

            //int[] rakamlar3 = { 3, 8, 24, 61, 94, 17, 28 };
            //Array.Reverse(rakamlar3);  // Diziyi ters çevirme

            //for (int i = 0; i < rakamlar3.Length; i++)
            //{
            //    Console.WriteLine(rakamlar3[i]);
            //}

            #endregion

            #region Dizi Metotları

            //string[] musteriler = { "serkan", "nazlı", "buket", "melis", "efe", "arda" };
            //int siraNo = Array.IndexOf(musteriler, "melis");  // Dizi içindeki indeks numarası

            //Console.WriteLine(siraNo);

            //int[] sayilar2 = { 55, 23, 67, 88, 41, 2, 74, 35, 19 };
            //Console.WriteLine("Dizideki en büyük sayı: " + sayilar2.Max() 
            //    + " Dizideki en küçük sayı: " + sayilar2.Min());

            #endregion

            #region Kullanıcıdan Girdi Alma

            //string[] sehirler3 = new string[5];

            //for (int i = 0; i < sehirler3.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Yazınız: ");
            //    sehirler3[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("------------------------");

            //for (int i = 0; i < sehirler3.Length; i++)
            //{
            //    Console.WriteLine(sehirler3[i]);
            //}

            //int[] rakamlar4 = { 15, 25, 35, 45, 55 };
            //int toplam = 0;

            //for (int i = 0; i < rakamlar4.Length; i++)
            //{
            //    toplam += rakamlar4[i];
            //}

            //Console.WriteLine(toplam);

            //int[] sayilar3 = { 13, 26, 35, 48, 59, 64, 892, 721, 47, 230 };
            //Console.WriteLine("Çift Sayılar");

            //for (int i = 0; i < sayilar3.Length; i++)
            //{
            //    if (sayilar3[i] % 2 == 0)
            //    {
            //        Console.WriteLine(sayilar3[i]);
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("Tek Sayılar");

            //for (int i = 0; i < sayilar3.Length; i++)
            //{
            //    if (sayilar3[i] % 2 == 1)
            //    {
            //        Console.WriteLine(sayilar3[i]);
            //    }
            //}

            #endregion

            Console.Read();

        }
    }
}
