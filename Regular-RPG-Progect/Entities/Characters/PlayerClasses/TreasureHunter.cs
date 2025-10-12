using Regular_RPG_Progect.Entities.Items;

namespace Regular_RPG_Progect.Entities.Characters.PlayerClasses
{
    internal class TreasureHunter : Melee
    {
        public TreasureHunter(string name) : base(name, PlayerClass.Rogue, 20, 20, 5, 15)
        {
            this.FillLevelUpParamsTemplate(strength: 1, agility: 3, endurance: 2);

            this._equippedWeapon = new Weapon("Basic Dagger", PlayerClass.Rogue, 10, 100);
            this._equippedArmor = new Armor("Basic Leather Armor", PlayerClass.Rogue, 5, 100);
        }
    }
}
