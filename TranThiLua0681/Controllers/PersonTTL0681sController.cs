using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TranThiLua0681.Models;
using TranThiLua0681.Data;
namespace TranThiLua0681.Controllers
{
    public class PersonTTL0681sController : Controller
    {
        private readonly ApplicationContext _context;

        public PersonTTL0681sController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: PersonTTL0681s
        public async Task<IActionResult> Index()
        {
            return View(await _context.PersonTTL0681.ToListAsync());
        }

        // GET: PersonTTL0681s/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personTTL0681 = await _context.PersonTTL0681
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (personTTL0681 == null)
            {
                return NotFound();
            }

            return View(personTTL0681);
        }

        // GET: PersonTTL0681s/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PersonTTL0681s/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonId,PersonName")] PersonTTL0681 personTTL0681)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personTTL0681);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personTTL0681);
        }

        // GET: PersonTTL0681s/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personTTL0681 = await _context.PersonTTL0681.FindAsync(id);
            if (personTTL0681 == null)
            {
                return NotFound();
            }
            return View(personTTL0681);
        }

        // POST: PersonTTL0681s/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PersonId,PersonName")] PersonTTL0681 personTTL0681)
        {
            if (id != personTTL0681.PersonId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personTTL0681);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonTTL0681Exists(personTTL0681.PersonId))
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
            return View(personTTL0681);
        }

        // GET: PersonTTL0681s/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personTTL0681 = await _context.PersonTTL0681
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (personTTL0681 == null)
            {
                return NotFound();
            }

            return View(personTTL0681);
        }

        // POST: PersonTTL0681s/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var personTTL0681 = await _context.PersonTTL0681.FindAsync(id);
            _context.PersonTTL0681.Remove(personTTL0681);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonTTL0681Exists(int id)
        {
            return _context.PersonTTL0681.Any(e => e.PersonId == id);
        }
    }
}
