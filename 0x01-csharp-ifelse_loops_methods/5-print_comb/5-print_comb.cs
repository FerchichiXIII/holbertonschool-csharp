using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            while (n <= 99)
                {
                    if (n != 99)
                    {
                        Console.Write ("{0:00}, ",n);

                    }
                    else
                    {
                        Console.Write ("{0:00}\n",n);
                    }
                    n++;
                }
        }
    }
}
