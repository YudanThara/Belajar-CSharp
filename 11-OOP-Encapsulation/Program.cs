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
        Hero mc = new Hero();

        // Percobaan 1: Normal
        mc.HP = 80;  // Masuk ke 'set', dicek if-else, lolos. _hp jadi 80.
        Console.WriteLine(mc.HP); // Output: 80

        // Percobaan 2: Ngawur Minus
        mc.HP = -50; 
        // Masuk 'set', kena validasi (value < 0). 
        // Output: ⚠️ Error: Darah gak boleh minus! Dianggap 0.
        // Nilai _hp sekarang jadi 0.

        // Percobaan 3: Ngawur Kebanyakan
        mc.HP = 5000;
        // Masuk 'set', kena validasi (value > 100).
        // Output: ⚠️ Error: Overheal! Mentok di 100.
        // Nilai _hp sekarang jadi 100.
        }
    }
}