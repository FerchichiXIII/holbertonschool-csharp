﻿using System;

namespace _2_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            char n = 'a';
            while (n <= 'z')
            {
                if (n != 'e' && n != 'q')
                {
                    Console.Write(n);
                }
                n ++;
            }
        }
    }
}