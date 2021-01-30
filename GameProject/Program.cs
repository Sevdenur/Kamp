using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            IGamerService gamerManager = new GamerManager(new UserValidationManager());
            Gamer gamer = new Gamer
            {
                Id = 1,
                BirthYear = 1996,
                FirstName = "SEVDENUR",
                LastName = "DEMİREL",
                IdentityNumber = 12345
            };
            gamerManager.Add(gamer);

            IGameService gameManager = new GameManager();
            Game game = new Game {
                GameName = "League of Legends",
                Price = 50
            };
            gameManager.Add(game);

            ICampainService campainManager = new CampainManager();
            Campain campain = new Campain {
                CampainName = "",
                Discount = 0
            };

            SalesManager salesManager = new SalesManager();
            salesManager.Sell(gamer, game, campain);

            Console.ReadLine();
        }
    }
}
