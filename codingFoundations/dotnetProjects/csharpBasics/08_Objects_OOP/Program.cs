//Objects & OOP

//OOP -> Object oriented Programming
// Programming based on objects interacting with one another

//Object 
// block of memory that has been allocated (set aside) and configured according to the 'blueprint'

//Everything in C# DERIVES FROM THE OBJECT CLASS!!!
object objectThinggy = new object();
//objectThinggy.GetType();

// Vehicle vehicle = new Vehicle();
//vehicle.GetType(); getting this method off of the object class

//Pet (object/class) -> THE BLUEPRINT

//What are the "Pillars" of OOP -> WHAT ULTIMATLY MAKES THIS STUFF WORK???
//A.P.I.E
//A => Abstraction -> what we percive the pet to be at this point
//P => Polymophism -> we can morph this into many different shapes
//I => Inheritance -> parent/child relationship (is a)
//E => Encapsulation -> process of 'hiding' stuff 

//make a class 
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