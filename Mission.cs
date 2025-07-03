using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MissionControl
{
    public class Mission
    {
        public Mission() { }

        public Mission(string missionName, string missionStatus)
        {
            Name = missionName;
            Status = missionStatus;
        }

        public string? Name { get; set; }
        public DateTime Startzeitpunkt { get; set; }
        public string? Status { get; set; }
    }
}