using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regular_RPG_Progect.Entities.Characters
{
    internal abstract class Melee : Player
    {
        public Melee(string name,
            PlayerClass playerClass,
            int strength = 1,
            int agility = 1,
            int intelligence = 1,
            int endurance = 1) : base(name, playerClass, strength, agility, intelligence, endurance)
        {
            Type = PlayerType.Melee;
        }
    }
}
