using System.Linq;
using System.Collections.Generic;

namespace GameReview.Models
{
    public class Game
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Rating
        {
            get
            {
                if(Reviews.Any())
                    return Reviews.Average( e => e.Rating);
                else
                    return 0;
            }
        }
        public List<Review> Reviews { get; set; } = new List<Review>();
        public static void Create(Game game)
        {
            GlobalVariables.Games.Add(game); //use the global var to add a game
        }

        public static List<Game> ReadAll()
        {
            return GlobalVariables.Games;
        }

        public static Game Read(string name)
        {
            foreach (var game in GlobalVariables.Games)
            {
                if (game.Name == name)
                    return game;
            }

            return null;
        }

        public void AddReviewToGame(Review review)
        {
            Reviews.Add(review);
        }
    }
}