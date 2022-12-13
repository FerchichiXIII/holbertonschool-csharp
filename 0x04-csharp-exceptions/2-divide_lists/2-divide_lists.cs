using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> NewList = new List<int>();
        int Div = 0;
        for(int i = 0; i < listLength;i++)
        {
            try
            {
                Div = list1[i] / list2[i];
                NewList.Add(Div);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                NewList.Add(0);
            }
            catch (Exception)
            {
                Console.WriteLine("Out of range");
            }
        }
        return NewList;
    }
}
