using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPolyDanCol
{
   class Program
   {
       static void Main(string[] args)
       {
           KaryawanTetap karyawanTetap = new KaryawanTetap();
           karyawanTetap.NIK = "14080819112736";
           karyawanTetap.Nama = "Arif Yusuf";
           karyawanTetap.GajiBulanan = 3500000;

           KaryawanHarian karyawanHarian = new KaryawanHarian();
           karyawanHarian.NIK = "14080819112734";
           karyawanHarian.Nama = "Nurwicaksana";
           karyawanHarian.JumlahJamKerja = 10;
           karyawanHarian.UpahPerJam = 15000;

           Sales sales = new Sales();
           sales.NIK = "14080819112766";
           sales.Nama = "Bayu Pamungkas";
           sales.JumlahPenjualan = 20;
           sales.Komisi = 50000;

           List<Karyawan> listKaryawan = new List<Karyawan>();

           listKaryawan.Add(karyawanTetap);
           listKaryawan.Add(karyawanHarian);
           listKaryawan.Add(sales);

           int noUrut = 1;

           foreach (Karyawan karyawan in listKaryawan)
           {
           Console.WriteLine("{0}. NIK: {1}, Nama: {2}, Gaji: {3:N0}",
           noUrut, karyawan.NIK, karyawan.Nama, karyawan.Gaji());

           noUrut++;
           }
           Console.ReadKey();
       }
   }
}