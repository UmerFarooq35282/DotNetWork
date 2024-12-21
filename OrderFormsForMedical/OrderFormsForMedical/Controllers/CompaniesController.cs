using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OrderFormsForMedical.DbContextFolder;
using OrderFormsForMedical.Models;

namespace OrderFormsForMedical.Controllers
{
    public class CompaniesController : Controller
    {
        private readonly ProjectDbContext _context;

        public CompaniesController(ProjectDbContext context)
        {
            _context = context;
        }

        // GET: Companies
        public async Task<IActionResult> Index()
        {
            return View(await _context.Companies.ToListAsync());
        }

        // GET: Companies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companies = await _context.Companies
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (companies == null)
            {
                return NotFound();
            }

            return View(companies);
        }

        // GET: Companies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Companies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompanyId,CompanyName,DistType")] Companies companies)
        {
            if (ModelState.IsValid)
            {
                _context.Add(companies);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(companies);
        }

        // GET: Companies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companies = await _context.Companies.FindAsync(id);
            if (companies == null)
            {
                return NotFound();
            }
            return View(companies);
        }

        // POST: Companies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("CompanyId,CompanyName,DistType")] Companies companies)
        //{
        //    if (id != companies.CompanyId)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(companies);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!CompaniesExists(companies.CompanyId))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(companies);
        //}

        // GET: Companies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companies = await _context.Companies
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (companies == null)
            {
                return NotFound();
            }

            return View(companies);
        }

        // POST: Companies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var companies = await _context.Companies.FindAsync(id);
            if (companies != null)
            {
                _context.Companies.Remove(companies);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompaniesExists(int id)
        {
            return _context.Companies.Any(e => e.CompanyId == id);
        }
    }
}
