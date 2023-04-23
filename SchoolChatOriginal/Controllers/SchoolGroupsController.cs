using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SchoolChat.Models;
using SchoolChatOriginal.Data;

namespace SchoolChatOriginal.Controllers
{
    public class SchoolGroupsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SchoolGroupsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SchoolGroups
        public async Task<IActionResult> Index()
        {
              return View(await _context.Groups.ToListAsync());
        }

        // GET: SchoolGroups/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Groups == null)
            {
                return NotFound();
            }

            var schoolGroup = await _context.Groups
                .FirstOrDefaultAsync(m => m.IdGroup == id);
            if (schoolGroup == null)
            {
                return NotFound();
            }

            return View(schoolGroup);
        }

        // GET: SchoolGroups/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SchoolGroups/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdGroup,GroupName,GroupDescription,IdCategory")] SchoolGroup schoolGroup)
        {
            if (ModelState.IsValid)
            {
                _context.Add(schoolGroup);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(schoolGroup);
        }

        // GET: SchoolGroups/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Groups == null)
            {
                return NotFound();
            }

            var schoolGroup = await _context.Groups.FindAsync(id);
            if (schoolGroup == null)
            {
                return NotFound();
            }
            return View(schoolGroup);
        }

        // POST: SchoolGroups/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdGroup,GroupName,GroupDescription,IdCategory")] SchoolGroup schoolGroup)
        {
            if (id != schoolGroup.IdGroup)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(schoolGroup);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SchoolGroupExists(schoolGroup.IdGroup))
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
            return View(schoolGroup);
        }

        // GET: SchoolGroups/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Groups == null)
            {
                return NotFound();
            }

            var schoolGroup = await _context.Groups
                .FirstOrDefaultAsync(m => m.IdGroup == id);
            if (schoolGroup == null)
            {
                return NotFound();
            }

            return View(schoolGroup);
        }

        // POST: SchoolGroups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Groups == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Groups'  is null.");
            }
            var schoolGroup = await _context.Groups.FindAsync(id);
            if (schoolGroup != null)
            {
                _context.Groups.Remove(schoolGroup);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SchoolGroupExists(int id)
        {
          return _context.Groups.Any(e => e.IdGroup == id);
        }
    }
}
