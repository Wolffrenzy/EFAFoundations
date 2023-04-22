namespace _10_Interfaces_Tests;

public class UnitTest1
{
    [Fact]
    public void CallingInterfaceMethods()
    {
        //todo: Testing Environment Setup
        //todo: Arrange
        //declare a new interface instance as IFruit
        // We cannot make a new IFruit(), but....
        // b/c Banana implements the IFruit interface below works!!!
        IFruit banana = new Banana();

        //todo: Action
        var output = banana.Peel();
        System.Console.WriteLine(output);

        System.Console.WriteLine("The banana is Peeled: " + banana.IsPeeled);

        //todo: Assertion
        Assert.True(banana.IsPeeled);

        //* AAA SETUP 

    }

    [Fact]
    public void InterfacesInCollections()
    {
        var orange = new Orange();

        //list of IFruits
        List<IFruit> fruits = new List<IFruit>()
        {
            new Banana(),
            new Grape(),
            orange
        };

        //lets loop through the list
        foreach (IFruit fruit in fruits)
        {
            System.Console.WriteLine(fruit.Name);
            System.Console.WriteLine(fruit.Peel());

            //assert if it is of type IFruit
            Assert.IsAssignableFrom<IFruit>(fruit); //* SUCCESS!!!
        }
        System.Console.WriteLine(orange.Squeeze());
    }

    [Fact]
    public void IterfacesInMethods()
    {
        var grape = new Grape();

        var output = GetFruitName(grape);

        System.Console.WriteLine(output);

        Assert.Equal(output, grape.Name);
    }

    //Helper Method X-unit will not test this... just run it when needed
    private string GetFruitName(Grape grape)
    {
        return grape.Name;
    }

    [Fact]
    public void TypeOfInstance()
    {
        var fruitSalad = new List<IFruit>
        {
            new Orange(true),
            new Orange(),
            new Grape(),
            new Orange(),
            new Banana(true),
            new Grape()
        };

        System.Console.WriteLine("Is the orange Peeled?");
        foreach (var fruit in fruitSalad)
        {
            //we are going to use the 'is' keyword
            // allows us to 'check for a specific type'
            if (fruit is Orange orange)
            {
                if (orange.IsPeeled)
                {
                    System.Console.WriteLine("Is a peeled Orange.");
                }
                else
                {
                    System.Console.WriteLine("Is an Orange.");
                }
            }
            else if (fruit.GetType() == typeof(Grape))
            {
                System.Console.WriteLine("Is a Grape.");
            }
            else if (fruit.IsPeeled)
            {
                System.Console.WriteLine("You peeled a Banana.");
            }
            else
            {
                System.Console.WriteLine("Is a Banana.");
            }
        }
    }
}

// Pattern Matching
// Another way to demonstrate checking types is with Pattern Matching
// Docs: https://docs.microsoft.com/en-us/dotnet/csharp/pattern-matching
// This is basically the same way we did the first if (fruit is Orange orange)