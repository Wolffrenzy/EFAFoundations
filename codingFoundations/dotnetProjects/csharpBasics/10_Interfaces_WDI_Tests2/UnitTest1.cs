namespace _10_Interfaces_WDI_Tests2;

public class UnitTest1
{
    private decimal _debt;

    public UnitTest1()
    {
        _debt = 9000.01m;
    }
    
    private void PayDebt(ICurrency payment)
    {
        _debt -= payment.Value; // _debt = _debt - payment.Value;
        System.Console.WriteLine($"You have {payment.Value.ToString("c")} towards your debt!");
    }

    [Fact]
    public void PayDebtTest()
    {
        PayDebt(new Dollar());
        PayDebt(new ElectronicPayment(315.52m));

        decimal expectedDebt = 9000.01m - 316.52m;

        Assert.Equal(expectedDebt, _debt);
    }

    [Fact]
    public void InjectingIntoConstructors()
    {
        ICurrency dollar = new Dollar();
        ICurrency ePayment = new ElectronicPayment(243.71m);

        //make some transactions
        Transaction firstTransaction = new Transaction(dollar);
        var secondTransaction = new Transaction(ePayment);

        System.Console.WriteLine(firstTransaction.GetTransactionType());
        System.Console.WriteLine(secondTransaction.GetTransactionType());

        Assert.Equal("Dollar", firstTransaction.GetTransactionType());
        
        Assert.Equal("Electronic Payment", secondTransaction.GetTransactionType());

        Assert.Equal( 243.71m , secondTransaction.GetTransactionAmount());
    }

    [Fact]
    public void MoreExamples()
    {
        //? what if we have multiple transactions
        var transactionList = new List<Transaction>
        {
            new Transaction(new Dollar()),
            new Transaction(new ElectronicPayment(231.95m)),
            new Transaction(new Dime()),
            new Transaction(new Dollar()),
            new Transaction(new Penny())
        };

        //todo: We want to write to the console the type, amount, and Date of transaction
        //todo: for each transaction

        //todo: The only way to access the data of a collection is to 'iterate' or 'loop' through it
        foreach (var transaction in transactionList)
        {
            //name of transaction
            var type = transaction.GetTransactionType();
            var amount = transaction.GetTransactionAmount();

            //Now we want to print to the console
            System.Console.WriteLine($"{type} - {amount.ToString("c")} - {transaction.DateOfTransaction}");
        }
    }
}