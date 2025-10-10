using System;
using Regular_RPG_Progect.Entities.Characters;

namespace Regular_RPG_Progect.Services
{
    public class EnemyGenerator1
    {
       private string[] strings = { "Goblin", "Orc", "Troll", "Bandit", "Wolf" };

        

        /*private IEnemyFactory chooseFactory(EnemyType type)
        {
            switch (type)
            {
                case EnemyType.Tank:
                    return new TankFactory();
                case EnemyType.Balanced:
                    return new BalancedFactory();
                case EnemyType.GlassCannon:
                    return new GlassCannonFactory();
                default:
                    throw new ArgumentException("Invalid enemy type");
            }
        }

        public Enemy GenerateByType(int playerLevel, EnemyType type)
        {

        }

        public Enemy GenerateRandom(int playerLevel)
        {
            int level = calculateLevel(playerLevel);

            EnemyType type = (EnemyType)Utils.CustomRandom.Next(1, Enum.GetNames(typeof(EnemyType)).Length);

            int experienceReward = 20 + (level - 1) * 10 + Utils.CustomRandom.Next(1, 10);
            int goldReward = 15 + (level - 1) * 5 + Utils.CustomRandom.Next(1, 10);

            int baseStatHp = 1000;
            int baseStatDmg = 20;
            int baseStatDef = 20;

            if (type == EnemyType.Tank)
            {
                baseStatHp += 1000 + (level) * 200;
                baseStatDef += (level) * 20;
                baseStatDmg += (level) * 5;
            }
            else if (type == EnemyType.Balanced)
            {
                baseStatHp += 400 + (level) * 100;
                baseStatDef += (level) * 10;
                baseStatDmg += (level) * 10;
            }
            else if (type == EnemyType.GlassCannon)
            {
                baseStatHp += (level) * 100;
                baseStatDef += (level) * 5;
                baseStatDmg += (level) * 25;
            }


            return new Enemy(
                strings[Utils.CustomRandom.Next(0, strings.Length)],
                type,
                level,
                experienceReward,
                goldReward,
                baseStatDmg,
                baseStatDef
                );
        }*/
    }
}
