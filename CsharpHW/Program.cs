using System;

public class Program
{
    public static void Main()
    {
        try
        {

            Human person = new Human(
                "Elene",
                "Margalitadze",
                25,
                "01024085079",
                "555123456",
                "elenemarg@email.com"
            );
            person.DisplayInfoInConsole();


            Account account1 = new Account("GE00TB0000000000000001", "GEL", 1000);
            Account account2 = new Account("GE00TB0000000000000002", "GEL", 500);
            Account account3 = new Account("GE00TB0000000000000003", "USD", 200);

            Client client1 = new Client("anna", "smith", "01024085070", account1);
            Client client2 = new Client("mariam", "green", "01024085071", account2);
            Client client3 = new Client("avery", "lane", "01024085072", account3);

            client1.DisplayClientInfo();
            client2.DisplayClientInfo();
            client3.DisplayClientInfo();

            client1.DepositMoney(500);
            client1.WithdrawMoney(200);
            client1.TransferMoney(client2, 300);

            client1.DisplayClientInfo();
            client1.DisplayClientInfo();
            client2.DisplayClientInfo();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}