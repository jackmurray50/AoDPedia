using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AoDPedia_Site;

namespace AoDPedia_Site.Controllers
{
    public class UnitsController : Controller
    {
        private readonly AoDPediaContext _context;

        public UnitsController(AoDPediaContext context)
        {
            _context = context;
        }

        // GET: Units
        public async Task<IActionResult> Index()
        {
            return View(await _context.TUnits.ToListAsync());
        }

        // GET: Units/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tUnit = await _context.TUnits
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tUnit == null)
            {
                return NotFound();
            }

            return View(tUnit);
        }

        // GET: Units/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Units/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Cost,Fluff")] TUnit tUnit)
        {
            if (ModelState.IsValid)
            {
                tUnit.Id = Guid.NewGuid();
                _context.Add(tUnit);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tUnit);
        }

        // GET: Units/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tUnit = await _context.TUnits.FindAsync(id);
            if (tUnit == null)
            {
                return NotFound();
            }
            return View(tUnit);
        }

        // POST: Units/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Name,Cost,Fluff")] TUnit tUnit)
        {
            if (id != tUnit.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tUnit);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TUnitExists(tUnit.Id))
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
            return View(tUnit);
        }

        // GET: Units/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tUnit = await _context.TUnits
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tUnit == null)
            {
                return NotFound();
            }

            return View(tUnit);
        }

        // POST: Units/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var tUnit = await _context.TUnits.FindAsync(id);
            _context.TUnits.Remove(tUnit);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TUnitExists(Guid id)
        {
            return _context.TUnits.Any(e => e.Id == id);
        }
    }
}
