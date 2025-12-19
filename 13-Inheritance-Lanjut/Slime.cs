using System;

namespace Belajar_CSharp
{
    // Slime adalah anak Monster
    public class Slime : Monster
    {
        // Semua slime tubuhnya kenyal
        public void Regenerasi()
        {
            Console.WriteLine(Nama + " meregenerasi HP karena tubuhnya kenyal.");
        }
    }
}