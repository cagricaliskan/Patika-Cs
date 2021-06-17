using System;
using System.Collections.Generic;

namespace koleksiyonlar_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> kullanıcılar = new Dictionary<int, string>();

            kullanıcılar.Add(10,"Ayşe Yılmaz");
            kullanıcılar.Add(12,"Ahmet Yılmaz");
            kullanıcılar.Add(18,"Deniz Arda");
            kullanıcılar.Add(20,"Özcan Coşar");

            //Dizi elemanlarına erişim
            System.Console.WriteLine("*** Elemanlara Erişim ***");
            System.Console.WriteLine(kullanıcılar[12]);

            foreach (var item in kullanıcılar)
            {
                System.Console.WriteLine(item);                
            }


            //contains
            System.Console.WriteLine("*** Contains ***");

            System.Console.WriteLine(kullanıcılar.ContainsKey(12));
            System.Console.WriteLine(kullanıcılar.ContainsValue("Zikriye Ürkmez"));

            //keys
            System.Console.WriteLine("*** Keys ***");
            foreach (var item in kullanıcılar.Keys)
            {
                System.Console.WriteLine(item);
            }

            //values
            System.Console.WriteLine("*** Values ***");
            foreach (var item in kullanıcılar.Values)
            {
                System.Console.WriteLine(item);
            }


            Console.ReadLine();

        }
    }
}
