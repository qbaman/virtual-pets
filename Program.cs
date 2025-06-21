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

            // First pet
            VirtualPet leoTheCat = new VirtualPet();
            leoTheCat.FullName = "Leo";
            leoTheCat.Age = 12;
            leoTheCat.Species = "Cat";

            WriteLine("> Pet 1");
            WriteLine($"My name is {leoTheCat.FullName}, the {leoTheCat.Species}.");
            WriteLine($"I am {leoTheCat.Age} years old.");
            WriteLine("");

            // Second pet
            VirtualPet juniorTheParrot = new VirtualPet();
            juniorTheParrot.FullName = "Junior";
            juniorTheParrot.Age = 50;
            juniorTheParrot.Species = "Parrot";

            WriteLine("> Pet 2");
            WriteLine($"My name is {juniorTheParrot.FullName}, the {juniorTheParrot.Species}.");
            WriteLine($"I am {juniorTheParrot.Age} years old.");
            WriteLine("");

            WriteLine("Press any key to exit...");
            ReadKey();
        }
    }
}
