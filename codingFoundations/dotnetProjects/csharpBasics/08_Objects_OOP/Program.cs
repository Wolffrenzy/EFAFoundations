//Objects & OOP

//OOP -> Object Oriented Programming
//Programming based on objects interacting with one another

//Object
//Block of memory that has been allocated (set aside) and configured according to the 'blueprint'

//Everything in C# Derives from the object class
object objectThingy = new object();
//objectThingy.GetType();

// Vehicle vehicle = new Vehicle();
//vehicle.GetType(); getting this method off of the 

//What are the Pillars of OOP -> What Ultimately makes this stuff work?
//A.P.I.E
//A => Abstraction -> What we perceive the pet to be at this point
//P => Polymorphism -> We can morph this into many different shapes
//I => Inheritance -> Parent/Child relationship (is a)
//E => Encapsulation -> Process of 'hiding' stuff

// make a class

public class Pet
{
    public string Name { get; set; }
    public string Breed { get; set; }
    public string Color { get; set; }
    public int NumberOfLegs { get; set; }
    public int Weight { get; set; }

    public void Speak()
    {
        System.Console.WriteLine("Ruff!");
    }
}