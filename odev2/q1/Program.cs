using System;
using System.Collections;

namespace q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("20 afet pozitif sayi giriniz");
            
            ArrayList aritmetik = new ArrayList();
            ArrayList nonaritmetik = new ArrayList();


            for(int i = 0; i<20; i++){
                System.Console.WriteLine("{0}. sayıyı giriniz", i+1);

                string x = Console.ReadLine();

                if(int.TryParse(x, out int number) && number >= 0)
                {
                    if(Prime(number)){
                        aritmetik.Add(number);
                    }else {
                        nonaritmetik.Add(number);
                    }
                }
            }

            aritmetik.Sort();
            nonaritmetik.Sort();

            System.Console.WriteLine("*** Sıralı aritmetik sayılar ***");
            foreach (var item in aritmetik)
            {
                System.Console.WriteLine(item);
            }


            System.Console.WriteLine("*** Sıralı aritmetik olmayan sayılar ***");
            foreach (var item in nonaritmetik)
            {
                System.Console.WriteLine(item);
            }

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
