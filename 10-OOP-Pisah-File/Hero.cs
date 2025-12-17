using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Belajar_CSharp
{
    public class Hero
    {
        public string Nama;
        public int Level;

        public void PerkenalkanDiri()
        {
            Console.WriteLine("Halo! Saya " + Nama + ", Level " + Level);
        }
    }
}