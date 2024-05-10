using FiorelloSlider_OnetoMany.Data;
using FiorelloSlider_OnetoMany.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FiorelloSlider_OnetoMany.Controllers
{
    public class BlogController : Controller
    {

        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Blog> blogs = await _context.Blogs.Where(m => !m.SoftDeleted).ToListAsync();
            return View(blogs);
        }
    }
}
