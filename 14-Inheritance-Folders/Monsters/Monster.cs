using System;

namespace Belajar_CSharp.Monsters
{
    public class Monster
    {
        public string Nama;
        public int Level;

        public void Info()
        {
            Console.WriteLine($"[{Nama}] - Level {Level}");
        }
    }
}