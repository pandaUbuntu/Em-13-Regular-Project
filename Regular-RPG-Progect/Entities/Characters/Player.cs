 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regular_RPG_Progect.Entities.Characters
{
    class Player : Character
    {
        protected int _expirienceLevelCap = 0;
        protected int _currentExpirience = 0;

        protected int _strength = 1;
        protected int _agility = 1;
        protected int _intelligence = 1;
        protected int _endurance = 1;

        protected double _critChance = 0.05;

        protected int _money = 0;

        public int Strength { get { return _strength; } }
        public int Agility { get { return _agility; } }
        public int Intelligence { get { return _intelligence; } }
        public int Endurance { get { return _endurance; } }
        public double CritChance { get { return _critChance; } }
        public int Money { get { return _money; } }
        public int CurrentExpirience { get { return _currentExpirience; } }
        public int ExpirienceLevelCap { get { return _expirienceLevelCap; } }

        public int AddMoney(int amount)
        {
            if (amount < 0)
                throw new ArgumentException("Amount must be non-negative.");
            _money += amount;

            return _money;
        }

        public int SpendMoney(int amount)
        {
            if (amount < 0)
                throw new ArgumentException("Amount must be non-negative.");

            if (amount > _money)
                throw new ArgumentException("Not enough money.");

            _money -= amount;

            return _money;
        }

        public Player(string name) : base(name, 1000, 1)
        {
        }
    }
}
