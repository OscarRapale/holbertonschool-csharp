using System;

namespace Enemies
{
    /// <summary>Public class Zombie</summary>
    public class Zombie
    {
        /// <summary>Public field health</summary>
        public int health;

        /// <summary>Public constructor</summary>
        public Zombie()
        {
            this.health = 0;
        }

        public Zombie(int value)
        {
          if (value < 0)
          {
            throw new ArgumentException("Health must be greater than or equal to 0");
          }  

          this.health = value;
        }
    }

}
