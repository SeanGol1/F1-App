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
        //public string Position2 { get; set; }
        //public string Position3 { get; set; }
        //public string Position4 { get; set; }
        //public string Position5 { get; set; }
        //public string Position6 { get; set; }
        //public string Position7 { get; set; }
        //public string Position8 { get; set; }
        //public string Position9 { get; set; }
        //public string Position10 { get; set; }
        //public string Position11 { get; set; }
        //public string Position12 { get; set; }
        //public string Position13 { get; set; }
        //public string Position14 { get; set; }
        //public string Position15 { get; set; }
        //public string Position16 { get; set; }
        //public string Position17 { get; set; }
        //public string Position18 { get; set; }
        //public string Position19 { get; set; }
        //public string Position20 { get; set; }
        public int Season { get; set; }
        public int Round { get; set; }

        public UserPredictions()
        {
          
        }


    }
}
