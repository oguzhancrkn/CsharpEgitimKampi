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
            #region //Double Degişkenler

            //Kod tarafında . ile ayırdıgımız sayılar calıştırılınca , olarak ayrılır.
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + " TL" );
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("---- Patates Birim Fiyatı: " + potatoPrice + " TL");
            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + " TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650 ;
            //strawGram = 0.750 ;
            //potatoGram =  4.859 ;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryPrice * strawGram;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;




            //Console.WriteLine("Alınan Ürün : Elma - " + "Birim Fiyat: " + applePrice + " - Gramaj " + appleGram + " -Toplam Tutar " + appleTotalPrice);
            //Console.WriteLine("Alınan Ürün : Portakal - " + "Birim Fiyat: " + orangePrice + " - Gramaj " + orangeGram + " -Toplam Tutar " + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün : Çilek - " + "Birim Fiyat: " + strawberryPrice + " - Gramaj " + strawGram + " -Toplam Tutar " + strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün : Patates - " + "Birim Fiyat: " + potatoPrice + " - Gramaj " + potatoGram + " -Toplam Tutar " + potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün : Domates - " + "Birim Fiyat: " + tomatoPrice + " - Gramaj " + tomatoGram + " -Toplam Tutar " + tomatoTotalPrice);


            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutar:" + shoppingTotalPrice + "TL");



            #endregion

            #region //Klavyeden Veri Girişleri String Degişkenler

            //Console.WriteLine("***** Csharp Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı :");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı:");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Yaş Bilgisi: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("Yolcu Tc Kimlik No:" +  passengerIdentityNumber + " - + Yolcu Ad Soyad: " + passengerName + " " + passengerSurname  + " " + passengerDistrict + " " + passengerCity + " " + passengerAge);


            #endregion

            #region //Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen Aldıgınız Ayakkabı Sayısını Giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldıgınız Bilgisayar Sayısını Giriniz:");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldıgınız Sandalye Sayısını Giriniz:");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldıgınız Televizyon Sayısını Giriniz:");
            //tvCount = int.Parse(Console.ReadLine());

            //int tolalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvPrice * tvCount;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + tolalPrice);

            #endregion

            #region //Klavyeden ondalıklı sayı işlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());


            //Console.Write("Lütfen 2.Sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());


            //Console.Write("Lütfen 3.Sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav ortalamanız: " + result);



            #endregion

            #region //Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütden Cinsiyet Seciniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Sectiginiz Cinsiyet: " + gender);


            #endregion


            Console.Read();
        }
    }
}
