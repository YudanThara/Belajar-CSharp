using System;

namespace Belajar_CSharp
{
    // ==========================================
    // 1. CLASS INDUK (PARENT / BASE CLASS)
    // ==========================================
    class Monster
    {
        public string Nama;
        public int HP;

        public void Serang()
        {
            Console.WriteLine(Nama + " menyerang dengan pukulan biasa!");
        }
    }

    // ==========================================
    // 2. CLASS ANAK (CHILD / DERIVED CLASS)
    // ==========================================
    class Zombie : Monster 
    {
        // Fitur Spesial Zombie
        public string TipeInfeksi;

        public void Gigit()
        {
            Console.WriteLine(Nama + " MENGGIGIT pemain! (Efek: " + TipeInfeksi + ")");
        }
    }

    // Anak kedua: Naga
    class Naga : Monster
    {
        public void SemburanApi()
        {
            Console.WriteLine(Nama + " menyemburkan API PANAS! 🔥");
        }
    }

    // ==========================================
    // 3. PROGRAM UTAMA
    // ==========================================
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BELAJAR INHERITANCE (PEWARISAN) ===\n");

            // --- TEST ZOMBIE ---
            Zombie z = new Zombie();
            z.Nama = "Zombie Kampung"; 
            z.HP = 100;
            z.TipeInfeksi = "Racun Level 1";

            z.Serang(); // Pake jurus Bapaknya (Pukulan Biasa)
            z.Gigit();  // Pake jurus Sendiri (Gigit)

            Console.WriteLine("--------------------");

            // --- TEST NAGA ---
            Naga n = new Naga();
            n.Nama = "Bahamut";
            n.HP = 9999;

            n.Serang();       // Warisan
            n.SemburanApi();  // Spesial

            Console.ReadKey();
        }
    }
}