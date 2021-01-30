using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SalesManager : ISalesService
    {
        public void Sell(Gamer gamer, Game game, Campain campain)
        {
            if (campain.Discount==0)
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " " +
                    game.GameName + " adlı oyunu " + " satın aldı. Toplam ödenen tutar = " + game.Price);
            }
            else
            {
                float indirim = game.Price * campain.Discount / 100;
                float price = game.Price - indirim;
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " " + game.GameName + " adlı oyunu " +
                    campain.CampainName + " kampanyası ile satın aldı. Toplam ödenen tutar = " + price);
            }
            
        }
    }
}
