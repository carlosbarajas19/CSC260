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
        IDataAccessLayer dal = new GameListDAL();

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
        public IActionResult FilterCollection(string genre = null, Platform? platform = null, string esrbRating = null)
        {
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
        public IActionResult Rent(int ID, string name)
        {
            if (name is null) return View("Collection", dal.GetCollection());
            dal.GetCollection().ToList().Find(g => g.ID == ID).Rent(name);
            return View("Collection", dal.GetCollection().ToList());
        }
        [HttpPost]
        public IActionResult ReturnGame(int ID)
        {
            dal.GetCollection().ToList().Find(g => g.ID == ID).Return();
            return View("Collection", dal.GetCollection().ToList());
        }
        [HttpPost]
        public IActionResult RemoveGame(int ID)
        {
            dal.DeleteGame(ID);
            return View("Collection", dal.GetCollection().ToList());
        }
        [HttpPost]
        public IActionResult SearchForGames(string key)
        {
            return View("Collection", dal.SearchForGames(key));
        }
    }
}
