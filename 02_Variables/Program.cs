using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Klavyeden Veri Girişi
            //Console.WriteLine("*** CSharp hava yolu bilgisi ***");
            //Console.WriteLine();
            //string customerIdendity, customerName, customerSurname, customerDistrict, customerCity, customerAge;
            //Console.Write("yolcu adını giriniz : ");
            //customerName = Console.ReadLine();

            //Console.Write("yolcu soyadı giriniz : ");
            //customerSurname = Console.ReadLine();

            //Console.Write("yolcu TC bilgisi giriniz : ");
            //customerIdendity = Console.ReadLine();
            
            //Console.Write("yolcu ilçe bilgisi giriniz : ");
            //customerDistrict = Console.ReadLine();

            //Console.Write("yolcu şehir giriniz : ");
            //customerCity = Console.ReadLine();

            //Console.Write("yolcu yaş giriniz : ");
            //customerAge = Console.ReadLine();

            //Console.WriteLine("Yolcu Kimlik numarası : "+ customerIdendity+" Yolcu Adı : " + customerName
            //    + "yolcu soyadı : " + customerSurname + customerDistrict +" / " + customerCity + " yolcu yaş : "
            //    + customerAge);
            #endregion

            #region klavyeden int giriş

            int shoesPrice, computerPrice, chairPrice, tvPrice;
            shoesPrice = 1000;
            computerPrice = 20000;
            chairPrice = 5000;
            tvPrice = 12000;
            
            int shoesCount, computerCount, chairCount, tvCount;
            Console.Write("lütfen ne kadar ayakkabı alacağınızın bilgisini veriniz: ");
            shoesCount = int.Parse(Console.ReadLine());
            Console.Write("lütfen ne kadar bilgisayar alacağınızın bilgisini veriniz: ");
            computerCount = int.Parse(Console.ReadLine());
            Console.Write("lütfen ne kadar sandalye alacağınızın bilgisini veriniz: ");
            chairCount = int.Parse(Console.ReadLine());
            Console.Write("lütfen ne kadar televizyon alacağınızın bilgisini veriniz: ");
            tvCount = int.Parse(Console.ReadLine());
            int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;
            Console.WriteLine();
            Console.WriteLine("Toplam Ödemeniz gereken ücret = " + totalPrice);
            #endregion

            /* hangi sayıyı kullanmak istiyorsanız yani diyelim ki integer 
             * bir sayı ise "int.parse" yapmanız double bir sayı ise "double.parse" yapmanız gerekmektedir
             */
            Console.ReadLine();
        }
    }
}
