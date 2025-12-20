using System;
// IMPORT ALAMAT
using Belajar_CSharp.Monsters.Slimes;  // Dari Folder Slimes
using Belajar_CSharp.Monsters.Goblins; // Dari Folder Goblins

namespace Belajar_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== DUNIA MONSTER DENGAN FOLDER RAPI ===\n");

            // 1. Panggil Slime Api (Dari Folder Slimes)
            SlimeApi s = new SlimeApi();
            s.Nama = "Slime Pyro";
            s.Level = 10;
            
            s.Info();    // Punya Kakek (Monster)
            s.Lompat();  // Punya Bapak (Slime)
            s.Bakar();   // Punya Sendiri
            
            // 1. Panggil Slime Es (Dari Folder Slimes)
            SlimeEs sEs = new SlimeEs();
            sEs.Nama = "Slime Cryo";
            sEs.Level = 15;
            
            sEs.Info();
            sEs.Lompat();
            sEs.Bakar();

            Console.WriteLine("-----------------------------");

            // 2. Panggil Goblin (Dari Folder Goblins)
            Goblin g = new Goblin();
            g.Nama = "Goblin Pencuri";
            g.Level = 5;
            g.Senjata = "Pisau Dapur";

            g.Info();
            g.CuriEmas();

            Console.ReadKey();
        }
    }
}