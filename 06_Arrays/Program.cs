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

            #region Temel dizi örnekleri


            //DeğişkenTürü [] DiziAdı = new DeğişkenTürü[elemanSayısı];
            //string[] colors = new string[4];
            //colors[0] = "kırmızı";
            //colors[1] = "sarı";
            //colors[2] = "beyaz";
            //colors[3] = "mavi";
            //Console.WriteLine(colors[2]);


            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] =48;
            //numbers[2] =698;
            //numbers[3] =24;
            //numbers[7] =748;
            //Console.WriteLine(numbers[5]);

            //string[] cities = { "Prag", "Roma", "Aina", "Ankara" ,"Bursa"};
            //Console.WriteLine(cities[2]);


            #endregion




            #region Dizideki tüm elemanları sıralama

            //string[] colors = { "sarı", "kırmızı", "beyaz", "mavi", "yeşil", "turuncu", "pembe" };
            //for (int i = 0; i<colors.Length; i++)
            //{
            //        Console.WriteLine(colors[i]);
            //}



            //int[] numbers = {4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };

            //for (int i = 0; i < numbers.Length; i++) {
            //    if (numbers[i] % 3 == 0) {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}


            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100};
            //int enBuyuk = myArray.Max();
            //Console.WriteLine(enBuyuk);

            //int maxNumber = myArray[0];
            //for(int i = 0; i < myArray.Length; i++)
            //{
            //    if(myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);



            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++) {
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //      Console.WriteLine(numbers[i]);
            //}
            #endregion


            #region Dizi Metotları

            //string[] customers = {"ali", "buse", "ayşegül", "merve", "çınar", "kaya"};
            //int index = Array.IndexOf(customers, "merve");
            //Console.WriteLine(index);


            #endregion





            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];
            //for(int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i+1}. Şehri Giriniz : ");
            //    cities[i] = Console.ReadLine();
            //}
            //for(int i = 0;i < cities.Length;i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            #endregion



            #region Tek Çift

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    if(numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i] +" çift sayıdır");
            //    }
            //    else
            //    {
            //        Console.WriteLine(numbers[i] +" tek sayıdır");
            //    }
            //}

            #endregion

            Console.Read();
        }
    }
}
