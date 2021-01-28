using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICampaignService
    {
        void Add(Game game, Campaign campaign, Gamer gamer);
        void Update(Game game, Campaign campaign, Gamer gamer);
        void Delete(Game game, Campaign campaign, Gamer gamer);
    }
}
