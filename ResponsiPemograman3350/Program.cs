using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemograman3350
{
    public class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan("Arif", "20113350", 3000000);
            Karyawan karyawan2 = new Karyawan("Rizki", "19113350", 2000000);

            Console.WriteLine("NO   NIK / NAMA        Gaji Bulanan ");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("1. {0} {1}\t {2}", karyawan1.NIK, karyawan1.Nama, karyawan1.GajiBulanan);
            Console.WriteLine("2. {0} {1}\t {2}", karyawan2.NIK, karyawan2.Nama, karyawan2.GajiBulanan);
            Console.WriteLine();
            //Console.WriteLine("Alhamdulillah Naik Gaji 10%");
            Console.WriteLine();
            Console.WriteLine("NO   NIK / NAMA        Gaji Bulanan ");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("1. {0} {1}\t {2}", karyawan1.NIK, karyawan1.Nama, karyawan1.Naik);
            Console.WriteLine("2. {0} {1}\t {2}", karyawan2.NIK, karyawan2.Nama, karyawan2.Naik);

            Console.ReadKey();
        }
    }
}

