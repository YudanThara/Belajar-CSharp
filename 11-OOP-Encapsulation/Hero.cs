using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Belajar_CSharp 
{
    class Hero
    {
        // 1. DATA RAHASIA (Private)
        // Biasanya diawali garis bawah (_namaVariabel) atau huruf kecil.
        // Orang luar TIDAK BISA sentuh ini langsung.
        private int _hp; 

        // 2. SATPAM (Public Property)
        // Ini pintu aksesnya. Huruf besar (PascalCase).
        public int HP
        {
            // GET: Orang cuma mau lihat/baca "Berapa darahnya sekarang?"
            get 
            { 
                return _hp; // Silakan ambil data dari brankas.
            }

            // SET: Orang mau ubah "Ganti darahnya jadi X dong!"
            set 
            { 
                // Disini kita bisa pasang IF (Validasi)!
                // 'value' adalah angka baru yang mau dimasukkan.
                
                if (value < 0) 
                {
                    // Kalau diisi minus, paksa jadi 0 (Mati).
                    Console.WriteLine("⚠️ Error: Darah gak boleh minus! Dianggap 0.");
                    _hp = 0; 
                }
                else if (value > 100)
                {
                    // Kalau diisi kebanyakan, mentokin ke 100.
                    Console.WriteLine("⚠️ Error: Overheal! Mentok di 100.");
                    _hp = 100;
                }
                else
                {
                    // Kalau angkanya wajar, ya silakan masuk.
                    _hp = value;
                }
            }
        }
    }
}