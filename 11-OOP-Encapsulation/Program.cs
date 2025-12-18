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
        Mahasiswa mhs1 = new Mahasiswa();

        mhs1.SetNama("Yudan Prihantara");
        mhs1.SetUmur(19);

        Console.WriteLine("Data Mahasiswa:");
        Console.WriteLine("Nama : " + mhs1.GetNama());
        Console.WriteLine("Umur : " + mhs1.GetUmur());

        Console.ReadLine();
        }
    }
}