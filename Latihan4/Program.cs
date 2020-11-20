using System;

namespace Latihan4
{
    class Program
    {
        static void Main(string[] args)
        {
            float nilaiAbsen,nilaiTugas,nilaiUTS,nilaiUAS,nilaiAkhir;
            String nama, nim;

            Console.WriteLine("Aplikasi Penghitung Nilai Mahasiswa");
            Console.Write("Masukkan Nama Mahasiswa : ");
            nama = Console.ReadLine();

            Console.Write("Masukkan NIM Mahasiswa : ");
            nim = Console.ReadLine();

            Console.Write("Masukkan Nilai Absen Mahasiswa : ");
            nilaiAbsen = float.Parse(Console.ReadLine());

            Console.Write("Masukkan Nilai Tugas Mahasiswa : ");
            nilaiTugas = float.Parse(Console.ReadLine());

            Console.Write("Masukkan Nilai UTS Mahasiswa : ");
            nilaiUTS = float.Parse(Console.ReadLine());

            Console.Write("Masukkan Nilai UAS Mahasiswa : ");
            nilaiUAS = float.Parse(Console.ReadLine());

            nilaiAkhir = ((nilaiAbsen * 10 / 100)+(nilaiTugas * 20 / 100)+(nilaiUTS * 30 / 100)+(nilaiUAS * 40 / 100));

            Console.WriteLine("Nama Mahasiswa {0}", nama);
            Console.WriteLine("NIM Mahasiswa {0}", nim);


            if (nilaiAkhir >= 80)
            {
                Console.WriteLine("Nilai Akhir = {0}", nilaiAkhir);
                Console.WriteLine("Nilai Huruf = A");
            }
            else if (nilaiAkhir >= 70 && nilaiAkhir < 80)
            {
                Console.WriteLine("Nilai Akhir = {0}", nilaiAkhir);
                Console.WriteLine("Nilai Huruf = B");
            }
            else if (nilaiAkhir >= 56 && nilaiAkhir < 70)
            {
                Console.WriteLine("Nilai Akhir = {0}", nilaiAkhir);
                Console.WriteLine("Nilai Huruf = C");
            }
            else if (nilaiAkhir >= 40 && nilaiAkhir < 56)
            {
                Console.WriteLine("Nilai Akhir = {0}", nilaiAkhir);
                Console.WriteLine("Nilai Huruf = D");
            }
            else if (nilaiAkhir < 40)
            {
                Console.WriteLine("Nilai Akhir = {0}", nilaiAkhir);
                Console.WriteLine("Nilai Huruf = E");
            }

            if(nilaiAkhir >= 56)
            {
                Console.WriteLine("Anda dinyatakan : LULUS");
            } else
            {
                Console.WriteLine("Anda dinyatakan : TIDAK LULUS");
            }

            Console.ReadLine();
        }
    }
}
