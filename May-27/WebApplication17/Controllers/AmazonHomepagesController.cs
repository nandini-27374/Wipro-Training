using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication17.Data;
using WebApplication17.Models;

namespace WebApplication17.Controllers
{
    public class AmazonHomepagesController : Controller
    {
        private readonly WebApplication17Context _context;

        public AmazonHomepagesController(WebApplication17Context context)
        {
            _context = context;
        }

        // GET: AmazonHomepages
        public async Task<IActionResult> Index()
        {
            return View(await _context.AmazonHomepage.ToListAsync());
        }

        // GET: AmazonHomepages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var amazonHomepage = await _context.AmazonHomepage
                .FirstOrDefaultAsync(m => m.Id == id);
            if (amazonHomepage == null)
            {
                return NotFound();
            }

            return View(amazonHomepage);
        }

        // GET: AmazonHomepages/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AmazonHomepages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,ImageUrl,Price,Description")] AmazonHomepage amazonHomepage)
        {
            if (ModelState.IsValid)
            {
                _context.Add(amazonHomepage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(amazonHomepage);
        }

        // GET: AmazonHomepages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var amazonHomepage = await _context.AmazonHomepage.FindAsync(id);
            if (amazonHomepage == null)
            {
                return NotFound();
            }
            return View(amazonHomepage);
        }

        // POST: AmazonHomepages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,ImageUrl,Price,Description")] AmazonHomepage amazonHomepage)
        {
            if (id != amazonHomepage.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(amazonHomepage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AmazonHomepageExists(amazonHomepage.Id))
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
            return View(amazonHomepage);
        }

        // GET: AmazonHomepages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var amazonHomepage = await _context.AmazonHomepage
                .FirstOrDefaultAsync(m => m.Id == id);
            if (amazonHomepage == null)
            {
                return NotFound();
            }

            return View(amazonHomepage);
        }

        // POST: AmazonHomepages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var amazonHomepage = await _context.AmazonHomepage.FindAsync(id);
            if (amazonHomepage != null)
            {
                _context.AmazonHomepage.Remove(amazonHomepage);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AmazonHomepageExists(int id)
        {
            return _context.AmazonHomepage.Any(e => e.Id == id);
        }
    }
}
