using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void Add(Game game, Campaign campaign, Gamer gamer)
        {
            Console.WriteLine(game.GameName  +  "  adlı oyunda " + game.UnitPrice +" TL İndirim var");
        }

        public void Delete(Game game, Campaign campaign, Gamer gamer)
        {
            Console.WriteLine(game.GameName + " adlı oyundan İndirim silindi");
        }

        public void Update(Game game, Campaign campaign, Gamer gamer)
        {
            Console.WriteLine("İndirim güncellendi");
        }
    }
}
