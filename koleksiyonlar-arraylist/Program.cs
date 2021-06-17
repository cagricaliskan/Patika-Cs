using System;
using System.Collections;
using System.Collections.Generic;

namespace koleksiyonlar_arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();

            // liste.Add("Ayşe");
            // liste.Add(2);
            // liste.Add(true);
            // liste.Add('A');

            // Console.WriteLine(liste[1]);

            // foreach (var item in liste)
            // {
            //     System.Console.WriteLine(item);
            // }


            //addRange
            System.Console.WriteLine("*** Add Range ***");

            // string[] renkler = {"kırmızı", "sarı", "yesil"};
            // liste.AddRange(renkler);
            List<int> sayılar = new List<int>(){1,8,3,7,9,92,5};
            liste.AddRange(sayılar);
            foreach (var item in liste)
            {
                System.Console.WriteLine(item);
            }

            //binary search 
            System.Console.WriteLine("*** Binary Search ***");
            liste.Sort();
            System.Console.WriteLine(liste.BinarySearch(9));

            //Reverse
            System.Console.WriteLine("*** Reverse ***");
            liste.Reverse();

            foreach (var item in liste)
            {
                System.Console.WriteLine(item);                
            }

            //clear
            System.Console.WriteLine("*** Clear ***");

            liste.Clear();

            Console.ReadLine();
        }
    }
}
