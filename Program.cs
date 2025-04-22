internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Starting Action1 Job...");

        var profile = Environment.GetEnvironmentVariable("APP_PROFILE");
        var dryRun = Environment.GetEnvironmentVariable("DRY_RUN");

        Console.WriteLine($"APP_PROFILE: {profile}");
        Console.WriteLine($"DRY_RUN: {dryRun}");

        // Your WebJob logic here
    }
}
