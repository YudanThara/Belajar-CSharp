using System;
using System.Collections.Generic;

namespace Belajar_CSharp
{
    // 1. MEMBUAT INTERFACE (KONTRAK KEMAMPUAN)
    // Aturannya mirip Abstract: Cuma judul method, gak ada isinya.
    // Bedanya: Pakai kata 'interface', bukan 'class'.
    interface IKendaraan
    {
        void Gas(); // Wajib bisa nge-gas
        void Rem(); // Wajib bisa nge-rem
    }

    // 2. CLASS MOBIL (Benda Mati)
    // Mobil 'mengimplementasikan' IKendaraan
    class Mobil : IKendaraan
    {
        public string Merk;

        public Mobil(string merk)
        {
            Merk = merk;
        }

        // Wajib ada karena kontrak IKendaraan
        public void Gas()
        {
            Console.WriteLine($"{Merk} melaju: Vrooom... Ngeng!");
        }

        public void Rem()
        {
            Console.WriteLine($"{Merk} berhenti: Ciittt...");
        }
    }

    // 3. CLASS KUDA (Makhluk Hidup)
    // Lihat! Kuda ini hewan, tapi dia juga IKendaraan.
    class Kuda : IKendaraan
    {
        public string Nama;

        public Kuda(string nama)
        {
            Nama = nama;
        }

        // Implementasi Gas-nya Kuda beda sama Mobil
        public void Gas()
        {
            Console.WriteLine($"{Nama} berlari: Hiyaaa! Tuk tik tak tik tuk...");
        }

        public void Rem()
        {
            Console.WriteLine($"{Nama} berhenti: Prrrrt! (Tarik tali kekang)");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BELAJAR INTERFACE (KONTRAK SKILL) ===\n");

            // Kita buat Garasi yang isinya IKendaraan
            // Tidak peduli itu benda mati atau hewan, asal punya label 'IKendaraan', boleh masuk.
            List<IKendaraan> garasi = new List<IKendaraan>();

            garasi.Add(new Mobil("Toyota Avanza"));
            garasi.Add(new Kuda("Si Putih"));
            garasi.Add(new Mobil("Tesla Model S"));

            Console.WriteLine("--- Tes Semua Kendaraan di Garasi ---");
            
            foreach (IKendaraan k in garasi)
            {
                // Kita gak tau ini aslinya Kuda atau Mobil
                // Tapi kita YAKIN 100% dia punya tombol Gas dan Rem.
                k.Gas();
                k.Rem();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}