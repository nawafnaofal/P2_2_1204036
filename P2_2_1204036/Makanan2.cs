using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204036
{
    class Makanan2 
    {

        static void Main(String[] args)
        {
        MENU: // label
            Console.Clear();
            Console.WriteLine("|========NASGOR ABAH=========|");
            Console.WriteLine("|1.Daftar Harga Makanan      |");
            Console.WriteLine("|2.Pesan Makanan             |");
            Console.WriteLine("|3.Keluar                    |");
            Console.WriteLine("|============================|");
            Console.Write("> Pilih Menu : ");
            int PilihanMenu = int.Parse(Console.ReadLine());
            if (PilihanMenu != 1 && PilihanMenu != 2 && PilihanMenu !=3)
            {
                Console.WriteLine("Pilihan Tidak Tersedia !");
                Console.WriteLine(" ");
                Console.WriteLine("Tekan ENTER Untuk memilih ulang");
                Console.ReadKey(true);
                goto MENU;
            }

            switch (PilihanMenu)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("|=================== Harga ===================|");
                    Console.WriteLine("|---------------------------------------------|");
                    Console.WriteLine("|  Daftar Makanan         |     Harga         |");
                    Console.WriteLine("|---------------------------------------------|");
                    Console.WriteLine("| 1. Nasgor Ayam          | Rp. 12000         |");
                    Console.WriteLine("| 2. Mie Goreng Rendang   | Rp. 25000         |");
                    Console.WriteLine("|=============================================|");
                    Console.WriteLine(" ");
                    Console.WriteLine(" Tekan Enter Untuk Kembali Ke menu... ");
                    Console.ReadKey(true);
                    goto MENU;
                    break;
                case 2:
                INPUT:

                    Console.Clear();
                    Console.WriteLine("|==================== Menu Makanan ===================|");
                    Console.WriteLine("| > Pilih Menu Makanan                                |");
                    Console.WriteLine("|   [ 1. Nasgor Ayam        ]                         |");
                    Console.WriteLine("|   [ 2. Mie Goreng Rendang ]                         |");
                    Console.WriteLine("|=====================================================|");
                    Console.Write("|> Pilih :  ");
                    int PilihanJenis = int.Parse(Console.ReadLine());
                    Console.WriteLine(" ");
                    if (PilihanJenis != 1 && PilihanJenis != 2)
                    {
                        Console.WriteLine("Pilihan Tidak Tersedia !");
                        Console.WriteLine(" ");
                        Console.WriteLine("Tekan ENTER Untuk memilih ulang");
                        Console.ReadKey(true);
                        goto INPUT;
                    }
                    else if (PilihanJenis == 1)
                    {
                        Console.Write("|Nama\t\t: ");
                        string nama = (Console.ReadLine());
                        int beliNasgor = 0;
                        Console.Write("|Beli Berapa\t: ");
                        beliNasgor = Convert.ToInt16(Console.ReadLine());
                        Nasgor hargaNasgor = new Nasgor();
                        hargaNasgor.HargaNas(beliNasgor);
                        hargaNasgor.output();                       
                        Console.WriteLine("|==========================================|");
                        Console.WriteLine("|Tekan ENTER untuk kembali ke menu...");
                        Console.ReadKey(true);

                    }

                    if (PilihanJenis == 2)
                    { 
                        Console.Write("|Nama\t\t: ");
                        string nama = (Console.ReadLine());
                        int beliMie = 0;
                        Console.Write("|Beli Berapa\t: ");
                        beliMie = Convert.ToInt16(Console.ReadLine());
                        MieGoreng hargaMie = new MieGoreng();
                        hargaMie.HargaMie(beliMie);
                        hargaMie.output();
                        Console.WriteLine("|==========================================|");
                        Console.WriteLine("|Tekan ENTER untuk kembali ke menu...");
                        Console.ReadKey(true);
                    }
                    goto MENU;
                    break;                   
                case 3:
                    return;
            }
        }       
    }
}
