using static System.Console;

namespace VirtualPetSimulator
{
    public class VirtualPet   // ← make it public
    {
        public string FullName;
        public int Age;
        public string Species;
        public bool IsAwake;

        private int ExperiencePoints;

        public VirtualPet(string petName, int petAge, string petSpecies, bool petIsAwake)
        {
            FullName = petName;
            Age = petAge;
            Species = petSpecies;
            IsAwake = petIsAwake;
        }

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

        public void Wake()   // ← add this so PlayAction compiles
        {
            IsAwake = true;
            WriteLine($"{FullName} wakes up and stretches.");
        }

        public void Eat(string foodName)
        {
            WriteLine($"{FullName} is now eating {foodName}.");
        }
    }
}
