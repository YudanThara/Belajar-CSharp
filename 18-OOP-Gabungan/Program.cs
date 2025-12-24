using System;

namespace Belajar_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== 18. OOP ULTIMATE GABUNGAN ===\n");

            // 1. Bikin Assassin (Pakai Class Gabungan)
            Assassin player = new Assassin("Lancelot");

            // 2. Cek Status Awal (Encapsulation jalan)
            Console.WriteLine($"Hero: {player.Nama} | Energy: {player.Energy}");

            // 3. Serang Biasa (Polymorphism & Inheritance jalan)
            player.Serang();
            player.Serang();
            
            // Cek Energy berkurang gak?
            Console.WriteLine($"Sisa Energy: {player.Energy}");

            // 4. Pakai Ultimate (Interface jalan)
            player.Ultimate();

            Console.ReadKey();
        }
    }
}