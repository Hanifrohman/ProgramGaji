using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Program Penambahan Gaji";
            Karyawan ObjKaryawan = new Karyawan("123456", "Hariyono", 3000000);
            Karyawan ObjKaryawan2 = new Karyawan("654321", "Muldiyono", 2000000);

            Hasil(ObjKaryawan,ObjKaryawan2);

            Console.WriteLine("Asyiiiiikk Kenaikan Gaji 10%");
            Console.WriteLine();

            var result = (0.10 * ObjKaryawan.GajiBulanan) + ObjKaryawan.GajiBulanan;
            var result2 = (0.10 * ObjKaryawan2.GajiBulanan) + ObjKaryawan2.GajiBulanan;
            ObjKaryawan.GajiBulanan = Convert.ToInt32(result);
            ObjKaryawan2.GajiBulanan = Convert.ToInt32(result2);

            Hasil(ObjKaryawan, ObjKaryawan2);

            Console.ReadKey();
        }

        static void Hasil(Karyawan karyawan, Karyawan karyawan2)
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("  No. |   NIK    |        Nama        |    Gaji Bulanan");
            Console.WriteLine("-------------------------------------------------------");
            Console.Write("   1. ");
            Console.Write("\t{0}\t", karyawan.Nik);
            Console.Write("\t{0}\t", karyawan.Nama);
            Console.Write("\t{0}", karyawan.GajiBulanan);
            Console.WriteLine();
            Console.Write("   2. ");
            Console.Write("\t{0}\t", karyawan2.Nik);
            Console.Write("\t{0}\t", karyawan2.Nama);
            Console.Write("\t{0}", karyawan2.GajiBulanan);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
