using Microsoft.AspNetCore.Mvc;
using MinhaAppVS.Models;

namespace MinhaAppVS.Controllers
{
    public class MovieController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Movie movie)
        {
            if (ModelState.IsValid)
            {
                //
            }
            return View(movie);
        }
    }
}
