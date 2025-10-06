using System;

public class Account
{
    private string _accountNumber;
    private string _currency;
    private decimal _balance;

    public string AccountNumber
    {
        get => _accountNumber;
        private set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length != 22)
                throw new ArgumentException("Account number must be exactly 22 characters");
            _accountNumber = value;
        }
    }

    public string Currency
    {
        get => _currency;
        private set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length != 3)
                throw new ArgumentException("Currency must be exactly 3 characters");
            _currency = value.ToUpper();
        }
    }

    public decimal Balance
    {
        get => _balance;
        private set
        {
            if (value < 0)
                throw new ArgumentException("Balance cannot be negative");
            _balance = value;
        }
    }

    public Account(string accountNumber, string currency, decimal initialBalance = 0)
    {
        AccountNumber = accountNumber;
        Currency = currency;
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException( "amount must be positive");

        Balance += amount;
        Console.WriteLine($"Deposited {amount} {Currency}. New balance: {Balance} {Currency}");
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("amount must be positive");

        if (Balance < amount)
            throw new InvalidOperationException("Insufficient amount");

        Balance -= amount;
        Console.WriteLine($"Withdrawn {amount} {Currency}. New balance: {Balance} {Currency}");
    }

    public void TransferTo(Account targetAccount, decimal amount)
    {
        if (targetAccount == null)
            throw new ArgumentNullException(nameof(targetAccount));

        if (amount <= 0)
            throw new ArgumentException("amount must be positive");

        if (this.Currency != targetAccount.Currency)
            throw new InvalidOperationException("Currency issue");

        if (Balance < amount)
            throw new InvalidOperationException("Not enough money amount");

        this.Balance -= amount;
        targetAccount.Balance += amount;

        Console.WriteLine($"Transferred {amount} {Currency} from account {this.AccountNumber} to {targetAccount.AccountNumber}");
    }

    public void DisplayAccountInfo()
    {
        Console.WriteLine($"Account: {AccountNumber}, Currency: {Currency}, Balance: {Balance}");
    }
}