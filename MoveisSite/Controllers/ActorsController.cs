using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MoveisSite.Data.Services;
using MoveisSite.Models;

namespace MoveisSite.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allActors = await _service.GetAllAsync();

            return View(allActors);
        }

        //Get Actors/Create
        public async Task<IActionResult> Create()
        {
            return  View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")]Actor actor)
        {
            if(!ModelState.IsValid)
            {
                return View(actor);
            }

            await _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }

        //Get Actors/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null)
                return View("Empty");

            return View(actorDetails);
        }
    }
}
