using System;

namespace Belajar_CSharp
{
    // SlimeEs adalah anak Slime
    public class SlimeEs : Slime
    {
        // Skill khusus tipe Es
        public void SemburanEs()
        {
            Console.WriteLine(Nama + " menyemburkan es! ❄️");
        }
    }
}