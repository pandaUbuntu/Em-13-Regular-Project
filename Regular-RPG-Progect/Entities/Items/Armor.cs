
using Regular_RPG_Progect.Entities.Characters;

namespace Regular_RPG_Progect.Entities.Items
{
    public class Armor : Item
    {
        public Armor(string name, PlayerClass playerClass, int defense, int price) : base(name, playerClass, defense, price)
        {
        }
        public int Defense { get { return _value; } }
    }
}
