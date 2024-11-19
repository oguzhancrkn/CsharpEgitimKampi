using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region // For Döngüsü

            //For(x;y;z) x : başlangıc , y :  bitiş , z : artış ve azalış döngülerini tutar

            //int i;

            //for (i=1; i<=5; i++)
            //{
            //    Console.WriteLine("C# Egitim Kampı");
            //}

            //------------------------------------------

            //1 den 20 ye kadar sayıları yazar.
            //for (int i = 1; i<=20; i++) 
            //{
            //   Console.WriteLine(i);
            //}

            //------------------------------------------
            //3 er 3 er 50 ye kadar yaz
            //for (int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}
            //------------------------------------------

            //Console.Write("Lütfen Ekrana Yazılması İstediginiz Adedi Giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i<= finishValue; i++) 
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}

            //--------

            //Console.Write("Lütfen Ekrana Tuttugunuz Takımı Yazınız: ");
            //int takim = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= takim; i++)
            //{
            //    Console.WriteLine("Galatasaray");
            //}


            #endregion

            #region //For Döngüsü ile Karar Yapıları

            //for (int i = 1; i <=100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //------------------------------

            //Döngü ile Toplama işlemi
            //int totalvalue = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //   totalvalue += i;
            //}
            //Console.WriteLine(totalvalue);
            //------------------------------

            //ikiye tam bolunebilen 20 ye kadar ve toplamını yaz

            //int totalValue = 0;
            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }

            //}
            //Console.WriteLine("-----");
            //Console.WriteLine(totalValue);

            //-her saat sonunda bakterileri hesapla-----------------------------

            //int bacterium = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + "Saat Sonunda : " + bacterium);
            //}



            #endregion

            #region //While Döngüsü şart saglandıgı müddetce anlamı taşır 

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);

            #endregion

            #region //Örnek Sınav Sorusu

            //Klavyeden girilen 3 basamaklı saının basamakları toplamını hesaplayan kodu yazınız ? 
            //Console.Write("sayıyı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundreds;
            //int sum;

            //ones = number % 10;
            //tens = (number % 100) / 10;
            //hundreds = number / 100;


            //Console.WriteLine(ones + "-" + tens + "-" + hundreds);
            //sum = ones + tens + hundreds;
            //Console.WriteLine(sum);

            //---------------yazı girilince ki sorusu---------

            //Console.Write("Bir kelime giriniz: ");
            //string word = Console.ReadLine();

            //char firstLetter, middleLetter, lastLetter;

            //// İlk harf
            //firstLetter = word[0];

            //// Orta harf (kelimenin uzunluğu tekse tam ortadaki harf alınır)
            //middleLetter = word[word.Length / 2];

            //// Son harf
            //lastLetter = word[word.Length - 1];

            //Console.WriteLine($"İlk harf: {firstLetter}");
            //Console.WriteLine($"Orta harf: {middleLetter}");
            //Console.WriteLine($"Son harf: {lastLetter}");

            //Console.WriteLine(word);



            #endregion
            Console.Read();
        }
    }
}
