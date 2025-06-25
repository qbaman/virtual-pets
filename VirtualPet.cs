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

        // Private field (not accessible from Program.cs)
        private int ExperiencePoints;

        // Methods / behaviours
        public void Greet()
        {
            WriteLine($"My name is {FullName}, the {Species}!");
            WriteLine($"I am {Age} years old.");
            WriteLine($"Is awake? {IsAwake}");
        }

        public void Sleep()
        {
            IsAwake = false;
            WriteLine($"{FullName} is now happily snoring... Zzzzz");
        }

        public void Eat()
        {
            WriteLine($"{FullName} is now eating.");
        }
    }
}
