using static System.Console;

namespace VirtualPetSimulator
{
    public class Cat : VirtualPet
    {
        public Cat(string name, int age, bool isAwake)
            : base(name, age, "Cat", isAwake) { }

        public override void MakeSound() => WriteLine($"{FullName} says: Meow!");

        public override void Eat(string foodName)
        {
            base.Eat(foodName);
            WriteLine($"{FullName} purrs contentedly.");
        }
    }
}
