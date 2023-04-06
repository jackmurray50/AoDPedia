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

        private bool TUnitExists(Guid id)
        {
            return _context.TUnits.Any(e => e.Id == id);
        }
    }
}
