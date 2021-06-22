using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using F1_App.Data;
using F1_App.Models;
using System.Xml;

namespace F1_App.Controllers
{
    public class RacesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RacesController(ApplicationDbContext context)
        {
            _context = context;
        }
               

        // GET: Races
        public async Task<IActionResult> Index()
        {
            GetRaces();
            SystemConfig sc = GetCurrentSeasonRound();
            ViewBag.Round = sc.CurrentRound;
            return View(await _context.Race.ToListAsync());
        }

        public void GetRaces()
        {
            string current = "";
            Race race = new Race();
            String URLString = "https://ergast.com/api/f1/2021/races";

            XmlTextReader reader = new XmlTextReader(URLString);
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: // The node is an element.                        
                        current = reader.Name;



                        break;

                    case XmlNodeType.Text: //Display the text in each element.
                        if (current == "RaceName")
                        {
                            race.RaceName = reader.Value;
                        }
                        else if (current == "CircuitName")
                        {
                            race.Id = reader.Value;
                        }
                        else if (current == "Country")
                        {
                            race.Country = reader.Value;
                        }
                        else if (current == "Date")
                        {
                            race.Date = reader.Value;
                            race.Id = reader.Value;
                        }
                        else if (current == "Time")
                        {
                            race.Time = (reader.Value).Remove(reader.Value.Length - 1);
                            if (RaceExists(race.Id))
                                _context.Update(race);
                            else
                                _context.Add(race);
                            _context.SaveChanges();
                            race = new Race();
                        }

                        current = "";

                        break;
                    case XmlNodeType.EndElement: //Display the end of the element.                 
                        break;
                }
            }
        }

        // GET: Races/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var race = await _context.Race
                .FirstOrDefaultAsync(m => m.Id == id);
            if (race == null)
            {
                return NotFound();
            }

            return View(race);
        }

        // GET: Races/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Races/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RaceName,Country,Date,Time")] Race race)
        {
            if (ModelState.IsValid)
            {
                _context.Add(race);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(race);
        }

        // GET: Races/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var race = await _context.Race.FindAsync(id);
            if (race == null)
            {
                return NotFound();
            }
            return View(race);
        }

        // POST: Races/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,RaceName,Country,Date,Time")] Race race)
        {
            if (id != race.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(race);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RaceExists(race.Id))
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
            return View(race);
        }

        // GET: Races/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var race = await _context.Race
                .FirstOrDefaultAsync(m => m.Id == id);
            if (race == null)
            {
                return NotFound();
            }

            return View(race);
        }

        // POST: Races/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var race = await _context.Race.FindAsync(id);
            _context.Race.Remove(race);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RaceExists(string id)
        {
            return _context.Race.Any(e => e.Id == id);
        }
        public SystemConfig GetCurrentSeasonRound()
        {
            SystemConfig systemConfig = _context.SystemConfig.Find(1);

            return systemConfig;
        }
    }
}
