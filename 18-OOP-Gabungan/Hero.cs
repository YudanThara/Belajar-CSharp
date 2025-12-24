using System;

namespace Belajar_CSharp
{
    // ABSTRACT: Template dasar hero
    public abstract class Hero
    {
        public string Nama;
        
        // ENCAPSULATION: Energy diproteksi
        private int _energy;

        public int Energy
        {
            get { return _energy; }
            set 
            {
                if (value < 0) _energy = 0;
                else if (value > 100) _energy = 100;
                else _energy = value;
            }
        }

        // ABSTRACT METHOD: Wajib punya serangan dasar
        public abstract void Serang();
    }
}