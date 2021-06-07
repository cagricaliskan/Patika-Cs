using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;


            switch (month)
            {
                case 1:
                System.Console.WriteLine("Ocak");
                break;

                case 2:
                System.Console.WriteLine("Subat");
                break;
                
                case 3:
                System.Console.WriteLine("Mart");
                break;

                case 4:
                System.Console.WriteLine("Nisan");
                break;

                case 5:
                System.Console.WriteLine("Mayıs");
                break;

                case 6:
                System.Console.WriteLine("Haziran");
                break;

                default:
                break;
            }


            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    System.Console.WriteLine("Kış");
                    break;

                case 3:
                case 4:
                case 5:  
                    System.Console.WriteLine("Bahar");
                    break;

                case 6:
                case 7:
                case 8:
                    System.Console.WriteLine("Yaz");
                    break;

                case 9:
                case 10:
                case 11:
                    System.Console.WriteLine("Sonbahar");
                    break;

                default:
                break;
            }

            Console.ReadLine();
        }
    }
}
