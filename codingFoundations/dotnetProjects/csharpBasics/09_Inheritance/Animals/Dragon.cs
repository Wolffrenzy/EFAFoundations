using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Dragon : Animal
{
    public Dragon()
    {
        HasFur = false;
        IsMammal = false;
        DietType = DietType.Carnivore;
    }
}
public class IceDragon : Dragon
{
    public IceDragon()
    {
        HasFur = false;
        IsMammal = false;
        DietType = DietType.Carnivore;
    }

    public void IceBlast()
    {
        // uses ice blast, depletes health
    }
}

public class MegaDeath : Dragon
{
    public MegaDeath()
    {
        HasFur = true;
        IsMammal = false;
        DietType = DietType.Carnivore;
    }
}


public class Wyrm : Dragon
{
    public Wyrm()
    {
        NumberOfLegs = 0;
    }

    public override void Move()
    {
        System.Console.WriteLine("I'm crawling and I can't get up!");
    }

    public void BurrowUnderGround()
    {
        //regenerate health while underground
    }
}

public class Hydra : Dragon
{
    public int HeadCount { get; set; }  = 5;
}