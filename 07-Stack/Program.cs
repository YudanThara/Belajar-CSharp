using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Belajar_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // STACK = Tumpukan (LIFO - Last In First Out)
            // Data yang terakhir masuk, akan keluar pertama kali.
            Stack<string> riwayatMenu = new Stack<string>();

            Console.WriteLine("=== SIMULASI NAVIGASI MENU GAME ===");

            // 1. PUSH (Masuk Tumpukan / Buka Menu Baru)
            // Menumpuk halaman menu satu per satu
            riwayatMenu.Push("Main Menu");
            Console.WriteLine("Buka: Main Menu");

            riwayatMenu.Push("Menu Karakter");
            Console.WriteLine("Buka: Menu Karakter");

            riwayatMenu.Push("Equip Senjata");
            Console.WriteLine("Buka: Equip Senjata"); // <-- Ini posisi paling atas sekarang

            Console.WriteLine("\n[Posisi kamu sekarang ada di menu: " + riwayatMenu.Peek() + "]");
            Console.WriteLine("Jumlah riwayat (Stack): " + riwayatMenu.Count);
            Console.WriteLine("-----------------------------");

            // 2. POP (Keluar Tumpukan / Tombol Back)
            // Mengambil data paling atas (terakhir masuk) dan membuangnya
            Console.WriteLine("User menekan tombol BACK...");
            string menuKeluar = riwayatMenu.Pop(); // 'Equip Senjata' dibuang
            Console.WriteLine("Menutup: " + menuKeluar);
            Console.WriteLine("Sekarang kembali ke: " + riwayatMenu.Peek()); // Balik ke 'Menu Karakter'

            Console.WriteLine("\nUser menekan tombol BACK lagi...");
            menuKeluar = riwayatMenu.Pop(); // 'Menu Karakter' dibuang
            Console.WriteLine("Menutup: " + menuKeluar);
            Console.WriteLine("Sekarang kembali ke: " + riwayatMenu.Peek()); // Balik ke 'Main Menu'

            Console.WriteLine("-----------------------------");
            
            // Cek Sisa Stack
            Console.WriteLine("Sisa riwayat navigasi:");
            foreach (string menu in riwayatMenu)
            {
                Console.WriteLine("- " + menu);
            }

            Console.ReadKey();
        }
    }
}