//1. This is our BASE CLASS
//2. I want other classes to 'derive/inherit' from me
//3. I do not want the user/developer to be able to make instances (copies) of me

public abstract class Animal
{
    //Define the attributes of the animal
    public Animal()
    {
        System.Console.WriteLine("This is the Animal Constructor.");
    }
    public int NumberOfLegs { get; set; }
    
    public bool IsMammal { get; set; }
    
    public bool HasFur { get; set; }
    
    public DietType DietType { get; set; }

    public virtual void Move()  //Virtual Keyword allows you to "override" default parent behavior
    {
        System.Console.WriteLine($"This {GetType().Name} moves. "); //? GetType() -> Animal
    }

}
