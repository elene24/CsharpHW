public class Document : IReadable, IWritable
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