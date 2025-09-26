
namespace Regular_RPG_Progect.Entities.Items
{
    class Weapon : Item
    {
        public Weapon(string name, int gamage) : base(name, gamage)
        {
        }

        public int Damage { get { return _value; } }
    }
}
