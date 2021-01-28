using System;
using System.Collections.Generic;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {

            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1999,
                FirstName = "Ahmet Hakan",
                LastName = "Yıldırım",
                IdentityNumber = 12345
            });

            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.BirthYear = 1999;
            gamer1.FirstName = "Ahmet Hakan";
            gamer1.LastName = "Yıldırım";
            gamer1.IdentityNumber = 2345678;

            Game game1 = new Game();
            game1.Id = 1;
            game1.GameName = "Euro Truck Simulator 2";
            game1.UnitPrice = 18;

            Campaign campaign1 = new Campaign();
            campaign1.Id = 1;
            campaign1.CampaignName = "Yaz İndirimi";
            campaign1.CampaignPercent = 67;

            Console.WriteLine("Sevgili " +  gamer1.FirstName + " " + game1.GameName + "  oyununda % " + campaign1.CampaignPercent + " indirim başladı");
            Console.WriteLine();
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(game1, campaign1, gamer1);

            GameManager game = new GameManager();
            game.Add(game1);








        }
    }
}
