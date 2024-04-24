using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            while (true)
            {
                try
                {
                    Console.Write("\nKetik K untuk Terhubung ke Database atau E untuk Keluar dari Aplikasi: ");
                    char chr = char.ToUpper(Console.ReadKey().KeyChar);
                    switch (chr)
                    {
                        case 'K':
                            {
                                Console.Clear();
                                
                                string db = "ZOO";
                                SqlConnection conn = null;
                                string strKoneksi = "Data source = LAPTOP-4U8KKFFT\\YUSVANTRIATMOJO; " +
                                    "initial catalog = {0}; " +
                                    "User ID = sa; password = yusvantri12103";
                                conn = new SqlConnection(string.Format(strKoneksi, db));
                                conn.Open();
                                Console.Clear();
                                while (true)
                                {
                                    try
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\nMenu");
                                        Console.WriteLine("1. MASTER");
                                        Console.WriteLine("2. Perawatan");
                                        Console.WriteLine("3. Pemeriksaan");
                                        Console.WriteLine("4. Cetak Riwayat Kesehatan");
                                        Console.WriteLine("5. EXIT");
                                        Console.Write("\nEnter your choice (1-5): ");
                                        char ch = char.ToUpper(Console.ReadKey().KeyChar);
                                        Console.Clear();
                                        switch (ch)
                                        {
                                            case '1':
                                                {
                                                    while (true)
                                                    {
                                                        try
                                                        {
                                                            Console.WriteLine("\nMenu Master ");
                                                            Console.WriteLine("1. HEWAN");
                                                            Console.WriteLine("2. KEEPER");
                                                            Console.WriteLine("3. DOKTER HEWAN");
                                                            Console.WriteLine("4. BACK");
                                                            Console.Write("\nEnter your choice (1-4): ");
                                                            char ch1 = char.ToUpper(Console.ReadKey().KeyChar);
                                                            Console.Clear();
                                                            switch (ch1)
                                                            {
                                                                case '1':
                                                                    {
                                                                        while (true)
                                                                        {
                                                                            try
                                                                            {
                                                                                
                                                                                Console.WriteLine("\nMenu HEWAN");
                                                                                Console.WriteLine("==========");
                                                                                Console.WriteLine("ID Hewan :");
                                                                                Console.WriteLine("Nama Hewan :");
                                                                                Console.WriteLine("Jenis Hewan :");
                                                                                Console.WriteLine("Spesies Hewan :");
                                                                                Console.WriteLine("Jenis Kelamin :");
                                                                                Console.WriteLine("Tanggal Lahir :");
                                                                                Console.WriteLine("Tanggal Lahir :");
                                                                                Console.WriteLine("Umur :");
                                                                                Console.WriteLine("Berat :");
                                                                                Console.WriteLine("\n============");
                                                                                Console.WriteLine("LIST Hewan");
                                                                                Console.WriteLine("============");
                                                                                pr.list(conn);
                                                                                Console.WriteLine("\n============");
                                                                                Console.WriteLine("PILIHAN MENU");
                                                                                Console.WriteLine("============");
                                                                                Console.WriteLine("1. READ");
                                                                                Console.WriteLine("2. INPUT");
                                                                                Console.WriteLine("3. BACK");
                                                                                Console.Write("\nEnter your choice (1-5): ");
                                                                                char ch2 = char.ToUpper(Console.ReadKey().KeyChar);
                                                                                Console.Clear();
                                                                                switch (ch2)
                                                                                {
                                                                                    case '1':
                                                                                        {
                                                                                            Console.Clear();
                                                                                            Console.WriteLine("Data Hewan\n");
                                                                                            Console.WriteLine("Masukkan ID Hewan yang Ingin Dilihat:");
                                                                                            string idH = Console.ReadLine();
                                                                                            try
                                                                                            {
                                                                                                pr.baca(idH, conn);
                                                                                            }
       
                                                                                            catch (Exception e)
                                                                                            {
                                                                                                Console.WriteLine("\nAnda tidak memiliki " +
                                                                                                    "akses untuk melihat data atau Data yang anda masukkan salah");
                                                                                                Console.WriteLine(e.ToString());
                                                                                            }
                                                                                            while(true)
                                                                                            {
                                                                                                try
                                                                                                {
                                                                                                    Console.WriteLine("\n============");
                                                                                                    Console.WriteLine("PILIHAN MENU");
                                                                                                    Console.WriteLine("============");
                                                                                                    Console.WriteLine("1. UPDATE");
                                                                                                    Console.WriteLine("2. DELETE");
                                                                                                    Console.WriteLine("3. BACK");
                                                                                                    Console.Write("\nEnter your choice (1-3): ");
                                                                                                    char ch5 = char.ToUpper(Console.ReadKey().KeyChar);
                                                                                                    Console.Clear();
                                                                                                    switch (ch5)
                                                                                                    {
                                                                                                        case '1':
                                                                                                            {
                                                                                                                Console.Clear();
                                                                                                                Console.WriteLine("Update Data Hewan\n");
                                                                                                                

                                                                                                                // Meminta pengguna memasukkan nama baru
                                                                                                                Console.WriteLine("Masukkan Nama Hewan Baru (biarkan kosong jika tidak ingin mengubah):");
                                                                                                                string nmH = Console.ReadLine();

                                                                                                                // Meminta pengguna memasukkan jenis hewan baru
                                                                                                                Console.WriteLine("Masukkan Jenis Hewan Baru (biarkan kosong jika tidak ingin mengubah):");
                                                                                                                string jsH = Console.ReadLine();

                                                                                                                Console.WriteLine("Masukkan Spesies Hewan Baru (biarkan kosong jika tidak ingin mengubah):");
                                                                                                                string spH = Console.ReadLine();

                                                                                                                Console.WriteLine("Masukkan Jenis kelamin Hewan Baru (biarkan kosong jika tidak ingin mengubah):");
                                                                                                                string jkH = Console.ReadLine();

                                                                                                                Console.WriteLine("Masukkan Tanggal lahir Hewan Baru (biarkan kosong jika tidak ingin mengubah):");
                                                                                                                string tglH = Console.ReadLine();

                                                                                                                Console.WriteLine("Masukkan Tanggal masuk Hewan Baru (biarkan kosong jika tidak ingin mengubah):");
                                                                                                                string tglmH = Console.ReadLine();

                                                                                                                Console.WriteLine("Masukkan Berats Hewan Baru (biarkan kosong jika tidak ingin mengubah):");
                                                                                                                string br = Console.ReadLine();
                                                                                                                try
                                                                                                                {
                                                                                                                    pr.update(idH, nmH, jsH, spH, jkH, tglH, tglmH, br, conn);
                                                                                                                }

                                                                                                                catch (Exception e)
                                                                                                                {
                                                                                                                    Console.WriteLine("\nAnda tidak memiliki " +
                                                                                                                        "akses untuk mengubah data atau Data yang anda masukkan salah");
                                                                                                                    Console.WriteLine(e.ToString());
                                                                                                                }
                                                                                                            }
                                                                                                            break;
                                                                                                        case '2':
                                                                                                            {
                                                                                                                Console.Clear();
                                                                                                                Console.WriteLine("Anda memilih DELETE.");
                                                                                                               
                                                                                                                try
                                                                                                                {
                                                                                                                    pr.delete(idH, conn);
                                                                                                                }
                                                                                                                catch (Exception e)
                                                                                                                {
                                                                                                                    Console.WriteLine("\nAnda tidak memiliki " +
                                                                                                                        "akses untuk melihat data atau Data yang anda masukkan salah");
                                                                                                                    Console.WriteLine(e.ToString());
                                                                                                                }
                                                                                                            }
                                                                                                            break;
                                                                                                        case '3':
                                                                                                            {
                                                                                                                Console.Clear();
                                                                                                                break;

                                                                                                            }
                                                                                                        default:
                                                                                                            {
                                                                                                                Console.Clear();
                                                                                                                Console.WriteLine("\nInvalid option");

                                                                                                            }
                                                                                                            break;
                                                                                                    }
                                                                                                    if (ch5 == '3')
                                                                                                    {
                                                                                                        Console.Clear();
                                                                                                        break;
                                                                                                    }
                                                                                                }

                                                                                                catch (Exception e)
                                                                                                {
                                                                                                    Console.WriteLine("\nAnda tidak memiliki " +
                                                                                                        "akses untuk melihat data atau Data yang anda masukkan salah");
                                                                                                    Console.WriteLine(e.ToString());
                                                                                                }

                                                                                            }
                                                                                                
                                                                                        }
                                   
                                                                                        break;
                                                                                    case '2':
                                                                                        {
                                                                                            Console.Clear();
                                                                                            Console.WriteLine("Input Data Hewan\n");
                                                                                            Console.WriteLine("Masukkan ID Hewan :");
                                                                                            string idH = Console.ReadLine();
                                                                                            Console.WriteLine("Masukkan Nama Hewan :");
                                                                                            string nmH = Console.ReadLine();
                                                                                            Console.WriteLine("Masukkan Jenis Hewan :");
                                                                                            string jsH = Console.ReadLine();
                                                                                            Console.WriteLine("Masukkan Spesies Hewan:");
                                                                                            string spH = Console.ReadLine();
                                                                                            Console.WriteLine("Masukkan Jenis Kelamin Hewan (Betina / Jantan) :");
                                                                                            string jkH = Console.ReadLine();
                                                                                            Console.WriteLine("Masukkan Tanggal Lahir Hewan:");
                                                                                            string tglH = Console.ReadLine();
                                                                                            Console.WriteLine("Masukkan Tanggal Masuk Hewan :");
                                                                                            string tglmH = Console.ReadLine();
                                                                                            Console.WriteLine("Masukkan Berat Hewan :");
                                                                                            string br = Console.ReadLine();

                                                                                            try
                                                                                            {
                                                                                                pr.insert(idH, nmH, jsH, spH, jkH, tglH, tglmH, br, conn);

                                                                                            }
                                                                                            catch (Exception e)
                                                                                            {
                                                                                                Console.WriteLine("\nAnda tidak memiliki " +
                                                                                                    "akses untuk menambah data atau Data yang anda masukkan salah");
                                                                                                Console.WriteLine(e.ToString());
                                                                                            }
                                                                                        }
                                                                                        break;
                                                                                   
                                                                                    case '3':
                                                                                        {
                                                                                            Console.Clear();
                                                                                            break;
                                                                                        }
                                                                                    default:
                                                                                        {
                                                                                            Console.Clear();
                                                                                            Console.WriteLine("\nInvalid option");

                                                                                        }
                                                                                        break;

                                                                                }
                                                                                if (ch2 == '3')
                                                                                {
                                                                                    Console.Clear();
                                                                                    break;
                                                                                }
                                                                            }
                                                                            catch
                                                                            {
                                                                                Console.Clear();
                                                                                Console.WriteLine("\nCheck for the value entered.");
                                                                            }
                                                                        }
                                                                    }
                                                                    break;

                                                                case '2':
                                                                    {
                                                                        while (true)
                                                                        {
                                                                            try
                                                                            {
                                                                                
                                                                                Console.WriteLine("\nMenu KEEPER");
                                                                                Console.WriteLine("===========");
                                                                                Console.WriteLine("ID Keeper :");
                                                                                Console.WriteLine("Nama Keeper :");
                                                                                Console.WriteLine("Alamat Keeper :");
                                                                                Console.WriteLine("Nomor Telepon Keeper :");
                                                                                Console.WriteLine("\n===========");
                                                                                Console.WriteLine("LIST Keeper");
                                                                                Console.WriteLine("===========");
                                                                                pr.list1(conn);
                                                                                Console.WriteLine("\n============");
                                                                                Console.WriteLine("PILIHAN MENU");
                                                                                Console.WriteLine("============");
                                                                                Console.WriteLine("1. READ");
                                                                                Console.WriteLine("2. INPUT");
                                                                                Console.WriteLine("3. BACK");
                                                                                Console.Write("\nEnter your choice (1-5): ");
                                                                                char ch2 = char.ToUpper(Console.ReadKey().KeyChar);
                                                                                switch (ch2)
                                                                                {
                                                                                    case '1':
                                                                                        {
                                                                                            Console.Clear();
                                                                                            Console.WriteLine("Anda memilih READ.");
                                                                                            
                                                                                            Console.WriteLine("Data Keeper\n");
                                                                                            Console.WriteLine("Masukkan ID Keeper yang Ingin Dilihat:");
                                                                                            string idK = Console.ReadLine();
                                                                                            try
                                                                                            {
                                                                                                pr.baca1(idK, conn);
                                                                                            }
                                                                                            catch (Exception e)
                                                                                            {
                                                                                                Console.WriteLine("\nAnda tidak memiliki " +
                                                                                                    "akses untuk melihat data atau Data yang anda masukkan salah");
                                                                                                Console.WriteLine(e.ToString());
                                                                                            }
                                                                                            while(true)
                                                                                            {
                                                                                                try
                                                                                                {

                                                                                                    Console.WriteLine("\n============");
                                                                                                    Console.WriteLine("PILIHAN MENU");
                                                                                                    Console.WriteLine("============");
                                                                                                    Console.WriteLine("1. UPDATE");
                                                                                                    Console.WriteLine("2. DELETE");
                                                                                                    Console.WriteLine("3. BACK");
                                                                                                    Console.Write("\nEnter your choice (1-3): ");
                                                                                                    char ch5 = char.ToUpper(Console.ReadKey().KeyChar);
                                                                                                    Console.Clear();
                                                                                                    switch (ch5)
                                                                                                    {
                                                                                                        case '1':
                                                                                                            {
                                                                                                                Console.Clear();
                                                                                                                Console.WriteLine("Update Data Keeper\n");

                                                                                                                Console.WriteLine("Masukkan Nama Keeper Baru (biarkan kosong jika tidak ingin mengubah):");
                                                                                                                string nmK = Console.ReadLine();

                                                                                                                Console.WriteLine("Masukkan alamat Baru (biarkan kosong jika tidak ingin mengubah):");
                                                                                                                string almtK = Console.ReadLine();

                                                                                                                Console.WriteLine("Masukkan Nomor telpon Baru (biarkan kosong jika tidak ingin mengubah):");
                                                                                                                string tlpK = Console.ReadLine();

                                                                                                                try
                                                                                                                {
                                                                                                                    pr.update1(idK, nmK, almtK, tlpK, conn);
                                                                                                                }

                                                                                                                catch (Exception e)
                                                                                                                {
                                                                                                                    Console.WriteLine("\nAnda tidak memiliki " +
                                                                                                                        "akses untuk mengubah data atau Data yang anda masukkan salah");
                                                                                                                    Console.WriteLine(e.ToString());
                                                                                                                }
                                                                                                            }
                                                                                                            break;
                                                                                                        case '2':
                                                                                                            {
                                                                                                                Console.Clear();
                                                                                                                Console.WriteLine("Anda memilih DELETE.");
                                                                                                               
                                                                                                                try
                                                                                                                {
                                                                                                                    pr.delete1(idK, conn);
                                                                                                                }
                                                                                                                catch (Exception e)
                                                                                                                {
                                                                                                                    Console.WriteLine("\nAnda tidak memiliki " +
                                                                                                                        "akses untuk menghapus data atau Data yang anda masukkan salah");
                                                                                                                    Console.WriteLine(e.ToString());
                                                                                                                }
                                                                                                            }
                                                                                                            break;
                                                                                                        case '3':
                                                                                                            {
                                                                                                                Console.Clear();
                                                                                                                break;
                                                                                                            }
                                                                                                        default:
                                                                                                            {
                                                                                                                Console.Clear();
                                                                                                                Console.WriteLine("\nInvalid option");

                                                                                                            }
                                                                                                            break;
                                                                                                    }

                                                                                                    if (ch5 == '3')
                                                                                                    {
                                                                                                        Console.Clear();
                                                                                                        break;
                                                                                                    }
                                                                                                }
                                                                                                catch (Exception e)
                                                                                                {
                                                                                                    Console.WriteLine("\nAnda tidak memiliki " +
                                                                                                        "akses untuk melihat data atau Data yang anda masukkan salah");
                                                                                                    Console.WriteLine(e.ToString());
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                        break;
                                                                                    case '2':
                                                                                        {
                                                                                            Console.Clear();
                                                                                            Console.WriteLine("Anda memilih INPUT.");
                                                                                           
                                                                                            Console.WriteLine("Input Data Keeper\n");
                                                                                            Console.WriteLine("Masukkan ID Keeper :");
                                                                                            string idK = Console.ReadLine();
                                                                                            Console.WriteLine("Masukkan Nama Keeper :");
                                                                                            string nmK = Console.ReadLine();
                                                                                            Console.WriteLine("Masukkan Alamat Keeper :");
                                                                                            string almtK = Console.ReadLine();
                                                                                            Console.WriteLine("Masukkan Nomor Telepon :");
                                                                                            string tlpK = Console.ReadLine();


                                                                                            try
                                                                                            {
                                                                                                pr.insert1(idK, nmK, almtK, tlpK, conn);

                                                                                            }
                                                                                            catch (Exception e)
                                                                                            {
                                                                                                Console.WriteLine("\nAnda tidak memiliki " +
                                                                                                    "akses untuk menambah data atau Data yang anda masukkan salah");
                                                                                                Console.WriteLine(e.ToString());
                                                                                            }

                                                                                        }
                                                                                        break;
                                                                                
                                                                                    case '3':
                                                                                        {
                                                                                           
                                                                                            Console.Clear();
                                                                                            break;
                                                                                        }
                                                                                        
                                                                                    default:
                                                                                        {
                                                                                            Console.Clear();
                                                                                            Console.WriteLine("\nInvalid option");

                                                                                        }
                                                                                        break;

                                                                                }
                                                                                if (ch2 == '3')
                                                                                {
                                                                                    Console.Clear();
                                                                                    break;
                                                                                }
                                                                            }
                                                                            catch
                                                                            {
                                                                                Console.Clear();
                                                                                Console.WriteLine("\nCheck for the value entered.");
                                                                            }
                                                                        }
                                                                    }
                                                                    break;
                                                                case '3':
                                                                    {
                                                                        while (true)
                                                                        {
                                                                            try
                                                                            {
                                                                                Console.WriteLine("\nMenu DOKTER HEWAN");
                                                                                Console.WriteLine("=================");
                                                                                Console.WriteLine("ID Dokter Hewan :");
                                                                                Console.WriteLine("Nama Dokter Hewan :");
                                                                                Console.WriteLine("Alamat Dokter Hewan :");
                                                                                Console.WriteLine("Nomor Telepon Dokter Hewan :");
                                                                                Console.WriteLine("\n=================");
                                                                                Console.WriteLine("LIST Dokter Hewan");
                                                                                Console.WriteLine("=================");
                                                                                pr.list2(conn);
                                                                                Console.WriteLine("\n============");
                                                                                Console.WriteLine("PILIHAN MENU");
                                                                                Console.WriteLine("============");
                                                                                Console.WriteLine("1. READ");
                                                                                Console.WriteLine("2. INPUT");
                                                                                Console.WriteLine("3. BACK");
                                                                                Console.Write("\nEnter your choice (1-3): ");
                                                                                char ch2 = char.ToUpper(Console.ReadKey().KeyChar);
                                                                                switch (ch2)
                                                                                {
                                                                                    case '1':
                                                                                        {
                                                                                            Console.Clear();
                                                                                            Console.WriteLine("Anda memilih READ.");
                                                                                            Console.Clear();
                                                                                            Console.WriteLine("Data Dokter Hewan\n");
                                                                                            Console.WriteLine("Masukkan ID Dokter Hewan yang Ingin Dilihat:");
                                                                                            string idDH = Console.ReadLine();
                                                                                            try
                                                                                            {
                                                                                                pr.baca2(idDH, conn);
                                                                                            }
                                                                                            catch (Exception e)
                                                                                            {
                                                                                                Console.WriteLine("\nAnda tidak memiliki " +
                                                                                                    "akses untuk melihat data atau Data yang anda masukkan salah");
                                                                                                Console.WriteLine(e.ToString());
                                                                                            }
                                                                                            while(true)
                                                                                            {
                                                                                                try
                                                                                                {
                                                                                                    Console.WriteLine("\n============");
                                                                                                    Console.WriteLine("PILIHAN MENU");
                                                                                                    Console.WriteLine("============");
                                                                                                    Console.WriteLine("1. UPDATE");
                                                                                                    Console.WriteLine("2. DELETE");
                                                                                                    Console.WriteLine("3. BACK");
                                                                                                    Console.Write("\nEnter your choice (1-3): ");
                                                                                                    char ch5 = char.ToUpper(Console.ReadKey().KeyChar);
                                                                                                    Console.Clear();
                                                                                                    switch(ch5)
                                                                                                    {
                                                                                                        case '1':
                                                                                                            {
                                                                                                                Console.Clear();
                                                                                                                Console.WriteLine("Update Data Dokter Hewan\n");

                                                                                                                Console.WriteLine("Masukkan Nama Dokter hewan Baru (biarkan kosong jika tidak ingin mengubah):");
                                                                                                                string nmDH= Console.ReadLine();

                                                                                                                Console.WriteLine("Masukkan alamat Baru (biarkan kosong jika tidak ingin mengubah):");
                                                                                                                string almtDH = Console.ReadLine();

                                                                                                                Console.WriteLine("Masukkan Nomor telpon Baru (biarkan kosong jika tidak ingin mengubah):");
                                                                                                                string tlpDH = Console.ReadLine();

                                                                                                                try
                                                                                                                {
                                                                                                                    pr.update2(idDH, nmDH, almtDH, tlpDH, conn);
                                                                                                                }

                                                                                                                catch (Exception e)
                                                                                                                {
                                                                                                                    Console.WriteLine("\nAnda tidak memiliki " +
                                                                                                                        "akses untuk mengubah data atau Data yang anda masukkan salah");
                                                                                                                    Console.WriteLine(e.ToString());
                                                                                                                }
                                                                                                            }
                                                                                                            break;
                                                                                                        case '2':
                                                                                                            {
                                                                                                                Console.Clear();
                                                                                                                Console.WriteLine("Anda memilih DELETE.");

                                                                                                                try
                                                                                                                {
                                                                                                                    pr.delete2(idDH, conn);
                                                                                                                }
                                                                                                                catch (Exception e)
                                                                                                                {
                                                                                                                    Console.WriteLine("\nAnda tidak memiliki " +
                                                                                                                        "akses untuk menghapus data atau Data yang anda masukkan salah");
                                                                                                                    Console.WriteLine(e.ToString());
                                                                                                                }
                                                                                                            }
                                                                                                            break;
                                                                                                        case '3':
                                                                                                            {
                                                                                                                Console.Clear();
                                                                                                                break;
                                                                                                            }
                                                                                                        default:
                                                                                                            {
                                                                                                                Console.Clear();
                                                                                                                Console.WriteLine("\nInvalid option");

                                                                                                            }
                                                                                                            break;
                                                                                                    }

                                                                                                    if (ch5 == '3')
                                                                                                    {
                                                                                                        Console.Clear();
                                                                                                        break;
                                                                                                    }
                                                                                                
                                                                                                }
                                                                                                catch (Exception e)
                                                                                                {
                                                                                                    Console.WriteLine("\nAnda tidak memiliki " +
                                                                                                        "akses untuk melihat data atau Data yang anda masukkan salah");
                                                                                                    Console.WriteLine(e.ToString());
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                        break;
                                                                                    case '2':
                                                                                        {
                                                                                            Console.Clear();
                                                                                            Console.WriteLine("Anda memilih INPUT.");
                                                                                            
                                                                                            Console.WriteLine("Input Data Dokter Hewan\n");
                                                                                            Console.WriteLine("Masukkan ID Dokter hewan :");
                                                                                            string idDH = Console.ReadLine();
                                                                                            Console.WriteLine("Masukkan Nama Dokter Hewan :");
                                                                                            string nmDH = Console.ReadLine();
                                                                                            Console.WriteLine("Masukkan Alamat Dokter Hewan :");
                                                                                            string almtDH = Console.ReadLine();
                                                                                            Console.WriteLine("Masukkan Nomor Telepon :");
                                                                                            string tlpDH = Console.ReadLine();


                                                                                            try
                                                                                            {
                                                                                                pr.insert2(idDH, nmDH, almtDH, tlpDH, conn);

                                                                                            }
                                                                                            catch (Exception e)
                                                                                            {
                                                                                                Console.WriteLine("\nAnda tidak memiliki " +
                                                                                                    "akses untuk menambah data atau Data yang anda masukkan salah");
                                                                                                Console.WriteLine(e.ToString());
                                                                                            }

                                                                                        }
                                                                                        break;
                                                                                   
                                                                                    case '3':
                                                                                        {

                                                                                            Console.Clear();
                                                                                            break;
                                                                                        }
                                                                                    default:
                                                                                        {
                                                                                            Console.Clear();
                                                                                            Console.WriteLine("\nInvalid option");

                                                                                        }
                                                                                        break;

                                                                                }
                                                                                if (ch2 == '3')
                                                                                {
                                                                                    Console.Clear();
                                                                                    break;
                                                                                }
                                                                            }
                                                                            catch
                                                                            {
                                                                                Console.Clear();
                                                                                Console.WriteLine("\nCheck for the value entered.");
                                                                            }
                                                                        }
                                                                    }
                                                                    break;
                                                                case '4':
                                                                    {
                                                                        Console.Clear();
                                                                        break;
                                                                    }

                                                                case '5':
                                                                    conn.Close();
                                                                    Console.Clear();
                                                                    Main(new String[0]);
                                                                    return;
                                                                default:
                                                                    {
                                                                        Console.Clear();
                                                                        Console.WriteLine("\nInvalid option");
                                                                    }
                                                                    break;
                                                            }
                                                            if (ch1 == '4')
                                                            {
                                                                Console.Clear();
                                                                break;
                                                            }
                                                        }
                                                        catch
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("\nCheck for the value entered.");
                                                        }
                                                    }
                                                }
                                                break;
                                            case '2':
                                                {
                                                    while (true)
                                                    {
                                                        try
                                                        {
                                                              
                                                            Console.WriteLine("\nMenu Perawatan");
                                                            Console.WriteLine("==============");
                                                            Console.WriteLine("ID Perawatan :");
                                                            Console.WriteLine("ID Keeper :");
                                                            Console.WriteLine("ID Hewan :");
                                                            Console.WriteLine("Tanggal Perawatan :");
                                                            Console.WriteLine("Kondisi Hewan :");
                                                            Console.WriteLine("Detail Perawatan :");
                                                            Console.WriteLine("\n==============");
                                                            Console.WriteLine("LIST Perawatan");
                                                            Console.WriteLine("==============");
                                                            pr.list3(conn);
                                                            Console.WriteLine("\n============");
                                                            Console.WriteLine("PILIHAN MENU");
                                                            Console.WriteLine("============");
                                                            Console.WriteLine("1. READ");
                                                            Console.WriteLine("2. INPUT");
                                                            Console.WriteLine("3. BACK");
                                                            Console.Write("\nEnter your choice (1-3): ");
                                                            char ch3 = char.ToUpper(Console.ReadKey().KeyChar);
                                                            switch (ch3)
                                                            {
                                                                case '1':
                                                                    {
                                                                        Console.Clear();
                                                                        Console.WriteLine("Anda memilih READ.");
                                                                      
                                                                        Console.WriteLine("Data Perawatan\n");
                                                                        Console.WriteLine("Masukkan ID Perawatan yang Ingin Dilihat:");
                                                                        string idPR = Console.ReadLine();
                                                                        try
                                                                        {
                                                                            pr.baca3(idPR, conn);
                                                                        }
                                                                        catch (Exception e)
                                                                        {
                                                                            Console.WriteLine("\nAnda tidak memiliki " +
                                                                                "akses untuk melihat data atau Data yang anda masukkan salah");
                                                                            Console.WriteLine(e.ToString());
                                                                        }
                                                                        while(true)
                                                                        {
                                                                            try
                                                                            {
                                                                                Console.WriteLine("\n============");
                                                                                Console.WriteLine("PILIHAN MENU");
                                                                                Console.WriteLine("============");
                                                                                Console.WriteLine("1. UPDATE");
                                                                                Console.WriteLine("2. DELETE");
                                                                                Console.WriteLine("3. BACK");
                                                                                Console.Write("\nEnter your choice (1-3): ");
                                                                                char ch5 = char.ToUpper(Console.ReadKey().KeyChar);
                                                                                Console.Clear();
                                                                                switch(ch5)
                                                                                {
                                                                                    case '1':
                                                                                        {
                                                                                            Console.Clear();
                                                                                            Console.WriteLine("Update Data Perawatan\n");

                                                                                            Console.WriteLine("Masukkan ID Keeper (biarkan kosong jika tidak ingin mengubah):");
                                                                                            string idK = Console.ReadLine();

                                                                                            Console.WriteLine("Masukkan ID Hewan (biarkan kosong jika tidak ingin mengubah):");
                                                                                            string idH = Console.ReadLine();

                                                                                            Console.WriteLine("Masukkan Tanggal Perawatan (biarkan kosong jika tidak ingin mengubah):");
                                                                                            string tglPR = Console.ReadLine();

                                                                                            Console.WriteLine("Masukkan Kondisi hewan (biarkan kosong jika tidak ingin mengubah):");
                                                                                            string kdsPR = Console.ReadLine();

                                                                                            Console.WriteLine("Masukkan Detail Perawatan (biarkan kosong jika tidak ingin mengubah):");
                                                                                            string PR = Console.ReadLine();

                                                                                            try
                                                                                            {
                                                                                                pr.update3(idPR, idK, idH, tglPR, kdsPR, PR, conn);
                                                                                            }

                                                                                            catch (Exception e)
                                                                                            {
                                                                                                Console.WriteLine("\nAnda tidak memiliki " +
                                                                                                    "akses untuk mengubah data atau Data yang anda masukkan salah");
                                                                                                Console.WriteLine(e.ToString());
                                                                                            }
                                                                                        }
                                                                                        break;
                                                                                    case '2':
                                                                                        {
                                                                                            Console.Clear();
                                                                                            Console.WriteLine("Anda memilih DELETE.");
                                                                                           
                                                                                            try
                                                                                            {
                                                                                                pr.delete3(idPR, conn);
                                                                                            }
                                                                                            catch (Exception e)
                                                                                            {
                                                                                                Console.WriteLine("\nAnda tidak memiliki " +
                                                                                                    "akses untuk menghapus data atau Data yang anda masukkan salah");
                                                                                                Console.WriteLine(e.ToString());
                                                                                            }
                                                                                        }
                                                                                        break;
                                                                                    case '3':
                                                                                        {

                                                                                            Console.Clear();
                                                                                            break;
                                                                                        }
                                                                                    default:
                                                                                        {
                                                                                            Console.Clear();
                                                                                            Console.WriteLine("\nInvalid option");

                                                                                        }
                                                                                        break;

                                                                                }
                                                                                if (ch5 == '3')
                                                                                {
                                                                                    Console.Clear();
                                                                                    break;
                                                                                }

                                                                            }
                                                                            catch (Exception e)
                                                                            {
                                                                                Console.WriteLine("\nAnda tidak memiliki " +
                                                                                    "akses untuk melihat data atau Data yang anda masukkan salah");
                                                                                Console.WriteLine(e.ToString());
                                                                            }
                                                                        }

                                                                    }
                                                                    break;
                                                                case '2':
                                                                    {
                                                                        Console.Clear();
                                                                        Console.WriteLine("Anda memilih INPUT.");
                                                                        
                                                                        Console.WriteLine("Input Data Perawatan\n");
                                                                        Console.WriteLine("Masukkan ID Perawatan :");
                                                                        string idPR = Console.ReadLine();
                                                                        Console.WriteLine("Masukkan ID Keeper :");
                                                                        string idK = Console.ReadLine();
                                                                        Console.WriteLine("Masukkan ID Hewan :");
                                                                        string idH = Console.ReadLine();
                                                                        Console.WriteLine("Masukkan Tanggal Perawatan :");
                                                                        string tglPR = Console.ReadLine();
                                                                        Console.WriteLine("Masukkan Kondisi Hewan (Sakit / Sehat) :");
                                                                        string kdsPR = Console.ReadLine();
                                                                        Console.WriteLine("Masukkan Detail Perawatan :");
                                                                        string PR = Console.ReadLine();


                                                                        try
                                                                        {
                                                                            pr.insert3(idPR, idK, idH, tglPR, kdsPR, PR, conn);

                                                                        }
                                                                        catch (Exception e)
                                                                        {
                                                                            Console.WriteLine("\nAnda tidak memiliki " +
                                                                                "akses untuk menambah data atau Data yang anda masukkan salah");
                                                                            Console.WriteLine(e.ToString());
                                                                        }

                                                                    }
                                                                    break;
                                                               
                                                                case '3':
                                                                    {
                                                                        Console.Clear();
                                                                        break;
                                                                    }
                                                                default:
                                                                    {
                                                                        Console.Clear();
                                                                        Console.WriteLine("\nInvalid option");

                                                                    }
                                                                    break;

                                                            }
                                                            if (ch3== '3')
                                                            {
                                                                Console.Clear();
                                                                break;
                                                            }
                                                        }
                                                        catch
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("\nCheck for the value entered.");
                                                        }
                                                    }
                                                }
                                                break;
                                            case '3':
                                                {
                                                    while (true)
                                                    {
                                                        try
                                                        {
                                                            Console.WriteLine("\nMenu Pemeriksaan");
                                                            Console.WriteLine("================");
                                                            Console.WriteLine("ID Pemeriksaan :");
                                                            Console.WriteLine("ID Hewan :");
                                                            Console.WriteLine("ID Keeper :");
                                                            Console.WriteLine("Tanggal Pemeriksaan:");
                                                            Console.WriteLine("Diagnosisl :");
                                                            Console.WriteLine("Pengobatan :");
                                                            Console.WriteLine("Saran: ");
                                                            Console.WriteLine("\n================");
                                                            Console.WriteLine("LIST Pemeriksaan");
                                                            Console.WriteLine("================");
                                                            pr.list4(conn);
                                                            Console.WriteLine("\n===========");
                                                            Console.WriteLine("PILIH MENU: ");
                                                            Console.WriteLine("==========");
                                                            Console.WriteLine("1. READ");
                                                            Console.WriteLine("2. INPUT");
                                                            Console.WriteLine("3. BACK");
                                                            Console.Write("\nEnter your choice (1-5): ");
                                                            char ch4 = char.ToUpper(Console.ReadKey().KeyChar);
                                                            switch (ch4)
                                                            {
                                                                case '1':
                                                                    {
                                                                        Console.Clear();
                                                                        Console.WriteLine("Anda memilih READ.");
                                                                        Console.WriteLine("Data Pemeriksaan\n");
                                                                        Console.WriteLine("Masukkan ID Pemeriksaan yang Ingin Dilihat:");
                                                                        string idPM = Console.ReadLine();
                                                                        try
                                                                        {
                                                                            pr.baca4(idPM, conn);
                                                                        }
                                                                        catch (Exception e)
                                                                        {
                                                                            Console.WriteLine("\nAnda tidak memiliki " +
                                                                                "akses untuk melihat data atau Data yang anda masukkan salah");
                                                                            Console.WriteLine(e.ToString());
                                                                        }
                                                                        while(true)
                                                                        {
                                                                            try
                                                                            {
                                                                                Console.WriteLine("\n============");
                                                                                Console.WriteLine("PILIHAN MENU");
                                                                                Console.WriteLine("============");
                                                                                Console.WriteLine("1. UPDATE");
                                                                                Console.WriteLine("2. DELETE");
                                                                                Console.WriteLine("3. BACK");
                                                                                Console.Write("\nEnter your choice (1-3): ");
                                                                                char ch5 = char.ToUpper(Console.ReadKey().KeyChar);
                                                                                Console.Clear();
                                                                                switch (ch5) 
                                                                                { 
                                                                                    case '1':
                                                                                        {
                                                                                            Console.Clear();
                                                                                            Console.WriteLine("Update Data Pemeriksaan\n");

                                                                                            Console.WriteLine("Masukkan ID Hewan (biarkan kosong jika tidak ingin mengubah):");
                                                                                            string idH = Console.ReadLine();

                                                                                            Console.WriteLine("Masukkan ID Dokter Hewan (biarkan kosong jika tidak ingin mengubah):");
                                                                                            string idDH = Console.ReadLine();

                                                                                            Console.WriteLine("Masukkan Tanggal Pemeriksaan (biarkan kosong jika tidak ingin mengubah):");
                                                                                            string tglPM = Console.ReadLine();

                                                                                            Console.WriteLine("Masukkan Diagnois (biarkan kosong jika tidak ingin mengubah):");
                                                                                            string dgPM = Console.ReadLine();

                                                                                            Console.WriteLine("Masukkan Pengobatan (biarkan kosong jika tidak ingin mengubah):");
                                                                                            string pbPM = Console.ReadLine();

                                                                                            Console.WriteLine("Masukkan Saran (biarkan kosong jika tidak ingin mengubah):");
                                                                                            string srPM = Console.ReadLine();

                                                                                            try
                                                                                            {
                                                                                                pr.update4(idPM, idH, idDH, tglPM, dgPM, pbPM, srPM, conn);
                                                                                            }

                                                                                            catch (Exception e)
                                                                                            {
                                                                                                Console.WriteLine("\nAnda tidak memiliki " +
                                                                                                    "akses untuk mengubah data atau Data yang anda masukkan salah");
                                                                                                Console.WriteLine(e.ToString());
                                                                                            }
                                                                                        }
                                                                                        break;
                                                                                    case '2':
                                                                                        {
                                                                                            Console.Clear();
                                                                                            Console.WriteLine("Anda memilih DELETE.");
                                                                                          
                                                                                            try
                                                                                            {
                                                                                                pr.delete4(idPM, conn);
                                                                                            }
                                                                                            catch (Exception e)
                                                                                            {
                                                                                                Console.WriteLine("\nAnda tidak memiliki " +
                                                                                                    "akses untuk menambah data atau Data yang anda masukkan salah");
                                                                                                Console.WriteLine(e.ToString());
                                                                                            }
                                                                                        }
                                                                                        break;
                                                                                    case '3':
                                                                                        {

                                                                                            Console.Clear();
                                                                                            break;
                                                                                        }
                                                                                    default:
                                                                                        {
                                                                                            Console.Clear();
                                                                                            Console.WriteLine("\nInvalid option");

                                                                                        }
                                                                                        break;

                                                                                }
                                                                                if (ch5 == '3')
                                                                                {
                                                                                    Console.Clear();
                                                                                    break;
                                                                                }

                                                                            }
                                                                            catch (Exception e)
                                                                            {
                                                                                Console.WriteLine("\nAnda tidak memiliki " +
                                                                                    "akses untuk melihat data atau Data yang anda masukkan salah");
                                                                                Console.WriteLine(e.ToString());
                                                                            }
                                                                        }

                                                                    }
                                                                    break;
                                                                case '2':
                                                                    {
                                                                        Console.Clear();
                                                                        Console.WriteLine("Anda memilih INPUT.");
                                                                        
                                                                        Console.WriteLine("Input Data Pemeriksaan\n");
                                                                        Console.WriteLine("Masukkan ID Pemeriksaan :");
                                                                        string idPM = Console.ReadLine();
                                                                        Console.WriteLine("Masukkan ID Hewan :");
                                                                        string idH = Console.ReadLine();
                                                                        Console.WriteLine("Masukkan ID Dokter Hewan :");
                                                                        string idDH = Console.ReadLine();
                                                                        Console.WriteLine("Masukkan Tanggal Pemeriksaan :");
                                                                        string tglPM = Console.ReadLine();
                                                                        Console.WriteLine("Masukkan Diagnosis :");
                                                                        string dgPM = Console.ReadLine();
                                                                        Console.WriteLine("Masukkan Pengobatan :");
                                                                        string pbPM = Console.ReadLine();
                                                                        Console.WriteLine("Masukkan Saran :");
                                                                        string srPM = Console.ReadLine();


                                                                        try
                                                                        {
                                                                            pr.insert4(idPM, idH, idDH, tglPM, dgPM, pbPM, srPM, conn);

                                                                        }
                                                                        catch (Exception e)
                                                                        {
                                                                            Console.WriteLine("\nAnda tidak memiliki " +
                                                                                "akses untuk menambah data atau Data yang anda masukkan salah");
                                                                            Console.WriteLine(e.ToString());
                                                                        }

                                                                    }
                                                                    break;
                                                              
                                                                case '3':
                                                                    {
                                                                        Console.Clear();
                                                                        break;
                                                                    }
                                                                default:
                                                                    {
                                                                        Console.Clear();
                                                                        Console.WriteLine("\nInvalid option");

                                                                    }
                                                                    break;

                                                            }
                                                            if (ch4 == '3')
                                                            {
                                                                Console.Clear();
                                                                break;
                                                            }
                                                        }
                                                        catch
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("\nCheck for the value entered.");
                                                        }
                                                    }
                                                }
                                                break;
                                            case '4':
                                                {
                                                    while (true)
                                                    {
                                                        try
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("\nINI HALAMAN Cetak Laporan.");
                                                            Console.WriteLine("\n===========");
                                                            Console.WriteLine("Piliah Menu: ");
                                                            Console.WriteLine("==========");
                                                            Console.WriteLine("1. BACK");
                                                            Console.Write("\nEnter your choice (1): ");
                                                            char ch5 = char.ToUpper(Console.ReadKey().KeyChar);
                                                            switch(ch5)
                                                            {
                                                                case '1':
                                                                    {
                                                                        Console.Clear();
                                                                        break;
                                                                    }
                                                            }
                                                            if (ch5 == '1')
                                                            {
                                                                Console.Clear();
                                                                break;
                                                            }
                                                        }
                                                        catch
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("\nCheck for the value entered.");
                                                        }
                                                    }
                                                }
                                                break;
                                                
                                            case '5':
                                                conn.Close();
                                                Console.Clear();
                                                Main(new String[0]);
                                                return;
                                            default:
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("\nInvalid option");

                                                }
                                                break;
                                        }
                                    }
                                    catch
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\nCheck for the value entered.");
                                    }
                                }
                            }
                        case 'E':
                            return;
                        default:
                            {
                                Console.WriteLine("\nInvalid option");
                            }
                            break;
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Tidak Dapat Mengakses Database Tersebut\n");
                    Console.ResetColor();
                }
            }
        }
        public void list(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("Select Id_hewan from Hewan", con);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                for (int i = 0; i < r.FieldCount; i++)
                {
                    Console.WriteLine(r.GetValue(i));
                }
                Console.WriteLine();
            }
            r.Close();
        }

        public void baca(string idHw ,SqlConnection con)
        {
            string str = "";
            str = "Select Id_hewan,Nama_hewan,Jenis_hewan, Spesies_hewan, Jk_hewan, Tgl_lahir, Tgl_masuk, Umur, Berat from Hewan where Id_hewan = @idh";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("idh", idHw));
            cmd.ExecuteNonQuery();
            Console.WriteLine("\n=================");
            Console.WriteLine("Data Detail Hewan");
            Console.WriteLine("=================\n");
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                for (int i = 0; i < r.FieldCount; i++)
                {
                    Console.WriteLine(r.GetValue(i));
                }
                Console.WriteLine();
            }
            r.Close();
        }
        public void insert(string idHw, string nmHw, string jsHw, string spHw, string jkHw, string tglHw, string tglmHw,
            string brw, SqlConnection conn)
        {

            string str = "";
            str = "insert into Hewan (Id_hewan,Nama_hewan,Jenis_hewan, Spesies_hewan, Jk_hewan, Tgl_lahir, Tgl_masuk, Berat) " +
                "values(@idh, @nmh, @jsh, @sph, @jkh, @tglh, @tglmh, @b)";
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("idh", idHw));
            cmd.Parameters.Add(new SqlParameter("nmh", nmHw));
            cmd.Parameters.Add(new SqlParameter("jsh", jsHw));
            cmd.Parameters.Add(new SqlParameter("sph", spHw));
            cmd.Parameters.Add(new SqlParameter("jkh", jkHw));
            cmd.Parameters.Add(new SqlParameter("tglh", tglHw));
            cmd.Parameters.Add(new SqlParameter("tglmh", tglmHw));
            cmd.Parameters.Add(new SqlParameter("b", brw));
            cmd.ExecuteNonQuery();
            Console.WriteLine("\nData Berhasil Ditambahkan");
        }

        public void update(string idHw, string nmHw, string jsHw, string spHw, string jkHw, string tglHw, string tglmHw,
                   string brw, SqlConnection conn)
        {
            // Membuat pernyataan SQL untuk UPDATE
            string updateQuery = "UPDATE Hewan SET ";
            List<string> updates = new List<string>(); // Menyimpan kolom-nilai yang akan diupdate

            // Menambahkan kolom-nilai ke dalam list jika ada input yang diberikan
            if (!string.IsNullOrEmpty(nmHw))
            {
                updates.Add("Nama_hewan = @NewName");
            }
            if (!string.IsNullOrEmpty(jsHw))
            {
                updates.Add("Jenis_hewan = @NewJenis");
            }
            if (!string.IsNullOrEmpty(spHw))
            {
                updates.Add("Spesies_hewan = @NewSpesies");
            }
            if (!string.IsNullOrEmpty(jkHw))
            {
                updates.Add("Jk_hewan = @NewJenisKelamin");
            }
            if (!string.IsNullOrEmpty(tglHw))
            {
                updates.Add("Tgl_lahir = @NewTanggalLahir");
            }
            if (!string.IsNullOrEmpty(tglmHw))
            {
                updates.Add("Tgl_masuk = @NewTanggalMasuk");
            }
            if (!string.IsNullOrEmpty(brw))
            {
                updates.Add("Berat = @NewBerat");
            }

            // Menggabungkan semua kolom-nilai yang akan diupdate menjadi satu string
            updateQuery += string.Join(", ", updates);

            // Menambahkan kondisi WHERE
            updateQuery += " WHERE Id_hewan = @IdHewan";

            // Membuat SqlCommand dengan pernyataan SQL yang disiapkan
            SqlCommand command = new SqlCommand(updateQuery, conn);

            // Menambahkan parameter untuk setiap kolom-nilai yang akan diupdate

            if (!string.IsNullOrEmpty(nmHw))
            {
                command.Parameters.Add("@NewName", SqlDbType.NVarChar).Value = nmHw;
            }
            if (!string.IsNullOrEmpty(jsHw))
            {
                command.Parameters.Add("@NewJenis", SqlDbType.NVarChar).Value = jsHw;
            }
            if (!string.IsNullOrEmpty(spHw))
            {
                command.Parameters.Add("@NewSpesies", SqlDbType.NVarChar).Value = spHw;
            }
            if (!string.IsNullOrEmpty(jkHw))
            {
                command.Parameters.Add("@NewJenisKelamin", SqlDbType.NVarChar).Value = jkHw;
            }
            if (!string.IsNullOrEmpty(tglHw))
            {
                command.Parameters.Add("@NewTanggalLahir", SqlDbType.Date).Value = Convert.ToDateTime(tglHw);
            }
            if (!string.IsNullOrEmpty(tglmHw))
            {
                command.Parameters.Add("@NewTanggalMasuk", SqlDbType.Date).Value = Convert.ToDateTime(tglmHw);
            }
            if (!string.IsNullOrEmpty(brw))
            {
                command.Parameters.Add("@NewBerat", SqlDbType.Decimal).Value = brw;
            }

            // Menambahkan parameter untuk kondisi WHERE
            command.Parameters.Add("@IdHewan", SqlDbType.NVarChar).Value = idHw;

            // Eksekusi perintah UPDATE
            int rowsAffected = command.ExecuteNonQuery();

            // Memeriksa apakah baris telah diubah
            if (rowsAffected > 0)
            {
                Console.WriteLine("Update successful!");
            }
            else
            {
                Console.WriteLine("No rows updated. Data not found or no changes provided.");
            }
        }


        public void delete(string idHw, SqlConnection con)
        {
            string str = "";
            str = "Delete Hewan where Id_hewan = @idh";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("idh", idHw));
            cmd.ExecuteNonQuery();
            Console.WriteLine("\nData Berhasil Dihapus");
        }

        public void list1(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("Select Id_keeper from Keeper", con);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                for (int i = 0; i < r.FieldCount; i++)
                {
                    Console.WriteLine(r.GetValue(i));
                }
                Console.WriteLine();
            }
            r.Close();
        }
        public void baca1(string idk, SqlConnection con)
        {
            string str = "";
            str = "Select Id_keeper,Nama_keeper,Almt_keeper, Notlp_keeper from Keeper where Id_keeper = @idke";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("idke", idk));
            cmd.ExecuteNonQuery();
            Console.WriteLine("\n=================");
            Console.WriteLine("Data Detail Keeper");
            Console.WriteLine("=================\n");
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                for (int i = 0; i < r.FieldCount; i++)
                {
                    Console.WriteLine(r.GetValue(i));
                }
                Console.WriteLine();
            }
            r.Close();
        }
        public void insert1(string idk, string nmk, string almtk, string notlpk, SqlConnection conn)
        {

            string str = "";
            str = "insert into Keeper (Id_keeper,Nama_keeper,Almt_keeper, Notlp_keeper) " +
                "values(@idke, @nmke, @almtke, @notlpke)";
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("idke", idk));
            cmd.Parameters.Add(new SqlParameter("nmke", nmk));
            cmd.Parameters.Add(new SqlParameter("almtke", almtk));
            cmd.Parameters.Add(new SqlParameter("notlpke", notlpk));
            cmd.ExecuteNonQuery();
            Console.WriteLine("\nData Berhasil Ditambahkan");
        }

        public void update1(string idk, string nmk, string almtk, string notlpk, SqlConnection conn)
        {
            // Membuat pernyataan SQL untuk UPDATE
            string updateQuery = "UPDATE Keeper SET ";
            List<string> updates = new List<string>(); // Menyimpan kolom-nilai yang akan diupdate

            // Menambahkan kolom-nilai ke dalam list jika ada input yang diberikan
            if (!string.IsNullOrEmpty(nmk))
            {
                updates.Add("Nama_keeper = @NewName");
            }
            if (!string.IsNullOrEmpty(almtk))
            {
                updates.Add("Almt_keeper = @NewAlamat");
            }
            if (!string.IsNullOrEmpty(notlpk))
            {
                updates.Add("Notlp_keeper = @NewTlpKP");
            }

            // Menggabungkan semua kolom-nilai yang akan diupdate menjadi satu string
            updateQuery += string.Join(", ", updates);

            // Menambahkan kondisi WHERE
            updateQuery += " WHERE Id_keeper = @Idkeeper";

            // Membuat SqlCommand dengan pernyataan SQL yang disiapkan
            SqlCommand command = new SqlCommand(updateQuery, conn);

            // Menambahkan parameter untuk setiap kolom-nilai yang akan diupdate

            if (!string.IsNullOrEmpty(nmk))
            {
                command.Parameters.Add("@NewName", SqlDbType.NVarChar).Value = nmk;
            }
            if (!string.IsNullOrEmpty(almtk))
            {
                command.Parameters.Add("@NewAlamat", SqlDbType.NVarChar).Value = almtk;
            }
            if (!string.IsNullOrEmpty(notlpk))
            {
                command.Parameters.Add("@NewTlpKP", SqlDbType.NVarChar).Value = notlpk;
            }
            // Menambahkan parameter untuk kondisi WHERE
            command.Parameters.Add("@Idkeeper", SqlDbType.NVarChar).Value = idk;

            // Eksekusi perintah UPDATE
            int rowsAffected = command.ExecuteNonQuery();

            // Memeriksa apakah baris telah diubah
            if (rowsAffected > 0)
            {
                Console.WriteLine("Update successful!");
            }
            else
            {
                Console.WriteLine("No rows updated. Data not found or no changes provided.");
            }
        }

        public void delete1(string idk, SqlConnection con)
        {
            string str = "";
            str = "Delete Keeper where Id_keeper = @idke";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("idke", idk));
            cmd.ExecuteNonQuery();
            Console.WriteLine("\nData Berhasil Dihapus");
        }

        public void list2(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("Select Id_Dhewan from Dokter_hewan", con);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                for (int i = 0; i < r.FieldCount; i++)
                {
                    Console.WriteLine(r.GetValue(i));
                }
                Console.WriteLine();
            }
            r.Close();
        }
        public void baca2( string iddh, SqlConnection con)
        {
            string str = "";
            str = "Select Id_Dhewan,Nama_Dhewan,Almt_Dhewan, Notlp_Dhewan from Dokter_hewan where Id_Dhewan= @iddhe";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("iddhe", iddh));
            cmd.ExecuteNonQuery();
            Console.WriteLine("\n=================");
            Console.WriteLine("Data Detail Dokter Hewan");
            Console.WriteLine("=================\n");
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                for (int i = 0; i < r.FieldCount; i++)
                {
                    Console.WriteLine(r.GetValue(i));
                }
                Console.WriteLine();
            }
            r.Close();
        }
        public void insert2(string iddh, string nmdh, string almtdh, string notlpdh, SqlConnection conn)
        {

            string str = "";
            str = "insert into Dokter_hewan (Id_Dhewan,Nama_Dhewan,Almt_Dhewan, Notlp_Dhewan) " +
                "values(@iddhe, @nmdhe, @almtdhe, @notlpdhe)";
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("iddhe", iddh));
            cmd.Parameters.Add(new SqlParameter("nmdhe", nmdh));
            cmd.Parameters.Add(new SqlParameter("almtdhe", almtdh));
            cmd.Parameters.Add(new SqlParameter("notlpdhe", notlpdh));
            cmd.ExecuteNonQuery();
            Console.WriteLine("\nData Berhasil Ditambahkan");
        }

        public void update2(string iddh, string nmdh, string almtdh, string notlpdh, SqlConnection conn)
        {
            // Membuat pernyataan SQL untuk UPDATE
            string updateQuery = "UPDATE Dokter_hewan SET ";
            List<string> updates = new List<string>(); // Menyimpan kolom-nilai yang akan diupdate

            // Menambahkan kolom-nilai ke dalam list jika ada input yang diberikan
            if (!string.IsNullOrEmpty(nmdh))
            {
                updates.Add("Nama_Dhewan = @NewName");
            }
            if (!string.IsNullOrEmpty(almtdh))
            {
                updates.Add("Almt_Dhewan = @NewAlamat");
            }
            if (!string.IsNullOrEmpty(notlpdh))
            {
                updates.Add("Notlp_Dhewan = @NewTlpDH");
            }

            // Menggabungkan semua kolom-nilai yang akan diupdate menjadi satu string
            updateQuery += string.Join(", ", updates);

            // Menambahkan kondisi WHERE
            updateQuery += " WHERE Id_Dhewan = @IdDhewan";

            // Membuat SqlCommand dengan pernyataan SQL yang disiapkan
            SqlCommand command = new SqlCommand(updateQuery, conn);

            // Menambahkan parameter untuk setiap kolom-nilai yang akan diupdate

            if (!string.IsNullOrEmpty(nmdh))
            {
                command.Parameters.Add("@NewName", SqlDbType.NVarChar).Value = nmdh;
            }
            if (!string.IsNullOrEmpty(almtdh))
            {
                command.Parameters.Add("@NewAlamat", SqlDbType.NVarChar).Value = almtdh;
            }
            if (!string.IsNullOrEmpty(notlpdh))
            {
                command.Parameters.Add("@NewTlpDH", SqlDbType.NVarChar).Value = notlpdh;
            }
            // Menambahkan parameter untuk kondisi WHERE
            command.Parameters.Add("@IdDhewan", SqlDbType.NVarChar).Value = iddh;

            // Eksekusi perintah UPDATE
            int rowsAffected = command.ExecuteNonQuery();

            // Memeriksa apakah baris telah diubah
            if (rowsAffected > 0)
            {
                Console.WriteLine("Update successful!");
            }
            else
            {
                Console.WriteLine("No rows updated. Data not found or no changes provided.");
            }
        }

        public void delete2(string iddh, SqlConnection con)
        {
            string str = "";
            str = "Delete Dokter_hewan where Id_Dhewan = @iddhe";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("iddhe", iddh));
            cmd.ExecuteNonQuery();
            Console.WriteLine("\nData Berhasil Dihapus");
        }

        public void list3(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("Select Id_prwtn from Perawatan", con);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                for (int i = 0; i < r.FieldCount; i++)
                {
                    Console.WriteLine(r.GetValue(i));
                }
                Console.WriteLine();
            }
            r.Close();
        }
        public void baca3( string idpr, SqlConnection con)
        {
            string str = "";
            str = "Select Id_prwtn, Id_keeper, Id_hewan, Tgl_prwtn, Kondisi_hewan, Detail_prwtn from Perawatan where Id_prwtn= @idpre";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("idpre", idpr));
            cmd.ExecuteNonQuery();
            Console.WriteLine("\n==================");
            Console.WriteLine("Data Detail Perawatan");
            Console.WriteLine("==================\n");
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                for (int i = 0; i < r.FieldCount; i++)
                {
                    Console.WriteLine(r.GetValue(i));
                }
                Console.WriteLine();
            }
            r.Close();
        }
        public void insert3(string idpr, string idk, string idHw, string tglpr, string Kdhw, string Dtpr, SqlConnection conn)
        {

            string str = "";
            str = "insert into Perawatan (Id_prwtn, Id_keeper, Id_hewan, Tgl_prwtn, Kondisi_hewan, Detail_prwtn) " +
                "values(@idpre, @idke, @idh, @tglpre, @Kdhwe, @Dtpre)";
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("idpre", idpr));
            cmd.Parameters.Add(new SqlParameter("idke", idk));
            cmd.Parameters.Add(new SqlParameter("idh", idHw));
            cmd.Parameters.Add(new SqlParameter("tglpre", tglpr));
            cmd.Parameters.Add(new SqlParameter("Kdhwe", Kdhw));
            cmd.Parameters.Add(new SqlParameter("Dtpre", Dtpr));
            cmd.ExecuteNonQuery();
            Console.WriteLine("\nData Berhasil Ditambahkan");
        }

        public void update3(string idpr, string idk, string idHw, string tglpr, string Kdhw, string Dtpr, SqlConnection conn)
        {
            // Membuat pernyataan SQL untuk UPDATE
            string updateQuery = "UPDATE Perawatan SET ";
            List<string> updates = new List<string>(); // Menyimpan kolom-nilai yang akan diupdate

            // Menambahkan kolom-nilai ke dalam list jika ada input yang diberikan
            if (!string.IsNullOrEmpty(idk))
            {
                updates.Add("Id_keeper = @NewidKe");
            }
            if (!string.IsNullOrEmpty(idHw))
            {
                updates.Add("Id_hewan = @NewIdHpr");
            }
            if (!string.IsNullOrEmpty(tglpr))
            {
                updates.Add("Tgl_Prwtn = @Newtglpr");
            }
            if (!string.IsNullOrEmpty(Kdhw))
            {
                updates.Add("Kondisi_hewan = @NewkdHpr");
            }
            if (!string.IsNullOrEmpty(Dtpr))
            {
                updates.Add("Detail_prwtn = @NewDpr");
            }

            // Menggabungkan semua kolom-nilai yang akan diupdate menjadi satu string
            updateQuery += string.Join(", ", updates);

            // Menambahkan kondisi WHERE
            updateQuery += " WHERE Id_prwtn = @Idprwtn";

            // Membuat SqlCommand dengan pernyataan SQL yang disiapkan
            SqlCommand command = new SqlCommand(updateQuery, conn);

            // Menambahkan parameter untuk setiap kolom-nilai yang akan diupdate

            if (!string.IsNullOrEmpty(idk))
            {
                command.Parameters.Add("@NewidKe", SqlDbType.NVarChar).Value = idk;
            }
            if (!string.IsNullOrEmpty(idHw))
            {
                command.Parameters.Add("@NewIdHpr", SqlDbType.NVarChar).Value = idHw;
            }
            if (!string.IsNullOrEmpty(tglpr))
            {
                command.Parameters.Add("@Newtglpr", SqlDbType.NVarChar).Value = tglpr;
            }
            if (!string.IsNullOrEmpty(Kdhw))
            {
                command.Parameters.Add("@NewkdHpr", SqlDbType.NVarChar).Value = Kdhw;
            }
            if (!string.IsNullOrEmpty(Dtpr))
            {
                command.Parameters.Add("@NewDpr", SqlDbType.NVarChar).Value = Dtpr;
            }
            // Menambahkan parameter untuk kondisi WHERE
            command.Parameters.Add("@Idprwtn", SqlDbType.NVarChar).Value = idpr;

            // Eksekusi perintah UPDATE
            int rowsAffected = command.ExecuteNonQuery();

            // Memeriksa apakah baris telah diubah
            if (rowsAffected > 0)
            {
                Console.WriteLine("Update successful!");
            }
            else
            {
                Console.WriteLine("No rows updated. Data not found or no changes provided.");
            }
        }
        public void delete3(string idpr, SqlConnection con)
        {
            string str = "";
            str = "Delete Perawatan where Id_prwtn = @idpre";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("idpre", idpr));
            cmd.ExecuteNonQuery();
            Console.WriteLine("\nData Berhasil Dihapus");
        }



        public void list4(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("Select Id_Periksa from Pemeriksaan", con);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                for (int i = 0; i < r.FieldCount; i++)
                {
                    Console.WriteLine(r.GetValue(i));
                }
                Console.WriteLine();
            }
            r.Close();
        }
        public void baca4(string idpm, SqlConnection con)
        {
            string str = "";
            str = "Select Id_Periksa, Id_hewan, Id_Dhewan, Tgl_Periksa, Diagnosis, Pengobatan, Saran from Pemeriksaan where Id_Periksa= @idpme";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("idpme", idpm));
            cmd.ExecuteNonQuery();
            Console.WriteLine("\n======================");
            Console.WriteLine("Data Detail Pemeriksaan");
            Console.WriteLine("=======================\n");
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                for (int i = 0; i < r.FieldCount; i++)
                {
                    Console.WriteLine(r.GetValue(i));
                }
                Console.WriteLine();
            }
            r.Close();
        }
        public void insert4(string idpm, string idHw, string idDh, string tglpm, string dgpm, string pbpm, string srpm, SqlConnection conn)
        {

            string str = "";
            str = "insert into Pemeriksaan (Id_Periksa, Id_hewan, Id_Dhewan, Tgl_Periksa, Diagnosis, Pengobatan, Saran) " +
                "values(@idpme, @idh, @idke, @tglpme, @dgpme, @pbpme, @srpme)";
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("idpme", idpm));
            cmd.Parameters.Add(new SqlParameter("idh", idHw));
            cmd.Parameters.Add(new SqlParameter("idke", idDh));
            cmd.Parameters.Add(new SqlParameter("tglpme", tglpm));
            cmd.Parameters.Add(new SqlParameter("dgpme", dgpm));
            cmd.Parameters.Add(new SqlParameter("pbpme", pbpm));
            cmd.Parameters.Add(new SqlParameter("srpme", srpm));
            cmd.ExecuteNonQuery();
            Console.WriteLine("\nData Berhasil Ditambahkan");
        }

        public void update4(string idpm, string idHw, string idDh, string tglpm, string dgpm, string pbpm, string srpm, SqlConnection conn)
        {
            // Membuat pernyataan SQL untuk UPDATE
            string updateQuery = "UPDATE Pemeriksaan SET ";
            List<string> updates = new List<string>(); // Menyimpan kolom-nilai yang akan diupdate

            // Menambahkan kolom-nilai ke dalam list jika ada input yang diberikan
            if (!string.IsNullOrEmpty(idHw))
            {
                updates.Add("Id_hewan = @NewidH");
            }
            if (!string.IsNullOrEmpty(idDh))
            {
                updates.Add("Id_Dhewan = @NewIdDH");
            }
            if (!string.IsNullOrEmpty(tglpm))
            {
                updates.Add("Tgl_Periksa = @Newtglpm");
            }
            if (!string.IsNullOrEmpty(dgpm))
            {
                updates.Add("Diagnosis = @NewDgs");
            }
            if (!string.IsNullOrEmpty(pbpm))
            {
                updates.Add("Pengobatan = @NewPeng");
            }
            if (!string.IsNullOrEmpty(srpm))
            {
                updates.Add("Saran = @NewSR");
            }

            // Menggabungkan semua kolom-nilai yang akan diupdate menjadi satu string
            updateQuery += string.Join(", ", updates);

            // Menambahkan kondisi WHERE
            updateQuery += " WHERE Id_periksa = @idpme";

            // Membuat SqlCommand dengan pernyataan SQL yang disiapkan
            SqlCommand command = new SqlCommand(updateQuery, conn);

            // Menambahkan parameter untuk setiap kolom-nilai yang akan diupdate

            if (!string.IsNullOrEmpty(idHw))
            {
                command.Parameters.Add("@NewidH", SqlDbType.NVarChar).Value = idHw;
            }

            if (!string.IsNullOrEmpty(idDh))
            {
                command.Parameters.Add("@NewIdDH", SqlDbType.NVarChar).Value = idDh;
            }
            if (!string.IsNullOrEmpty(tglpm))
            {
                command.Parameters.Add("@Newtglpm", SqlDbType.NVarChar).Value = tglpm;
            }
            if (!string.IsNullOrEmpty(dgpm))
            {
                command.Parameters.Add("@NewDgs", SqlDbType.NVarChar).Value = dgpm;
            }
            if (!string.IsNullOrEmpty(pbpm))
            {
                command.Parameters.Add("@NewPeng", SqlDbType.NVarChar).Value = pbpm;
            }
            if (!string.IsNullOrEmpty(srpm))
            {
                command.Parameters.Add("@NewSR", SqlDbType.NVarChar).Value = srpm;
            }
            // Menambahkan parameter untuk kondisi WHERE
            command.Parameters.Add("@Idpme", SqlDbType.NVarChar).Value = idpm;

            // Eksekusi perintah UPDATE
            int rowsAffected = command.ExecuteNonQuery();

            // Memeriksa apakah baris telah diubah
            if (rowsAffected > 0)
            {
                Console.WriteLine("Update successful!");
            }
            else
            {
                Console.WriteLine("No rows updated. Data not found or no changes provided.");
            }
        }

        public void delete4(string idpm, SqlConnection con)
        {
            string str = "";
            str = "Delete Pemeriksaan where Id_Periksa = @idpme";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("idpme", idpm));
            cmd.ExecuteNonQuery();
            Console.WriteLine("\nData Berhasil Dihapus");
        }
    }
}
    

