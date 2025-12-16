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
            ExceptionTest();
            TryCatchFinally();

            Console.WriteLine("\nTekan sembarang tombol untuk keluar...");
            Console.ReadKey();
        }

// ======== Exception Handling with try-catch ========
        public static void ExceptionTest()
        {
            StreamReader sr = null;
            try
            {
                sr = File.OpenText("04-Exception_handling\\catatan.txt");
                Console.WriteLine(sr.ReadToEnd());
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

// ======= Finally Block Example ========
        public static void TryCatchFinally()
        {
            StreamReader sr = null;
            try
            {
                sr = File.OpenText("04-Exception_handling\\catatan.txt");
                Console.WriteLine(sr.ReadToEnd());
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                    Console.WriteLine("StreamReader ditutup.");
                }
            }
        }
    }
}
