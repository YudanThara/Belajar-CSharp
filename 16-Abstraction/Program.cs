using System;
using System.Collections.Generic;

namespace Belajar_CSharp
{
    // 1. CLASS ABSTRACT (KONSEP)
    // Class ini "Gaib". Tidak bisa di-new ItemLoot()
    // Fungsinya cuma sebagai kerangka dasar
    abstract class ItemLoot
    {
        public string Nama;

        // Method Biasa (Boleh ada isinya)
        public void Ambil()
        {
            Console.WriteLine($"[INFO] Kamu memungut {Nama} dari tanah.");
        }

        // METHOD ABSTRACT (KONTRAK MATI)
        // Tidak boleh ada isinya (kurung kurawal {})
        // Siapapun yang mewarisi class ini, WAJIB bikin isi method ini
        public abstract void Gunakan(); 
    }

    // 2. CLASS NYATA (HEALTH POTION)
    class HealthPotion : ItemLoot
    {
        public HealthPotion()
        {
            Nama = "Ramuan Merah";
        }

        // WAJIB ngetik 'override' dan ngisi kodingannya
        // Kalau dihapus, program bakal ERROR merah
        public override void Gunakan()
        {
            Console.WriteLine("Gluk.. Gluk.. Darah bertambah +50 HP! ❤️");
        }
    }

    // 3. CLASS NYATA (BOM ASAP)
    class BomAsap : ItemLoot
    {
        public BomAsap()
        {
            Nama = "Smoke Bomb";
        }

        public override void Gunakan()
        {
            Console.WriteLine("BOOF!! Menghilang dalam asap... Ninja Mode On! 💨");
        }
    }

    // 4. CLASS NYATA (COIN)
    class Coin : ItemLoot
    {
        public Coin()
        {
            Nama = "Koin Emas";
        }

        public override void Gunakan()
        {
            Console.WriteLine("Cling! Uang bertambah +100 Gold. 💰");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BELAJAR ABSTRACTION (KONTRAK CLASS) ===\n");

            // ItemLoot item = new ItemLoot(); // <--- PASTI ERROR
            // Karena barang abstract gak bisa dibeli/dibuat

            // Kita buat list tas inventaris
            List<ItemLoot> tas = new List<ItemLoot>();

            // Isi tas dengan barang-barang nyata
            tas.Add(new HealthPotion());
            tas.Add(new BomAsap());
            tas.Add(new Coin());

            // Loop untuk menggunakan semua item
            foreach (ItemLoot item in tas)
            {
                item.Ambil();   // Method biasa (warisan)
                item.Gunakan(); // Method abstract (hasil paksaan override)
                Console.WriteLine("----------------");
            }

            Console.ReadKey();
        }
    }
}