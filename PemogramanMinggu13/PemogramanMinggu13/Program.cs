using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PemogramanMinggu13
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek mhs1
            Mahasiswa mhs1 = new Mahasiswa();
            mhs1.Nim = "4874";
            mhs1.NamaMahasiswa = "Cornel";

            // membuat objek mhs2
            Mahasiswa mhs2 = new Mahasiswa();
            mhs2.Nim = "4825";
            mhs2.NamaMahasiswa = "Anggie";

            // membuat objek dosen
            Dosen dosen = new Dosen();
            dosen.Nik = "4819";
            dosen.NamaDosen = "Ahmadi";

            // membuat objek list
            List<Mahasiswa> list = new List<Mahasiswa>();

            // menambahkan elemen list
            list.Add(mhs1);
            list.Add(mhs2);

            // mengakses elemen list
            // mahasiswa mhs = list[1];

            Console.WriteLine("Nim    Nama");
            Console.WriteLine("=============");

            foreach (Mahasiswa mhs in list)
            {
                Console.WriteLine("{0},  {1}", mhs.Nim, mhs.NamaMahasiswa);
            }

            Console.ReadKey();
        }
    }
}