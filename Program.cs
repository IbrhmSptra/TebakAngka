using System;

namespace Tebak_Angka
{
    class Program
    {
        static void Main(string[] args)
        {
            int Menu=1;
            int Main;
            while (Menu != 2) {
                System.Console.WriteLine("-------------------------------------------------------------------------");
                System.Console.WriteLine("                 Selamat Datang Di Program Tebak Angka");
                System.Console.WriteLine("-------------------------------------------------------------------------");
                System.Console.WriteLine("                              1. Bermain");
                System.Console.WriteLine("                              2. Exit");
                System.Console.WriteLine();
                System.Console.WriteLine();
                System.Console.WriteLine();
                System.Console.WriteLine("-------------------------------------------------------------------------");
                System.Console.Write("Enter Here . . .");
                Menu = Convert.ToInt32(Console.ReadLine());
                if (Menu == 1) {
                    do {
                        
                        Random Acak = new Random();
                        int min = 1;
                        int max = 101;
                        int Jawaban = Acak.Next(min , max);
                        int Tebakan;
                        int Percobaan=1;
                        while (true) {
                            System.Console.WriteLine("----------------------------------------------------------------");
                            System.Console.WriteLine("               Tebak Angka Dari "+min+" Sampai 100");
                            System.Console.WriteLine("----------------------------------------------------------------");
                            System.Console.WriteLine();
                            System.Console.WriteLine();
                            System.Console.Write("  Tebakan = ");
                            Tebakan = Convert.ToInt32(Console.ReadLine());
                            if (Tebakan > Jawaban) {
                                System.Console.WriteLine("----------------------------");
                                System.Console.WriteLine("Tebakan Lebih Dari Jawaban");
                                System.Console.WriteLine("----------------------------");
                                Percobaan++;
                            }
                            if (Tebakan < Jawaban) {
                                System.Console.WriteLine("-----------------------------");
                                System.Console.WriteLine("Tebakan Kurang Dari Jawaban");
                                System.Console.WriteLine("-----------------------------");
                                Percobaan++;
                            }
                            if (Tebakan == Jawaban){
                                Percobaan++;
                                Console.Beep();
                                System.Console.WriteLine("--------------------------------------------------");
                                System.Console.WriteLine("            Selamat Tebakan Anda Benar");
                                System.Console.WriteLine("    Angka = "+Jawaban);
                                System.Console.WriteLine("  Tebakan = "+Tebakan);
                                System.Console.WriteLine("Percobaan = "+Percobaan);
                                System.Console.WriteLine("--------------------------------------------------");
                                break;
                            }
                        }
                        while (true) {
                            System.Console.WriteLine();
                            System.Console.WriteLine("    Apakah anda ingin bermain lagi ?");
                            System.Console.WriteLine("             1.Main Lagi");
                            System.Console.WriteLine("              2.Udahan");
                            System.Console.WriteLine();
                            System.Console.Write("Enter Here . . .");
                            Main = Convert.ToInt32(Console.ReadLine());
                            if (Main != 1 && Main != 2 ) {
                                System.Console.WriteLine();
                                System.Console.WriteLine("        Pilihan Tidak Tersedia!!");
                            }
                            if (Main == 1 || Main == 2) {
                                break;
                            }
                        }
                    } while (Main!=2);
                }
            }
            System.Console.WriteLine("------------------------------------------------------------------");
            System.Console.WriteLine("                     Terimakasih Telah Bermain");
            System.Console.WriteLine("------------------------------------------------------------------");
        }
    }
}
