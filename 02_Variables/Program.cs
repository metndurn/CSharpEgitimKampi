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
            #region Double Degiskenler
            //kodlama tarafında nokta koyulur program calısma esnasında virgul ılr gosterılır
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            /*ornek calisma meyve sebze fiyatlarinin gramajlari olsun ve bunlari birbirleriyle carpip
             tolayip kucuk bir cikti olusturalim*/

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();
            ////double degiskene isim atamasi yapıldı
            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            ////atanan isimlere degerleri atandi
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            ////atamasi yapılan degerler ekrana yazdırıldı ve eklenti ile tl para birimi eklendi
            //Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("----- Elmanın Birim Fiyati: " + applePrice + "₺");
            //Console.WriteLine("----- Portakalın Birim Fiyati: " + orangePrice + "₺");
            //Console.WriteLine("----- Çileğin Birim Fiyati: " + strawberryPrice + "₺");
            //Console.WriteLine("----- Patatesin Birim Fiyati: " + potatoPrice + "₺");
            //Console.WriteLine("----- Tomatesin Birim Fiyati: " + tomatoPrice + "₺");

            //Console.WriteLine();
            //Console.WriteLine();

            ///*alınmak ıstenen kolılar belırlenıyor*/
            //double appleGram, orangeGram, strawberryGram,potatoGram,tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = applePrice * appleGram;
            //double orangeTotalPrice = orangePrice * orangeGram;
            //double strawberryTotalPrice = strawberryPrice * strawberryGram;
            //double potatoTotalPrice = potatoPrice * potatoGram;
            //double tomatoTotalPrice = tomatoPrice * tomatoGram;

            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyatı: " + applePrice +
            //    " - Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice + " ₺ ");
            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyatı: " + orangePrice +
            //    " - Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice + " ₺ ");
            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyatı: " + strawberryPrice +
            //    " - Gramaj: " + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice + " ₺ ");
            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyatı: " + potatoPrice +
            //    " - Gramaj: " + potatoGram + " - Toplam Tutar: " + potatoTotalPrice + " ₺ ");
            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyatı: " + tomatoPrice +
            //    " - Gramaj: " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice + " ₺ ");

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingTotalPrice + " ₺ ");
            #endregion

            #region Char Degiskenler
            //tek bir karakter kullanmak için kullanılır
            //ABCDEFGH
            //DEF....
            //TOPLANTI YARIN SAAT 20:00'DE
            //("A") ÇİFT TIRNAK KULLANILMAZ HER ZAMAN TEK TIRNAK KULLANILIR ('A')

            //char symbol;
            //symbol = 'A';

            //Console.WriteLine(symbol);


            #endregion

            #region Klavyeden Veri Girisleri String Degiskenler

            /*bır havayolu sirketi icin musterının bilet bılgılerını alacagız*/

            //Console.WriteLine("***** Karliova Hava Yollari Yolcu Bilgisi *****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerCity, passengerDistrict, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı:");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı:");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Şehir:");
            //passengerCity = Console.ReadLine();

            //Console.Write("İlçe:");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Yolcu Yaşı:");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu Tc Kimlik No");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("-----------------------");
            //Console.WriteLine(" - Yolcu Adı: " + passengerName + " - Yolcu Soyadı: " + passengerSurname + " - Şehir: " +
            //    passengerCity + " / " + passengerDistrict + " - Yolcunun Yaşı: " + passengerAge + " - Yolcu TC Kimlik No: " + passengerIdentityNumber);
            #endregion

            #region Klavyeden Tam Sayı Girisleri Ve Dönüsümleri

            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;
            //Console.WriteLine("Karlıova Alışveriş Dünyasına Hoş Geldiniz..:");
            //Console.WriteLine();

            //Console.Write("Lutfen Aldığınız Ayakkabı Sayısını Giriniz..:");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lutfen Aldığınız Bilgisayar Sayısını Giriniz..:");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lutfen Aldığınız Sandalye Sayısını Giriniz..:");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lutfen Aldığınız Televizyon Sayısını Giriniz..:");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesPrice * shoesCount + computerPrice * computerCount + chairPrice * chairCount + tvPrice * tvCount;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice);
            #endregion

            #region Klavyeden Ondalikli Sayi Girisleri Ve Donusum İslemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav Notunu Giriniz..:");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav Notunu Giriniz..:");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav Notunu Giriniz..:");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız..: " + result);

            #endregion

            #region Klavyeden Karakter Girisleri 

            char gender;
            Console.Write("Lütfen Cinsiyet Seciniz..:");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Sectiğiniz Cinsiyet: " + gender);

            #endregion
            Console.Read();
        }
    }
}
