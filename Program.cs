
using System;
using MissionControl;



class Program
{


    static void Main(string[] args)
    {


        Console.WriteLine("Mission Control Online!");
        Console.WriteLine("=======================\n");

        var testStart = new Mission
        {
            Name = "Test Start",
            Startzeitpunkt = new DateTime(2025, 07, 05, 12, 00, 00),
            Status = "Bereit",
        };

        var starlink = new Mission
        {
            Name = "Starlink Mission 1",
            Startzeitpunkt = new DateTime(2025, 07, 10, 10, 00, 00),
            Status = "Bereit",
        };

        var marsRover = new Mission
        {
            Name = "Mars Exploration Labatory",
            Startzeitpunkt = new DateTime(2026, 08, 15, 06, 30, 00),
            Status = "Im Testphase",
        };

        List<Mission> missions = new List<Mission>();
        missions.Add(testStart);
        missions.Add(starlink);
        missions.Add(marsRover);

        foreach (Mission mission in missions)

            Console.WriteLine($" Missionsname: {mission.Name}\n Startzeitpunkt: {mission.Startzeitpunkt}\n Status: {mission.Status}\n");




    }
}