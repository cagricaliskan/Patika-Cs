using System;
using System.Collections;

namespace q2
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("20 afet pozitif sayi giriniz");
            
            ArrayList sayi = new ArrayList();
            


            for(int i = 0; i<20; i++){
                System.Console.WriteLine("{0}. sayıyı giriniz", i+1);

                int x = int.Parse(Console.ReadLine());
                sayi.Add(i);
            }

            sayi.Sort();
            int max3 = 0;
            for(int i = sayi.Count; i >= sayi.Count-3; i++){
                max3 += i;
            }
            System.Console.WriteLine("max 3 : " + max3);

            int min3 = 0;
            for(int i = 0; i >= 3; i++){
                min3 += i;
            }
            System.Console.WriteLine("min 3 : " + max3);


            Console.ReadLine();
        }
    }
}
