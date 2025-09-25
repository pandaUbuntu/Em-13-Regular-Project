using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regular_RPG_Progect.Entities.Items
{
    abstract class Item
    {
        protected int _id;
        private static int autoInc = 1;
        protected string _name;
        protected int value = 0;

        public int Id { get { return _id; } }
        public string Name { get { return _name; } }
        public int Value { get { return value; } }

        public Item(string name, int value)
        {
            this._id = autoInc++;
            this._name = name;
            this.value = value;
        }
    }
}
