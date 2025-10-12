using System;
using Regular_RPG_Progect.Entities.Characters;

namespace Regular_RPG_Progect.Utils
{
    internal class CreatePlayerHelper
    {
        public static Player CreatePlayer(string name, PlayerClass playerClass)
        {
            Player player = null;

            if (playerClass == PlayerClass.Paladin) 
                player = new Entities.Characters.PlayerClasses.Paladin(name);
            else if (playerClass == PlayerClass.Mage)
                player = new Entities.Characters.PlayerClasses.Mage(name);
            else if (playerClass == PlayerClass.Rogue)
                player = new Entities.Characters.PlayerClasses.TreasureHunter(name);
            else
                throw new ArgumentException("Invalid player class");

            return player;
        }
    }
}
