 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Regular_RPG_Progect.Entities.Items;
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

    public enum PlayerType
    {
        Melee = 1,
        Ranged,
        Caster
    }

    public abstract class Player : Character
    {
        protected Weapon _equippedWeapon = null;
        protected Armor _equippedArmor = null;

        protected int _money = 0;

        protected Dictionary<Characteristic, int> _levelUpParamsTemplate = new Dictionary<Characteristic, int>();
        protected Dictionary<Characteristic, int> _params = new Dictionary<Characteristic, int>();

        public double Strength { get { return getParamByName(Characteristic.Strength); } }
        public int Agility { get { return getParamByName(Characteristic.Agility); } }
        public int Intelligence { get { return getParamByName(Characteristic.Intelligence); } }
        public int Endurance { get { return getParamByName(Characteristic.Endurance); } }
        public int CritChance { get { return getParamByName(Characteristic.CritChance) + getParamByName(Characteristic.BaseCritChance); } }
        public int Money { get { return _money; } }
        public PlayerClass Class { get; }
        public PlayerType Type { get; protected set; }
        public BoundedValue Mana { get; protected set; } = null;
        public BoundedValue Expirience { get; protected set; } = null;

        public Weapon EquippedWeapon { get { return _equippedWeapon; } set { this._equippedWeapon = value; } }
        public Armor EquippedArmor { get { return _equippedArmor; } set { this._equippedArmor = value; } }

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
            int strength = 1,
            int agility = 1,
            int intelligence = 1,
            int endurance = 1
            ) : base(name, 1)
        {
            this.Class = playerClass;

            this.setParamByName(Characteristic.Strength, strength);
            this.setParamByName(Characteristic.Agility, agility);
            this.setParamByName(Characteristic.Intelligence, intelligence);
            this.setParamByName(Characteristic.Endurance, endurance);        
            this.setParamByName(Characteristic.BaseCritChance, agility);

            this.CreateHealth(endurance * 100);
            this.Mana = new BoundedValue(0, intelligence * 50);
            this.Expirience = new BoundedValue(max: 1000, currentZero: true);
            
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

            this.Expirience.Increase(amount);
            while (this.Expirience.Value >= this.Expirience.Max)
            {
                this.Expirience.Decrease(this.Expirience.Max);
                this.LevelUp();
            }
            return this.Expirience.Value;
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
            int strength = 0,
            int agility = 0,
            int intelligence = 0,
            int endurance = 0
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
            this.Expirience.ResetValue(_level * 1000, true);

            this.addParamByName(Characteristic.Strength, this._levelUpParamsTemplate[Characteristic.Strength]);
            this.addParamByName(Characteristic.Agility, this._levelUpParamsTemplate[Characteristic.Agility]);
            this.addParamByName(Characteristic.Intelligence, this._levelUpParamsTemplate[Characteristic.Intelligence]);
            this.addParamByName(Characteristic.Endurance, this._levelUpParamsTemplate[Characteristic.Endurance]);

            this.ResetHealth();
            this.ResetMana();
            this.ResetCritChance();
        }

        public override void TakeDamage(int damage)
        {

        }

        public override int CausedDamage()
        {
            return 0;
        }
    }
}
