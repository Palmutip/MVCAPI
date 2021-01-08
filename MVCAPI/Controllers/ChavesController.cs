using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCAPI.Models;

namespace MVCAPI.Controllers
{
    public class ChavesController : Controller
    {
        private readonly mysola97_APIContext _context;

        public ChavesController(mysola97_APIContext context)
        {
            _context = context;
        }

        // GET: Chaves
        public async Task<IActionResult> Index()
        {
            return View(await _context.Chaves.ToListAsync());
        }

        // GET: Chaves/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chaves = await _context.Chaves
                .FirstOrDefaultAsync(m => m.Id == id);
            if (chaves == null)
            {
                return NotFound();
            }

            return View(chaves);
        }

        // GET: Chaves/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Chaves/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Numchave,Stringchave")] Chaves chaves)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chaves);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(chaves);
        }

        // GET: Chaves/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chaves = await _context.Chaves.FindAsync(id);
            if (chaves == null)
            {
                return NotFound();
            }
            return View(chaves);
        }

        // POST: Chaves/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Numchave,Stringchave")] Chaves chaves)
        {
            if (id != chaves.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chaves);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChavesExists(chaves.Id))
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
            return View(chaves);
        }

        // GET: Chaves/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chaves = await _context.Chaves
                .FirstOrDefaultAsync(m => m.Id == id);
            if (chaves == null)
            {
                return NotFound();
            }

            return View(chaves);
        }

        // POST: Chaves/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var chaves = await _context.Chaves.FindAsync(id);
            _context.Chaves.Remove(chaves);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChavesExists(int id)
        {
            return _context.Chaves.Any(e => e.Id == id);
        }
    }
}
