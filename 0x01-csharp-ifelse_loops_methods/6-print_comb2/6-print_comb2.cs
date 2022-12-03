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
                    int a = n % 10;
                    int b = n / 10;
                    if (a != b && a > b)
                {
                    if (n != 89)
                        {
                            Console.Write ("{0:00}, ",n);

                        }
                    else
                        {
                            Console.Write ("{0:00}\n",n);
                        }
  
                }
                n++;
                }
        }
    }
}
