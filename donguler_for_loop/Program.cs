using System;

namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {

            //ekrana girilen sayıya kadar olan tek sayıları ekrana yazıdr.
            System.Console.WriteLine("Sayı giriniz");
            int sayac = int.Parse(Console.ReadLine());

            for (int i = 0; i <=  sayac; i++)
            {
                if(i % 2 == 1){
                    System.Console.WriteLine(i);
                }
            }

            //1 ile 1000 arasındaki tek ve çift sayıların kendi içlerindeki toplamlarını ekrana yazdır.
            int tek = 0;
            int cift = 0;

            for (int i = 0; i < 1000; i++)
            {
                if(i%2==1){
                    tek += i;
                } else {
                    cift +=i;
                }
            }

            System.Console.WriteLine("Tek sayıların toplamı: " + tek);
            System.Console.WriteLine("Cift sayıların toplamı: " +cift);


            //break continue

            for (int i = 0; i < 10; i++)
            {
                if(i==4){
                    break;  
                }
                 System.Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i++)
            {
                if(i==4){
                    continue;
                }
                System.Console.WriteLine(i);
                
            }

            Console.ReadLine();
        }
    }
}
