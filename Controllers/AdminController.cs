using LmsApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

public class AdminController : Controller
{
    private readonly ApplicationDbContext _context;
    public AdminController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: /Admin
    public IActionResult Index()
    {
        var admins = _context.Admins.ToList();
        return View(admins);
    }

    // GET: /Admin/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: /Admin/Create
    [HttpPost]
    public IActionResult Create(Admin admin)
    {
        if (ModelState.IsValid)
        {
            _context.Admins.Add(admin);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(admin);
    }
}
