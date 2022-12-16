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
        private string name = "(No name)";
        /// <summary>prv str name</summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Zombie()
        {
            health = 0;
        }
        /// <summary> new instance </summary>
        public Zombie(int value)
        {

            if (value < 0)
            {
                throw new ArgumentException ("Health must be greater than or equal to 0");
            }
            health = value;
        }
        /// <summary> that returns the value of health of the Zombie object </summary>
        public int GetHealth()
        {
            return health;
        }
    }
}
