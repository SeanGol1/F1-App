using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace F1_App.Models
{
    public class Driver
    {   
        public string Id { get; set; }
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public int StandingsPosition { get; set; }
        public int Points { get; set; }
        public string TeamName { get; set; }
        public int Number { get; set; }
        public Driver()
        {

        }

    }
}
