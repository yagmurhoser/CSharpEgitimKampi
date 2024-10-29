using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Yazdırma Komutları
            //Console.Write("Merhaba Dünya");
            //Console.WriteLine("Selam");


            //Console.WriteLine("***** Yemek Kategorileri*****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri*****");

            #endregion




            #region String Değişkenler

            //string
            //Değişken_türü değişken_adı;

            //string name;
            //name = "yağmur";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Yağmur";
            //customerSurname = "Hoşer";
            //customerPhone = "5555555555";
            //customerEmail = "yagmurhoser01@gmail.com";
            //district = "Yüreğir";
            //city = "Adana";


            //Console.WriteLine("**** Rezervasyon Kartı****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("iletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-------------------------------------");



            #endregion


            #region int değişkenler

            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("*** Restoran Menü Fiyat ***");
            Console.WriteLine();
            Console.WriteLine("---------Hamburger Fiyat: " + hamburgerPrice);
            Console.WriteLine("---------Kola: " + cokePrice);
            Console.WriteLine("---------Su: " + waterPrice);
            Console.WriteLine("---------Kızartma: " + friesPrice);
            Console.WriteLine("---------Pizza: " + pizzaPrice);
            Console.WriteLine("---------Limonata: " + lemonadePrice);
            Console.WriteLine();
            Console.WriteLine("*** Restoran Menü Fiyat ***");

            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int totalFriesPrice = 0;
            int totalPizzaPrice = 0;
            int totalLemonadePrice = 0;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;
            Console.WriteLine("-------------------------");
            Console.WriteLine("Hamburger Tutarı: "+ totalHamburgerPrice+ "Tl");
            Console.WriteLine("Kola Tutarı: "+ totalCokePrice+ "Tl");
            Console.WriteLine("Su Tutarı: "+ totalWaterPrice+ "Tl");
            Console.WriteLine("Kızartma Tutarı: "+ totalFriesPrice+ "Tl");
            Console.WriteLine("Pizza Tutarı: "+ totalPizzaPrice+ "Tl");
            Console.WriteLine("Limonata Tutarı: "+ totalLemonadePrice+ "Tl");
            Console.WriteLine("");

            int totalPrice = totalCokePrice + totalFriesPrice + totalHamburgerPrice + totalLemonadePrice + totalPizzaPrice + totalWaterPrice;
            Console.WriteLine("Toplam Tutar : "+totalPrice+ " TL");
            #endregion



            Console.Read();

        }
    }
}
