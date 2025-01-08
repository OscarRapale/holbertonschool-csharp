using System;

namespace Enemies
{
    /// <summary>Public class Zombie</summary>
    public class Zombie
    {
        /// <summary>Private field health</summary>
        private int health;

        /// <summary>Private field name</summary>
        private string name;

        /// <summary>Public constructor</summary>
        public Zombie()
        {
            this.health = 0;
            this.name = "(No name)";
        }

        /// <summary>Public property Name</summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>New public constructor with value parameter</summary>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            this.health = value;
            this.name = "(No name)";
        }

        /// <summary>Public method for health</summary>
        /// <returns>Health value</returns>
        public int GetHealth()
        {
            return this.health;
        }
    }
}