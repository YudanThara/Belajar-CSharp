using System;

namespace Belajar_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== INHERITANCE BERTINGKAT (MULTILEVEL) ===\n");

            // Buat Slime Api
            SlimeApi musuh = new SlimeApi();
            musuh.Nama = "Slime Pyro Level 50";
            musuh.HP = 2000;

            // 1. Skill Kakek (Monster)
            musuh.Jalan();

            // 2. Skill Bapak (Slime)
            musuh.Regenerasi();

            // 3. Skill Sendiri (SlimeApi)
            musuh.LedakanApi();

            // Buat Slime Es
            SlimeEs musuh2 = new SlimeEs();
            musuh2.Nama = "Slime Cryo Level 60";
            musuh2.HP = 1500;

            // 1. Skill Kakek (Monster)
            musuh2.Jalan();

            // 2. Skill Bapak (Slime)
            musuh2.Regenerasi();

            // 3. Skill Sendiri (SlimeEs)
            musuh2.SemburanEs();

            Console.ReadKey();
        }
    }
}