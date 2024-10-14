using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdirmaKomutlari

            //Console.WriteLine("Merhaba Dunya");
            //Console.Write("Selam");

            //Console.WriteLine("****** Yemek Kategorileri ******");
            //Console.WriteLine();
            //Console.WriteLine("1- Çorbalar");
            //Console.WriteLine("2- Ana Yemekler");
            //Console.WriteLine("3- Soğuk Başlangıçlar");
            //Console.WriteLine("4- Salatalar");
            //Console.WriteLine("5- İçeçekler");
            //Console.WriteLine("6- Tatlilar");
            //Console.WriteLine();
            //Console.WriteLine("****** Yemek Kategorileri ******");

            #endregion

            #region String Degiskenler

            //string
            //degiskenin_turu degiskenin_adi;

            //string name;
            //name = "Metin";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Metin";
            //customerSurname = "Duran";
            //customerPhone = "90 500 400 30 20";
            //customerEmail = "deneme@gmail.com";
            //district = "Arnavutkoy";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletisim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("------------------------------------------------");

            //Console.WriteLine();

            //customerName = "Meryem";
            //customerSurname = "Duran";
            //customerPhone = "90 500 400 30 20";
            //customerEmail = "test@gmail.com";
            //district = "Gaziosmanpasa";
            //city = "İstanbul";

            //Console.WriteLine("------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletisim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("------------------------------------------------");

            #endregion

            #region İnt Degiskenler

            //int 
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int pizzaPrice = 250;
            int friesPrice = 50;
            int cokePrice = 35;
            int waterPrice = 10;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("----- Hamburger: " + hamburgerPrice + "TL");
            Console.WriteLine("----- Pizza: " + pizzaPrice + "TL");
            Console.WriteLine("----- Kızartma: " + friesPrice + "TL");
            Console.WriteLine("----- Kola: " + cokePrice + "TL");
            Console.WriteLine("----- Su: " + waterPrice + "TL");
            Console.WriteLine("----- Limonata: " + lemonadePrice + "TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();

            int hamburgerCount;
            int pizzaCount;
            int friesCount;
            int cokeCount;
            int waterCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalPizzaPrice;
            int totalFriesPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalLemonadePrice;

            hamburgerCount = 3;
            pizzaCount = 0;
            friesCount = 1;
            cokeCount = 2;
            waterCount = 4;
            lemonadeCount = 3;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + "TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + "TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + "TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + "TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + "TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + "TL");

            int totalPrice = totalHamburgerPrice + totalPizzaPrice + totalFriesPrice + totalCokePrice + totalWaterPrice + totalLemonadePrice;
            Console.WriteLine();
            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + "TL");

            #endregion
            Console.Read();
        }
    }
}
