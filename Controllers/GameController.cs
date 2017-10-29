using Microsoft.AspNetCore.Mvc;
using GameReview.Models;

namespace GameReview.Controllers
{
    public class GameController : Controller
    {
        //GET: /<controller>/
        public IActionResult Index()
        {
            return View(Game.ReadAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Game game)
        {
            Game.Create(game);
            return RedirectToAction("Index");
        }
    }
}