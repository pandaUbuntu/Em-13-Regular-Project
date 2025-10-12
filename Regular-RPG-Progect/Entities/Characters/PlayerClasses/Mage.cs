using Regular_RPG_Progect.Entities.Items;

namespace Regular_RPG_Progect.Entities.Characters.PlayerClasses
{
    internal class Mage : Caster
    {
        public Mage(string name) : base(name, PlayerClass.Mage, 5, 15, 25, 15)
        {
            this.FillLevelUpParamsTemplate(agility: 1, intelligence: 3, endurance: 2);

            this._equippedWeapon = new Weapon("Basic Staff", PlayerClass.Mage, 10, 100);
            this._equippedArmor = new Armor("Basic Robe", PlayerClass.Mage, 5, 100);
        }
    }
}
