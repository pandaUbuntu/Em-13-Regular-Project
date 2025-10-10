using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regular_RPG_Progect.Entities.Characters.PlayerClasses
{
    internal class Mage : Caster
    {
        public Mage(string name) : base(name, PlayerClass.Mage, 5, 15, 25, 15)
        {
            this.FillLevelUpParamsTemplate(agility: 1, intelligence: 3, endurance: 2);
        }
    }
}
