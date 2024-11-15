using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args) {

        Program program = new Program();
        Console.WriteLine("Masukin nama bangun datar disini yuk!: ");
        Console.WriteLine("1. persegi ");
        Console.WriteLine("2. persegi panjang ");
        Console.WriteLine("3. belah ketupat ");
        Console.WriteLine("4. segitiga ");
        Console.WriteLine("\n");

        Console.WriteLine("pilih bangun datar mu! (pilih 1-4): ");
        int pilih = int.Parse(Console.ReadLine());

        switch (pilih) {
            case 1:
                Console.Write("masukan sisi persegi bjir: ");
                int sisi = int.Parse(Console.ReadLine());
                luasPersegi(sisi);
                break;

            case 2:
                Console.Write("masukan panjang persegi panjang bjir: ");
                int panjang = int.Parse(Console.ReadLine());
                Console.Write("masukan lebar persegi panjang bjir: ");
                int lebar = int.Parse(Console.ReadLine());
                Console.WriteLine($"luas persegi panjangnya ialah: {program.luasPersegiPanjang(panjang, lebar)}");
                break;

            case 3:
                Console.Write("masukan diagonal 1 belah ketupat bjir: ");
                int diagonal1 = int.Parse(Console.ReadLine());    
                Console.Write("masukan diagonal 2 belah ketupat bjir: ");
                int diagonal2 = int.Parse(Console.ReadLine());   
                Console.WriteLine($"luas belah ketupat ialah: {luasBelahKetupat(diagonal1, diagonal2)}");
                break;

            case 4:
                Console.Write("masukkan alas segitiga bjir: ");
                int alas = int.Parse(Console.ReadLine());
                Console.Write("masukkan tinggi segitiga bjir: ");
                int tinggi = int.Parse(Console.ReadLine());
                program.luasSegitiga(alas, tinggi);
                break;  
        }
        
    }

    // Method Static

    static void luasPersegi(int sisi) {
        int luas  = sisi * sisi;
        Console.WriteLine($"Luas persegi yaitu: {luas}");
    }

    // Method Static

    int luasPersegiPanjang(int panjang, int lebar){
        return panjang * lebar;
    }

    // Method Return

    static int luasBelahKetupat(int diagonal1, int diagonal2){
        return (diagonal1 * diagonal2)/2;
    }

    // Method non Retrun

    void luasSegitiga(int alas, int tinggi){
        double luas2 = alas * tinggi * 0.5;
        Console.WriteLine($"Luas segitiga yaitu: {luas2}");
    }
}