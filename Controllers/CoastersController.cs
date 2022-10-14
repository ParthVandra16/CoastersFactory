using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CoastersFactory.Data;
using CoastersFactory.Models;

namespace CoastersFactory.Controllers
{
    public class CoastersController : Controller
    {
        private readonly CoastersFactoryContext _context;

        public CoastersController(CoastersFactoryContext context)
        {
            _context = context;
        }

        // GET: Coasters
        public async Task<IActionResult> Index()
        {
            return View(await _context.Coasters.ToListAsync());
        }

        // GET: Coasters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coasters = await _context.Coasters
                .FirstOrDefaultAsync(m => m.Id == id);
            if (coasters == null)
            {
                return NotFound();
            }

            return View(coasters);
        }

        // GET: Coasters/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Coasters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BrandName,Material,Color,Size,Shape,Price,ReleaseDate,Rating")] Coasters coasters)
        {
            if (ModelState.IsValid)
            {
                _context.Add(coasters);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(coasters);
        }

        // GET: Coasters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coasters = await _context.Coasters.FindAsync(id);
            if (coasters == null)
            {
                return NotFound();
            }
            return View(coasters);
        }

        // POST: Coasters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,BrandName,Material,Color,Size,Shape,Price,ReleaseDate,Rating")] Coasters coasters)
        {
            if (id != coasters.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(coasters);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CoastersExists(coasters.Id))
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
            return View(coasters);
        }

        // GET: Coasters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coasters = await _context.Coasters
                .FirstOrDefaultAsync(m => m.Id == id);
            if (coasters == null)
            {
                return NotFound();
            }

            return View(coasters);
        }

        // POST: Coasters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var coasters = await _context.Coasters.FindAsync(id);
            _context.Coasters.Remove(coasters);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CoastersExists(int id)
        {
            return _context.Coasters.Any(e => e.Id == id);
        }
    }
}
