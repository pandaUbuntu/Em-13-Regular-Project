using Regular_RPG_Progect.Utils;

namespace Regular_RPG_Progect.Entities.Characters
{
    abstract class Character
    {
        protected string _name;   
        protected int _level;
        public BoundedValue Health { get; } = null;

        public string Name { get { return _name; } }
        public int Level { get { return _level; } }

        public Character(string name, int maxHealth, int level = 1)
        {
            _name = name;
            _level = level;
            Health = new BoundedValue(0, maxHealth);
        }
    }
}
