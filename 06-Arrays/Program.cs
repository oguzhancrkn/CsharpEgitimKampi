using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region //Temel Dizi Örnekleri

            //Değişken türü [] DiziAdı = new  Değişken Türü[Eleman Sayısı]
            //Dizin sıfırdan başlayacaktır.

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Mavi";
            //colors[2] = "Yeşil";
            //colors[3] = "Sarı";

            //Console.WriteLine(colors[2]);

            //---------------------------------------
            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[3] = 698;
            //numbers[7] = 748;
            //Console.WriteLine(numbers[5]); olarak calıştırınca sıfır degerini verir.

            //---------------------------------------




            #endregion

            #region //Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Sarı", "kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //----3'e bilğmğnden kalan sıfır ise------------------------------------
            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 533, 7456, 2365, 1120 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //---------------------------------

            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //for (int i = 0; i < symbols.Length; i++)
            //{


            //        Console.WriteLine(symbols[i]);

            //}

            //----------------------------------------
            //Dizideki en büyük elmanı bulan sayı 

            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };
            //int maxNumber = myArray[0];
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //----Dizinin  uzunlugunu hesapla-------------------------

            //string[] persons = { "ali", "ahmet", "mehmet", "oguz", "mustafa" };
            //Console.WriteLine(persons.Length);

            //----sort metodu------------------------------------;

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //----reverse metodu tersten sıralama------------------------------------;

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region //Dizi metotlar

            //string[] customers = { "ali", "buse", "ayşegül", "merve", "cınar", "kaya" };
            //int index = Array.IndexOf(customers, "ayşegül");
            //Console.WriteLine(index); 3 osnucunu verir

            //*---max ve mın metotları---
            //int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };
            //Console.WriteLine("Dizini En Büyük Elemanı: " + numbers.Max() +    "Dizinin En Kücük Elemanı: " + numbers.Min());




            #endregion

            #region

            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}.Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("*******************");

            //for (int i = 0; i < cities.Length; i++)
            //{   
            //    Console.WriteLine(cities[i]);

            //}

            //--tamsayı dizisinin toplamını oluştur---------------------------

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);


            //int[] numbers2 = { 10, 20, 30, 8435344, 534653434 };
            //int sum2 = 0;

            //for (int i = 0; i < numbers2.Length; i++)
            //{
            //    sum2 += numbers2[i];
            //}
            //Console.WriteLine(sum2);

            //--sayıları tek ve cift olarak ayrı ayrı listele---------------------------

            //int[] numnbers = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220, 328 };

            //Console.WriteLine("çift sayılar: ");
            //Console.WriteLine();
            //for (int i = 0; i < numnbers.Length; i++)
            //{
            //    if (numnbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numnbers[i]);
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("****************");
            //Console.WriteLine("Tek Sayılar");
            //for (int i = 0; i < numnbers.Length; i++)
            //{
            //    if (numnbers[i] % 2 == 1)
            //    {
            //       Console.WriteLine(numnbers[i]);
            //    }
            //}
            #endregion
            Console.Read();

        }
    }
}
