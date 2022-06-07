using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CbsStudents.Data;
using cbsStudents.Models.Entities;
using cbsStudents.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using cbsStudents.Mappers;

namespace cbsStudents.Controllers;


[Authorize]
public class EventsController : Controller
{
    private CbsStudentsContext _context;

    private readonly IWebHostEnvironment _webHost; // IMAGE


    public EventsController(CbsStudentsContext context, IWebHostEnvironment webHost)
    {
        //this._context = context;
        _context = context;
        _webHost = webHost;
    }


    // GET med sortering og filter
    [AllowAnonymous]
    public async Task<IActionResult> Index(string sortOrder, string searchString)
    {

        // SORT COLUMN TITLES - HVORFOR DE STRENGE SKREVET SOM DE ER?
        ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "Title" : "";
        ViewData["DateSortParm"] = sortOrder == "Date" ? "date" : "Date";


        // SEARCH FIELD
        ViewData["CurrentFilter"] = searchString;

        var events = from e in _context.Event
                     select e;

        if (!String.IsNullOrEmpty(searchString))
        {
            events = events.Where(e => e.Title.Contains(searchString)
                                   || e.Description.Contains(searchString));
        }


        switch (sortOrder)
        {
            case "Title":
                events = events.OrderBy(e => e.Title);
                break;
            case "Date":
                events = events.OrderBy(s => s.EventStartDateTime);
                break;
        }

        return View(await events.AsNoTracking().ToListAsync());
    }



    // GET: Events/Details/5
    [AllowAnonymous]
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null || _context.Event == null)
        {
            return NotFound();
        }

        var @event = await _context.Event
            .FirstOrDefaultAsync(m => m.Id == id);
        if (@event == null)
        {
            return NotFound();
        }

        return View(@event);
    }



    // GET: Events/Create
    public IActionResult Create()
    {
        var vm = new EventCreateEditVm();

        //create SelectListItem
        vm.Venues = _context.Venue.Select(a => new SelectListItem
        {
            Text = a.Name, // name to show in html dropdown
            Value = a.VenueId // value of html dropdown
        }).ToList();

        return View(vm);
    }




    //POST: Events/Create
    [HttpPost]
    [ValidateAntiForgeryToken]

    public async Task<IActionResult> Create(EventCreateEditVm vm)
    {
        if (ModelState.IsValid)
        {

            //create SelectListItem
            vm.Venues = _context.Venue.Select(a => new SelectListItem
            {
                Text = a.Name, // name to show in html dropdown
                Value = a.VenueId // value of html dropdown
            }).ToList();


            // IMAGE
            string uniqueFileName = GetUploadedFileName(vm);
            vm.ImageName = uniqueFileName;
            var @event = new EventMapper().mapFromViewToEvent(vm); // MAPPER

            // INSERT RECORD IN DB
            _context.Add(@event);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

        return View(vm);
    }

    private string GetUploadedFileName(EventCreateEditVm vm)
    {
        string uniqueFileName = null;

        if (vm.ImageFile != null)
        {
            string uploadsFolder = Path.Combine(_webHost.WebRootPath, "images");
            uniqueFileName = Guid.NewGuid().ToString() + "_" + vm.ImageFile.FileName;
            string filePath = Path.Combine(uploadsFolder, uniqueFileName);
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                vm.ImageFile.CopyTo(fileStream);
            }
        }
        return uniqueFileName;
    }




    // GET: Events/Edit/5
     public async Task<IActionResult> Edit(int? id)
    {
        //var vm = new EventCreateEditVm();

        if (id == null || _context.Event == null)
        {
            return NotFound();
        }

        var @event = await _context.Event.FindAsync(id);

        if (@event == null)
        {
            return NotFound();
        }
        return View(@event);
    }


    // POST: Events/Edit/5

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, Event @event)

    {
        if (id != @event.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(@event);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventExists(@event.Id))
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
        return View(@event);
    }


    // GET: Events/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null || _context.Event == null)
        {
            return NotFound();
        }

        var @event = await _context.Event
            .FirstOrDefaultAsync(m => m.Id == id);
        if (@event == null)
        {
            return NotFound();
        }

        return View(@event);
    }


    // POST: Events/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        if (_context.Event == null)
        {
            return Problem("Entity set 'CbsStudentsContext.Event'  is null.");
        }
        var @event = await _context.Event.FindAsync(id);
        if (@event != null)
        {
            _context.Event.Remove(@event);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool EventExists(int id)
    {
        return _context.Event.Any(e => e.Id == id);
    }
}

