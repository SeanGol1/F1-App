using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using F1_App.Data;
using F1_App.Models;
using Microsoft.AspNetCore.Authorization;

namespace F1_App.Controllers
{
    public class UserPredictionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserPredictionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: UserPredictions
        public async Task<IActionResult> Index()
        {
            return View(await _context.UserPredictions.ToListAsync());
        }

        // GET: UserPredictions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userPredictions = await _context.UserPredictions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userPredictions == null)
            {
                return NotFound();
            }

            return View(userPredictions);
        }

        // GET: UserPredictions/Create
        [Authorize]
        public IActionResult Create()
        {
            List<Driver> model = null;
            var query = from d in _context.Driver
                        orderby d.StandingsPosition
                        select d;
            model = query.ToList();
            ViewBag.Drivers = model;

            return View();
        }

        public class Data
        {
            public string name { get; set; }
            public int position { get; set; }
        }
        [HttpPost]
        public void getPosList([FromBody]List<Data> dataList)
        {
            foreach (var item in dataList)
            {
                UserPredictions userPredictions = new UserPredictions();


                SystemConfig SessionDetails = GetCurrentSeasonRound();
                if (ModelState.IsValid)
                {
                    userPredictions.DriverId = item.name;
                    userPredictions.Position = item.position;
                    userPredictions.Season = SessionDetails.CurrentSeason;
                    userPredictions.Round = SessionDetails.CurrentRound;
                    userPredictions.UserId = HttpContext.User.Identity.Name;
                    int newId = GetIdUserPredictions(userPredictions);

                    if (newId == 0)
                    {                        
                        _context.Add(userPredictions);
                    }
                    else
                    {
                        userPredictions.Id = newId;
                        _context.Update(userPredictions);
                    }
                    _context.SaveChanges();
                }

            }
            RedirectToAction("Index", "Drivers");

            //return Json(true);
            //return ;

        }
        // POST: UserPredictions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Data item)
        {
            UserPredictions userPredictions = new UserPredictions();


            SystemConfig SessionDetails = GetCurrentSeasonRound();
            if (ModelState.IsValid)
            {
                userPredictions.Season = SessionDetails.CurrentSeason;
                userPredictions.Round = SessionDetails.CurrentRound;
                userPredictions.UserId = HttpContext.User.Identity.Name;
                userPredictions.Id = GetIdUserPredictions(userPredictions);
                _context.Add(userPredictions);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userPredictions);
        }

        // GET: UserPredictions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userPredictions = await _context.UserPredictions.FindAsync(id);
            if (userPredictions == null)
            {
                return NotFound();
            }
            return View(userPredictions);
        }

        // POST: UserPredictions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,Position1,Position2,Position3,Position4,Position5,Position6,Position7,Position8,Position9,Position10,Position11,Position12,Position13,Position14,Position15,Position16,Position17,Position18,Position19,Position20,Season,Round")] UserPredictions userPredictions)
        {
            if (id != userPredictions.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userPredictions);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserPredictionsExists(userPredictions.Id))
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
            return View(userPredictions);
        }

        // GET: UserPredictions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userPredictions = await _context.UserPredictions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userPredictions == null)
            {
                return NotFound();
            }

            return View(userPredictions);
        }

        // POST: UserPredictions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userPredictions = await _context.UserPredictions.FindAsync(id);
            _context.UserPredictions.Remove(userPredictions);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserPredictionsExists(int id)
        {
            return _context.UserPredictions.Any(e => e.Id == id);
        }

        private int GetIdUserPredictions(UserPredictions up)
        {
            int Id = 0;
            try
            {
                var query = from u in _context.UserPredictions
                            where u.UserId == up.UserId && u.Season == up.Season && u.Round == up.Round && u.Position == up.Position
                            select u.Id;
                Id = query.FirstOrDefault();
            }
            catch (Exception)
            {
                                
            }

            return Id;
        }
        public SystemConfig GetCurrentSeasonRound()
        {
            SystemConfig systemConfig = _context.SystemConfig.Find(1);

            return systemConfig;
        }
    }
}
