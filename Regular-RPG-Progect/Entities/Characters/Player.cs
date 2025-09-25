 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Regular_RPG_Progect.Utils;

namespace Regular_RPG_Progect.Entities.Characters
{
    public enum Characteristic
    {
        Strength = 1,
        Agility,
        Intelligence,
        Endurance
    }

    public enum PlayerClass
    {
        Paladin = 1,
        Rogue,
        Mage
    }

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

        protected Dictionary<Characteristic, int> _levelUpParamsTemplate = new Dictionary<Characteristic, int>();

        public int Strength { get { return _strength; } }
        public int Agility { get { return _agility; } }
        public int Intelligence { get { return _intelligence; } }
        public int Endurance { get { return _endurance; } }
        public double CritChance { get { return _critChance; } }
        public int Money { get { return _money; } }
        public int CurrentExpirience { get { return _currentExpirience; } }
        public int ExpirienceLevelCap { get { return _expirienceLevelCap; } }

        public BoundedValue Mana { get; protected set; } = null;

        public Player(
            string name,
            int strength,
            int agility,
            int intelligence,
            int endurance
            ) : base(name, 1)
        {
            this._strength = strength;
            this._agility = agility;
            this._intelligence = intelligence;
            this._endurance = endurance;

            this._critChance += this._agility * 0.5;

            this._expirienceLevelCap = 1000;
            this.CreateHealth(this._endurance * 10);
            this.Mana = new BoundedValue(0, this._intelligence * 5);
        }

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

        public int AddExpirience(int amount)
        {
            if (amount < 0)
                throw new ArgumentException("Amount must be non-negative.");

            _currentExpirience += amount;
            while (_currentExpirience >= _expirienceLevelCap)
            {
                _currentExpirience -= _expirienceLevelCap;
                this.LevelUp();
            }
            return _currentExpirience;
        }

        private void SetLevelUpParamsTemplate(Characteristic characteristic, int value)
        {
            if (value < 0)
                throw new ArgumentException("Value must be non-negative.");
            if (this._levelUpParamsTemplate.ContainsKey(characteristic))
                this._levelUpParamsTemplate[characteristic] = value;
            else
                this._levelUpParamsTemplate.Add(characteristic, value);
        }

        protected void FillLevelUpParamsTemplate(
            int strength = 1,
            int agility = 1,
            int intelligence = 1,
            int endurance = 1
            )
        {
            this.SetLevelUpParamsTemplate(Characteristic.Strength, strength);
            this.SetLevelUpParamsTemplate(Characteristic.Agility, agility);
            this.SetLevelUpParamsTemplate(Characteristic.Intelligence, intelligence);
            this.SetLevelUpParamsTemplate(Characteristic.Endurance, endurance);
        }

        public void LevelUp()
        {
            _level++;
            _expirienceLevelCap = (int)(_expirienceLevelCap * 1000);

            _strength += this._levelUpParamsTemplate[Characteristic.Strength];
            _agility += this._levelUpParamsTemplate[Characteristic.Agility]; 
            _intelligence += this._levelUpParamsTemplate[Characteristic.Intelligence];
            _endurance += this._levelUpParamsTemplate[Characteristic.Endurance];

            this.Health.ResetValue(this._endurance * 10);
            this.Mana.ResetValue(this._intelligence * 5);
        }
    }
}
