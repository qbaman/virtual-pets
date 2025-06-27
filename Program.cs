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

            // First pet
            VirtualPet leoTheCat = new VirtualPet();
            leoTheCat.FullName = "Leo";
            WriteLine("> Pet 1");
            WriteLine($"My name is {leoTheCat.FullName}.");

            // Second pet
            VirtualPet juniorTheParrot = new VirtualPet();

            WriteLine("Press any key to exit...");
            ReadKey();
        }
    }
}
