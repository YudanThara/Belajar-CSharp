using System;
using System.Collections.Generic; // Wajib ada untuk pakai List

namespace Belajar_CSharp
{
    // 1. CLASS INDUK (BAPAK)
    class Monster
    {
        public string Nama;

        // KATA KUNCI 1: "virtual"
        // Artinya: Method ini BOLEH ditimpa/diubah oleh anak-anaknya.
        public virtual void Serang()
        {
            Console.WriteLine(Nama + " melakukan serangan standar (Pukul).");
        }
    }

    // 2. CLASS ANAK (ZOMBIE)
    class Zombie : Monster
    {
        // KATA KUNCI 2: "override"
        // Artinya: Kita ganti jurus Bapak dengan jurus kita sendiri.
        public override void Serang()
        {
            Console.WriteLine(Nama + " MENGGIGIT otak pemain! 🧟‍♂️");
        }
    }

    // 3. CLASS ANAK (NAGA)
    class Naga : Monster
    {
        public override void Serang()
        {
            Console.WriteLine(Nama + " MENYEMBURKAN Api Panas! 🔥");
        }
    }

    // 4. CLASS ANAK (SLIME)
    class Slime : Monster
    {
        // Slime tidak pakai 'override'.
        // Artinya: Dia pasrah mengikuti gaya Bapaknya (Pukulan standar).
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BELAJAR POLYMORPHISM (BANYAK BENTUK) ===\n");

            // Membuat objek-objek
            Monster m1 = new Zombie();
            m1.Nama = "Zombie Kampung";

            Monster m2 = new Naga();
            m2.Nama = "Naga Indosiar";

            Monster m3 = new Slime(); // Slime yang penurut
            m3.Nama = "Slime Polos";

            // --- INI KEAJAIBANNYA! (The Power of Polymorphism) ---
            // Kita bisa masukkan mereka semua ke dalam SATU List yang sama
            // padahal jenisnya beda-beda. Kok bisa? Karena bapaknya sama (Monster).
            
            List<Monster> pasukan = new List<Monster>();
            pasukan.Add(m1);
            pasukan.Add(m2);
            pasukan.Add(m3);

            Console.WriteLine("Jenderal berteriak: 'SERANG!!!'\n");

            // Kita loop (putar) satu per satu
            foreach (Monster m in pasukan)
            {
                // Perintahnya SAMA persis: .Serang()
                // Tapi hasilnya BEDA-BEDA tergantung siapa dia.
                m.Serang(); 
            }

            Console.ReadKey();
        }
    }
}