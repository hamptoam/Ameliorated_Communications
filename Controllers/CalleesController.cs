using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ameliorated_Communications.Data;
using Ameliorated_Communications.Models;

namespace Ameliorated_Communications.Controllers
{
    public class CalleesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CalleesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Callees
        public async Task<IActionResult> Index()
        {
            return View(await _context.Callees.ToListAsync());
        }

        // GET: Callees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var callee = await _context.Callees
                .FirstOrDefaultAsync(m => m.CalleeId == id);
            if (callee == null)
            {
                return NotFound();
            }

            return View(callee);
        }

        // GET: Callees/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Callees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CalleeId,phoneNumber,firstName,lastName,Address,City,State,zipCode,callCount,answerCount,gift,giftDate,lastCallDate,lastCallTime,nextCallDate,nextCallTime,hasResponse,calleeDemeanor,isInterested")] Callee callee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(callee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(callee);
        }

        // GET: Callees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var callee = await _context.Callees.FindAsync(id);
            if (callee == null)
            {
                return NotFound();
            }
            return View(callee);
        }

        // POST: Callees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CalleeId,phoneNumber,firstName,lastName,Address,City,State,zipCode,callCount,answerCount,gift,giftDate,lastCallDate,lastCallTime,nextCallDate,nextCallTime,hasResponse,calleeDemeanor,isInterested")] Callee callee)
        {
            if (id != callee.CalleeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(callee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CalleeExists(callee.CalleeId))
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
            return View(callee);
        }

        // GET: Callees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var callee = await _context.Callees
                .FirstOrDefaultAsync(m => m.CalleeId == id);
            if (callee == null)
            {
                return NotFound();
            }

            return View(callee);
        }

        // POST: Callees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var callee = await _context.Callees.FindAsync(id);
            _context.Callees.Remove(callee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CalleeExists(int id)
        {
            return _context.Callees.Any(e => e.CalleeId == id);
        }
    }
}
