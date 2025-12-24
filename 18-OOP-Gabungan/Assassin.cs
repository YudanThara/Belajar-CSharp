using System;

namespace Belajar_CSharp
{
    // INHERITANCE: Anak Hero
    // IMPLEMENTS: Punya IKemampuan
    public class Assassin : Hero, IKemampuan
    {
        // Constructor (Setup awal)
        public Assassin(string nama)
        {
            Nama = nama;
            Energy = 100; // Set energy awal full
        }

        // POLYMORPHISM (Override): Serangan dasar Assassin
        public override void Serang()
        {
            if (Energy >= 10)
            {
                Console.WriteLine($"{Nama} melempar pisau rasi bintang! (Energy -10)");
                Energy -= 10; // Kurangi energy lewat Property
            }
            else
            {
                Console.WriteLine($"{Nama} kelelahan... butuh istirahat!");
            }
        }

        // INTERFACE IMPLEMENTATION: Skill Ultimate
        public void Ultimate()
        {
            Console.WriteLine($"\n{Nama} mengaktifkan SHADOW DANCE! (Critical Hit!)");
            Console.WriteLine("Musuh langsung tewas seketika!");
        }
    }
}