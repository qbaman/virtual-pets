using System;
using System.Collections.Generic;
using static System.Console;

namespace VirtualPetSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Title = "Virtual Pet Simulator ";

            WriteLine(@"
 ███████████  ██████████ ███████████     █████████  █████ ██████   ██████
░░███░░░░░███░░███░░░░░█░█░░░███░░░█    ███░░░░░███░░███ ░░██████ ██████ 
 ░███    ░███ ░███  █ ░ ░   ░███  ░    ░███    ░░░  ░███  ░███░█████░███ 
 ░██████████  ░██████       ░███       ░░█████████  ░███  ░███░░███ ░███ 
 ░███░░░░░░   ░███░░█       ░███        ░░░░░░░░███ ░███  ░███ ░░░  ░███ 
 ░███         ░███ ░   █    ░███        ███    ░███ ░███  ░███      ░███ 
 █████        ██████████    █████      ░░█████████  █████ █████     █████
░░░░░        ░░░░░░░░░░    ░░░░░        ░░░░░░░░░  ░░░░░ ░░░░░     ░░░░░ 
");

            WriteLine("Welcome to the pet simulator!");
            WriteLine("");


            // Use subclasses (polymorphism)
            VirtualPet leoTheCat = new Cat("Leo", 12, true);
            VirtualPet juniorTheParrot = new Parrot("Junior", 50, false);
            VirtualPet callieTheUnicorn = new Unicorn("Callie", 250, true);

            var pets = new List<VirtualPet> { leoTheCat, juniorTheParrot, callieTheUnicorn };

            // Shared actions via interface
            var actions = new List<IPetAction> { new FeedAction(), new PlayAction(), new NapAction() };

            int i = 1;
            foreach (var pet in pets)
            {
                WriteLine($"> Pet {i++}");
                pet.Greet();
                pet.MakeSound();
                foreach (var act in actions)
                    act.Apply(pet); // same call, different behaviour = polymorphism

                WriteLine("");
            }

            WriteLine("Press any key to exit...");
            ReadKey();
        }
    }
}
