using System;

namespace tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit conversion
            System.Console.WriteLine("*** Implicit ***");
            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            System.Console.WriteLine(d);

            float f = d;
            System.Console.WriteLine(f);

            
            
            //Explicit conversion
            System.Console.WriteLine("*** Explicit ***");

            int x = 4;
            byte y = (byte)x;
            System.Console.WriteLine(y);

            float w = 10.3f;
            byte v = (byte)w;
            System.Console.WriteLine(v);

            //ToString
            System.Console.WriteLine("** ToString **");

            int xx = 6;
            string yy = xx.ToString();
            System.Console.WriteLine(yy);

            //Convert
            System.Console.WriteLine("** Convert **");
            string s1 = "10", s2 = "20";

            int sayi1 , sayi2;

            sayi1  = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            int toplam = sayi1 + sayi2;

            System.Console.WriteLine(toplam);

            System.Console.WriteLine("*** parse ***");
            ParseMethod();

            Console.ReadLine();
        }
        public static void ParseMethod(){
            string m1 = "10";
            string m2 = "10.25";
            int rakam;
            double d;

            rakam = Int32.Parse(m1);
            d = Double.Parse(m2);

            System.Console.WriteLine("sayi 1 : " + rakam);
            System.Console.WriteLine("sayi 2 : " + d);

        }
            
    }
}
