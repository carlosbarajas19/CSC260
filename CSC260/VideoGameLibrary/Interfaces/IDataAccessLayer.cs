using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoGameLibrary.Models;

namespace VideoGameLibrary.Interfaces
{
    public interface IDataAccessLayer
    {
        /*IEnumerable<Game> GetGames();

        void AddGame(Game game);

        void RemoveGame();

        Game GetGame();

        void UpdateGame();*/

        IEnumerable<Game> GetCollection();
        IEnumerable<Game> GetRentedGames();
        IEnumerable<Game> GetAvailableGames();
        IEnumerable<Game> SearchForGames(string key);
        IEnumerable<Game> FiterCollection(string genre = null, Platform? platform = null, string esrbRating = null);
        void AddGame(Game game);
        void UpdateGame(Game game);
        void DeleteGame(int? id);

        
    }
}
