using System;
using System.Collections.Generic;
using System.Text;
using F1_App.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace F1_App.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


        public DbSet<Driver> Driver { get; set; }
        public DbSet<UserPredictions> UserPredictions { get; set; }
        public DbSet<SystemConfig> SystemConfig { get; set; }
        public DbSet<F1_App.Models.Race> Race { get; set; }



    }
}
