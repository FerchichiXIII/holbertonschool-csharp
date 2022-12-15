using System;

using System;

namespace Enemies
{
    /// <summary>
    /// namespace : Enemies
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// Class : Zombie
        /// </summary>
        public int health;
        /// <summary> int health </summary>
        public Zombie()
        {
            health = 0;
        }
        public Zombie(int value)
        {
            /// <summary> a new public constructor: public Zombie(int value)</summary>
            health = value;
            if (value < 0)
            {
                throw new ArgumentException ("Health must be greater than or equal to 0");
            }
        }
    }
}
