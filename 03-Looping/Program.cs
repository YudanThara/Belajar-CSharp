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
            For_Loop();
            While_Loop();
            Do_While_Loop();
            Foreach_Loop();
            Factorial(5);

            Console.WriteLine("\nTekan sembarang tombol untuk keluar...");
            Console.ReadKey();
        }

// ======== FOR LOOP ========
        public static void For_Loop()
        {
            Console.WriteLine("For Loop:");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Perulangan ke-" + i);
            }
        }

// ======== WHILE LOOP ========
        public static void While_Loop()
        {
            Console.WriteLine("\nWhile Loop:");
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine("Perulangan ke-" + i);
                i++;
            }
        }

// ======== DO WHILE LOOP ========
        public static void Do_While_Loop()
        {
            Console.WriteLine("\nDo While Loop:");
            int i = 1;
            do
            {
                Console.WriteLine("Perulangan ke-" + i);
                i++;
            } while (i <= 5);
        }

// ======== FOREACH LOOP ========
        public static void Foreach_Loop()
        {
            Console.WriteLine("\nForeach Loop:");
            string[] buah = { "Apel", "Pisang", "Mangga", "Jeruk" };
            foreach (string b in buah)
            {
                Console.WriteLine("Buah: " + b);
            }
        }

// ======== RECURSION ========
        public static int Factorial(int n)
        {
            Console.WriteLine("\nRecursion (Factorial):");
            if (n == 0)
            {
                return 1;
            }
            else
            {
                int result = n * Factorial(n - 1);
                Console.WriteLine("Factorial(" + n + ") = " + result);
                return result;
            }
        }
    }
}
