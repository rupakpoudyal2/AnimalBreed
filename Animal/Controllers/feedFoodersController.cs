using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Animal.Models;
using Animal.Repository;

namespace Animal.Controllers
{
    public class feedFoodersController : Controller
    {
        private readonly AnimalContext _context;

        public feedFoodersController(AnimalContext context)
        {
            _context = context;
        }

        // GET: feedFooders
        public async Task<IActionResult> Index()
        {
            return View(await _context.feedFooder.ToListAsync());
        }

        // GET: feedFooders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var feedFooder = await _context.feedFooder
                .FirstOrDefaultAsync(m => m.id == id);
            if (feedFooder == null)
            {
                return NotFound();
            }

            return View(feedFooder);
        }

        // GET: feedFooders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: feedFooders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,fooderNameNep,fooderNameEng,address,municipility,district,state,shortNote,cultivation,seedingMethod,seedHarvestingStorage,grassProduct,dm,cp,tdn,ndf,c,p,df,adl,tanni,nitrateScore,remarks,price")] feedFooder feedFooder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(feedFooder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(feedFooder);
        }

        // GET: feedFooders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var feedFooder = await _context.feedFooder.FindAsync(id);
            if (feedFooder == null)
            {
                return NotFound();
            }
            return View(feedFooder);
        }

        // POST: feedFooders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,fooderNameNep,fooderNameEng,address,municipility,district,state,shortNote,cultivation,seedingMethod,seedHarvestingStorage,grassProduct,dm,cp,tdn,ndf,c,p,df,adl,tanni,nitrateScore,remarks,price")] feedFooder feedFooder)
        {
            if (id != feedFooder.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(feedFooder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!feedFooderExists(feedFooder.id))
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
            return View(feedFooder);
        }

        // GET: feedFooders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var feedFooder = await _context.feedFooder
                .FirstOrDefaultAsync(m => m.id == id);
            if (feedFooder == null)
            {
                return NotFound();
            }

            return View(feedFooder);
        }

        // POST: feedFooders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var feedFooder = await _context.feedFooder.FindAsync(id);
            _context.feedFooder.Remove(feedFooder);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool feedFooderExists(int id)
        {
            return _context.feedFooder.Any(e => e.id == id);
        }
    }
}
