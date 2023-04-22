public class Transaction
{
    // 1. private backing field that will hold the dependency data

    //* We have GLOBAL SCOPE, so, this '_currency' can be used throughout the class!!!
    private readonly ICurrency _currency;

    // 2. Create a constructor that depends on ICurrency
    public Transaction(ICurrency currency)
    {
        _currency = currency;
        DateOfTransaction = DateTime.Now;
    }

    //Transaction trans = new Transaction();
    public DateTimeOffset DateOfTransaction { get; set; }

    public decimal GetTransactionAmount()
    {
        return _currency.Value;
    }

    public string GetTransactionType() => _currency.Name;

    /*
        public string GetTransactionType()
        {
            return _currency.Name;
        }
    */
}