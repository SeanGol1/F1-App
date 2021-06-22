using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using F1_App.Models;
using System.Xml;
using F1_App.Data;

namespace F1_App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {

            _context = context;
        }
        public IActionResult Index()
        {

            /* Display Race Details */
            List<Race> Races = _context.Race.ToList();
            SystemConfig sc = GetCurrentSeasonRound();            
            Race CRace = Races[sc.CurrentRound - 1];
            ViewBag.Race = CRace;

            /*Display Driver Details*/            
            var query = (from d in _context.Driver
                        orderby d.StandingsPosition
                        select d).Take(5);
            List<Driver> driverList = query.ToList();
            ViewBag.DriverList = driverList;

            /*If User Is Logged In*/
            if (User.Identity.IsAuthenticated)
            {
                /*Display user tournaments*/
                var query2 = (from t in _context.Tournament                              
                              select t).Take(1);
                List<Tournament> tournamentList = query2.ToList();
                ViewBag.TournList = tournamentList;

                
                              
            }

            return View();
        }

        public IActionResult About()
        {
            CreateDriver();
            //UpdatePoints();

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public SystemConfig GetCurrentSeasonRound()
        {
            SystemConfig systemConfig = _context.SystemConfig.Find(1);

            return systemConfig;
        }

        public void UpdatePoints()
        {
            string current = "";
            String URLString = "https://ergast.com/api/f1/current/last/results";
            Driver driver = new Driver();
            SystemConfig syscon = _context.SystemConfig
                                        .FirstOrDefault(m => m.Id == 1);
            XmlTextReader reader = new XmlTextReader(URLString);
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: // The node is an element.   
                        if (reader.Name == "StandingsList")
                        {
                            while (reader.MoveToNextAttribute())
                            {
                                if (reader.Name == "season")
                                    syscon.CurrentSeason = Convert.ToInt32(reader.Value);
                                else if (reader.Name == "round")
                                    syscon.CurrentRound = (Convert.ToInt32(reader.Value) + 1);
                            }
                            _context.Update(syscon);
                            _context.SaveChanges();
                        }
                        break;
                    case XmlNodeType.Text: //Display the text in each element.
                        break;
                }
            }
        }

        public void CreateDriver()
        {
            string current = "";
            String URLString = "https://ergast.com/api/f1/2021/driverStandings";
            Driver driver = new Driver();
            SystemConfig syscon = _context.SystemConfig
                                        .FirstOrDefault(m => m.Id == 1);
            XmlTextReader reader = new XmlTextReader(URLString);
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: // The node is an element.                        

                        if (reader.Name == "StandingsList")
                        {
                            while (reader.MoveToNextAttribute())
                            {
                                if (reader.Name == "season")
                                    syscon.CurrentSeason = Convert.ToInt32(reader.Value);
                                else if (reader.Name == "round")
                                    syscon.CurrentRound = (Convert.ToInt32(reader.Value) + 1);
                            }
                            _context.Update(syscon);
                            _context.SaveChanges();
                        }

                        //Filter through XML Data and create a Driver Object
                        if (reader.Name == "DriverStanding")
                        {
                            while (reader.MoveToNextAttribute())
                            {
                                if (reader.Name == "position")
                                    driver.StandingsPosition = Convert.ToInt32(reader.Value);
                                else if (reader.Name == "points")
                                    driver.Points = Convert.ToInt32(reader.Value);

                            }
                        }

                        else if (reader.Name == "Driver")
                        {
                            while (reader.MoveToNextAttribute())
                            {
                                if (reader.Name == "driverId")
                                    driver.Id = reader.Value;


                            }
                        }
                        else if (reader.Name == "Constructor")
                        {
                            while (reader.MoveToNextAttribute())
                            {
                                if (reader.Name == "Name")
                                    driver.TeamName = reader.Value;
                            }
                        }
                        else if (reader.Name == "GivenName" || reader.Name == "FamilyName" || reader.Name == "Name")
                        {
                            current = reader.Name;
                        }

                        break;

                    case XmlNodeType.Text: //Display the text in each element.
                        if (current == "GivenName")
                        {
                            driver.GivenName += reader.Value;

                        }
                        else if (current == "FamilyName")
                        {
                            driver.FamilyName += reader.Value;
                        }
                        else if (current == "Name")
                        {
                            driver.TeamName += reader.Value;
                            //On the Last piece of info for Driver, Send to create Function.
                            InsertDriver(driver);
                            driver = new Driver();
                        }
                        current = "";

                        break;
                    case XmlNodeType.EndElement: //Display the end of the element.                 
                        break;
                }
            }
        }
        public void InsertDriver(Driver driver)
        {
            if (DriverExists(driver.Id))
                _context.Update(driver);
            else
                _context.Add(driver);
            _context.SaveChanges();
        }
        public bool DriverExists(string id)
        {
            return _context.Driver.Any(e => e.Id == id);
        }
    }
}
