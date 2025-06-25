using static System.Console;

namespace VirtualPetSimulator
{
    class Unicorn : VirtualPet
    {
        public Unicorn(string name, int age, bool isAwake)
            : base(name, age, "Unicorn", isAwake) { }

        public override void MakeSound() => WriteLine($"{FullName} neighs majestically ✨");
        public void CastSparkles()
        {
            System.Console.WriteLine($"{FullName} casts rainbow sparkles! (+30 XP)");
            Eat("stardust"); // reuses +15 XP and prints message
        }
    }
}
