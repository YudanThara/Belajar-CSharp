using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Belajar_CSharp 
{
    public class Mahasiswa
{
    private string nama;
    private int umur;

    public void SetNama(string nama)
    {
        this.nama = nama;
    }

    public string GetNama()
    {
        return nama;
    }

    public void SetUmur(int umur)
    {
        if (umur > 0)
            this.umur = umur;
    }

    public int GetUmur()
    {
        return umur;
    }
}

}