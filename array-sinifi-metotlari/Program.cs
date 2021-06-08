using System;

namespace array_sinifi_metotlari
{
    class Program
    {
        static void Main(string[] args)
        {
            //sort
            System.Console.WriteLine("Sırasız Liste");
            int[] sayiDizisi = {23,12,4,86,72,3,11,17};
            foreach (var sayi in sayiDizisi)
            {
                System.Console.WriteLine(sayi);
                
            }

            //sırlama
            System.Console.WriteLine("Sıralı Liste");

            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                System.Console.WriteLine(sayi);
                
            }

            //Clear 
            System.Console.WriteLine("*** Array Clear ***");

            Array.Clear(sayiDizisi,2,2);

            foreach (var sayi in sayiDizisi)
            {
                System.Console.WriteLine(sayi);
                
            }

            //reverse
            System.Console.WriteLine("*** Array Reverse ***");

            Array.Reverse(sayiDizisi);

            foreach (var sayi in sayiDizisi)
            {
                System.Console.WriteLine(sayi);
                
            }


            //indexof 

            System.Console.WriteLine("*** Array IndexOf ***");

            System.Console.WriteLine(Array.IndexOf(sayiDizisi,23));


            //resize 

            System.Console.WriteLine("*** Array Resize");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8] = 99;

            foreach (var sayi in sayiDizisi)
            {
                System.Console.WriteLine(sayi);
                
            }

            Console.ReadLine();
        }
    }
}
