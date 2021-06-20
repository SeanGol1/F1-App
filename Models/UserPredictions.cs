using F1_App.Data.Migrations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace F1_App.Models
{
    public class UserPredictions
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int Position { get; set; }
        public string DriverId { get; set; }
        public int Season { get; set; }
        public int Round { get; set; }
        public int PossiblePoints { get; set; }

        public UserPredictions()
        {
          
        }


    }
}
