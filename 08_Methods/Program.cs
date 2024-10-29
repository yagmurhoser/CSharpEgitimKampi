using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metotlar

            // ()
            // Geriye değer döndürmeyenler
            // Void 

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}
            //CustomerList();





            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();

            #endregion



            #region Geriye değer döndürmeyen string parametreli metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Yağmur Hoşer");


            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri : "+ name+ " " + surName);
            //}

            //CustomerCard("Yağmur", "Hoşer");
            //CustomerCard("Ayşegül", "Kaya");


            #endregion


            #region Geriye değer döndürmeyen int parametreli metotlar

            //void Sum(int number1,  int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //Sum(4, 5, 6);

            #endregion





            #region Geriye değer döndüren metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Yağmur";
            //    string surname = "Hoşer";
            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());


            #endregion




            #region Geriye değer döndüren string parametreli metotlar


            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke : "+ countryName + " - Başkent : "+ capital+ " - Bayrak Rengi : "+flagColor;
            //    return cardInfo;
            //}


            //Console.Write("Ülke Adı : ");
            //string country = Console.ReadLine();

            //Console.Write("Başkent Adı : ");
            //string capitalname = Console.ReadLine();


            //Console.Write("Bayrak Rengi : ");
            //string flag = Console.ReadLine();

            //Console.WriteLine(CountryCard(country, capitalname, flag));



            #endregion


            #region Geriye değer döndüren int parametreli metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(45, 98));


            #endregion




            #region Örnek Uygulama

            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2+ exam3) / 3;
                if (result >= 50)
                {
                    return student +  "İsimli öğrenci sınavı geçti" + " Ortalaması : "+result;
                }
                else
                {
                    return "Öğrenci başarısız geçti";

                }
            }
            Console.WriteLine(ExamResult("Yağmur", 50, 50, 50));

            #endregion









            Console.Read();
        }
    }
}
