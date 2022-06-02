using System;
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



namespace cbsStudents.Controllers;

[Authorize]
public class EventsController : Controller
{
    private CbsStudentsContext _context;
    private readonly UserManager<IdentityUser> _userManager;

    public EventsController(CbsStudentsContext context, UserManager<IdentityUser> userManager)
    {
        _userManager = userManager;
        this._context = context;
    }

    // [AllowAnonymous]

    // SEARCHSTRING INDEX - Christian
    //public IActionResult Index(string SearchString = "")
    //{
    //    if (SearchString == null)
    //    {
    //        SearchString = "";
    //    }
    //    var events = from p in _context.Event select p;

    //    events = events.Where(x => x.Title.Contains(SearchString) ||
    //        x.Description.Contains(SearchString));

    //    // ViewBag.SearchString = SearchString;
    //    var vm = new EventIndexVm
    //    {
    //        Events = events.ToList(),
    //        SearchString = SearchString
    //    };

    //    return View(vm);
    //}


    // GAMMEL CONTROLLER
    //public class EventsController : Controller
    //{
    //private readonly CbsStudentsContext _context;

    //public EventsController(CbsStudentsContext context)
    //{
    //    _context = context;
    //}


    // GET med sortering og filter
    [AllowAnonymous]
    public async Task<IActionResult> Index(string sortOrder, string searchString)
    {
        ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "title" : "";
        ViewData["DateSortParm"] = sortOrder == "Date" ? "date" : "Date";
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
            case "title":
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
            return View();
        }

        // POST: Events/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,Title,EventStartDateTime,EventEndDateTime,Online,Adress,City,Country,EventType,Description")] EventVm @event) // Skiftet fra Event til EventVm
        public async Task<IActionResult> Create(Event @event) // Skiftet fra Event til EventVm. Tilføj bindings igen - hvilke?
        {
            if (ModelState.IsValid)
            {
            // BARN - konverter fra DateOnly og TimeOnly til DateTime. Virker ikke
            //Event ev = new Event();
            //ev.Title = @event.Title;
            //ev.EventStartDateTime = @event.EventStartDate.ToDateTime(@event.EventStartTime);
            _context.Add(@event);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
                
            }
            return View(@event);
        }

    // BARN:
    //public async Task<IActionResult> Create([Bind("Id,Title,EventStartDateTime,EventEndDateTime,Online,Adress,City,Country,EventType,Description")] EventVm @event)
    //{
    //    if (ModelState.IsValid)
    //    {
    //        Event ev = new Event();
    //        ev.Title = @event.Title;
    //        ev.EventStartDateTime = @event.EventStartDate.ToDateTime(@event.EventStartTime);
    //        _context.Add(@event);
    //        await _context.SaveChangesAsync();
    //        return RedirectToAction(nameof(Index));

    //    }
    //    return View(@event);
    //}


    // GET: Events/Edit/5
   // public async Task<IActionResult> Edit(int? id)
          public async Task<IActionResult> Edit(int? id)
            {
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
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description")] Event @event)
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

