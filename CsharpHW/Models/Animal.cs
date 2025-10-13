using System;

namespace Models
{
    public abstract class Animal
    {
        public string Name { get; set; }

        protected Animal(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Animal name cannot be empty or null.");

            Name = name;
        }

        public abstract void MakeSound();
    }
}