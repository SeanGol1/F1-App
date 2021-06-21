using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using F1_App.Data;
using F1_App.Models;
using System.Net.Http;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Xml;

namespace F1_App.Controllers
{
    public class DriversController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DriversController(ApplicationDbContext context)
        {

            _context = context;
        }

        // GET: Drivers
        public async Task<IActionResult> Index()
        {
            CreateDriver();
            List<Driver> model = null;
            var query = from d in _context.Driver
                        orderby d.StandingsPosition 
                        select d;
            model = query.ToList();
            //return View(await _context.Driver.ToListAsync());
            return View(model);
        }

        // Post: SaveDrivers
        [HttpPost]
        public async Task<IActionResult> SaveDrivers([Bind("Id,DriverID,StandingsPosition,Points,TeamName")] UserPredictions userPredictions)
        {

            userPredictions.UserId = "27168af2 - e1f2 - 4bd5 - b9b4 - 93e9be6d5988";
            //userPredictions.Season = 

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userPredictions);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {

                }
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: Drivers/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var driver = await _context.Driver
                .FirstOrDefaultAsync(m => m.Id == id);
            if (driver == null)
            {
                return NotFound();
            }

            return View(driver);
        }

        // GET: Drivers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Drivers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,StandingsPosition,Points,TeamName")] Driver driver)
        {
            if (ModelState.IsValid)
            {
                _context.Add(driver);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(driver);
        }

        // GET: Drivers/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var driver = await _context.Driver.FindAsync(id);
            if (driver == null)
            {
                return NotFound();
            }
            return View(driver);
        }

        // POST: Drivers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Name,StandingsPosition,Points,TeamName")] Driver driver)
        {
            if (id != driver.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(driver);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DriverExists(driver.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(driver);
        }

        // GET: Drivers/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var driver = await _context.Driver
                .FirstOrDefaultAsync(m => m.Id == id);
            if (driver == null)
            {
                return NotFound();
            }

            return View(driver);
        }

        // POST: Drivers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var driver = await _context.Driver.FindAsync(id);
            _context.Driver.Remove(driver);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public bool DriverExists(string id)
        {
            return _context.Driver.Any(e => e.Id == id);
        }
        static HttpClient client = new HttpClient();

        // GET: Get Drivers and Update DB
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



    }
}
