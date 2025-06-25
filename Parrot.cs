using static System.Console;

namespace VirtualPetSimulator
{
    public class Parrot : VirtualPet
    {
        public Parrot(string name, int age, bool isAwake)
            : base(name, age, "Parrot", isAwake) { }

        public override void MakeSound() => WriteLine($"{FullName} squawks loudly!");

        public override void Greet()
        {
            base.Greet();
            WriteLine($"{FullName} flaps their wings.");
        }
    }
}
