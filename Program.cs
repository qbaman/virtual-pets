using System;
using static System.Console;

namespace VirtualPetSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Title = "=== Virtual Pet Simulator ===";

            WriteLine(@"
 __      __   _ _        _   _      _   
 \ \    / /__| | |    __| | | |_ _ (_)__ 
  \ \/\/ / -_) | |   (_-<   |  _| '_/ _ \
   \_/\_/\___|_|_|   /__/    \__|_| \___/
");

            WriteLine("Welcome to the pet simulator!");
            WriteLine("");

            // VirtualPet   = a new type
            // leo          = identifier
            // new VirtualPet() = constructs a VirtualPet object
            VirtualPet leoTheCat = new VirtualPet();
            leoTheCat.FullName = "Leo";
            leoTheCat.Age = 12;
            leoTheCat.Species = "Cat";
            leoTheCat.IsAwake = true;

            // This would cause an error because ExperiencePoints is private:
            // leoTheCat.ExperiencePoints = 10;

            WriteLine("> Pet 1");
            leoTheCat.Greet();   // invoke method
            leoTheCat.Eat();     // invoke method
            WriteLine("");

            VirtualPet juniorTheParrot = new VirtualPet();
            juniorTheParrot.FullName = "Junior";
            juniorTheParrot.Age = 50;
            juniorTheParrot.Species = "Parrot";
            juniorTheParrot.IsAwake = false;

            WriteLine("> Pet 2");
            juniorTheParrot.Greet();
            juniorTheParrot.Sleep();
            WriteLine("");

            WriteLine("Press any key to exit...");
            ReadKey();
        }
    }
}
