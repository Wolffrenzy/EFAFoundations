using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Banana : IFruit
{
    public Banana(){}
    public Banana(bool IsPeeled)
    {
        IsPeeled = isPeeled;
    }
    public string Name 
    {
        get
        {
            return "Banana";
        }
    }

    public bool isPeeled {get; private set;}

    public string Peel()
    {
        isPeeled = true;
        return "You peel a banana.";
    }
}

public class Orange : IFruit    //ctrl + .  -> implement interface
{
    public Orange(){}

    public Orange(bool isPeeled)
    {
        IsPeeled = isPeeled;
    }
    public string Name => "Orange";

    public bool IsPeeled => { get; private set; }

    public string Peel()
    {
        isPeeled = true;
        return "You peel the orange";
    }

    //can have our own method that pertains to an orange
    public string Squeeze()
    {
        return "You squeeze the orange and juice comes out";
    }
}

public class Grape : IFruit
{
    public Grape(){}
    public string Name => "Grape";

    public bool IsPeeled => false;

    public string Peel()
    {
        return "Who peels grapes?";
    }
}