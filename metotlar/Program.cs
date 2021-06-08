using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //erişim belirleyici geri dönüş tipi metot adi (parametre listesi/ argüman){
            // komutlar;
            //}            
            
            int x = Topla(2,4);
            System.Console.WriteLine(x);
            

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(x));

            int x1 = ornek.ArttirVeTopla(2,4);
            System.Console.WriteLine(x1);


            Console.ReadLine();
        }

        public static int Topla(int deger1, int deger2){
            return (deger1 + deger2);
        }
    }

    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            System.Console.WriteLine(veri);
        }

        public int ArttirVeTopla(int deger1, int deger2)
        {
            deger1 +=1;
            deger2 +=1;
            return (deger1+deger2);
        }
    }
}
