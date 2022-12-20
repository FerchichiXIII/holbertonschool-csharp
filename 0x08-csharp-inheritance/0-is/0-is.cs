using System;


    class Obj
    {
        public static bool IsOfTypeInt(object obj)
        {
            /// <summary> 
            /// returns True if the object is an int, otherwise return False.
            /// </summary>
            if (obj is int)
            {
                /// <summary> if obj is int return true </summary>
                return true;
            }
                return false;
        }
  
    }
