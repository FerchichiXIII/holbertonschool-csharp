using System;
using System.Collections.Generic;

    class Obj
    {
        public static bool IsOfTypeInt(object obj)
        {
            if (obj is int)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
