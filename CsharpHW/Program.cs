using AnimalSounds.Models;
using Models;
using System;

namespace AnimalSounds
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create animals with names
                Animal[] animals = {
                    new Dog("Buddy"),
                    new Cat("Whiskers"),
                    new Dog("Max"),
                    new Cat("Luna")
                };

                Console.WriteLine("=== ცხოველების ხმები ===");
                Console.WriteLine("=== Animal Sounds ===\n");

                // Make all animals sound
                foreach (var animal in animals)
                {
                    animal.MakeSound();
                }

                // Test exception handling
                Console.WriteLine("\n=== Testing Exception ===");
                try
                {
                    var unnamedAnimal = new Dog(""); // This should throw exception
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Exception caught: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }
    }
}