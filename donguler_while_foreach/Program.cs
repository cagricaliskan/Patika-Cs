using System;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //while 
            // 1den başlayarak console'dan alınan sayıya kadar (sayı dahil) ortalama hesaplayıp console'a yazdıran program.
            System.Console.WriteLine("Bir sayı giriniz.");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }

            System.Console.WriteLine("Ortalama: " + (toplam / sayi));


            //adan zye kadar olan sayıları konsole yazdır
            char c = 'a';
            while (c < 'z')
            {
                System.Console.WriteLine(c);
                c++;
            }



            System.Console.WriteLine("***** FOREACH *****");

            string[] arabalar = {"BMW" , "Ford", "Audi"};

            foreach (var item in arabalar)
            {
                System.Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
