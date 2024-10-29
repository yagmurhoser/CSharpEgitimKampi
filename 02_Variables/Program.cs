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
            #region Double Değişkenler
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("*** Fiyat Listesi ***");
            //Console.WriteLine();
            //Console.WriteLine();
            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("-------Elma Birim Fiyatı:" + applePrice+ "TL");
            //Console.WriteLine("-------Portakal Birim Fiyatı:" + orangePrice+ "TL");
            //Console.WriteLine("-------Çilek Birim Fiyatı:" + strawberryPrice + "TL");
            //Console.WriteLine("-------Patates Birim Fiyatı:" + potatoPrice + "TL");
            //Console.WriteLine("-------Domates Birim Fiyatı:" + tomatoPrice + "TL");
            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan Ürün: Elma-"+"Birim Fiyat:"+applePrice + "-Gram:"+appleGram+"-Toplam Tutar: "+appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal-" + "Birim Fiyat:" + orangePrice + "-Gram:" + orangeGram + "-Toplam Tutar: " + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek-" + "Birim Fiyat:" + strawberryPrice + "-Gram:" + strawberryGram + "-Toplam Tutar: " + strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates-" + "Birim Fiyat:" + potatoPrice + "-Gram:" + potatoGram + "-Toplam Tutar: " + potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates-" + "Birim Fiyat:" + tomatoPrice + "-Gram:" + tomatoGram + "-Toplam Tutar: " + tomatoTotalPrice);


            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Alışveriş Toplam Tutarı:"+shoppingTotalPrice);
            #endregion

            #region Char

            //ABCDEFGH...

            char symbol;
            symbol = 'a';
            Console.WriteLine(symbol);

            #endregion


            #region Veri girişleri String
            //Console.WriteLine("*** Yolcu Bilgisi ***");
            //Console.WriteLine();
            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge,
            //    passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName =Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname =Console.ReadLine();

            //Console.Write("İlçe: ");
            //passengerDistrict =Console.ReadLine();

            //Console.Write("Şehir: ");
            //passengerCity =Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge =Console.ReadLine();

            //Console.Write("Yolcu TC: ");
            //passengerIdentityNumber=Console.ReadLine(); 

            //Console.WriteLine();
            //Console.WriteLine("-----------------------");
            //Console.WriteLine("Yolcu TC: "+passengerIdentityNumber+" Yolcu Ad Soyad: "+passengerName+" "+passengerSurname+" Yolcu Şehir İlçe: "+passengerCity+"/"+passengerDistrict+"Yolcu Yaş: "+passengerAge);

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşleri
            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;
            //Console.Write("Lütfen Aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());


            //Console.Write("Lütfen Aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());


            //int totalPrice = shoesCount * shoePrice + computerCount * computerPrice + chairCount * chairPrice + tvPrice * tvCount;
            //Console.WriteLine("Toplam Tutar: "+totalPrice);
            #endregion


            #region Klavyeden ondalıklı sayı işlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("1. sınav notu: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("2. sınav notu: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("3. sınav notu: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: "+result);

            #endregion



            #region Klavyeden Karakter Girişleri
            char gender;
            Console.Write("Cinsiyet Seçiniz: ");
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Seçtiğiniz Cinsiyet: "+gender);

            #endregion


            Console.Read();
        }
    }
}
