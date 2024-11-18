using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  //If Else

            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd") 

            //{
            //    Console.WriteLine("Şifre Dogru"); 

            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            // ----------------------------------------------
            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if(capital == "Ankara" & country == "Türkiye")
            //{
            //    Console.Write("Veriler Dogrulandı ");
            //}
            //else
            //{
            //    Console.Write("Hatalı Bilgi ");
            //}

            //------------------------------------------------

            //int number;
            //Console.Write("Sayıyı Giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı Dogru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Hatalı");
            //}

            //-------------------------------------------------

            //int exam1, exam2, exam3, averagle;
            //string result = "Hata";

            //Console.Write("Sınav1 : ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav2 : ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav3 : ");
            //exam3 = int.Parse(Console.ReadLine());

            //averagle = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması: " + averagle);

            //if (averagle > 0 & averagle <= 50)
            //{
            //    result = "Sonuç Vasat";
            //}
            //if (averagle > 50 & averagle <= 70)
            //{
            //    result = "Sonuç Orta";
            //}
            //if (averagle > 70 & averagle <= 84)
            //{
            //    result = "Sonuç İyi";
            //}
            //if (averagle > 84)
            //{
            //    result = "Sonuç Cok İyi";
            //}

            //Console.WriteLine(result);

            //---------------------------------------------------

            //string city;
            //Console.Write("Lütfen Şehir girişi yapınız: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("Şehir Mevcur");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir Mevcut Degil");
            //}

            //---------------------------------------------------

            //string capital;
            //Console.WriteLine("Lütfen Başkent Giriniz: ");
            //capital = Console.ReadLine();

            //if (capital == "Ankara" | capital == "Urfa")

            //{
            //    Console.WriteLine("Başkent Mevcut");

            //}
            //else
            //{
            //    Console.WriteLine("Başkent Mevcut Degil");
            //}

            //---------------------------------------------------

            //Console.Write("Lütfen Kullanıcı Adınızı Giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.Write("Bu kullanıcı adı kabul edilemez: ");
            //}
            //else
            //{
            //    Console.Write("Hoşgeldiniz: ");
            //}

            #endregion

            #region  //Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //------------------------------------------

            //Console.Write("Lütfen 1.Sayıyı Giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sayıyı Giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());
            //int result = number1 % number2;

            //Console.Write("1.sayının , 2.sayıya bölümünden kalan: " + result);

            //------------------------------------------

            //Console.WriteLine("Lütfen Sayıyı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("Sayı Çifttir");
            //}
            //else
            //{
            //    Console.Write("Sayı Tektir");
            //}

            //------------------------------------------

            //char team;
            //Console.Write("Lütfen Takım Sembolünüzü Giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' || team == 'G') // || "veya" anlamına gelir.
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //else if (team == 'f' || team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //else if (team == 'b' || team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            //else
            //{
            //    Console.WriteLine("Takım Tutmuyor");
            //}

            //------------------------------------------






            #endregion


            #region //Örnek proje uygulamaları

            //Console.WriteLine("***** ^C# Egitim Kampı Restoran *****");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Corbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İcecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine();


            //string menuItem;
            //Console.Write(" Detayının Görmek İstediginiz Menü Seçimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Ana Yemekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine("------------Ana Yemekler------------");
            //    Console.WriteLine();

            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Corbalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Corbası");
            //    Console.WriteLine("2-Ezogelin Corbası");
            //    Console.WriteLine("3-Tavuk Corbası");
            //    Console.WriteLine("4-Domates Corbası");
            //    Console.WriteLine("5-Kelle Paca Corbası");
            //    Console.WriteLine("------------Corbalar------------");
            //    Console.WriteLine();

            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Pizzalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margeritta Pizza");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine("4-Bol Malzemeli Pizza");
            //    Console.WriteLine("5-Sucucklu Pizza");
            //    Console.WriteLine("------------Pizzalar------------");
            //    Console.WriteLine();

            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------İcecekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine("4-Limonata");
            //    Console.WriteLine("5-Şalgam");
            //    Console.WriteLine("------------İcecekler------------");
            //    Console.WriteLine();

            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Tatlılar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Trilice");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine("4-Profiterol");
            //    Console.WriteLine("5-Baklava");
            //    Console.WriteLine("------------Tatlılar------------");
            //    Console.WriteLine();

            //}

            #endregion

            #region //Switch Case

            //Console.Write("Lütfen Ay Girişi Yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    default: Console.Write("Hatalı Veri Girişi"); break ;
            //}

            #endregion

            #region // Switch Case Kullanarak Hesap Makinması Yapma

            //int number1, number2, result;
            //char symbol;
            //Console.Write("1.Sayıyı Giriniz: ");
            //number1 = int .Parse(Console.ReadLine());

            //Console.Write("2.Sayıyı Giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütden Yapmak İstediginiz İşlemi Giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Carpım: " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;
            //}

            #endregion


            Console.Read();
        }
    }
}
