using System;
using System.Collections.Generic;

namespace koleksiyonlar_generic
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<T> T=> object türündedir.

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(10);
            sayiListesi.Add(12);
            sayiListesi.Add(13);
            sayiListesi.Add(52);
            sayiListesi.Add(2);
            sayiListesi.Add(56);
            sayiListesi.Add(75);


            List<string> renk = new List<string>();

            renk.Add("kırmızı");
            renk.Add("sarı");
            renk.Add("beyaz");

            //Count

            System.Console.WriteLine(renk.Count);
            System.Console.WriteLine(sayiListesi.Count);

            System.Console.WriteLine("*** Tüm renkler ***");
            foreach (var item in renk)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine("*** Tüm sayılar ***");
            foreach (var item in sayiListesi)
            {
                System.Console.WriteLine(item);
            }

            sayiListesi.ForEach(sayi => System.Console.WriteLine(sayi));
            renk.ForEach(renks => System.Console.WriteLine(renks));


            //Listeden çıkarma
            sayiListesi.Remove(75);
            renk.Remove("kırmızı");
            sayiListesi.ForEach(sayi => System.Console.WriteLine(sayi));
            renk.ForEach(renks => System.Console.WriteLine(renks));

            sayiListesi.RemoveAt(0);
            renk.RemoveAt(1);
            sayiListesi.ForEach(sayi => System.Console.WriteLine(sayi));
            renk.ForEach(renks => System.Console.WriteLine(renks));


            if(sayiListesi.Contains(10)){
                System.Console.WriteLine("10 liste içerisinde bulundu");
            }

            //eleman ile indexe erişme
            System.Console.WriteLine(sayiListesi.BinarySearch(56));

            //diziyi liste çevirme
            string[] hayvanlar = {"Kedi", "Köpek", "Kuş"};

            List<string> hayvanlarListesi = new List<string>(hayvanlar);

            //listeyi temizleme
            hayvanlarListesi.Clear();

            Console.ReadLine();
        }
    }
}
