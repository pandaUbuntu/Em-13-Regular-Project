using Regular_RPG_Progect.Utils;

namespace Regular_RPG_Progect.Entities.Characters
{
    abstract public class Character
    {
        protected string _name;   
        protected int _level;
        public BoundedValue Health { get; protected set; } = null;

        public string Name { get { return _name; } }
        public int Level { get { return _level; } }

        public Character(string name, int level = 1)
        {
            _name = name;
            _level = level;
        }

        protected void CreateHealth(int maxHealth)
        {
            this.Health = new BoundedValue(0, maxHealth);
        }

        public abstract void TakeDamage(int damage);
        public abstract int CausedDamage();
    }
}
