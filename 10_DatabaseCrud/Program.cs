using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
	internal class Program
	{
		static void Main(string[] args)

		{
            //Crud islemleri --> Creat, Read, Update, Delete

            Console.WriteLine("***** Menu Siparis Islem Paneli");
            Console.WriteLine();

            Console.WriteLine("-------------------------------");

			#region Kategori Ekleme Islemleri
			//Console.Write("Eklemek Istediginiz Kategori Adi: ");
			//string categoryName = Console.ReadLine();

			//SqlConnection connection = new SqlConnection("Data Source=.;initial catalog=EgitimKampiDb;integrated security=true");
			//connection.Open();
			//SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@kategoriAdi)", connection);
			//command.Parameters.AddWithValue("kategoriAdi", categoryName);
			//command.ExecuteNonQuery();
			//connection.Close();

			//Console.WriteLine("Kategori Basariyla Eklendi.: ");
			#endregion

			#region Urun Ekleme Islemleri

			//string productName;
			//decimal productPrice;
			////bool productSatus

			//Console.Write("Urun Adi: ");
			//productName = Console.ReadLine();
			//Console.Write("Urun Fiyati: ");
			//productPrice = decimal.Parse(Console.ReadLine());

			//SqlConnection connection = new SqlConnection("Data Source=.;initial catalog=EgitimKampiDb;integrated security=true");
			//connection.Open();
			//SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection);
			//command.Parameters.AddWithValue("@productName", productName);
			//command.Parameters.AddWithValue("@productPrice", productPrice);
			//command.Parameters.AddWithValue("@productStatus", true);
			//command.ExecuteNonQuery();
			//connection.Close();
			//Console.WriteLine("Urun Eklemesi Basarili: ");

			#endregion

			#region Urun Listeleme İslemleri

			//SqlConnection connection = new SqlConnection("Data Source=.;initial catalog=EgitimKampiDb;integrated security=true");
			//connection.Open();
			//SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
			//SqlDataAdapter adapter = new SqlDataAdapter(command);
			//DataTable dataTable = new DataTable();
			//adapter.Fill(dataTable);
			//connection.Close();

			//foreach (DataRow row in dataTable.Rows)
			//{
			//	foreach (var item in row.ItemArray)
			//	{
			//		Console.Write(item.ToString() + " ");
			//	}
			//             Console.WriteLine();
			//         }
			#endregion

			#region Urun Silme İslemleri

			//Console.Write("Silinecek Urun Id: ");
			//int productId=int.Parse(Console.ReadLine());

			//SqlConnection connection = new SqlConnection("Data Source=.;initial catalog=EgitimKampiDb;integrated security=true");
			//connection.Open();
			//SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId", connection);
			//command.Parameters.AddWithValue("@productId", productId);
			//command.ExecuteNonQuery();

			//connection.Close();

			//         Console.WriteLine("Silme Islemi Yapildi!");

			#endregion

			#region Urun Guncelleme Islemleri

			Console.Write("Guncellenecek Urun Id: ");
			int productId = int.Parse(Console.ReadLine());

			Console.Write("Guncellenecek Urun Adi: ");
			string productName = Console.ReadLine();

			Console.Write("Guncellenecek Urun Fiyati: ");
			decimal productPrice = decimal.Parse(Console.ReadLine());

			SqlConnection connection = new SqlConnection("Data Source=.;initial catalog=EgitimKampiDb;integrated security=true");
			connection.Open();
			SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName, ProductPrice=@productPrice where ProductId=@productId", connection);
			command.Parameters.AddWithValue("@productName", productName);
			command.Parameters.AddWithValue("@productPrice", productPrice);
			command.Parameters.AddWithValue("@productId", productId);
			command.ExecuteNonQuery();

			connection.Close();

            Console.WriteLine("Guncelleme Basarili!");

            #endregion
            Console.Read();
        }
	}
}
