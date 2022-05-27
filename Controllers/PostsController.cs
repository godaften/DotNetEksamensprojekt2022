using CbsStudents.Data;
using Microsoft.AspNetCore.Mvc;
using cbsStudents.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


namespace cbsStudents.Controllers;

[Authorize]
public class PostsController : Controller
{
    private CbsStudentsContext _context;
    private readonly UserManager<IdentityUser> _userManager;

    public PostsController(CbsStudentsContext context, UserManager<IdentityUser> userManager)
    {
        _userManager = userManager;
        this._context = context;
    }

    [AllowAnonymous]
    public IActionResult Index(string SearchString = "")
    {
        if (SearchString == null)
        {
            SearchString = "";
        }
        var posts = from p in _context.Post select p;

        posts = posts.Where(x => x.Title.Contains(SearchString) ||
            x.Text.Contains(SearchString)).Include(y => y.User);

        // ViewBag.SearchString = SearchString;
        var vm = new PostIndexVm
        {
            Posts = posts.ToList(),
            SearchString = SearchString
        };

        return View(vm);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create([Bind("Title", "Text", "Status")] Post post)
    {
        if (ModelState.IsValid)
        {
            // go ahead and save it into the database
            // redirectToAction()
            IdentityUser user = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
            post.UserId = user.Id;

            post.Created = DateTime.Now;
            _context.Post.Add(post);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        return View();
        // Console.WriteLine(post.Text + " " + post.Title);
        // return RedirectToAction("Test");
    }

    public IActionResult Edit(int id)
    {
        Post p = _context.Post.Include(x => x.Comments).ThenInclude(x => x.User)
            .First(x => x.Id == id);

        return View(p);
    }

    [HttpPost]
    public IActionResult Edit(int id, [Bind("Id", "Title", "Text", "Status")] Post post)
    {
        if (ModelState.IsValid)
        {
            _context.Post.Update(post);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        return View();
    }


    public IActionResult Test()
    {
        ViewBag.Jesper = "Jesper is here!";
        return View();
    }

}