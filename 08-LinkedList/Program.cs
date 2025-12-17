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
            // Membuat Linked List (Rantai Data)
            LinkedList<string> rutePerjalanan = new LinkedList<string>();

            // 1. Menambah Data (Simpul/Node)
            // Kita buat rute awal: Kota Awal -> Hutan -> Boss Castle
            rutePerjalanan.AddLast("Kota Awal");
            rutePerjalanan.AddLast("Hutan Kegelapan");
            rutePerjalanan.AddLast("Boss Castle");

            Console.WriteLine("=== RUTE AWAL ===");
            CetakRute(rutePerjalanan);

            // 2. MENYISIPKAN DATA (Insert) 
            // Tiba-tiba ada update game, ada 'Desa Pedagang' SETELAH 'Hutan Kegelapan'
            
            // Cari dulu node patokannya (Hutan Kegelapan)
            LinkedListNode<string> patokan = rutePerjalanan.Find("Hutan Kegelapan");
            
            // Tambahkan data baru SETELAH patokan
            rutePerjalanan.AddAfter(patokan, "Desa Pedagang (DLC)");

            Console.WriteLine("\n=== SETELAH UPDATE MAP (Insert Tengah) ===");
            CetakRute(rutePerjalanan);

            // 3. MENGHAPUS DATA (Remove)
            // Boss Castle dihancurkan, jadi hilang dari map
            rutePerjalanan.Remove("Boss Castle");

            Console.WriteLine("\n=== SETELAH BOSS KALAH (Remove) ===");
            CetakRute(rutePerjalanan);

            // 4. NAVIGASI MAJU MUNDUR (Next & Previous)
            Console.WriteLine("\n=== CEK NAVIGASI ===");
            LinkedListNode<string> lokasiSaatIni = rutePerjalanan.First; // Mulai dari depan
            Console.WriteLine("Start: " + lokasiSaatIni.Value);
            
            // Maju ke node berikutnya (Next)
            lokasiSaatIni = lokasiSaatIni.Next; 
            Console.WriteLine("Maju ke: " + lokasiSaatIni.Value); // Hutan

            // Mundur lagi (Previous)
            lokasiSaatIni = lokasiSaatIni.Previous;
            Console.WriteLine("Mundur ke: " + lokasiSaatIni.Value); // Balik ke Kota Awal

            Console.ReadKey();
        }

        // Fungsi tambahan biar gak capek ngetik foreach berulang kali
        static void CetakRute(LinkedList<string> list)
        {
            foreach (string tempat in list)
            {
                Console.Write(tempat + " -> ");
            }
            Console.WriteLine("TAMAT");
        }
    }
}