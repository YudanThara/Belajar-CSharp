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
            // === ARRAY 1: Cara Langsung ===
            // Membuat array berisi 4 nama karakter
            string[] namaKarakter = { "Firefly", "Kafka", "Acheron", "March 7th" };

            Console.WriteLine("=== DAFTAR KARAKTER HSR (Array) ===");
            
            // Mengakses data array berdasarkan index
            Console.WriteLine("Karakter 1: " + namaKarakter[0]); 
            Console.WriteLine("Karakter 2: " + namaKarakter[1]);
            Console.WriteLine("Karakter 3: " + namaKarakter[2]);
            Console.WriteLine("Karakter 4: " + namaKarakter[3]);

            // Mengubah isi array
            namaKarakter[3] = "Evernight"; 
            Console.WriteLine("Karakter 4 (Diganti): " + namaKarakter[3]);

            Console.WriteLine("-------------------------");

            // === ARRAY 2: Pakai Looping ===
            Console.WriteLine("Menampilkan Semua Pakai Loop:");
            
            for (int i = 0; i < namaKarakter.Length; i++)
            {
                Console.WriteLine("Index ke-" + i + ": " + namaKarakter[i]);
            }

            Console.ReadKey();
        }
    }
}