using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TranThiLua0681.Data;
using TranThiLua0681.Models;

namespace TranThiLua0681.Controllers
{
    public class TTL50681sController : Controller
    {
        private readonly ApplicationContext _context;

        public TTL50681sController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: TTL50681s
        public async Task<IActionResult> Index()
        {
            return View(await _context.TTL50681.ToListAsync());
        }

        // GET: TTL50681s/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tTL50681 = await _context.TTL50681
                .FirstOrDefaultAsync(m => m.TTLId == id);
            if (tTL50681 == null)
            {
                return NotFound();
            }

            return View(tTL50681);
        }

        // GET: TTL50681s/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TTL50681s/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TTLId,TTLName,TTLGender")] TTL50681 tTL50681)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tTL50681);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tTL50681);
        }

        // GET: TTL50681s/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tTL50681 = await _context.TTL50681.FindAsync(id);
            if (tTL50681 == null)
            {
                return NotFound();
            }
            return View(tTL50681);
        }

        // POST: TTL50681s/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TTLId,TTLName,TTLGender")] TTL50681 tTL50681)
        {
            if (id != tTL50681.TTLId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tTL50681);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TTL50681Exists(tTL50681.TTLId))
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
            return View(tTL50681);
        }

        // GET: TTL50681s/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tTL50681 = await _context.TTL50681
                .FirstOrDefaultAsync(m => m.TTLId == id);
            if (tTL50681 == null)
            {
                return NotFound();
            }

            return View(tTL50681);
        }

        // POST: TTL50681s/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tTL50681 = await _context.TTL50681.FindAsync(id);
            _context.TTL50681.Remove(tTL50681);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TTL50681Exists(int id)
        {
            return _context.TTL50681.Any(e => e.TTLId == id);
        }
    }
}
