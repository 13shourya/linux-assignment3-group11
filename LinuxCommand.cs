public class LinuxCommand
{
    public string Command { get; set; } = "";
    public string Description { get; set; } = "";
    public string Category { get; set; } = "";

    public void Display()
    {
        Console.WriteLine($"Command: {Command}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Category: {Category}");
        Console.WriteLine("----------------------------------");
    }
}
