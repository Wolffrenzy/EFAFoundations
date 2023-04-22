namespace _10_Interfaces_WDI_Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        ICurrency penny = new Penny();

        Assert.Equal(.01m, penny.Value);
    }

    [Fact]
    
    public void DimeTest()
    {
        ICurrency dime = new Dime();

        Assert.Equal(.10m, dime.Value);
    }

    [Fact]

    public void DollarTest()
    {
        ICurrency dollar = new Dollar();

        Assert.Equal(1.00m, dollar.Value);
        Assert.Equal("Dollar", dollar.Name);
    }

    [Theory]
    [InlineData(100.2)]
    [InlineData(37.12)]
    [InlineData(1.50)]
    [InlineData(19)]
    public void EPayTest(double value)
    {
        decimal convertToDecimal = Convert.ToDecimal(value);
        var ePayment = new ElectronicPayment(convertToDecimal);

        Assert.Equal(convertToDecimal, ePayment.Value);
        Assert.Equal("Electronic Payment", ePayment.Name);
        
    }
}