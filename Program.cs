using System;
using virtual_pets;
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

            // VirtualPet   = a new type (class)
            // leo          = identifier (object name)
            // new VirtualPet() = constructs a VirtualPet object
            VirtualPet leo = new VirtualPet();
            VirtualPet junior = new VirtualPet();

            WriteLine("Press any key to exit...");
            ReadKey();
        }
    }
}
