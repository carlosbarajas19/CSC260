using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoGameLibrary.Models;
using VideoGameLibrary.Interfaces;
using VideoGameLibrary.Data;

namespace VideoGameLibrary.Controllers
{
    
    public class GameController : Controller
    {
        IDataAccessLayer dal;
        public GameController(IDataAccessLayer indal)
        {
            dal = indal;
        }

        public IActionResult Collection()
        {
            return View(dal.GetCollection().ToList());
        }

        public IActionResult DeleteGame()
        {
            ViewBag.mode = "delete";
            return View("Collection",dal.GetCollection().ToList());
        }

        public IActionResult GameForm()
        {
            ViewBag.ID = 0;
            return View();
        }

        public IActionResult AddGame(Game game)
        {
            if(ModelState.IsValid)
            {
                dal.AddGame(game);
                return Redirect("/Game/Collection");
            }
            return View("GameForm", game);
        }

        [HttpPost]
        public IActionResult FilterCollection(string gameView, string genre = null, Platform? platform = null, string esrbRating = null)
        {
            ViewBag.mode = gameView;
            return View("Collection" ,dal.FiterCollection(genre, platform, esrbRating).ToList());
        }

        public IActionResult RentGames()
        {
            ViewBag.mode = "rent";
            return View("Collection", dal.GetAvailableGames());
        }

        public IActionResult ReturnAGame()
        {
            ViewBag.mode = "return";
            return View("Collection", dal.GetRentedGames());
        }

        [HttpPost]
        public IActionResult Rent(string gameView, int ID, string name)
        {
            ViewBag.mode = gameView;
            if (name is null) return View("Collection", dal.GetCollection());

            var gm = dal.GetCollection().ToList().Find(g => g.ID == ID);
            if(gm != null)
            {
                gm.Rent(name);
                dal.UpdateGame(gm);
            }

            if(gameView == "rent") return RentGames();
            return View("Collection", dal.GetCollection().ToList());
        }
        [HttpPost]
        public IActionResult ReturnGame(string gameView, int ID)
        {
            ViewBag.mode = gameView;
            var gm = dal.GetCollection().ToList().Find(g => g.ID == ID);
            if (gm != null)
            {
                gm.Return();
                dal.UpdateGame(gm);
            }

            if (gameView == "return") return ReturnAGame();
            return View("Collection", dal.GetCollection().ToList());
        }
        [HttpPost]
        public IActionResult RemoveGame(string gameView, int ID)
        {
            ViewBag.mode = gameView;
            dal.DeleteGame(ID);

            if (gameView == "delete") return DeleteGame();
            return View("Collection", dal.GetCollection().ToList());
        }
        [HttpPost]
        public IActionResult SearchForGames(string gameView, string key)
        {
            ViewBag.mode = gameView;
            return View("Collection", dal.SearchForGames(key));
        }
    }
}
