using Regular_RPG_Progect.Entities.Characters;
using Regular_RPG_Progect.Entities.Items;

namespace Regular_RPG_Progect.Services
{
    class WeaponGenerator
    {
        private string[] names = { "Sword", "Spear", "Bow" };

        public Weapon generate(int lvl)
        {
            int minDmg = 5 + (lvl - 1) * 2;
            int maxDmg = 15 + (lvl - 1) * 3;

            return new Weapon(
                names[Utils.CustomRandom.Next(0, names.Length)], 
                (PlayerClass)Utils.CustomRandom.Next(1, 3), 
                Utils.CustomRandom.Next(minDmg, maxDmg));
        }
    }
}
