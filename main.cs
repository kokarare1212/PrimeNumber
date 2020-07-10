using System;
using System.Globalization;

namespace PrimeNumberCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 2;i <= 10000000; i++)
            {
                int k = (int)Math.Sqrt(i);
                bool f = true;
                for(int j = 2; j <= k; j++)
                {
                    if(i % j == 0)
                    {
                        f = false;
                    }
                }
                if (f)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
