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
        Endurance,
        CritChance,
        BaseCritChance,
        DefenseBonus,
        DamageBonus,
        HealthBonus,
        ManaBonus
    }

    public enum PlayerClass
    {
        Paladin = 1,
        Rogue,
        Mage
    }

    public class Player : Character
    {
        protected int _expirienceLevelCap = 0;
        protected int _currentExpirience = 0;

        protected int _money = 0;

        protected Dictionary<Characteristic, int> _levelUpParamsTemplate = new Dictionary<Characteristic, int>();
        protected Dictionary<Characteristic, int> _params = new Dictionary<Characteristic, int>();

        public double Strength { get { return getParamByName(Characteristic.Strength); } }
        public int Agility { get { return getParamByName(Characteristic.Agility); } }
        public int Intelligence { get { return getParamByName(Characteristic.Intelligence); } }
        public int Endurance { get { return getParamByName(Characteristic.Endurance); } }
        public int CritChance { get { return getParamByName(Characteristic.CritChance) + getParamByName(Characteristic.BaseCritChance); } }
        public int Money { get { return _money; } }
        public int CurrentExpirience { get { return _currentExpirience; } }
        public int ExpirienceLevelCap { get { return _expirienceLevelCap; } }
        public PlayerClass Class { get; }
        public BoundedValue Mana { get; protected set; } = null;

        protected int getParamByName(Characteristic name)
        {
            if (this._params.ContainsKey(name))
                return this._params[name];

            return 0;
        }

        protected void setParamByName(Characteristic name, int value)
        {
            if (this._params.ContainsKey(name))
                this._params[name] = value;
            else
                this._params.Add(name, value);
        }

        protected void addParamByName(Characteristic name, int value)
        {
            if (this._params.ContainsKey(name))
                this._params[name] += value;
            else
                this._params.Add(name, value);
        }

        private void ResetHealth()
        {
            if (this.Health != null)
                this.Health.ResetValue(this.Endurance * 100 + getParamByName(Characteristic.HealthBonus));
        }

        private void ResetMana()
        {
            if (this.Mana != null)
                this.Mana.ResetValue(this.Intelligence * 50 + getParamByName(Characteristic.ManaBonus));
        }

        private void ResetCritChance()
        {
            this.setParamByName(Characteristic.BaseCritChance, this.Agility);
        }

        public Player(
            string name,
            PlayerClass playerClass,
            int strength,
            int agility,
            int intelligence,
            int endurance
            ) : base(name, 1)
        {
            this.setParamByName(Characteristic.Strength, strength);
            this.setParamByName(Characteristic.Agility, agility);
            this.setParamByName(Characteristic.Intelligence, intelligence);
            this.setParamByName(Characteristic.Endurance, endurance);
            this.Class = playerClass;

            this.setParamByName(Characteristic.BaseCritChance, agility);

            this._expirienceLevelCap = 1000;
            this.CreateHealth(endurance * 100);
            this.Mana = new BoundedValue(0, intelligence * 50);
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

            this.addParamByName(Characteristic.Strength, this._levelUpParamsTemplate[Characteristic.Strength]);
            this.addParamByName(Characteristic.Agility, this._levelUpParamsTemplate[Characteristic.Agility]);
            this.addParamByName(Characteristic.Intelligence, this._levelUpParamsTemplate[Characteristic.Intelligence]);
            this.addParamByName(Characteristic.Endurance, this._levelUpParamsTemplate[Characteristic.Endurance]);

            this.ResetHealth();
            this.ResetMana();
            this.ResetCritChance();
        }
    }
}
