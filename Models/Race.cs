using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace F1_App.Models
{
    public class Race
    {        
        public string Id { get; set; }
        public string RaceName { get; set; }
        public string Country { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public Race()
        {

        }
    }
}
