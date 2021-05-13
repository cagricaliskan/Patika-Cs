using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            //atama ve işlem 
            int x = 1;
            int y = 3;
            y = y+2; 
            int result = x + y;
            Console.WriteLine(result);

            y+=3;
            Console.WriteLine(y);

            y/=1;
            Console.WriteLine(y);

            x*=3;
            Console.WriteLine(x);


            bool isSuc = true;
            bool isComp = false;

            if(isSuc && isComp)Console.WriteLine("Perfect");

            if(isSuc || isComp)System.Console.WriteLine("Great!");

            if(isSuc && !isComp)System.Console.WriteLine("Fine!");


            int a = 3;
            int b = 4;
            bool sonuc = a<b;

            System.Console.WriteLine(sonuc);
            sonuc = a>b;
            System.Console.WriteLine(sonuc);
            sonuc = a>=b;
            System.Console.WriteLine(sonuc);
            sonuc = a<=b;
            System.Console.WriteLine(sonuc);
            sonuc = a==b;
            System.Console.WriteLine(sonuc);
            sonuc = a!=b;
            System.Console.WriteLine(sonuc);


            System.Console.WriteLine("*** Aritmetik Operatörler ***");

            int sayi1 = 10;
            int sayi2 = 7;
            int sonuc1 = sayi1/sayi2;
            System.Console.WriteLine(sonuc1);
            sonuc1 = sayi1*sayi2;
            sonuc1 = sayi1+sayi2;
            sonuc1 = sayi1 ++;


            int sonuc2 = 20%3;
            System.Console.WriteLine(sonuc2);


            Console.ReadLine();

        }
    }
}
