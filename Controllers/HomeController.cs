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
                         select d).Take(10);
            List<Driver> driverList = query.ToList();
            ViewBag.DriverList = driverList;

            /*If User Is Logged In*/
            if (User.Identity.IsAuthenticated)
            {
                /*Display user tournaments*/
                var query2 = (from t in _context.Tournament
                              join ut in _context.UserTournament on t.Id equals ut.TournamentId
                              where ut.UserId == HttpContext.User.Identity.Name
                              select t);
                List<Tournament> tournamentList = query2.ToList();
                ViewBag.TournList = tournamentList;

                var query3 = from up in _context.UserPoints
                             where up.UserName == HttpContext.User.Identity.Name
                             select up.Points;
                ViewBag.Points = query3.FirstOrDefault();



            }

            return View();
        }

        public IActionResult About()
        {
            CreateDriver();
            SystemConfig sys = GetCurrentSeasonRound();
            if (sys.PointsDone == false)
                UpdatePoints();
            return View();
        }
        
        
        public IActionResult Contact(string driver)
        {
            ViewData["Message"] = "Driver of the Day:" + driver;
            string[] names = driver.Split(' ');
            SystemConfig sys = GetCurrentSeasonRound();
            var query = from d in _context.Driver
                        where d.GivenName == names[0] && d.FamilyName == names[1]
                        select d.Id;
            sys.DriveroftheDay = query.FirstOrDefault();
            _context.Update(sys);
            _context.SaveChanges();
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
            int round = 0;
            int season = 0;
            int Driverno = 0;
            int position = 0;
            String URLString = "https://ergast.com/api/f1/current/last/results";

            SystemConfig syscon = _context.SystemConfig
                                        .FirstOrDefault(m => m.Id == 1);



            XmlTextReader reader = new XmlTextReader(URLString);
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: // The node is an element.   
                        if (reader.Name == "Race")
                        {
                            while (reader.MoveToNextAttribute())
                            {
                                if (reader.Name == "season")
                                    season = Convert.ToInt32(reader.Value);
                                else if (reader.Name == "round")
                                    round = Convert.ToInt32(reader.Value);
                            }
                        }
                        if (reader.Name == "Result")
                        {
                            while (reader.MoveToNextAttribute())
                            {
                                if (reader.Name == "number")
                                    Driverno = Convert.ToInt32(reader.Value);
                                else if (reader.Name == "position")
                                    position = Convert.ToInt32(reader.Value);
                            }
                            UpdateUserDriver(round, season, Driverno, position);
                        }
                        break;
                    case XmlNodeType.Text: //Display the text in each element.
                        break;
                }
            }
            syscon.PointsDone = true;
            _context.Update(syscon);
            _context.SaveChanges();
        }

        public void UpdateUserDriver(int round, int season, int Driverno, int position)
        {
            var query = from up in _context.UserPredictions
                        where up.Round == round && up.Season == season && up.Position == position
                        select up;
            List<UserPredictions> userPredictions = query.ToList();
            foreach (var item in userPredictions)
            {
                if (item.DriverNo == Driverno)
                {
                    UserPoints userPoints = getUserPoints(item.UserId);
                    userPoints.Points += item.PossiblePoints;
                    //int temppoints = userPoints.Points;
                    //temppoints += item.PossiblePoints;
                    //userPoints.Points = temppoints;
                    _context.Update(userPoints);
                    _context.SaveChanges();

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
                        else if (reader.Name == "GivenName" || reader.Name == "FamilyName" || reader.Name == "Name" || reader.Name == "PermanentNumber")
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
                        else if (current == "PermanentNumber")
                        {
                            driver.Number = Convert.ToInt32(reader.Value);
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
        public UserPoints getUserPoints(string username)
        {
            var query = from up in _context.UserPoints
                        where up.UserName == username
                        select up;
            return query.FirstOrDefault();
        }
    }
}
