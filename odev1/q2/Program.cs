using System;

namespace q2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            int[] numbers = new int[x];
            
            System.Console.WriteLine("{0} adet sayı giriniz.", x);
            
            for (int i = 0; i < x; i++)
            {
                Console.Write("{0}. sayi: ", i+1);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            System.Console.WriteLine("Bolen degerini giriniz.");
            int bolen = int.Parse(Console.ReadLine());

            System.Console.WriteLine("*** Bolene tam bolunen sayılar ***");
            foreach (var item in numbers)
            {
                if(item%bolen == 0)
                {
                    System.Console.WriteLine(item);
                }
            }


            Console.ReadLine();
        }
    }
}
