using System;

namespace Enemies
{
    /// <summary>Public class Zombie</summary>
    public class Zombie
    {
        /// <summary>Public field health</summary>
        private int health;

        /// <summary>Public constructor</summary>
        public Zombie()
        {
            this.health = 0;
        }

         /// <summary>New public constructor with value parameter</summary>
        public Zombie(int value)
        {
          if (value < 0)
          {
            throw new ArgumentException("Health must be greater than or equal to 0");
          }  
          this.health = value;
        }

    /// <summary>Public method for health</summary>
    /// <returns>Health value</returns>
        public int GetHealth()
        {
            return this.health;
        }
    }

}
