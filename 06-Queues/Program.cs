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
            // Membuat Queue (Antrean) bertipe String
            Queue<string> antreanLogin = new Queue<string>();

            // 1. ENQUEUE (Masuk Antrean)
            // Menambahkan data ke belakang antrean
            antreanLogin.Enqueue("Yudan (Admin)");
            antreanLogin.Enqueue("Player_1");
            antreanLogin.Enqueue("Player_2");
            antreanLogin.Enqueue("Cheater_007");

            Console.WriteLine("=== STATUS SERVER: PENUH ===");
            Console.WriteLine("Total pemain dalam antrean: " + antreanLogin.Count);
            
            // 2. PEEK (Intip Siapa Paling Depan)
            // Cuma melihat data paling depan tanpa menghapusnya
            Console.WriteLine("Pemain berikutnya yang akan masuk: " + antreanLogin.Peek());
            Console.WriteLine("-----------------------------");

            // 3. DEQUEUE (Keluar Antrean / Masuk Game)
            // Mengambil data paling depan dan menghapusnya dari antrean
            Console.WriteLine("Sedang memproses login...");
            
            string userMasuk = antreanLogin.Dequeue(); // Yudan keluar antrean -> Masuk game
            Console.WriteLine("[INFO] " + userMasuk + " berhasil masuk ke dalam game!");

            string userKedua = antreanLogin.Dequeue(); // Player_1 keluar antrean
            Console.WriteLine("[INFO] " + userKedua + " berhasil masuk ke dalam game!");

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Sisa antrean sekarang: " + antreanLogin.Count);

            // 4. PRINT SISA ANTREAN (Looping)
            Console.WriteLine("Daftar pemain yang masih menunggu:");
            foreach (string nama in antreanLogin)
            {
                Console.WriteLine("- " + nama);
            }

            Console.ReadKey();
        }
    }
}