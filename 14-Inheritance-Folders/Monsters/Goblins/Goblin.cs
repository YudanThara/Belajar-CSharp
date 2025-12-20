using System;

namespace Belajar_CSharp.Monsters.Goblins
{
    public class Goblin : Monster
    {
        public string Senjata;

        public void CuriEmas()
        {
            Console.WriteLine(Nama + " mencuri emas pakai " + Senjata + "! 💰");
        }
    }
}