using Microsoft.Extensions.Configuration;

class Program
{
    static void Main(string[] args)
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false)
            .Build();

        Console.WriteLine("APP_PROFILE: " + config["AppProfile"]);
        Console.WriteLine("DRY_RUN: " + config["DryRun"]);

        // Your job logic...
    }
}
