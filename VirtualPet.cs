using static System.Console;

namespace VirtualPetSimulator
{
    // Must be public so public interfaces/actions can accept it
    public class VirtualPet
    {
        // Simple fields (keep as-is for now)
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

        // Mark as virtual so subclasses can override
        public virtual void Greet()
        {
            WriteLine($"My name is {FullName}, the {Species}!");
            WriteLine($"I am {Age} years old.");
            WriteLine($"Is awake? {IsAwake}.");
        }

        public virtual void Sleep()
        {
            IsAwake = false;
            WriteLine($"{FullName} is now happily snoring... Zzzzz");
        }

        public virtual void Wake()
        {
            IsAwake = true;
            WriteLine($"{FullName} wakes up and stretches.");
        }

        public virtual void Eat(string foodName)
        {
            WriteLine($"{FullName} is now eating {foodName}.");
        }

        // New: base MakeSound so Program can call it on VirtualPet
        public virtual void MakeSound()
        {
            WriteLine($"{FullName} makes a happy pet noise.");
        }
    }
}
