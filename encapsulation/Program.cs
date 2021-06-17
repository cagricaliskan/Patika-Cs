using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Ogrenci c2 = new Ogrenci();
            c2.Isim = "Deniz";
            c2.Soyisim = "Arda";
            c2.OgrenciNo = 23456789;
            c2.Sinif = 3;

            c2.OgrenciBilgileriniGetir();

            c2.SinifAtla();

            c2.OgrenciBilgileriniGetir();

            Console.ReadLine();
        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif 
        {
            get => sinif;
            set 
            {
                if(value <= 1){
                    System.Console.WriteLine("Sınıf en az 1 olabilir.");
                    sinif = 1;
                }else {
                    sinif = value;
                }
            }
        }

        public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = isim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogrenci()
        {
            
        }

        public void OgrenciBilgileriniGetir()
        {   
            System.Console.WriteLine("*** Ogrenci Bilgileri ***");
            System.Console.WriteLine("Ogrenci Adi          : {0}", this.Isim);
            System.Console.WriteLine("Ogrenci Soyadi       : {0}", this.Soyisim);
            System.Console.WriteLine("Ogrenci No           : {0}", this.OgrenciNo);
            System.Console.WriteLine("Ogrenci Sınıf        : {0}", this.Sinif);
        }


        public void SinifAtla()
        {
            this.Sinif = this.Sinif+1;
        }

        public void SinifDusur()
        {
            this.Sinif = this.Sinif-1;
        }
        

    }
}
