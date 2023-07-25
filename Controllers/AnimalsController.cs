using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FirstWeb.Data;
using FirstWeb.Models;

namespace FirstWeb.Controllers
{
    public class AnimalsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AnimalsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Animals
        public async Task<IActionResult> Index()
        {
              return _context.Animals != null ? 
                          View(await _context.Animals.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Animals'  is null.");
        }

        // GET: Animals/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Animals == null)
            {
                return NotFound();
            }

            var animals = await _context.Animals
                .FirstOrDefaultAsync(m => m.AnimalsName == id);
            if (animals == null)
            {
                return NotFound();
            }

            return View(animals);
        }

        // GET: Animals/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Animals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AnimalsName,Address,Age")] Animals animals)
        {
            if (ModelState.IsValid)
            {
                _context.Add(animals);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(animals);
        }

        // GET: Animals/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Animals == null)
            {
                return NotFound();
            }

            var animals = await _context.Animals.FindAsync(id);
            if (animals == null)
            {
                return NotFound();
            }
            return View(animals);
        }

        // POST: Animals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("AnimalsName,Address,Age")] Animals animals)
        {
            if (id != animals.AnimalsName)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(animals);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AnimalsExists(animals.AnimalsName))
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
            return View(animals);
        }

        // GET: Animals/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Animals == null)
            {
                return NotFound();
            }

            var animals = await _context.Animals
                .FirstOrDefaultAsync(m => m.AnimalsName == id);
            if (animals == null)
            {
                return NotFound();
            }

            return View(animals);
        }

        // POST: Animals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Animals == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Animals'  is null.");
            }
            var animals = await _context.Animals.FindAsync(id);
            if (animals != null)
            {
                _context.Animals.Remove(animals);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AnimalsExists(string id)
        {
          return (_context.Animals?.Any(e => e.AnimalsName == id)).GetValueOrDefault();
        }
    }
}
