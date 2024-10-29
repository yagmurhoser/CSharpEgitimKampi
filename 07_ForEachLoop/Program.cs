using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForEachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Foreach Döngüsü
            //Değişken türü
            //Değişken Adı
            //ın
            //Liste, koleksiyon, dizi

            //string[] cities = {"milano", "roma", "budapeşte",
            //"ankara", "istanbul","varşova"};

            //foreach(string city in cities)
            //{
            //    Console.WriteLine(city);
            //}



            //int[] numbers = { 45, 78, 985, 635,74,11,22,33,41};

            //foreach(int number in numbers)
            //{
            //    if(number % 2 == 0)
            //    {
            //        Console.WriteLine(number +" çift sayıdır");
            //    }
            //    else
            //    {
            //        Console.WriteLine(number +" tek sayıdır");
            //    }
            //}


            //int[] numbers = { 45, 78, 985, 635,74,11,22,33,41,205,6578,10394};

            //int total = 0;
            //foreach(int i in numbers)
            //{
            //    total+=i;
            //}
            //Console.WriteLine(total);



            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4
            //};
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}




            //string word = "Merhaba";
            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}







            #endregion








            #region Örnek Sınav Sistemi Uygulaması

            Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Sınıfınızda kaç öğrenci var : ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------");

            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i+1}.öğrencinin ismi : ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                for (int j = 0; j<3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j+1}. sınav notu : ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult+= value;  
                }
                studentExamAvg[i] = totalExamResult / 3;

            }

            for(int i =0; i<studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması {studentExamAvg[i]}");
                if(studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci geçti.");

                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci kaldı.");

                }
            }

            #endregion
            Console.Read();
        }
    }
}
