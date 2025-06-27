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

        private int ExperiencePoints;

        // Constructor
        public VirtualPet(string petName, int petAge, string petSpecies, bool petIsAwake)
        {
            FullName = petName;
            Age = petAge;
            Species = petSpecies;
            IsAwake = petIsAwake;
        }

        // Methods
        public void Greet()
        {
            WriteLine($"My name is {FullName}, the {Species}!");
            WriteLine($"I am {Age} years old.");
            WriteLine($"Is awake? {IsAwake}.");
        }

        public void Sleep()
        {
            IsAwake = false;
            WriteLine($"{FullName} is now happily snoring... Zzzzz");
        }

        public void Eat(string foodName)
        {
            WriteLine($"{FullName} is now eating {foodName}.");
        }
    }
}
