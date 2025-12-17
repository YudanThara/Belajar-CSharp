using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Belajar_CSharp
{
    // CLASS (CETAKAN)
    // Class tidak bisa jalan sendiri, dia cuma konsep/desain.
    class Hero
    {
        // Attribute (Data)
        public string Nama;
        public string Element;
        public int Level;
        public int AttackPower;

        // Method (Perilaku/Skill)
        public void Serang()
        {
            Console.WriteLine(Nama + " menyerang musuh! (DMG: " + AttackPower + ")");
        }

        public void Healing()
        {
            Console.WriteLine(Nama + " sedang memulihkan diri... HP penuh kembali!");
        }

        public void Info()
        {
            Console.WriteLine("--- STATUS HERO ---");
            Console.WriteLine("Nama    : " + Nama);
            Console.WriteLine("Element : " + Element);
            Console.WriteLine("Level   : " + Level);
        }
    }

    // 2. PROGRAM UTAMA
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BELAJAR OOP: CLASS & OBJECT ===\n");

            // Membuat Object 1 (Hero Pertama)
            // Pakai cetakan 'Hero' untuk membuat 'hero1'
            Hero hero1 = new Hero();
            
            // Mengisi data hero1
            hero1.Nama = "Jiyan";
            hero1.Element = "Aero (Angin)";
            hero1.Level = 80;
            hero1.AttackPower = 2500;

            // Memanggil perilaku hero1
            hero1.Info();
            hero1.Serang();

            Console.WriteLine(); // Spasi kosong

            // Membuat Object 2 (Hero Kedua)
            // Pakai cetakan yang sama, tapi isinya beda
            Hero hero2 = new Hero();
            hero2.Nama = "Yinlin";
            hero2.Element = "Electro (Listrik)";
            hero2.Level = 70;
            hero2.AttackPower = 2100;

            // Memanggil perilaku hero2
            hero2.Info();
            hero2.Serang();
            hero2.Healing();

            Console.ReadKey();
        }
    }
}