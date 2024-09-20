using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    abstract class Animal
    {
        // Egenskaper som alla djur bör ha
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }

        // Konstruktor
        public Animal(string name, double weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }

        // Abstrakt metod DoSound()
        public abstract void DoSound();
        public virtual string Stats()
        {
            return $"Name: {Name}, Weight: {Weight} kg, Age: {Age} years";
        }
    }

    // Skapa subklasser som ärver från Animal

    class Horse : Animal
    {
        public double Speed { get; set; } // Unik egenskap

        public Horse(string name, double weight, int age, double speed) : base(name, weight, age)
        {
            Speed = speed;
        }

        // Implementera DoSound()
        public override void DoSound()
        {
            Console.WriteLine("The horse neighs.");
        }
    }

    class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog(string name, double weight, int age, string breed)
            : base(name, weight, age)
        {
            Breed = breed;
        }

        public override void DoSound() => Console.WriteLine("Dog: Barks.");

        // Override för Stats-metoden
        public override string Stats()
        {
            return base.Stats() + $", Breed: {Breed}";
        }

        // Ny metod i Dog-klassen
        public string DogSpecialMethod()
        {
            return "This is a special method only for dogs!";
        }
    }


    class Hedgehog : Animal
    {
        public int NrOfSpikes { get; set; } // Unik egenskap

        public Hedgehog(string name, double weight, int age, int nrOfSpikes) : base(name, weight, age)
        {
            NrOfSpikes = nrOfSpikes;
        }

        public override void DoSound()
        {
            Console.WriteLine("The hedgehog makes a snuffling sound.");
        }
    }

    class Worm : Animal
    {
        public bool IsPoisonous { get; set; } // Unik egenskap

        public Worm(string name, double weight, int age, bool isPoisonous) : base(name, weight, age)
        {
            IsPoisonous = isPoisonous;
        }

        public override void DoSound()
        {
            Console.WriteLine("The worm is silent.");
        }
    }

    class Bird : Animal
    {
        public double WingSpan { get; set; } // Unik egenskap

        public Bird(string name, double weight, int age, double wingSpan) : base(name, weight, age)
        {
            WingSpan = wingSpan;
        }

        public override void DoSound()
        {
            Console.WriteLine("The bird chirps.");
        }
    }

    class Wolf : Animal
    {
        public double PackSize { get; set; } // Unik egenskap

        public Wolf(string name, double weight, int age, double packSize) : base(name, weight, age)
        {
            PackSize = packSize;
        }

        public override void DoSound()
        {
            Console.WriteLine("The wolf howls.");
        }
    }

    // subklasser från Bird
    class Pelican : Bird
    {
        public double BeakLength { get; set; } // Unik egenskap

        public Pelican(string name, double weight, int age, double wingSpan, double beakLength)
            : base(name, weight, age, wingSpan)
        {
            BeakLength = beakLength;
        }

        public override void DoSound()
        {
            Console.WriteLine("The pelican squawks.");
        }
    }

    class Flamingo : Bird
    {
        public string Color { get; set; } // Unik egenskap

        public Flamingo(string name, double weight, int age, double wingSpan, string color)
            : base(name, weight, age, wingSpan)
        {
            Color = color;
        }

        public override void DoSound()
        {
            Console.WriteLine("The flamingo honks.");
        }
    }

    class Swan : Bird
    {
        public bool IsAggressive { get; set; } // Unik egenskap

        public Swan(string name, double weight, int age, double wingSpan, bool isAggressive)
            : base(name, weight, age, wingSpan)
        {
            IsAggressive = isAggressive;
        }

        public override void DoSound()
        {
            Console.WriteLine("The swan hisses.");
        }
    }

    // IPerson med en metod deklaration Talk()
    interface IPerson
    {
        void Talk();
    }

    // Wolfman som ärver från Wolf och implementerar IPerson
    class Wolfman : Animal, IPerson
    {
        public int PackSize { get; set; }

        public Wolfman(string name, double weight, int age, int packSize)
            : base(name, weight, age)
        {
            PackSize = packSize;
        }

        public override void DoSound() => Console.WriteLine("Wolfman: Howls.");
        public void Talk() => Console.WriteLine("Wolfman: 'I am part wolf, part man.'");

        public override string Stats()
        {
            return base.Stats() + $", PackSize: {PackSize}";
        }
    
}
}

// Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, i vilken klass bör vi lägga det?
// Vi bör lägga det i Bird-klassen, eftersom alla fåglar ärver från denna klass och därmed får det nya attributet.
// 
// Om alla djur behöver det nya attributet, vart skulle man lägga det då?
// Vi bör lägga det i basklassen Animal, eftersom alla djur ärver från denna klass och då skulle få det nya attributet.
//
// Förklara vad som händer när polymorfism används i foreach-loopen.
// I foreach-loopen itererar vi över listan av Animal-objekt. Varje objekt anropar sin egna version av DoSound() och Stats() beroende på vilken subklass det tillhör, tack vare polymorfism.
//
// Varför kan du inte direkt komma åt en metod som bara finns i Dog från Animal-listan? 
// Eftersom listan är av typen Animal, kan du bara komma åt metoder som finns i Animal-klassen. För att anropa en metod som finns specifikt i Dog måste du type-casta objektet till Dog.
//
// Hur kommer du åt den specifika metoden för hundar genom en foreach-loop på Animal-listan?
// Genom att type-casta varje objekt i listan till Dog innan du anropar den specifika metoden.