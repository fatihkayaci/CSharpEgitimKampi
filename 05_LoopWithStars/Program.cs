using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt alta 10 tane yıldız oluşturma 

            // Alt alta 10 adet yıldız (*) sembolü yazdırma
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion

            #region Yan yana 10 tane yıldız oluşturma 

            // Yan yana 10 adet yıldız (*) sembolü yazdırma
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("*");
            //}

            //Console.WriteLine(); // Yeni satıra geçmek için ekledik

            #endregion

            #region Alt alta 10 tane yıldız oluşturma her satırda 10 yıldız

            // 10 satır boyunca her satırda 10 adet yıldız (*) sembolü yazdırma
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int y = 0; y < 10; y++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine(); // Her satırın sonunda yeni satıra geç
            //}

            #endregion

            #region Dik Üçgen

            // Yıldızlarla sağa dayalı bir dik üçgen oluşturma
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int y = 0; y <= i; y++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine(); // Her satırın sonunda yeni satıra geç
            //}

            #endregion

            #region Ters Dik Üçgen

            // Yıldızlarla ters bir dik üçgen oluşturma
            //for (int i = 5; i > 0; i--)
            //{
            //    for (int y = 0; y < i; y++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine(); // Her satırın sonunda yeni satıra geç
            //}

            #endregion

            #region Dik ve Ters Üçgen Beraber

            // Önce sağa dayalı dik üçgen, ardından ters dik üçgen oluşturma
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int y = 0; y <= i; y++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 4; i > 0; i--)
            //{
            //    for (int y = 0; y < i; y++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Baklava Dilimi

            // Baklava dilimi oluşturma
            //int n = 5;
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}

            //for (int i = n - 1; i >= 1; i--)
            //{
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}

            #endregion

            #region Piramit

            // Yıldızlarla piramit oluşturma
            //n = 5;
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n; j > i; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 0; k < 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ters Piramit

            // Yıldızlarla ters piramit oluşturma
            //n = 5;
            //for (int i = n; i >= 1; i--)
            //{
            //    for (int j = n; j > i; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 0; k < 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            Console.Read(); // Programı kapatmadan önce bekletmek için

        }
    }
}
