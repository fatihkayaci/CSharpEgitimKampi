using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            #region If Else

            //// Şifre Kontrolü
            //Console.Write("Lütfen şifreyi giriniz: ");
            //string enteredPassword = Console.ReadLine();
            //if (enteredPassword == "abcd")
            //{
            //    Console.WriteLine("Şifre doğru.");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış!");
            //}

            //// Başkent ve Ülke Doğrulama
            //Console.Write("Lütfen başkenti giriniz: ");
            //string enteredCapital = Console.ReadLine();
            //Console.Write("Lütfen ülkeyi giriniz: ");
            //string enteredCountry = Console.ReadLine();

            //if (enteredCapital.ToLower() == "ankara" && enteredCountry.ToLower() == "türkiye")
            //{
            //    Console.WriteLine("Veriler doğrulandı.");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı bilgi girdiniz.");
            //}

            //// Sayı Kontrolü
            //Console.Write("Lütfen bir sayı giriniz: ");
            //int enteredNumber = int.Parse(Console.ReadLine());
            //if (enteredNumber == 5)
            //{
            //    Console.WriteLine("Sayı doğru.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı hatalı.");
            //}

            //// Sınav Ortalaması Hesaplama
            //Console.Write("Sınav 1 notunu giriniz: ");
            //int exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 2 notunu giriniz: ");
            //int exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 3 notunu giriniz: ");
            //int exam3 = int.Parse(Console.ReadLine());

            //int average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların ortalaması: " + average);

            //string grade;
            //if (average > 0 && average <= 50)
            //{
            //    grade = "Vasat";
            //}
            //else if (average > 50 && average <= 70)
            //{
            //    grade = "Orta";
            //}
            //else if (average > 70 && average <= 84)
            //{
            //    grade = "İyi";
            //}
            //else
            //{
            //    grade = "Çok iyi";
            //}

            //Console.WriteLine("Sonuç: " + grade);

            //// Şehir Kontrolü
            //Console.Write("Lütfen bir şehir giriniz: ");
            //string city = Console.ReadLine().ToLower();
            //if (city == "ankara" || city == "adana" || city == "istanbul" || city == "giresun")
            //{
            //    Console.WriteLine("Şehir mevcut.");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil.");
            //}

            //// Kullanıcı Adı Kontrolü
            //Console.Write("Lütfen kullanıcı adınızı giriniz: ");
            //string username = Console.ReadLine();
            //if (username.ToLower() != "admin")
            //{
            //    Console.WriteLine("Bu kullanıcı adı kabul edilemez.");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş geldiniz.");
            //}

            #endregion

            #region Mod İşlemleri

            //// Mod Alma İşlemi
            //int number1 = 26;
            //int remainder = number1 % 5;
            //Console.WriteLine("26'nın 5'e bölümünden kalan: " + remainder);

            //Console.Write("Lütfen bir sayı giriniz: ");
            //int inputNumber = int.Parse(Console.ReadLine());

            //if (inputNumber % 2 == 0)
            //{
            //    Console.WriteLine("Sayı çifttir.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tektir.");
            //}

            #endregion

            #region Karar Yapıları ile Char Kullanımı

            //// Takım Kontrolü
            //Console.Write("Lütfen takımınızın sembolünü giriniz: ");
            //char teamSymbol = char.Parse(Console.ReadLine().ToLower());

            //switch (teamSymbol)
            //{
            //    case 'g':
            //        Console.WriteLine("Galatasaray");
            //        break;
            //    case 'f':
            //        Console.WriteLine("Fenerbahçe");
            //        break;
            //    case 'b':
            //        Console.WriteLine("Beşiktaş");
            //        break;
            //    default:
            //        Console.WriteLine("Geçersiz takım sembolü.");
            //        break;
            //}

            #endregion

            #region Menü Seçim Uygulaması

            //Console.WriteLine("C# Eğitim Kampı Restoran");
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- Pizzalar");
            //Console.WriteLine("4- İçecekler");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("---------------------------------------");

            //Console.Write("Lütfen görmek istediğiniz menüyü seçiniz: ");
            //string selectedMenu = Console.ReadLine();

            //switch (selectedMenu)
            //{
            //    case "1":
            //        Console.WriteLine("Ana Yemekler: Köri Soslu Tavuk, Kızartma Tabağı, Etli Pilav, Fırında Makarna, Patlıcan Musakka");
            //        break;
            //    case "2":
            //        Console.WriteLine("Çorbalar: Mercimek Çorbası, Kremalı Tavuk Çorbası");
            //        break;
            //    case "3":
            //        Console.WriteLine("Pizzalar: Akdeniz Pizza, Margarita, Tavuklu Pizza");
            //        break;
            //    case "4":
            //        Console.WriteLine("İçecekler: Kola, Ayran, Su");
            //        break;
            //    case "5":
            //        Console.WriteLine("Tatlılar: Trileçe, Kazandibi, Profiterol");
            //        break;
            //    default:
            //        Console.WriteLine("Geçersiz seçim.");
            //        break;
            //}

            #endregion

            #region Hesap Makinesi

            //Console.Write("Lütfen birinci sayıyı giriniz: ");
            //int firstNumber = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen ikinci sayıyı giriniz: ");
            //int secondNumber = int.Parse(Console.ReadLine());

            //Console.Write("Yapmak istediğiniz işlemi giriniz (+, -, *, /): ");
            //char operation = char.Parse(Console.ReadLine());

            //int calculationResult;
            //switch (operation)
            //{
            //    case '+':
            //        calculationResult = firstNumber + secondNumber;
            //        Console.WriteLine("Toplam: " + calculationResult);
            //        break;
            //    case '-':
            //        calculationResult = firstNumber - secondNumber;
            //        Console.WriteLine("Fark: " + calculationResult);
            //        break;
            //    case '*':
            //        calculationResult = firstNumber * secondNumber;
            //        Console.WriteLine("Çarpım: " + calculationResult);
            //        break;
            //    case '/':
            //        if (secondNumber != 0)
            //        {
            //            calculationResult = firstNumber / secondNumber;
            //            Console.WriteLine("Bölüm: " + calculationResult);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Sıfıra bölme hatası.");
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("Geçersiz işlem.");
            //        break;
            //}

            #endregion

            Console.Read();

        }
    }
}
