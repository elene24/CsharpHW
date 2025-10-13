public class Car : IVehicle
{
    public string Model { get; set; }
    public int Year { get; set; }

    public void Start()
    {
        Console.WriteLine($"Starting {Year} {Model}... Vroom!");
    }
}