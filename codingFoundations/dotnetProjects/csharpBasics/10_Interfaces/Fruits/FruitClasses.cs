//* HAS A RELATIONSHIP
public class Banana : IFruit
{
    public Banana() { }

    public Banana(bool isPeeled)
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

    public bool IsPeeled { get; private set; }

    public string Peel()
    {
        IsPeeled = true;
        return "You peel a Banana.";
    }
}

public class Orange : IFruit //ctrl + .  -> implement interface
{
    public Orange() { }

    public Orange(bool isPeeled)
    {
        IsPeeled = isPeeled;
    }
    public string Name => "Orange";

    public bool IsPeeled { get; private set; }

    public string Peel()
    {
        IsPeeled = true;
        return "You peel the Orange";
    }

    //can have our own method that pertains to an orange
    public string Squeeze()
    {
        return "You squeeze the orange and juice comes out.";
    }
}

public class Grape : IFruit
{
    public Grape() { }
    public string Name => "Grape";

    public bool IsPeeled => false;

    public string Peel()
    {
        return "Who Peels grapes?";
    }
}