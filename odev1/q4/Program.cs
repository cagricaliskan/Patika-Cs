using System;

namespace q4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a sentence");
            string sen = Console.ReadLine();
            int spacecount = 0;
            int lettercount = 0;

            for (int i = 0; i < sen.Length; i++)
            {
                if(char.IsWhiteSpace(sen[i])){
                    spacecount++;
                }
            }

            lettercount = sen.Length - spacecount;
            
            System.Console.WriteLine("Bu cümle {0} kelime ve {1} harften oluşuyor.", spacecount+1, lettercount);


            Console.ReadLine();
        }
    }
}
