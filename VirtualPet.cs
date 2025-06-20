using System;
using static System.Console;

namespace VirtualPetSimulator
{
    // Base class
    class VirtualPet
    {
        public string FullName
        {
            get => _fullName;
            set => _fullName = string.IsNullOrWhiteSpace(value) ? "Unknown" : value.Trim();
        }
        private string _fullName = "Unknown";

        public int Age
        {
            get => _age;
            set => _age = Math.Max(0, value);    
        }
        private int _age;

        public string Species { get; protected set; } = "Pet";

        public bool IsAwake { get; private set; } = true;

        private int ExperiencePoints;
        public int Level => 1 + ExperiencePoints / 100;

        public VirtualPet(string petName, int petAge, string petSpecies, bool petIsAwake)
        {
            FullName = petName;
            Age = petAge;
            Species = petSpecies;
            IsAwake = petIsAwake;
        }
        public virtual void Greet()
        {
            WriteLine($"My name is {FullName}, the {Species} (Lv. {Level})!");
            WriteLine($"I am {Age} years old.");
            WriteLine($"Is awake? {IsAwake}.");
        }

        public virtual void Sleep()
        {
            IsAwake = false;
            WriteLine($"{FullName} curls up and snores... Zzzzz");
        }

        public virtual void Wake()
        {
            IsAwake = true;
            WriteLine($"{FullName} wakes up and stretches.");
        }

        public virtual void Eat(string foodName)
        {
            GainXP(15);
            WriteLine($"{FullName} is eating {foodName} (+15 XP).");
        }

        public virtual void MakeSound()
        {
            WriteLine($"{FullName} makes a happy pet noise.");
        }
        protected void GainXP(int amount) => ExperiencePoints = Math.Max(0, ExperiencePoints + amount);
    }
}
