using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            /*foreach yapısı soyledir ve 4 tane parametre alır foreach(1;2;3;4)
             kısmı olarak bıldıgımız for dongusunede benzıyor*/
            //1.ci parametre degisken turunu alır
            //2.ci parametre Dekiskenin adini alır
            //3.cu parametre ingilizcede in anlamına gelen turkcede icinde kısmını alır
            //4.cu listeleri, koleksıyonları, dizileri alır.

            //dizi ile sehirleri olusturup foreach ile ekranda gosterelım

            //string[] cities = { "Istanbul", "Ankara", "Bingol", "Lyon", "Milano", "Roma", "Budapeste" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            /*aritmatik islemlere icinde kullanabılırız*/

            //int[] numbers = { 100, 245, 850, 745, 785, 985, 1520, 6541, 1234, 123456, };
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            /*dizilerde cift sayıları bulan kodu yazalım*/

            //int[] numbers = { 100, 245, 850, 745, 785, 985, 1520, 6541, 1234, 123456, };
            //foreach (int number in numbers)
            //{
            //    if (number%2 == 0)//burada 0 olunca cift sayıları verir 1 yazınca tek sayıları verır unutma
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            /*dizideki elemanların toplam sayısını bulalım*/

            //int[] numbers = { 100, 245, 850, 745, 785, 985, 1520, 6541, 1234, 123456, };

            //int total = 0;

            //foreach (int number in numbers)
            //{
            //    total += number;
            //}
            //Console.WriteLine(total);

            /*list koleksıyonuda kullanılabılır liste dizisi tutarken tek basına olmaz foreach kullanarak gosterırız*/

            //List<int> numbers = new List<int>
            //{
            //    1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            /*yazılan kelımeyı char ile harf harf gosterelım*/

            //string word = "Merhaba";

            //foreach(char k in word)//word'deki degeri chara aktarıp harf halinde listeledik
            //{
            //    Console.WriteLine(k);
            //}

            #endregion

            #region Ornek Sinav Sistemi Uygulamasi

            Console.Write("***** C# Egitim Kampi Sinav Uygulamasi *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Siniftaki Ogrenci Sayisini Kullanicidan Alma
            Console.WriteLine("------------------------------");
            Console.Write("Sinifinizda Kac Ogrenci Var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");

            //Ogrenci İsimlerini Ve Not Ortalamalarini Saklayacak Diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            //her ogrenci icin notları toplayan for dongusu yapılacak
            for(int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. ogrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;//toplam sınav sonuclarını tutmak ıcın var

                //Her Ogrenci Icın 3 Sinav Notu Girisi

                for(int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli ogrencinin {j + 1}. sinav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;//notlari topluyoruz.
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;//toplam degerin 3'e bolumunden kalanı yazar
            }

            //Sinav Ortalamalari
            for(int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine($"{studentNames[i]} isimli ogrencinin ortalamasi: {studentExamAvg[i]}");

                //Ogrencilerin Ortalamasi Ve Gecip Kalma Durumlari
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} isimli ogrenci dersi gecti: ");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} isimli ogrenci dersten kaldi: ");
                }
                Console.WriteLine("---------------------");
            }

            #endregion

            Console.Read();
        }
    }
}
