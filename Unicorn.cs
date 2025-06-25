using static System.Console;

namespace VirtualPetSimulator
{
    public class Unicorn : VirtualPet
    {
        public Unicorn(string name, int age, bool isAwake)
            : base(name, age, "Unicorn", isAwake) { }

        public override void MakeSound() => WriteLine($"{FullName} neighs majestically ✨");
    }
}
