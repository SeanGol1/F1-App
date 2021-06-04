using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using F1_App.Data;
using F1_App.Models;

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
        public IActionResult Create()
        {
            return View();
        }

        // POST: UserPredictions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,DriverId,Position,Season,Round")] UserPredictions userPredictions)
        {
            if (ModelState.IsValid)
            {
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
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,DriverId,Position,Season,Round")] UserPredictions userPredictions)
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
    }
}
