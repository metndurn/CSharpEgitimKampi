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
			#region Void Methodlar

			/*bir yapının method olup olmadıgını analamak icin sonuna () bu ısaret
			 mutlaka konulmalı mesela Console.WriteLine() bir methodtur*/
			/*Geriye Deger Dondurmeyen Methodlar ornek olarak veri tabanı islemleri yapıldıgı zaman
			 Customer --> Listeleme, Ekleme, Silme, Guncelleme, bunları bır kere yazarız
			daha sonra bunları cagırırız tekrardan aynısını yazmaya gerek duymayız*/
			//Void olarak yazılır geriye deger dondurmez

			//void CustomerList()//musteriler adında method olusturup ıcını doldurduk
			//{
			//	//musterı ısımlerı burada yazıldı
			//             Console.WriteLine("Metin Duran: ");
			//             Console.WriteLine("Meryem Duran: ");
			//             Console.WriteLine("Bunyamin Duran: ");
			//             Console.WriteLine("Hakan Duran: ");
			//         }
			//CustomerList();//yukarıda void olarak yazdıgımız musterıler methodu ekrana yazdırdık kac kere bunu cagırırsak o kadar gelır
			//CustomerList();//yukarıda void olarak yazdıgımız musterıler methodu ekrana yazdırdık kac kere bunu cagırırsak o kadar gelır
			//CustomerList();//yukarıda void olarak yazdıgımız musterıler methodu ekrana yazdırdık kac kere bunu cagırırsak o kadar gelır
			//CustomerList();//yukarıda void olarak yazdıgımız musterıler methodu ekrana yazdırdık kac kere bunu cagırırsak o kadar gelır

			//void sum()//toplama islemi yaptırdık
			//{
			//	//toplanacak kodlar asagıda yazıldı
			//	int x = 1;
			//	int y = 2;
			//	int z = x + y;//toplama yapıldı
			//             Console.WriteLine(z);//ekrana basıldı
			//         }
			//sum();//yazılan method ekranada gorunmesı ıcın verılen ısım cagırıldı

			#endregion

			#region Geriye Deger Dondurmeyen String Parametreli Methodlar

			//void WriteMethod(string customerName)
			//{
			//	Console.WriteLine(customerName);
			//}
			//WriteMethod("Metin Duran");

			//musterı card olusturma parametreli
			//void customerCard(string name, string surName)
			//{
			//	Console.WriteLine("Musterı: " + name + " " + surName);
			//}
			//customerCard("Metin","Duran");
			//customerCard("Meryem","Duran");



			#endregion

			#region Geriye Deger Dondurmeyen int Parametreli Methodlar

			//void sum(int number1, int number2, int number3)
			//{
			//	int result=number1+number2+number3;
			//	Console.WriteLine(result);
			//}
			//sum(4, 5, 6);

			#endregion

			#region Geriye Deger Donduren Methodlar
			/*geriye deger donduruldugu zaman bunlar degiskenler, koleksiyonlar
			 listeler olabilir burada void olmadan yazacagız methodun turune bizler
			karar veriyoruz*/

			//string customerName()//degiskenli method tanmladık
			//{
			//	return "Metin Duran";//geriye return ile verilen degeri istedık
			//}
			//customerName();//methodu gerı cagırdık ama ekrana basma olmadıgı ıcın bos gelecektır

			/*ogrenci cardli method kullanımı geriye deger donduren*/
			//string StudentCard()
			//{
			//	string name = "Metin";
			//	string surname = "Duran";
			//	return name + " " + surname;
			//}
			//Console.WriteLine(StudentCard());


			#endregion

			#region Geriye Deger Donduren String Parametreli Methodlar

			/*Kullanıcıdan deger aldırıp yazdırdık ve ekstra olarakkendimizde en altta deger verıp ekranda gosterdık*/
			//string CountryCard(string countryName, string capital, string flagColor)
			//{
			//	string CardInfo = " Ulke:" + countryName + " - Baskent: " + capital + " - Bayrak Rengi " + flagColor;
			//	return CardInfo;
			//}
			//string Ulke, Baskent, BRengi;
			//Console.Write("Ulke Adini Giriniz.:");
			//Ulke = Console.ReadLine();

			//Console.Write("Baskent Adini Giriniz.:");
			//Baskent = Console.ReadLine();

			//Console.Write("Bayrak Rengini Giriniz.:");
			//BRengi = Console.ReadLine();

			//Console.WriteLine(CountryCard(Ulke, Baskent, BRengi));

			////kod uzerınden ekrana yazı yazdırıp gosterdık
			//Console.WriteLine(CountryCard("Turkiye", "Ankara", "Kirmizi-Beyaz"));

			#endregion

			#region  Geriye Deger Donduren Int Parametreli Methodlar

			//int Sum(int number1,int number2)
			//{
			//	int result=number1+number2;
			//	return result;
			//}
			//Console.WriteLine(Sum(45,98));
			//Console.WriteLine(Sum(36,25));
			//Console.WriteLine(Sum(44,36));
			//Console.WriteLine(Sum(14,20));

			#endregion

			#region Ornek Uygulama

			/*ogrencinin girmis oldugu sınavları ve ortalamasını alarak gecıp gecmedigini
			 ogrenmis olduk*/
			string ExamResult(string student, int exam1, int exam2, int exam3)
			{
				int result = (exam1 + exam2 + exam3) / 3;
				if (result >= 50)
				{
					return student + " - " + "Isimli Ogrenci Sinavi Gecti " + "Ortalama: " + result;
				}
				else
				{
					return student + " - " + "Isimli Ogrenci Sinavi Gecemedi " + "Ortalama: " + result;
				}
			}
            Console.WriteLine(ExamResult("Metin",45,75,80));
            Console.WriteLine(ExamResult("Meryem",35,75,60));
            Console.WriteLine(ExamResult("Mehmet",45,40,70));
            Console.WriteLine(ExamResult("Ayse",45,50,80));

			#endregion
			Console.Read();
		}
	}
}
