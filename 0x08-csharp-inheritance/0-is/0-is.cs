using System;
using System.Collections.Generic;

    class Obj
    {
         /// <summary> returns True if the object is an int, otherwise return False.</summary>
        public static bool IsOfTypeInt(object obj)
        {
           
            if (obj is int)
            {
                return true;
            }
            return false;
        }
  
    }
