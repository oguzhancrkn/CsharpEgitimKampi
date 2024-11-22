using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region //Foreach Döngüsü

            //-----sırayla yazmaa örnegi-----

            //Degişken Türü, Değişken Adı, In, Liste,Koleksiyon, Dizi

            //String[] cities = {"milano" ,"roma", "budapeşte"
            //         ,"ankara","istanbul", "varşova" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 83754, 38752, 25645, 742 };

            //foreach (int x in numbers)
            //{
            //    Console.WriteLine(x);
            //}

            //2 ye tam bolunuyorsa 
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 83754, 38752, 25645, 742 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 83754, 38752, 25645, 742 };

            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);

            //*****Listeler******

            //List<int> numbers = new List<int>()
            //{
            //    1,2, 3, 4, 5, 6, 7
            //};
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //--alt alta sıalama
            //string word = "Merhaba";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}



            #endregion


            #region  //Örnek Sınav Sistemi Uygulaması 

            Console.Write("***** C# Egitim Kampı Sınav Uygulaması ******");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Sınıftaki ogrenıc sayısını kullanıcıdan alma

            Console.WriteLine("-------------------------------");
            Console.Write("Sınıfınızda Kaç Ögrenci Var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------");

            //Ögrenci isimlerini ve not ortalamalarını saklayacak diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. ögrencinin ismini giriniz. ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;
                //HER OGRENCİ ICIN 3 SINA NOTU ALALIM

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli ögrencisinin {j + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value; //notları topluyıruz
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;
            }

            //sınav ortalamaları
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]}adlı ögrencinni ortalaması: {studentExamAvg[i]}");

                //ogrencilerin ortalaması ve gecip kalma durumu 
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]}adlı ogtenci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı ogrenci dersten kaldı");
                }
                Console.WriteLine("----------------------------");

            }




            #endregion

            Console.Read();




        }
    }
}
 