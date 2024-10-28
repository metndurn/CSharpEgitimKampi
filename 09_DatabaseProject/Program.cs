using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
	internal class Program
	{
		static void Main(string[] args)
		{
            //Ado.net

            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Lütfen Getirmek İstediğiniz Tablo Numarasını Giriniz: ");
            tableNumber = Console.ReadLine();
			Console.WriteLine("------------------------------");

            /*sqlconnection ile veri tabanımın baglantısını olusturdum*/
            SqlConnection connection = new SqlConnection("Data Source = .; initial Catalog = EgitimKampiDb; integrated security = true");
            //connection.open ile baglantımı actım
            connection.Open();
            /*sqlcommand ile command adında degisken nesnesi olusturup veri tabanımdaki verileri
             listelemesini istedim ve connection yazılacak ki istenilen tablo sorunsuz gelsin*/
            SqlCommand command = new SqlCommand("Select * From TblCategory", connection);
            /*sqldataadapter'dan adapter dekiskeni olusturup nesne turettık daha sonra burada
             (command) geklenip gelmesini istedik*/
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            /*datatable ile de yeni nesne turettık*/
            DataTable dataTable= new DataTable();
            //datatable'daki verileri adapter.fill'a aktarıp foreach yapısı ile listeleme yaprıracagız
            adapter.Fill(dataTable);
            //connection.close ile baglantı kesilecektir
            connection.Close();
            /*yukarıdaki yapılan butun ıslemlerı burada dogru duzgun lislenmesini saglamaya
             calistik datatable içinde ki butun row'lari getirsin yani veri tabanı icindeki
            istenilen tablodan butun sütunların eksiksiz gelmesini istedik*/
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString() + " ");
                }
                Console.WriteLine();
            }

			Console.Read();
		}
	}
}
