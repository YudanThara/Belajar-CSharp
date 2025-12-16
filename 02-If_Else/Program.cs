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
            If_statement();
            TestIfElse(11);
            TestSwitch(10, 2, '+');

            Console.WriteLine("\nTekan sembarang tombol untuk keluar...");
            Console.ReadKey();
        }

// ======== IF STATEMENT ========
        public static void If_statement()
        {
            int nilai1 = 80;
            int nilai2 = 60;

            if (nilai1 > nilai2)
            {
                Console.WriteLine("Nilai1 lebih besar dari Nilai2");
            }
        }

// ======== IF - ELSE STATEMENT ========
        public static void TestIfElse(int n)
        {
            if (n > 10)
            {
                Console.WriteLine("n lebih besar dari 10");
            }
            else if (n > 20)
            {
                Console.WriteLine("n lebih besar dari 20");
            }
            else
            {
                Console.WriteLine("n tidak lebih besar dari 10 dan 20");
            }
        }

        public static void TestSwitch(int op1, int op2, char opr)
        {
            int result;
            switch (opr)
            {
                case '+':
                    result = op1 + op2;
                    Console.WriteLine("Hasil: " + result);
                    break;
                case '-':
                    result = op1 - op2;
                    Console.WriteLine("Hasil: " + result);
                    break;
                case '*':
                    result = op1 * op2;
                    Console.WriteLine("Hasil: " + result);
                    break;
                case '/':
                    result = op1 / op2;
                    Console.WriteLine("Hasil: " + result);
                    if (op2 == 0)
                    {
                        Console.WriteLine("Peringatan: Pembagian dengan nol!");
                    }
                    break;
                default:
                    Console.WriteLine("Operator tidak dikenali");
                    return;
            }
        }
    }
}