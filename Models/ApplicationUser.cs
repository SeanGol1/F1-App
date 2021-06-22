using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
namespace F1_App.Models
{
    

    public class ApplicationUser : IdentityUser
    {
        public string Points { get; set; }
    }
}
