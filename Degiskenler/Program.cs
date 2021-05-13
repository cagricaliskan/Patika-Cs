using System;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;

            System.Console.WriteLine(dt);
            
            string str1 = string.Empty;
            str1 = "Cagri Caliskan";
            string ad = "Cagri";
            string soyad = "Caliskan";
            string tamisim = ad + soyad;
            
            
            int int1 = 5;
            int int2 = 3; 
            int int3 = int1 + int2;
            System.Console.WriteLine(int3);

            string str = "20";
            int int20 = 20;

            string newValue = str + int20.ToString(); 
            System.Console.WriteLine(newValue);

            int x = int20 + Convert.ToInt32(str);
            System.Console.WriteLine(x);
            
            Console.ReadLine();


        }
    }
}
