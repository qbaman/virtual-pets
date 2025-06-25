using static System.Console;

namespace VirtualPetSimulator
{
    class Parrot : VirtualPet
    {
        public Parrot(string name, int age, bool isAwake)
            : base(name, age, "Parrot", isAwake) { }

        public override void MakeSound() => WriteLine($"{FullName} squawks: Polly wants a cracker!");
        public override void Greet()
        {
            base.Greet();
            WriteLine($"{FullName} flaps their wings enthusiastically.");
        }
    }
}
