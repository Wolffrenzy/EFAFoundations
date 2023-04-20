using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//* THIS IS AN (IS A) RELATIONSHIP
//! CAT IS AN ANIMAL

public class Cat : Animal
{
    public Cat()
    {
        System.Console.WriteLine("This is the Cat Constructor");
        IsMammal = true;
        DietType = DietType.Carnivore;
    }

    //We can have properties that ONLY PERTAIN TO THE CAT OBJECT
    public double ClawLength { get; set; }

    public virtual void MakeSound()
    {
        System.Console.WriteLine("Meow.");
    }

    public override void Move()
    {
        // base.Move(); -> This is the base class implementation.
        System.Console.WriteLine($"This {GetType().Name} moves quickly!.");
    }
}

public class TabbyCat : Cat
{
    public TabbyCat()
    {
        System.Console.WriteLine("This is the Tabby Cat Constructor!");
    }

    public override void MakeSound()
    {
        System.Console.WriteLine("Purr...");
    }
}

public class Liger : Cat
{
    public Liger()
    {
        System.Console.WriteLine("This is the Liger Constructor!");
    }

    public override void Move()
    {
        System.Console.WriteLine($"The {GetType().Name} stalks it's prey.");
    }

    public override void MakeSound()
    {
        System.Console.WriteLine("ROAR!");
    }
}