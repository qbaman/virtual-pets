# Virtual Pets Simulator (C#)

This is a **console-based Virtual Pets Simulator** built in C#.  
The project demonstrates **object-oriented programming (OOP)** principles such as **inheritance, polymorphism, encapsulation, and abstraction**.

---

## Features

- **Multiple Pet Types** – Cat, Parrot, and Unicorn, each with unique behaviours.  
- **MakeSound()** – each pet can produce its own sound (e.g., meow, squawk, magical chime).  
- **Eat()** – pets can be fed different foods.  
- **Sleep()** – pets can go to sleep, demonstrating state changes.  
- **Rename Pets** – ability to change pet names dynamically.  
- **Polymorphism via IPetAction** – actions such as Feed, Nap, and Play can be applied to any pet.  
- **ASCII Banner** – console intro with styled ASCII art.  
- **Encapsulation** – Experience Points are private and managed internally.  

---

## OOP Concepts Demonstrated

- **Encapsulation** – pet fields (e.g., `ExperiencePoints`) kept private with controlled methods.  
- **Abstraction** – `IPetAction` interface defines actions for all pets.  
- **Inheritance** – Cat, Parrot, and Unicorn inherit from the base `VirtualPet` class.  
- **Polymorphism** – actions (`FeedAction`, `NapAction`, `PlayAction`) can apply to any pet via the `IPetAction` interface.  
