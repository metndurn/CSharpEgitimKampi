using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Dongusu

            /*donguler programlamada bu sekılde kodlar yazılmaz 1+2+3+4+5+6 
             * bu sekılde yazılırsa normal toplama gibi dusunulur ama programlarda
             * dogru kullanım olmayacaktır
             
            3+3=6+4=10+5=15+6=21
            bu sekılde oldugu zaman sistem toplamaya odaklanır ve sistem dogru calısmaz
            
            for yapısı su sekıldedır for (x;y;z)
            burada 
            x: baslangıc degeridir ve onu tutar
            y: bitis degerini tutar
            z: artis veya azalis degerini tutar
            parantez icinede kodları yazıp program calısır hale getırılır
             */

            /*ekrana 5 kere yazdırdık*/
            //int i;
            //for (i = 1; i <=5; i++) 
            //{
            //    Console.WriteLine("C# Egitim Kampi:");
            //}

            /*ekrana 1 den 20 kadar kucukten buyuge sıralı olacak sekılde yazdırdık*/
            //for (int i = 1; i <=20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            /*burada sayıları 3'lü halde yazdırmasını sagladık yani ekrana 3,6,9 seklınde yazacaktır*/
            //for (int i = 3; i <= 50; i +=3)
            //{
            //    Console.WriteLine(i);
            //}

            /*burada ekranda kullanıcıdan girdiler yaptırarak ekrana yazdırdık*/
            //Console.Write("Lutfen ekrana yazilmasini istediginiz adedi yaziniz.: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for(int i=1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yasasin Devleti Aliyye.: ");
            //}


            #endregion

            #region For Dongusu Ile Karar Yapilari
            /*burdaki dongude 1 ile 100 arasındaki sayılardan 5'e tam bolunen
             sayıları bulalım*/
            //for (int i = 1; i <= 100; i++)//1'den 100 kadar sayılar verıldı 
            //{
            //    if (i % 5 == 0)//verilen sayılar 5'e bolumunden kalanı verır
            //    {
            //        Console.WriteLine(i);//ekrana yazdırılır
            //    }
            //}

            /*1 ile 10 arasındaki ardısık sayıları toplayan uygulama*/

            //int totalValue = 0;
            //for(int i=1; i <= 10; i++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);

            /*burda 1 ile 20 arasında ki cift sayıların toplamını bulan uygulama*/

            //int totalValue = 0;
            //for(int i = 1; i <= 20; i++)
            //{
            //    if (i % 2 == 0)//sayının 2'ser 2'ser toplanarak ekrana yazdırılır ve daha sonra toplamı yazıldı
            //    {
            //        totalValue += i;//toplam yazıldı
            //        Console.WriteLine(i);//her seferinde i degiskeni ekrana yazılacak
            //    }
            //}
            //Console.WriteLine("------");
            //Console.WriteLine(totalValue);//inttin degeri toplanıp buraya yazıldı

            //int count = 0;
            //for (int i = 1; i <= 50; i++) 
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            /*her saat bası olusan bakteri mıktarını bulan kodu yazdık
             * yani 1.ci saatte 2 tane 2.ci satte 4 tane oldugu varsayılarak bulunur
             * 1-2-4-8-16-...*/

            //int bacterium = 1;
            //for(int i=1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ".Saat Sonunda: " + bacterium);
            //}

            #endregion

            #region While Dongusu

            /*while dongusu şu sekıldedır 
            While(sart)
            {
            islemler yapılır
            }
            bitis
            */

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Donguler..:");
            //    i++;
            //}


            /*1 ile 10 arasında 3 bolunen tam sayıları bulalım*/

            //int count = 1;
            //while (count <= 10)
            //{
            //    if (count % 3 == 0)
            //    {
            //        Console.WriteLine(count);
            //    }
            //    count++;
            //}

            /*1 ile 10 arasındaki sayıların toplamını bulduk*/
            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);
            #endregion

            #region Ornek Sınav Sorusu

            /*Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan
             kodu yazınız mesele 456 yazıldı bunların toplamını bulacaksın*/

            //456

            Console.Write("Lutfen Sayıyı Giriniz.:");
            int number=int.Parse(Console.ReadLine());
            int ones, tens, hundreds, sum;

            ones = number % 10;
            tens = (number % 100) / 10;
            hundreds = number / 100;//4.56 --> sadece 4 olanı verecek 56 vermeyecek

            Console.WriteLine(ones + "-" + tens + "-" + hundreds);

            sum = ones + tens + hundreds;
            Console.WriteLine(sum);

            #endregion
            Console.ReadKey();
        }
    }
}
