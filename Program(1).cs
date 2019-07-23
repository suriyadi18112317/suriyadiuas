using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectProduk
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek produk
        static List<Produk> daftarProduk = new List<Produk>();
        private static Produk prod;

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahProduk();
                        break;

                    case 2:
                        HapusProduk();
                        break;

                    case 3:
                        TampilProduk();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            Console.WriteLine("1. Tambah Produk");
            Console.WriteLine("2. Hapus Produk");
            Console.WriteLine("3. Tampilkan Produk");
            Console.WriteLine("4. Keluar");
        }

        static void TambahProduk()
        {
            Console.Clear();
            prod = new Produk();
            Console.Title = "Tambah Data Produk";
            
            Console.Write("Kode Produk : ");
            prod.kode = Console.ReadLine().ToString();
            Console.Write("Nama Produk : ");
            prod.nama = Console.ReadLine().ToString();
            Console.Write("Harga Beli : ");
            prod.beli = Convert.ToInt32(Console.ReadLine());
            Console.Write("Harga Jual : ");
            prod.jual = Convert.ToInt32(Console.ReadLine());

            daftarProduk.Add(prod);
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusProduk()
        {
            Console.Clear();

            Console.Title = "Hapus Data Produk";

            Console.Write("Kode Produk : ");
            string kodep = Console.ReadLine().ToString();

            var itemRemove = daftarProduk.SingleOrDefault(r => r.kode == kodep);
            if (itemRemove == null)
            {
                Console.WriteLine("Kode Produk Tidak Ditemukan");
            }
            else
            {
                daftarProduk.Remove(itemRemove);
                Console.WriteLine(" ");
                Console.WriteLine("Data Produk Berhasil Ditemukan");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilProduk()
        {
            Console.Clear();

            int noUrut = 1;
            Console.Title = "Data Produk";

            foreach(Produk produk in daftarProduk)
            {
                Console.WriteLine("{0},{1},{2},{3},{4}", noUrut, produk.kode, produk.nama, produk.beli, produk.jual);
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
