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
            #region //Metotlar 

            //() mor renkli küp metot ifade eder
            //Geriye Deger Döndürömeyen Metotlar
            //Customer * Ekle , Sil , Güncelle ,Listele 
            //Void 

            //void CustomeList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("oguzhan çirkin");
            //    Console.WriteLine("nurullah otkan");

            //}
            //CustomeList();
            //CustomeList();

            //*************************************************

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);

            //}
            //Sum();

            #endregion

            #region //Geriye Deger dondurmeyen parametreli metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Mehmet Yıldız");

            //void CostomerCard(string name , string surname, string title)
            //{
            //    Console.WriteLine("Müsteri: " + name + "" + surname + "" + title);
            //}
            //CostomerCard("Mehmet", "Yıldız" ,"uzman");
            //CostomerCard("Ayşegül", "Kaya", "Şef");

            #endregion

            #region //Geriye Deger döndürmeyen Int parametreli metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //Sum(1, 2, 3);

            #endregion

            #region //Geriye Değer Döndüren Metotlar

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard());


            #endregion

            #region //Geriye Değer Döndüren PArametreli Metotlar

            //string CountryCard(string CountryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + CountryName + " -- Başkent: " + capital + " -- Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini Girniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));
            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));
            #endregion

            #region //Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(36, 25));
            //Console.WriteLine(Sum(44, 75));


            //--------------------------------------------------------
            
            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student + "İsimli Ögrenci Sınavı Gecti" + "**" +  "Ortalama: " + result;
            //    }
            //    else
            //    {
            //        return student + "İsimli Ögrenci Sınavı Gecemedi" + "**" +  "Ortalama: " + result;
            //    }

            //}
            //Console.WriteLine(ExamResult("Ali ", 25, 41,85));
            //Console.WriteLine(ExamResult("Vali ", 67, 73,81));
            //Console.WriteLine(ExamResult("Mehmet ", 21, 55,34));


            #endregion




            Console.Read();
        }
    }
}
