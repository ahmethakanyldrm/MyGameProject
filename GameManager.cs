using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
   public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName +  " adlı Oyun Eklendi");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " adlı Oyun Silindi");
        }
    }
}
