﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CbsStudents.Data;
using cbsStudents.Models.Entities;
using cbsStudents.ViewModels;
using cbsStudents.Mappers;

namespace cbsStudents.Controllers
{
    public class VenuesController : Controller
    {
        private readonly CbsStudentsContext _context; // ?


        // CONSTRUCTOR?
        public VenuesController(CbsStudentsContext context)
        {
            //_context = context;
            this._context = context; // this vigtigt?
        }


        // GET: Venues
        public async Task<IActionResult> Index()
        {
            return View(await _context.Venue.ToListAsync());
        }


        // GET: Venues/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Venue == null)
            {
                return NotFound();
            }

            var venue = await _context.Venue
                .FirstOrDefaultAsync(m => m.VenueId == id);
            if (venue == null)
            {
                return NotFound();
            }

            return View(venue);
        }


        //// GET: Venues/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}
        public IActionResult Create()
        {
            var vm = new VenueVm();

            return View(vm);
        }




        // POST: Venues/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(VenueVm vm)
        {
            if (ModelState.IsValid)
            {
                var venue = new VenueMapper().mapFromVmToDm(vm); // MAPPER

                _context.Add(venue);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vm);
        }




        // GET: Venues/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Venue == null)
            {
                return NotFound();
            }

            var venue = await _context.Venue.FindAsync(id);
            if (venue == null)
            {
                return NotFound();
            }
            return View(venue);
        }

        // POST: Venues/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("VenueId,Name,NumberOfSeats")] Venue venue)
        {
            if (id != venue.VenueId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(venue);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VenueExists(venue.VenueId))
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
            return View(venue);
        }

        // GET: Venues/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Venue == null)
            {
                return NotFound();
            }

            var venue = await _context.Venue
                .FirstOrDefaultAsync(m => m.VenueId == id);
            if (venue == null)
            {
                return NotFound();
            }

            return View(venue);
        }

        // POST: Venues/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Venue == null)
            {
                return Problem("Entity set 'CbsStudentsContext.Venue'  is null.");
            }
            var venue = await _context.Venue.FindAsync(id);
            if (venue != null)
            {
                _context.Venue.Remove(venue);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VenueExists(string id)
        {
            return _context.Venue.Any(e => e.VenueId == id);
        }
    }
}