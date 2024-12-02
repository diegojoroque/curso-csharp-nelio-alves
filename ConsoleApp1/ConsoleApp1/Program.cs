using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;

            int blablabla = Area(x);

            Console.WriteLine(blablabla);

            static int Area(int n)
            {
                return n * n;
            }
        }
    }
}