
using Regular_RPG_Progect.Entities.Characters;

namespace Regular_RPG_Progect.Entities.Items
{
    abstract class Item
    {
        protected int _id;
        private static int autoInc = 1;
        protected string _name;
        protected PlayerClass _classRestriction;
        protected int _value = 0;

        public int Id { get { return _id; } }

        public string Name { get { return _name; } }
        public PlayerClass ClassRestriction { get { return _classRestriction; } }

        public Item(string name, PlayerClass playerClass, int value)
        {
            this._id = autoInc++;
            this._name = name;
            this._classRestriction = playerClass;
            this._value = value;
        }
    }
}
