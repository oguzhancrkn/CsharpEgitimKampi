using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region //Alt alta 10 tane yıldız oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion

            #region //Dik Ücgen formatı

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //        Console.Write("*");
            //    Console.WriteLine();
            //}

            //for (int i = 1; i <= 8; i++)
            //{
            //    for(int z = 1; z<= i; z++)
            //        Console.Write("GS");
            //    Console.WriteLine();
            //}

            #endregion

            #region //Ters Dik Ücgen
            //for (int i = 5; i >= 1; i--)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region //Dik ve ters ddik ücgen beraber

            //for (int i = 1; i <= 5; i++)
            //{
            //    // Boşluk ekle
            //    for (int j = 1; j <= 5 - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    // Yıldız ekle
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int k = 4; k >= 1; k--)
            //{
            //    // Boşluk ekle
            //    for (int m = 1; m <= 5 - k; m++)
            //    {
            //        Console.Write(" ");
            //    }
            //    // Yıldız ekle
            //    for (int m = 1; m <= k; m++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region //Baklava Dilimi 

            ////üst kısım 
            //int n = 5;

            //// Üst kısım (yukarı doğru genişleyen üçgen)
            //for (int i = 1; i <= n; i++)
            //{
            //    // Boşluklar
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    // Yıldızlar
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //// Alt kısım (aşağı doğru daralan üçgen)
            //for (int i = n - 1; i >= 1; i--)
            //{
            //    // Boşluklar
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    // Yıldızlar
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region //Piramit

            //int n = 5;
            //for (int i = 1; i <= n; i++)
            //{     //Boşluklar için 
            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //Yıldızlar
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region  //Ters Piramit

            //int n = 5;
            //for (int i = n; i >= 1; i--)
            //{
            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        Console.WriteLine(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            Console.Read();

        }



    }

}


