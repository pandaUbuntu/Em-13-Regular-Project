
using Regular_RPG_Progect.Entities.Characters;

namespace Regular_RPG_Progect.Entities.Items
{
    class Weapon : Item
    {
        public Weapon(string name, PlayerClass playerClass, int damage, int price) : base(name, playerClass, damage, price)
        {
        }

        public int Damage { get { return _value; } }
    }
}
