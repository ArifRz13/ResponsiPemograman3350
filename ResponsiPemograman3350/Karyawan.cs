using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemograman3350
{
    public class Karyawan
    {
        public string Nama { get; set; }
        public string NIK { get; set; }
        public int GajiBulanan { get; set; }
        public int Naik { get; set; }

        public Karyawan(string nama, string nik, int gaji)
        {
            this.NIK = nik;
            this.Nama = nama;
            if (gaji < 0)
            {
                this.GajiBulanan = 0;
                Naik = Convert.ToInt32((GajiBulanan * 1.1));
            }
            else
            {
                this.GajiBulanan = gaji;
                Naik = Convert.ToInt32((GajiBulanan * 1.1));
            }
        }
    }
}
