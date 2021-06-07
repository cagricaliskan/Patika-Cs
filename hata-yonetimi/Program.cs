using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            // try
            // {
            //     Console.WriteLine("Bir sayı giriniz!");
            //     int sayi = Convert.ToInt32(Console.ReadLine());

            //     System.Console.WriteLine("Girmiş olduğunuz sayi: " + sayi);
            // }
            // catch (System.Exception ex)
            // {
            //     System.Console.WriteLine("Hata: " + ex.Message.ToString());
                
            // }
            // finally
            // {
            //     System.Console.WriteLine("İşlem Tamamlandı!");
            // }


            try
            {
               //int a = int.Parse("null");
               int a = int.Parse("-2000000000000");
            }
            catch (ArgumentNullException ex)
            {
                
                System.Console.WriteLine("Bos deger girdiniz");
                System.Console.WriteLine(ex);
            }

            catch(FormatException ex)
            {
                System.Console.WriteLine("Veri tipi uygun değil");
                System.Console.WriteLine(ex);
            }

            catch(OverflowException ex)
            {
                System.Console.WriteLine("Çok kücük veya çok büyük bir değer girdiniz");
                System.Console.WriteLine(ex);
            }

            Console.ReadLine();
            
        }
    }
}
