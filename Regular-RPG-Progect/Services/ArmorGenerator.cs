using Regular_RPG_Progect.Entities.Characters;
using Regular_RPG_Progect.Entities.Items;

namespace Regular_RPG_Progect.Services
{
    class ArmorGenerator
    {
        private string[] names = { "Fullplate", "Chainmail", "Leather Armor" };

        public Armor generate(int lvl)
        {
            int minDef = 5 + (lvl - 1) * 2;
            int maxDef = 15 + (lvl - 1) * 3;

            return new Armor(
                names[Utils.CustomRandom.Next(0, names.Length)],
                (PlayerClass)Utils.CustomRandom.Next(1, 3),
                Utils.CustomRandom.Next(minDef, maxDef)
                );
        }
    }
}
