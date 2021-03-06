using System.Linq;
using System.Threading.Tasks;
using MoveisSite.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace MoveisSite.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;

        public MoviesController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allMovies = await _context.Movies
                            .Include(m => m.Cinema)
                            .OrderBy(m => m.Name)
                            .ToListAsync();

            return View(allMovies);
        }
    }
}
