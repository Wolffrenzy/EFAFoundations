public class Penny : ICurrency
{
    //Fat Arrow '=>' MEANS RETURNING 
    public string Name => "Penny";

    public decimal Value => .01m;
}

public class Dime : ICurrency
{
    public string Name => "Dime";

    public decimal Value => .10m;
}

public class Dollar : ICurrency
{
    public string Name => "Dollar";

    public decimal Value => 1.00m;
}

public class ElectronicPayment : ICurrency
{
    public ElectronicPayment(decimal value)
    {
        Value = value;
    }
    public string Name => "Electronic Payment";

    public decimal Value {get; private set;}
}

