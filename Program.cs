using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Reading Linux Commands from JSON file...\n");

        try
        {
            string json = File.ReadAllText("linux_commands.json");

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            List<LinuxCommand>? commands = JsonSerializer.Deserialize<List<LinuxCommand>>(json, options);

            if (commands != null)
            {
                foreach (var command in commands)
                {
                    command.Display();
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading file: " + ex.Message);
        }

        Console.WriteLine("JSON File Found: " + File.Exists("linux_commands.json"));
    }
}
