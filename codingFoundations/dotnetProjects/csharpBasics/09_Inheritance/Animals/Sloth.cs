using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class Sloth : Animal
{    
    public Sloth()
    {
        System.Console.WriteLine("Sloth Constructor.");
    }

    public bool IsSlow{ get { return true; } }
    //I want to omit the set; (setter), b/c, I only want the compiler to read the data

    public override void Move()
    {
        System.Console.WriteLine("The Sloth moves Slowly!");
    }
}

public class Megatherium : Sloth
{
    public Megatherium()
    {
        System.Console.WriteLine("This Sloth is extinct!");
    }

    public override void Move()
    {
        System.Console.WriteLine("Megatherium uses Move! It's not super effective!");
    }
}