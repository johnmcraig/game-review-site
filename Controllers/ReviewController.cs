using Microsoft.AspNetCore.Mvc;
using GameReview.Models;

namespace GameReview.Controllers
{
    public class ReviewController : Controller
    {
        [HttpGet]
        public IActionResult Create(string gameName)
        {
            ViewData["Game"] = gameName;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Review review, string gameName)
        {
            var game = Game.Read(gameName);
            game.AddReviewToGame(review);
            return RedirectToAction("Index", "Game");
        }
    }
}