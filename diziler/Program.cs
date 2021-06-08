using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //dizi tanımlama 
            string[] renkler = new String[5];

            string[] hayvanlar = {"Kedi", "Köpek" , "Güvercin"}; 

            int[] dizi;
            dizi = new int[5];

            //değer atama

            renkler[0] = "Kırmızı";
            System.Console.WriteLine(hayvanlar[2]);

            dizi[3] = 10;

            System.Console.WriteLine(dizi[3]);
            System.Console.WriteLine(renkler[0]);


            //dongulerle dizi kullanma
            //klavyeden girilen n sayının ortalamasını hesaplayan program 
            System.Console.WriteLine("Lütfen dizi eleman sayısını giriniz: ");
            int diziUzunlugu = int.Parse(Console.ReadLine());

            int[] sayiDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("{0}. sayıyıgiriniz: ", i+1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            } 

            int toplam = 0;
            foreach (var item in sayiDizisi)
            {
                toplam += item;
            }
            System.Console.WriteLine("Ortalama: " + (toplam/diziUzunlugu));

            Console.ReadLine();
        }
    }
}
