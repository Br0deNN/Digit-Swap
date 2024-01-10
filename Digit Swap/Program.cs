using System;
namespace Digitswap
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            char[] y = x.ToCharArray();

            Array.Reverse(y);

            string reversed = new string(y);

            Console.WriteLine(reversed);

            



        }
    }
}