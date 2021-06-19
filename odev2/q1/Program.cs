using System;
using System.Collections;

namespace q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("20 afet pozitif sayi giriniz");
            
            ArrayList asal = new ArrayList();
            ArrayList nonasal = new ArrayList();
            int aToplam=0;
            int nToplam =0;


            for(int i = 0; i<20; i++){
                System.Console.WriteLine("{0}. sayıyı giriniz", i+1);

                string x = Console.ReadLine();

                if(int.TryParse(x, out int number) && number >= 0)
                {
                    if(Prime(number)){
                        asal.Add(number);
                    }else {
                        nonasal.Add(number);
                    }
                }
            }

            asal.Sort();
            nonasal.Sort();

            System.Console.WriteLine("*** Sıralı aritmetik sayılar ***");
            foreach (var item in asal)
            {
                System.Console.WriteLine(item);
            }


            System.Console.WriteLine("*** Sıralı aritmetik olmayan sayılar ***");
            foreach (var item in nonasal)
            {
                System.Console.WriteLine(item);
            }

            for(int i = 0; i < asal.Count; i++){
                aToplam += i;
            }

            for(int i = 0; i < nonasal.Count; i++){
                nToplam += i;
            }

            System.Console.WriteLine("Aritmetik sayıların ortalaması {0}",aToplam/asal.Count);
            System.Console.WriteLine("Aritmetik olmayan sayıların ortalaması {0}",nToplam/nonasal.Count);

            Console.ReadLine();

        }


        public static bool Prime(int n){
        int i, m=0;
        m = n/2;   
        for(i = 2; i <= m; i++)    
          {    
           if(n % i == 0)    
            {    
             return true;  
            }  
          }    
          return false;        
        }
    }
}
