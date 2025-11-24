// See https://aka.ms/new-console-template for more information

using System;

namespace tip_donusumleri
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // Implicit Conversion (Bilinçsiz Dönüşüm)
            Console.WriteLine("Implicit Conversion:");

            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine("d: " + d);

            long h = d;
            Console.WriteLine("h: " + h);

            float i = h;
            Console.WriteLine("i: " + i);

            string e = "Mehmet";
            char f = 'k';
            object g = e + f + d;
            Console.WriteLine("g: " + g);

            // Explicit Conversion (Bilinçli Dönüşüm)
            Console.WriteLine("\nExplicit Conversion:");

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y: " + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t: " + t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v: " + v);

            // ToString Methodu
            Console.WriteLine("\nToString Method:");
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy: " + yy);
            float zz = 12.5f;
            string tt = zz.ToString();
            Console.WriteLine("tt: " + tt);
            // System.Convert Sınıfı
            Console.WriteLine("\nSystem.Convert Class:");
            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int toplam;
            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + toplam);
            
            // Parse Methodu
            Console.WriteLine("\nParse Method:");
            string s3 = "5", s4 = "15";
            int num1 = int.Parse(s3);
            int num2 = int.Parse(s4);
            Console.WriteLine("num1: " + num1);
            Console.WriteLine("num2: " + num2);
        }
    }
}

