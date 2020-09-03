using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

namespace Ovning3Arv
{
    public interface IPerson
    {
        string Talk();
    }
    abstract class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }

        public Animal(string name, double weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }

        public abstract string DoSound();

        public virtual string Stats()
        {

            return $"Name: {Name} Weight: {Weight} Age: {Age}";

        }
    }

    class Worm : Animal
    {
        public bool IsPoisonous { get; set; }
        public Worm(string name, double weight, int age, bool isPoisonous) : base(name, weight, age)
        {
            IsPoisonous = isPoisonous;
        }

        public override string DoSound() => "Worm talk";
        public override string Stats()
        {
            return base.Stats() + $" Is Poisonous: {IsPoisonous}";
        }

    }

    class Dog : Animal
    {
        public string Breed { get; set; }
        public Dog(string name, double weight, int age, string breed) : base(name, 27, age)
        {
            Breed = breed;
        }

        public override string DoSound() => "Dog bark";
        public override string Stats()
        {
            return base.Stats() + $" Breed: {Breed}";
        }

        public string ReturnString() => "s";
    }

    class Hedgehog : Animal
    {
        public int NrOfSpikes { get; set; }

        public Hedgehog(string name, double weight, int age, int nrOfSpikes) : base(name, weight, age)
        {
            NrOfSpikes = nrOfSpikes;
        }
        public override string DoSound() => "Hedgehog making sound";

        public override string Stats()
        {
            return base.Stats() + $" Nr of spikes: {NrOfSpikes}";
        }
    }

    class Bird : Animal
    {
        public double WingSpan { get; set; }

        public Bird(string name, double weight, int age, double wingSpan) : base(name, weight, age)
        {
            WingSpan = wingSpan;
        }
        public override string DoSound() => "Tweet tweet tweet";
        public override string Stats()
        {
            return base.Stats() + $" Wingspan: {WingSpan}";
        }
    }

    class Horse : Animal
    {
        public double Height { get; set; }

        public Horse(string name, double weight, int age, double height) : base(name, weight, age)
        {
            Height = height;
        }

        public override string DoSound() => "Horse neighing";
        public override string Stats()
        {
            return base.Stats() + $" Height: {Height}";
        }
    }

    class Wolf : Animal
    {
        public string Colour { get; set; }

        public Wolf(string name, double weight, int age, string colour) : base(name, weight, age)
        {
            Colour = colour;
        }
        public override string DoSound() => "Wolf howling";
        public override string Stats()
        {
            return base.Stats() + $" Colour: {Colour}";
        }
    }

    class Pelican : Bird
    {
        public int BeakSize { get; set; }

        public Pelican(string name, double weight, int age, double wingSpan, int beakSize) : base(name, weight, age, wingSpan)
        {
            BeakSize = beakSize;
        }
        public override string DoSound() => "Pelican \"tweet\"";

        public override string Stats()
        {
            return base.Stats() + $" Beak size: {BeakSize}";
        }

    }

    class Flamingo : Bird
    {
        public int NeckLenght { get; set; }
        public Flamingo(string name, double weight, int age, double wingSpan, int neckLength) : base(name, weight, age, wingSpan)
        {
            NeckLenght = neckLength;
        }
        public override string Stats()
        {
            return base.Stats() + $" Neck length: {NeckLenght}";
        }
    }

    class Swan : Bird
    {
        public int FeetSize { get; set; }
        public Swan(string name, double weight, int age, double wingSpan, int feetSize) : base(name, weight, age, wingSpan)
        {
            FeetSize = feetSize;
        }
        public override string Stats()
        {
            return base.Stats() + $" Feet size: {FeetSize}";
        }
    }
    class WolfMan : Wolf, IPerson
    {
        public WolfMan(string name, double weight, int age, string colour) : base(name, weight, age, colour)
        {

        }

        public string Talk() => "Wolverine speaking";
    }
    class Random : Animal
    {
        public string Colour { get; set; }
        public Random(string name, string colour) : base(name, 27, 20)
        {
            Colour = colour;
        }
        public override string DoSound() => "RAndom ... ";

    }


}
