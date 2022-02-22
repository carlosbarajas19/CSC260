using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoGameLibrary.Models;
using VideoGameLibrary.Interfaces;

namespace VideoGameLibrary.Data
{
    public class GameListDAL : IDataAccessLayer
    {
        public static List<Game> gameList = new List<Game>()
        {
            new Game("Minecraft",Platform.XBOX360, "Sandbox", "E10+", 2011, "/Images/MinecraftX360.jpg", 1),
            new Game("Hollow Knight",Platform.Nintendo_Switch, "Metroidvania", "E10+", 2017, "/Images/HollowKnight.jpg", 2),
            new Game("Pokemon Legends Arceus",Platform.Nintendo_Switch, "Action role-plaing", "E", 2022, "/Images/PokemonLA.jpg", 3),
            new Game("Halo 4",Platform.XBOX360, "Shooter", "M", 2012, "/Images/Halo4.jpg", 4),
            new Game("Lost Ark",Platform.PC, "MMO", "M", 2019, "/Images/LostArk.jpg", 5)
        };

        public void AddGame(Game game)
        {
            game.ID = gameList.Count + 1;
            gameList.Remove(game);
            gameList.Add(game);
        }

        public void DeleteGame(int? id)
        {
            Game foundGame = null;
            
            if(id != null)
            {
                gameList.ForEach(g =>
                {
                    if (g.ID == id)
                    {
                        foundGame = g;
                    }
                });
            }

            if(foundGame != null)
            {
                gameList.Remove(foundGame);
            }
        }

        public IEnumerable<Game> FiterCollection(string genre = "", Platform? platform = null, string esrbRating = "")
        {
            if (genre == null && platform == null && esrbRating == null) return gameList;
            List<Game> tmpGames = new List<Game>();

            string tmpGenre = (genre == null) ? "" : genre;
            string tmpPlatform = (platform == null) ? "" : platform.ToString();
            string tmpEsrb = (esrbRating == null) ? "" : esrbRating;

            foreach(Game g in gameList)
            {
               if(g.Genre.ToUpper().Contains(tmpGenre.ToUpper()) && g.Rating.ToUpper().Contains(tmpEsrb.ToUpper()) && g.Platform.ToString().Contains(tmpPlatform))
                {
                    tmpGames.Add(g);
                }
                
            }

            return tmpGames;
        }

        public IEnumerable<Game> GetCollection()
        {
            return gameList;
        }

        public IEnumerable<Game> GetRentedGames()
        {
            List<Game> tmpGames = gameList.Where(g => g.LoanedTo != null).ToList();
            return tmpGames;
        }

        public IEnumerable<Game> GetAvailableGames()
        {
            List<Game> tmpGames = gameList.Where(g => g.LoanedTo == null).ToList();
            return tmpGames;
        }

        public IEnumerable<Game> SearchForGames(string key)
        {
            if (string.IsNullOrEmpty(key)) return gameList;
            List<Game> tmpGames = new List<Game>();

            foreach(var g in gameList)
            {
                if(g.Title.ToUpper().Contains(key.ToUpper()))
                {
                    tmpGames.Add(g);
                }
            }

            return tmpGames;
        }
    }
}
