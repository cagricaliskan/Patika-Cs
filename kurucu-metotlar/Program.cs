using System;

namespace kurucu_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("*** Calisan 1 ***");
            Calisan c1 = new Calisan("Ayse", "Kara", 12345678, "İK" );
            c1.CalisanBilgileri();

            System.Console.WriteLine("*** Calisan 2 ***");
            Calisan c2 = new Calisan();
            c2.Ad = "Deniz";
            c2.Soyad = "Arda";
            c2.No = 23456789;
            c2.Departman = "IT";
            c2.CalisanBilgileri();


            Console.ReadLine();
        }
    }

    class Calisan
    {
        public string Ad { get; set; }
        public string  Soyad { get; set; }
        public int No { get; set; }
        public string Departman { get; set; }

        public Calisan(string ad, string soyad, int no, string departman){
            Ad = ad;
            Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }

        public Calisan(){

        }


        public void CalisanBilgileri(){
            System.Console.WriteLine("Calisan Adi {0}", Ad);
            System.Console.WriteLine("Calisan Soyadi {0}", Soyad);
            System.Console.WriteLine("Calisan No {0}", No);
            System.Console.WriteLine("Calisan Departman {0}", Departman);
        } 
    }
}
