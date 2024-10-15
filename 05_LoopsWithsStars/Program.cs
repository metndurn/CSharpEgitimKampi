using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithsStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*burada donguler ile bol bol denemeler yapacagız*/
            #region Alt Alta 10 Tane Yildiz Olusturma

            //for(int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion

            #region Yan Yana 10 Tane Yildiz Olusturma

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}

            #endregion

            #region Alt Alta 10 Tane Yildiz Olusturma Her Satirda 10 Tane Yildiz Olsun

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}

            #endregion

            #region Dik Ucgen Olusturma
            /*burada dık ucgen olustururken ilk for icinde 1'den baslatarak 5'e kadar
            okuttukki ilk yıldızı olusturuyor ve daha sonra 2.ci for olusturuldugunda
           j++ degıskenıne atama yapılıyor yanı once attırılıyor daha sonra i ile j 
           denklestırılıyor ve yildizlar olusmus oluyor*/
            //for (int i = 1; i <= 5; i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ters Dik Ucgen Olusturma

            //for (int i = 5; i >=1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Dik ve Ters Dik Ucgen Beraber Olusturma

            //for(int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for(int k = 4; k >= 1; k--)
            //{
            //    for (int m = 1; m <= k; m++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Baklava Dilimi ve Yildiz Olusturma

            //sembolun üst kısmı
            //int n = 5;
            //for (int i = 1; i <= n; i++) 
            //{
            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            ////sembolun alt kısmı
            //for (int i = n - 1; i >= 1; i--)
            //{
            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Piramit ve Yildiz Olusturma

            //int n = 5;
            //for (int i = 1; i <= n; i++)
            //{
            //    //bosluklar ıcın olusturuldu
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    //yıldızlar ıcın olusturuldu
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion
            
            #region Ters Piramit ve Yildiz Olusturma

            int n = 5;
            for (int i = n; i >= 1; i--)
            {
                //bosluklar ıcın olusturuldu
                for (int j = n - i; j > 0; j--)
                {
                    Console.Write(" ");
                }

                //yıldızlar ıcın olusturuldu
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion
            Console.ReadKey();
        }
    }
}
