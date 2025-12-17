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
            Console.WriteLine("=== DEMO FILE TERPISAH ===");

            Hero heroBaru = new Hero();
            heroBaru.Nama = "Rover (MC)";
            heroBaru.Level = 50;

            heroBaru.PerkenalkanDiri();

            Console.ReadKey();
        }
    }
}