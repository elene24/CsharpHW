// Task 3: Multiple Interfaces
interface IReadable
{
    void Read();
}

interface IWritable
{
    void Write();
}

class Document : IReadable, IWritable
{
    public void Read()
    {
        Console.WriteLine("Reading document...");
    }

    public void Write()
    {
        Console.WriteLine("Writing to document...");
    }
}