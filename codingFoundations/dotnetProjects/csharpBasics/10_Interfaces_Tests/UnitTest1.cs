namespace _10_Interfaces_Tests;

public class UnitTest1
{
    [Fact]
    public void CallingInterfaceMethods()
    {
        //todo: Testing Environment Setup
        //todo: Arrange
        //declare a new interface instance
        //we cannot make a new IFruit(), but....
        //b/c Banana implements the IFruit interface below works!
        IFruit banana = new Banana();

        //todo: Action
        var output = banana.Peel();
        System.Console.WriteLine(output);

        System.Console.WriteLine("The banana is peeled: " + banana.IsPeeled);

        //todo: Assertion
        Assert.True(banana.IsPeeled);

        //* AAA Setup
        //? Arrange, Action, Assertion
    
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

        //let's loop through the list
        foreach (IFruit fruit in fruits)
        {
            System.Console.WriteLine(fruit.Name);
            System.Console.WriteLine(fruit.Peel());

            //assert if it is of type Fruit
            Assert.IsType<IFruit>(fruit);
        }

        System.Console.WriteLine(orange.Squeeze());

    }
}