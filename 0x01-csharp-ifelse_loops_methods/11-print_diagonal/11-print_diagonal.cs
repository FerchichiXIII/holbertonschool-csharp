using System;


    class Line
    {
        public static void PrintDiagonal(int length)
        {
            int r ,num;
            if (length <= 0)
            {
                Console.Write("\n");
            }
            else
            {
                for (r = 1; r <= length;r++)
                {
                    if(r > 1)
                    {
                        for (num = 1; num <= r -1; num ++)
                        {

                            Console.Write(' ');
                        }
                    }
                    Console.WriteLine("\\");
                }
            }
        }
    }
