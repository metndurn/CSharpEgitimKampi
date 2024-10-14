using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region If Else
            /*if else te ilk basta if te yazılan kodlar dogruysa okey yok yanlış ise
             else kısmına gırer*/

            //Console.Write("Lutfen Şifrenizi Giriniz..:");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else 
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            /*ülke ve baskent verilerini kullanıcıdan aldırıp if else kullanarak
             ekrana cıktı olarak verdirdik*/
            //string capital, country;

            //Console.Write("Başkenti Giriniz..:");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz..:");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("veriler doğrulandı.:");
            //}
            //else
            //{
            //    Console.WriteLine("hatalı bilgi..:");
            //}

            /*int degisken kullanarak if else kullanımını gördük*/
            //int number;

            //Console.Write("Sayıyı Giriniz..:");
            //number=int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı Doğru.:");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Yanlış..:");
            //}

            //int exam1, exam2, exam3, average;
            ///*buradaki string if ve else yapısındaki kodların ıcıne gırmezse calısacaktır*/
            //string result = "Hata!";

            //Console.Write("Sınav1: ");
            //exam1=int.Parse(Console.ReadLine());

            //Console.Write("Sınav2: ");
            //exam2=int.Parse(Console.ReadLine());

            //Console.Write("Sınav3: ");
            //exam3 =int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Ortalama Sonucun.:" + average);

            //if (average > 0 & average <= 49)
            //{
            //    result = "Sonuc Vasat.:";
            //}
            //if (average > 50 & average <= 69)
            //{
            //    result = "Sonuc Orta.:";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuc İyi.:";
            //}
            //if (average > 84)
            //{
            //    result = "Sonuc Çok İyi.:";
            //}

            //Console.WriteLine(result);

            /*if else'te | karakterini kullanmayı gorduk veya karakteri if'in icinde ki sonucları dondurup
             gosterıyor*/
            //string city;
            //Console.WriteLine("Lütfen Şehir Girişi Yapınız.:");
            //city = Console.ReadLine();

            //if (city == "istanbul" | city == "ankara" | city == "bursa" | city == "bingöl")
            //{
            //    Console.WriteLine("Şehir Mevcut.:");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir Mevcut Değil.:");
            //}

            //kullanıcıdan isim aldırıp dogru olup olmadıgını teyıt ettırıp oyle gırıs yaptırdık
            //Console.Write("Lütfen Kullanıcı Adınızı Giriniz..:");
            //string username=Console.ReadLine();
            //if (username!="admin")
            //{
            //    Console.Write("Bu Kullanıcı Adı Kabul Edilemez..:");
            //}
            //else
            //{
            //    Console.Write(username + " " + "Hoş Geldiniz..:");
            //}

            //Console.ReadKey();
            #endregion

            #region Mod İslemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            /*klavyeden donusum alarak kod yazdırma*/
            //Console.Write("Lütfen 1.Sayıyı Giriniz..:");
            //int number1 = int.Parse(Console.ReadLine());//klavyeden donusum aldırdık

            //Console.Write("Lutfen 2.Sayıyı Giriniz..:");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.WriteLine("1.Sayının 2.Sayıya Bölümünden Kalan.: " + result);

            /*bunları if icinde bir sayının tek mı cıft mı oldugunu bulan programı yazalım*/
            //Console.Write("Lutfen Bir Sayı Girin.:");
            //int number = int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.Write("Sayı Cifttir.:");
            //}
            //else
            //{
            //    Console.Write("Sayı Tektir.:");
            //}
            #endregion

            #region Char Degiskenler ile karar yapıları
            /*harflere göre verilen takımları bulma programı yapalım mesela kucuk veya buyuk g + G gelirse 
             galatasaray olacak f + F olursa fenerbahce b + B olursa besiktas olacak burada char degiskeni kullanılacak*/
            //char team;
            //Console.Write("Lutfen takım sembolu giriniz.:");
            //team=char.Parse(Console.ReadLine());
            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //if (team == 'g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Besiktas");
            //}

            #endregion

            #region Örnek Proje Uygulaması
            /*ornek uygulama menu olacak yemek secım menusu olacak kategoriler olacak simdiye kadar kullanılan 
            // hersey bu uygulamada olacaktır bun degiskenler yazdırma komutları if else'lerde olacaktır*/
            //Console.WriteLine("***** C# Egitim Kampı Restoran *****");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Corbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-Icecekler");
            //Console.WriteLine("5-Tatlilar");
            //Console.WriteLine("------------------------------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.Write("Detayini gormek istediginiz menu secimi:");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Ana Yemekler ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kori Soslu Tavuk");
            //    Console.WriteLine("1-Kizartma Tabagi");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Firinda Somon");
            //    Console.WriteLine("5-Patlican Musakka");
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Ana Yemekler ----------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Corbalar ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Corbasi");
            //    Console.WriteLine("1-Ezogelin Corbasi");
            //    Console.WriteLine("3-Tarhana Corbasi");
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Corbalar ----------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Pizzalar ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("1-Tavuklu Pizza");
            //    Console.WriteLine("3-Sebzeli Pizza");
            //    Console.WriteLine("4-Margaritha Pizza");
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Pizzalar ----------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Icecekler ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("1-Ayran");
            //    Console.WriteLine("3-Gazoz");
            //    Console.WriteLine("4-Su");
            //    Console.WriteLine("5-Soda");
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Icecekler ----------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Tatlilar ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Tralice Tatlisi");
            //    Console.WriteLine("1-Kazandibi Tatlisi");
            //    Console.WriteLine("3-Sutlac Tatlisi");
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Tatlilar ----------");
            //    Console.WriteLine();
            //}
            //Console.ReadKey();

            #endregion

            #region Switch Case

            //Console.Write("Lutfen Ay Girisi Yapiniz.: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Agustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı Veri Girişi.:"); break;
            //}
            #endregion

            #region Switch Case Hesap Makinesi Uygulamasi

            int number1, number2, result;
            char symbol;

            Console.Write("1.Sayiyi Girin.:");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("2.Sayiyi Girin.:");
            number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("lutfen Yapmak Istediginiz Islemi Girin.: - + * / ");
            symbol = char.Parse(Console.ReadLine());
            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("Toplam: " + result);
                    break;
                case '-':
                    result = number1 - number2;
                    Console.WriteLine("Cıkarma: " + result);
                    break;

                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Carpma: " + result);
                    break;
                case '/':
                    result = number1 / number2;
                    Console.WriteLine("Bolme: " + result);
                    break;

                default:
                    break;
            }

            #endregion
            Console.ReadKey();
        }
    }
}
