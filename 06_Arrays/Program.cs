using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Ornekleri
            //2.4.6.8
            //sari,kirmizi,mavi,turuncu,beyaz
            //adana,istanbul,bingol,bursa
            //Degisken turu [] DiziAdi = new DegiskenTuru[ElemanSayisi]

            //string[] colors = new string[4];
            //colors[0] = "Sari";
            //colors[1] = "Kirmizi";
            //colors[2] = "Mavi";
            //colors[3] = "Beyaz";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Istanbul";
            //cities[1] = "Uskup";
            //cities[2] = "Madrid";
            //cities[3] = "Kahire";
            //cities[4] = "Sofya";

            //Console.WriteLine(cities[4]);

            //cift sayilar disi olusturduk
            /*dizilerde belirtilen alan dısına cıkıldıgı zaman tam sayılarda 0 olarak donus yapar*/
            //int[] number=new int[10];
            //number[0] = 10;
            //number[1] = 50;
            //number[2] = 158;
            //number[3] = 450;
            //number[4] = 24;
            //number[7] = 748;
            //number[9] = 78;

            //Console.WriteLine(number[6]);

            /*dizilerde farklı bir yontem daha vardır oda soyledir dizi eleman sayısı belirtilmeden yazılabılınir*/

            //string[] cities = new string[] { "Istanbul", "Bursa", "Prag", "Madrid", "Bingol", "Lyon" };
            //Console.WriteLine(cities[4]);

            #endregion

            #region Dizideki Tum Elemanlari Listele
            /*dizilerle beraber for dongusu kullanımı*/
            //string[] colors = { "Beyaz", "Kirmizi", "Sari", "Turuncu", "Mavi", "Pempe", "Yesil", "Mor" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            /*dizide butun yapıları kullanabılırız mesela degıskenler karar yapıları yazdırma komutları dongulerı*/

            //int[] numbers = { 4, 85, 96, 75, 125, 635, 438, 522, 7456, 2365, 1120 };//dizi belirlendi

            //for(int i=0; i < numbers.Length; i++)//for yapısı kullanıldı
            //{
            //    if (numbers[i] % 3 == 0)//for icinde if kullanılarak sart saglandi ve 3'e bolumunden kalanlar ekrana yazdırıldı
            //    {
            //        Console.WriteLine(numbers[i]);//sart saglandi ve 3'e bolumunden kalanlar ekrana yazdırıldı
            //    }
            //}

            /*dizilerde char degiskenide kullanılabilinir ornegi asagıdadır*/

            //char[] symbol = { 'a', 'b', 'c', '*', '/', '-' };
            //for(int i = 0; i < symbol.Length; i++)
            //{
            //    Console.WriteLine(symbol[i]);
            //}

            ///*dizideki en buyuk elemanı bulan sayıyı bulalım*/
            //int[] myArray = { 45, 78, 50, 100, 845, 654, 25, 65, 999 };//dizi degerleri verildi
            //int maxNumber = myArray[0];//maxdegisken olusturulup dizi ataması yapıldı

            //for (int i = 1; i < myArray.Length; i++)//dongu ıcınde dizinin max degeri istendi
            //{
            //    if (myArray[i] > maxNumber)//if ile sart kosulup degerler karsılastırıldı
            //    {
            //        maxNumber = myArray[i];//maxnumber'a myArray'den ustune atama yapıldı ve sonuc ekrana basıldı
            //    }
            //}
            //Console.WriteLine(maxNumber);//sonuc ekrana basıldı

            /*dizi metodlari kullanalım orneklerde length kullanalım*/
            //string[] persons = { "Metin", "Sadiye", "Meryem", "Halime", "Muhammed Asaf", "Mehmet" };
            //Console.WriteLine(persons.Length);

            /*dizi metodları short kullanımı Array.Short(yazılması gereken alandır) kucukten buyuge sıralama yapar*/
            //int[] numbers = { 15, 45, 50, 78, 98, 25, 10, 30, 65, 5 };
            //Array.Sort(numbers);
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            /*dizi metodları revers kullanımı Array.revers(yazılması gereken alandır) diziyi tersten sıralama yapar*/
            //int[] numbers = { 15, 45, 50, 78, 98, 25, 10, 30, 65, 5 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region Dizi Metodlari

            //string[] customers = { "Metin", "Sadiye", "Meryem", "Halime", "Muhammed Asaf", "Mehmet" };
            //int index = Array.IndexOf(customers, "Halime");
            //Console.WriteLine(index);

            //int[] numbers = { 10, 22, 45, 78, 65, 80, 95, 36 };
            //Console.WriteLine("Dizinin En Buyuk Elemani: " + numbers.Max()
            //    + " " + "Dizinin En Kucuk Elemani: " + numbers.Min());
            #endregion

            #region Kullanicidan Deger Alma Dizi Kullanarak

            //string[] cities = new string[5];
            //for(int i=0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lutfen {i + 1}. Sehri Giriniz..:");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("---------------------");

            //for(int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            /*tam sayı dizisi olusturulup hepsinin toplamını yapalım*/

            //int[] numbers = { 10, 25, 45, 74, 85 };
            //int sum = 0;
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            /*dizi icindeki sayıları tek ve cıft olarak ayıran uygulamayı yapalım liste halinde*/

            int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 };
            Console.WriteLine("Cıft Sayılar");
            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            Console.WriteLine("--------");
            Console.WriteLine();
            Console.WriteLine("Tek Sayılar");
            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            Console.WriteLine("--------");

            #endregion
            Console.Read();
        }
    }
}
