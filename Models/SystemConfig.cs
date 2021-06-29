using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace F1_App.Models
{
    public class SystemConfig
    {
        public int Id { get; set; }
        public int CurrentSeason { get; set; }
        public int CurrentRound { get; set; }
        public bool QualifyingFin { get; set; }
        public int MyId { get; set; }
        public bool PointsDone { get; set; }
        public string DriveroftheDay { get; set; }

        public SystemConfig()
        {

        }

    }
}
