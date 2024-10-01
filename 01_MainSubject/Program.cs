using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Console write
            //Console.WriteLine("Merhaba Dünya");
            //Console.WriteLine("Selam C# Eğitim");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine("1-Çorba");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Tatlılar");
            //Console.WriteLine("4-Dürümler");
            //Console.WriteLine("5-Mükemmel İkililer");
            //Console.WriteLine("*************************");
            #endregion
            #region Variables

            //string customerName;
            //string customerSurName;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Fatih";
            //customerSurName = "Kayacı";
            //customerPhone = "05555555555";
            //customerEmail = "fatihkayaci@yahoo.com";
            //district = "Sarıyer";
            //city = "İstanbul";

            //Console.WriteLine();
            //Console.WriteLine("***** Rezervasyon Kartı *****");
            //Console.WriteLine("--------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurName);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adress: " + customerEmail);
            //Console.WriteLine("Adress: " + district + " / " + city);
            //Console.WriteLine("---------------------------------------------------");

            //customerName = "Sıla";
            //customerSurName = "Kayacı";
            //customerPhone = "05555555555";
            //customerEmail = "sıla@deneme.com";
            //district = "Sarıyer";
            //city = "İstanbul";

            //Console.WriteLine();
            //Console.WriteLine("***** Rezervasyon Kartı *****");
            //Console.WriteLine("--------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurName);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adress: " + customerEmail);
            //Console.WriteLine("Adress: " + district + " / " + city);
            //Console.WriteLine("---------------------------------------------------");

            #endregion
            #region Veriable Int
            int hamburgerPrice = 300;
            int cokePrice = 40;
            int waterPrice = 10;
            int friesPrice = 85;
            int pizzaPrice = 250;
            int lemonadePrice = 35;

            Console.WriteLine("*****Restoran Fiyat Listesi*****");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("hamburger = " + hamburgerPrice);
            Console.WriteLine("kola = " + cokePrice);
            Console.WriteLine("su = " + waterPrice);
            Console.WriteLine("Patates = " + friesPrice);
            Console.WriteLine("pizza = " + pizzaPrice);
            Console.WriteLine("Limonata = " + lemonadePrice);
            Console.WriteLine("-------------------------------");
            Console.WriteLine();

            int hamburgerCount = 3;
            int cokeCount = 2;
            int waterCount = 1;
            int friesCount = 1;
            int pizzaCount = 2;
            int lemonadeCount = 3;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice =  cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Hamburger Tutarı " + totalHamburgerPrice + "TL");
            Console.WriteLine("Kola Tutarı " + totalCokePrice + "TL");
            Console.WriteLine("su tutarı " + totalWaterPrice + "TL");
            Console.WriteLine("Patates Tutarı "+ totalFriesPrice + "TL");
            Console.WriteLine("Pizza Tutarı " + totalPizzaPrice + "TL");
            Console.WriteLine("limonata tutarı " + totalLemonadePrice + "TL");
            Console.WriteLine("-------------------------------");
            int totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice
                +totalLemonadePrice;
            Console.WriteLine("Toplam Tutar : " + totalPrice + "TL");
            #endregion
            Console.Read();

        }
    }
}
