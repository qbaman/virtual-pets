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
 __      __  _       _             _   _      _   
 \ \    / / (_)     | |           | | (_)    | |  
  \ \  / /__ _ _ __ | |_ _   _ ___| |_ _  ___| |_ 
   \ \/ / _ \ | '_ \| __| | | / __| __| |/ _ \ __|
    \  /  __/ | | | | |_| |_| \__ \ |_| |  __/ |_ 
     \/ \___|_|_| |_|\__|\__,_|___/\__|_|\___|\__|
");

            WriteLine("Welcome to the pet simulator!");
            WriteLine("");

            // First pet
            VirtualPet leoTheCat = new VirtualPet("Leo", 12, "Cat", true);
            // leoTheCat.ExperiencePoints = 10; // Error: private

            WriteLine("> Pet 1");
            leoTheCat.Greet();
            leoTheCat.Eat("some dry food");
            WriteLine("");

            // Second pet
            VirtualPet juniorTheParrot = new VirtualPet("Junior", 50, "Parrot", false);

            WriteLine("> Pet 2");
            juniorTheParrot.Greet();
            juniorTheParrot.Eat("a worm");
            juniorTheParrot.Sleep();
            WriteLine("");

            // Third pet
            VirtualPet callieTheUnicorn = new VirtualPet("Callie", 250, "Unicorn", true);

            WriteLine("> Pet 3");
            callieTheUnicorn.Greet();
            callieTheUnicorn.Eat("rainbows");
            WriteLine("");

            WriteLine("Press any key to exit...");
            ReadKey();
        }
    }
}
