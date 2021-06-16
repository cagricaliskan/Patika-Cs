using System;

namespace q3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Kac kelime girmek istersiniz?");
            int x = int.Parse(Console.ReadLine());

            string[] kelimeler = new string[x];

            for (int i = 0; i < x; i++)
            {
                System.Console.WriteLine("{0}. kelimeyi giriniz: ", i+1);
                kelimeler[i] = Console.ReadLine();
            }

            System.Console.WriteLine("*** Girilen Kelimeler ***");
            foreach (var item in kelimeler)
            {
                System.Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
