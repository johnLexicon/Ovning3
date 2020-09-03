using System;
using System.Collections.Generic;

namespace Ovning3Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            Worm worm = new Worm("worm 1", 0.1, 5, false);
            Console.WriteLine(worm.DoSound());

            Animal horse = new Horse("Horse 1", 100, 30, 175);
            Console.WriteLine(horse.DoSound());

            Pelican pelican = new Pelican("pel 1", 5, 2, 50, 20);
            Console.WriteLine(pelican.DoSound());

            WolfMan wolfMan = new WolfMan("Wolverine", 100, 50, "black");
            Console.WriteLine(wolfMan.Talk());

            // Fråga 3.2.13: I Bird classen
            // Fråga 3.2.14: I Animal classen

            List<Animal> animals = new List<Animal>
            {
                new Wolf("Wolfy", 40, 25, "Brown"),
                new Swan("Swane", 2, 50, 30, 10),
                new WolfMan("Wolverine", 100, 50, "black"),
                new Horse("Horse nr 1", 100, 30, 175),
                new Worm("Poisonous worm", 2.3, 3, true),
                new Dog("Vovve", 10, 2, "Chiwawa"),
                new Dog("Spraky",45.2, 11, "Bulldog")
            };

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Stats());
                Console.WriteLine(animal.DoSound());
                if (animal is IPerson)
                {
                    IPerson animalPerson = animal as IPerson;
                    Console.WriteLine(animalPerson.Talk());
                }
                if(animal is Dog)
                {
                    Dog aDog = animal as Dog;
                    aDog.ReturnString();
                    Animal anim = aDog as Animal;
                }
            }

            List<Dog> dogs = new List<Dog>
            {
                new Dog("Vovve", 10, 2, "Chiwawa"),
                
                // new Horse("Horse nr 1", 100, 30, 175) går ej
                new Dog("Spraky",45.2, 11, "Bulldog")
            };

            // Fråga 3.3.9: För att en lista av hundar kan bara innehålla hundar eller dess subklasser och en häst är inte samma objekt och ärver inte från hund heller
            // Fråga 3.3.10: Av typer Animal för att alla objekt har ärvt från Animal 
            // Fråga 3.3.13: Subklasserna hanteras som instanser av basklasserna och den mest specialiserade formen appliceras
            // Fråga 3.3.16-17: Nej, kommer åt bara för Dog, eftersom Dog ärver Animal och inte tvärtom

            foreach(var dog in animals)
            {
                if(dog is Dog)
                    Console.WriteLine(dog.Stats());
            }

            Console.ReadLine();

        }
    }
}
