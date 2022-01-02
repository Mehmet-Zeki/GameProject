using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class SaleManager : ISaleService
    {
        public void Sale(Game game, Player player, Campaign campaign)
        {
            Console.WriteLine(player.FirstName+" "+player.LastName+" Adli Oyuncu "+ game.GameName+" Isimli Oyunu "
                +campaign.Discount+" Kampanyasini " + " Kullanarak Satin Alinmiştir.");
        }
    }
}
