using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Regular_RPG_Progect.Entities.Characters;

namespace Regular_RPG_Progect.Services.EnemyGenerator.Factory
{
    internal class EnemyFactory 
    {
        protected int baseStatHp = 1000;
        protected int baseStatDmg = 20;
        protected int baseStatDef = 20;

        protected int statHpByLevel = 0;
        protected int statDmgByLevel = 0;
        protected int statDefByLevel = 0;

        protected int bonusHp = 0;

        public EnemyFactory(int statHpByLevel, int statDmgByLevel, int statDefByLevel, int bonusHp)
        {
            this.statHpByLevel = statHpByLevel;
            this.statDmgByLevel = statDmgByLevel;
            this.statDefByLevel = statDefByLevel;
            this.bonusHp = bonusHp;
        }

        protected int calculateLevel(int playerLevel)
        {
            return playerLevel == 1 ? Utils.CustomRandom.Next(playerLevel, playerLevel + 1) : Utils.CustomRandom.Next(playerLevel - 1, playerLevel + 1);
        }

        protected void CalculateStats(int level)
        {
            baseStatHp += this.bonusHp + (level) * this.statHpByLevel;
            baseStatDef += (level) * this.statDmgByLevel;
            baseStatDmg += (level) * this.statDefByLevel;
        }
    }
}
