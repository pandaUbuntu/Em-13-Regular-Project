
using Regular_RPG_Progect.Entities.Items;

namespace Regular_RPG_Progect.Entities.Characters.PlayerClasses
{
    internal class Paladin : Melee
    {
        public Paladin(string name) : base(name, PlayerClass.Paladin, 20, 5, 5, 30)
        {
            this.FillLevelUpParamsTemplate(strength: 2, endurance: 4);

            this._equippedWeapon = new Weapon("Basic Sword", PlayerClass.Paladin, 5, 100);
            this._equippedArmor = new Armor("Basic Plate Armor", PlayerClass.Paladin, 15, 100);
        }
    }
}
