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
            else
            {
                /// <summary> if obj is not int return false </summary>
                return false;
            }
        }
    }
