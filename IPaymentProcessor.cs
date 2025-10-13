// Task 4: Payment System
interface IPaymentProcessor
{
    void ProcessPayment(decimal amount);
}

class CreditCardPayment : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing credit card payment of ${amount:F2}");
    }
}

class PayPalPayment : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing PayPal payment of ${amount:F2}");
    }
}