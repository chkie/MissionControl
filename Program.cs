
using MissionControl;



class Program
{


    static void Main(string[] args)
    {


        Console.WriteLine("Mission Control Online!");
        Console.WriteLine("=======================\n");

        var mission = new Mission
        {
            Name = "Test Start",
            Startzeitpunkt = new DateTime(2025, 07, 05, 12, 00, 00),
            Status = "Bereit",
        };

        Console.WriteLine("Mission:");
        Console.WriteLine($"Name: \t\t{mission.Name}");
        Console.WriteLine($"Startzeitpunkt: {mission.Startzeitpunkt}");
        Console.WriteLine($"Status: \t{mission.Status}");
    }
}