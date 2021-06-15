using System;

namespace q1
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

            System.Console.WriteLine("*** Cift Sayilar ***");
            foreach (var item in numbers)
            {
                if(item%2 == 0)
                {
                    System.Console.WriteLine(item);
                }
            }


            Console.ReadLine();
        }
    }
}
