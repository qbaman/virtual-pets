using System;
using static System.Console;

namespace VirtualPetSimulator
{
    class VirtualPet
    {
        // Fields
        public string FullName;
        public int Age;
        public string Species;
        public bool IsAwake;

        // private field (cannot be accessed directly in Program.cs)
        private int ExperiencePoints;

        // Method
        public void Greet()
        {
            WriteLine($"My name is {FullName}, the {Species}!");
            WriteLine($"I am {Age} years old.");
            WriteLine($"Is awake? {IsAwake}");
        }
    }
}
