//using System;
//using System.IO;

//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;
//using CbsStudents.Data;
//using cbsStudents.Models;
////using Microsoft.AspNetCore.Hosting;


//namespace cbsStudents.Controllers
//{
//    public class ImagesController : Controller
//    {
//        private readonly CbsStudentsContext _context;
//        private readonly IWebHostEnvironment _hostEnvironment;

//        public ImagesController(CbsStudentsContext context, IWebHostEnvironment hostEnvironment)
//        {
//            _context = context;
//            this._hostEnvironment = hostEnvironment;
         
//        }

//        // GET: Images
//        public async Task<IActionResult> Index()
//        {
//              return View(await _context.Images.ToListAsync());
//        }

//        // GET: Images/Details/5
//        public async Task<IActionResult> Details(int? id)
//        {
//            if (id == null || _context.Images == null)
//            {
//                return NotFound();
//            }

//            var imageUpload = await _context.Images
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (imageUpload == null)
//            {
//                return NotFound();
//            }

//            return View(imageUpload);
//        }

//        // GET: Images/Create
//        public IActionResult Create()
//        {
//            return View();
//        }

//        // POST: Images/Create
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create([Bind("Id,Title,ImageFile")] ImageUpload imageUpload)
//        {
//            if (ModelState.IsValid)
//            {
//                // SAVE IMAGE TO wwwroot/images
//                string wwwRootPath = _hostEnvironment.WebRootPath; // hostEnvironment gør det muligt at tilgå path
//                string fileName = Path.GetFileNameWithoutExtension(imageUpload.ImageFile.FileName);
//                string extension = Path.GetExtension(imageUpload.ImageFile.FileName);
//                imageUpload.ImageName=fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
//                imageUpload.ImageName = fileName = fileName + Guid.NewGuid() + extension; //GUID TJEK OP PÅ
//                string path = Path.Combine(wwwRootPath + "/images/", fileName);
//                using (var fileStream = new FileStream(path,FileMode.Create))
//                {
//                    await imageUpload.ImageFile.CopyToAsync(fileStream);
//                }
          
//                // INSERT RECORD IN DB
//                _context.Add(imageUpload);
//                await _context.SaveChangesAsync();
//                return RedirectToAction(nameof(Index));
//            }
//            return View(imageUpload);
//        }




//        // GET: Images/Edit/5
//        public async Task<IActionResult> Edit(int? id)
//        {
//            if (id == null || _context.Images == null)
//            {
//                return NotFound();
//            }

//            var imageUpload = await _context.Images.FindAsync(id);
//            if (imageUpload == null)
//            {
//                return NotFound();
//            }
//            return View(imageUpload);
//        }

//        // POST: Images/Edit/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,ImageName")] ImageUpload imageUpload)
//        {
//            if (id != imageUpload.Id)
//            {
//                return NotFound();
//            }

//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    _context.Update(imageUpload);
//                    await _context.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException)
//                {
//                    if (!ImageUploadExists(imageUpload.Id))
//                    {
//                        return NotFound();
//                    }
//                    else
//                    {
//                        throw;
//                    }
//                }
//                return RedirectToAction(nameof(Index));
//            }
//            return View(imageUpload);
//        }

//        // GET: Images/Delete/5
//        public async Task<IActionResult> Delete(int? id)
//        {
//            if (id == null || _context.Images == null)
//            {
//                return NotFound();
//            }

//            var imageUpload = await _context.Images
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (imageUpload == null)
//            {
//                return NotFound();
//            }

//            return View(imageUpload);
//        }

//        // POST: Images/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(int id)
//        {
//            if (_context.Images == null)
//            {
//                return Problem("Entity set 'CbsStudentsContext.Images'  is null.");
//            }
//            var imageUpload = await _context.Images.FindAsync(id);
//            if (imageUpload != null)
//            {
//                _context.Images.Remove(imageUpload);
//            }
            
//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
//        }

//        private bool ImageUploadExists(int id)
//        {
//          return _context.Images.Any(e => e.Id == id);
//        }


//        //// FRA MICROSOFT TUTORIAL
//        //// https://docs.microsoft.com/en-us/aspnet/core/mvc/models/file-uploads?view=aspnetcore-6.0
//        //public async Task<IActionResult> OnPostUploadAsync()
//        //{
//        //    using (var memoryStream = new MemoryStream())
//        //    {
//        //        await FileUpload.FormFile.CopyToAsync(memoryStream);

//        //        // Upload the file if less than 2 MB
//        //        if (memoryStream.Length < 2097152)
//        //        {
//        //            var file = new AppFile()
//        //            {
//        //                Content = memoryStream.ToArray()
//        //            };

//        //            _dbContext.File.Add(file);

//        //            await _dbContext.SaveChangesAsync();
//        //        }
//        //        else
//        //        {
//        //            ModelState.AddModelError("File", "The file is too large.");
//        //        }
//        //    }

//        //    return Page();
//        //}
//    }
//}
