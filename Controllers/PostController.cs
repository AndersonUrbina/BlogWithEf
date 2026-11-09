using Microsoft.AspNetCore.Mvc;
using BlogWithEf.Data;
using BlogWithEf.Models;
using System.Linq;

namespace BlogWithEf.Controllers
{
    public class PostsController : Controller
    {
        private readonly BlogDbContext _context;

        public PostsController(BlogDbContext context)
        {
            _context = context;
        }

        // GET: /Posts
        public IActionResult Index()
        {
            var posts = _context.Posts.OrderByDescending(p => p.CreatedUtc).ToList();
            return View(posts);
        }

        // GET: /Posts/Details/5
        public IActionResult Details(int id)
        {
            var post = _context.Posts.FirstOrDefault(p => p.Id == id);
            if (post == null) return NotFound();
            return View(post);
        }

        // GET: /Posts/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Posts/Create
        [HttpPost]
        public IActionResult Create(Post post)
        {
            if (ModelState.IsValid)
            {
                _context.Posts.Add(post);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(post);
        }
    }
}