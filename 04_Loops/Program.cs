using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            //// Belirli bir sayıda "C# Eğitim Kampı" yazdırma
            //for (int i = 0; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //// 1'den 20'ye kadar olan sayıları yazdırma
            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //// 3'ten başlayarak 50'ye kadar olan 3'ün katlarını yazdırma
            //for (int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //// Kullanıcının girdiği kadar "Yaşasın Cumhuriyet" yazdırma
            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 0; i < finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}

            #endregion

            #region For Döngüsü ile Karar Yapıları

            //// 0'dan 100'e kadar olan sayılardan 5'in katı olanları yazdırma
            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //// 1'den 10'a kadar olan sayıların toplamını hesaplama
            //int totalValue = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine("Toplam Değer: " + totalValue);

            //// 1'den 20'ye kadar olan çift sayıların toplamını hesaplama
            //int evenTotal = 0;
            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        evenTotal += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("Çift Sayıların Toplamı: " + evenTotal);

            //// 1'den 50'ye kadar olan sayılardan 7'ye bölünebilenlerin sayısını bulma
            //int countDivisibleBy7 = 0;
            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        countDivisibleBy7++;
            //    }
            //}
            //Console.WriteLine("7'ye bölünebilen sayı adedi: " + countDivisibleBy7);

            //// Bakterinin her saat iki katına çıkmasını simüle etme (24 saat boyunca)
            //int bacteriumCount = 1;
            //for (int i = 1; i <= 24; i++)
            //{
            //    bacteriumCount *= 2;
            //    Console.WriteLine(i + ". Saat Sonunda: " + bacteriumCount);
            //}

            #endregion

            #region While Döngüsü

            //// 1'den 10'a kadar "Merhaba Döngüler" yazdırma
            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            //// 1'den 10'a kadar olan sayılardan 3'ün katlarını yazdırma
            //i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //// 1'den 10'a kadar olan sayıların toplamını hesaplama
            //int sum = 0;
            //i = 1;
            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine("Toplam: " + sum);

            #endregion

            #region Örnek Soru

            // Kullanıcının girdiği 3 basamaklı bir sayının rakamlarının toplamını bulma
            //Console.Write("Lütfen 3 basamaklı bir sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //int total = 0;

            //for (i = 0; i < 3; i++)
            //{
            //    int digit = number % 10; // Son basamağı al
            //    number /= 10;            // Son basamağı çıkar
            //    total += digit;          // Rakamları toplama ekle
            //}

            //Console.WriteLine("Rakamların Toplamı: " + total);

            #endregion

        }
    }
}
