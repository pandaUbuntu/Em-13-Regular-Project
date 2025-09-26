
namespace Regular_RPG_Progect.Entities.Items
{
    class Armor : Item
    {
        public Armor(string name, int gdefense) : base(name, gdefense)
        {
        }
        public int Defense { get { return _value; } }
    }
}
