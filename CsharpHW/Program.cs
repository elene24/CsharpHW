using CsharpHW.Animals;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Task 1: Animals ===");
        List<IAnimal> animals = new List<IAnimal>
        {
            new Dog(),
            new Cat(),
            new Dog()
        };

        foreach (var animal in animals)
        {
            animal.MakeSound();
        }

        Console.WriteLine("\n Task 2: Vehicle ");
        Car myCar = new Car
        {
            Model = "Toyota Camry",
            Year = 2023
        };
        myCar.Start();

        Console.WriteLine("\n Task 3: Document ");
        Document doc = new Document();
        doc.Read();
        doc.Write();

        Console.WriteLine("\n Task 4: Payment System ");
        Console.Write("Enter payment method (1 for Credit Card, 2 for PayPal): ");
        string choice = Console.ReadLine();
        Console.Write("Enter amount: ");
        decimal amount = decimal.Parse(Console.ReadLine());

        IPaymentProcessor processor;

        if (choice == "1")
        {
            processor = new CreditCardPayment();
        }
        else
        {
            processor = new PayPalPayment();
        }

        processor.ProcessPayment(amount);

        Console.WriteLine("\n  Task 5: Logger with Default Implementation ");
        ILogger logger = new ConsoleLogger();
        logger.Log("This is a regular log message");
        logger.LogWithTime("This message includes timestamp");

        Console.WriteLine("\n  Task 6: Polymorphism with Shapes ");
        List<IShape> shapes = new List<IShape>
        {
            new Rectangle(5, 10),
            new Circle(3),
            new Rectangle(2, 4),
            new Circle(5)
        };

        double totalArea = 0;
        foreach (var shape in shapes)
        {
            double area = shape.GetArea();
            Console.WriteLine($"Shape area: {area:F2}");
            totalArea += area;
        }

        Console.WriteLine($"Total area of all shapes: {totalArea:F2}");
    }
}