using System;

namespace Belajar_CSharp
{
    // SlimeApi adalah anak Slime
    public class SlimeApi : Slime
    {
        // Skill khusus tipe Api
        public void LedakanApi()
        {
            Console.WriteLine(Nama + " meledakkan diri! BOOM! 🔥");
        }
    }
}