using System;

public class Client
{
    private string _personalNumber;

    public string FirstName { get; private set; }
    public string LastName { get; private set; }

    public string PersonalNumber
    {
        get => _personalNumber;
        private set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length != 11)
                throw new ArgumentException("11 Characters!");
            _personalNumber = value;
        }
    }

    public Account Account { get; private set; }

    public Client(string firstName, string lastName, string personalNumber, Account account)
    {
        FirstName = firstName;
        LastName = lastName;
        PersonalNumber = personalNumber;
        Account = account ?? throw new ArgumentNullException(nameof(account));
    }

    public void DisplayClientInfo()
    {
        Console.WriteLine($"Client: {FirstName} {LastName}, Personal Number: {PersonalNumber}");
        Account.DisplayAccountInfo();
    }

    public void DepositMoney(decimal amount) => Account.Deposit(amount);
    public void WithdrawMoney(decimal amount) => Account.Withdraw(amount);
    public void TransferMoney(Client targetClient, decimal amount) => Account.TransferTo(targetClient.Account, amount);
}