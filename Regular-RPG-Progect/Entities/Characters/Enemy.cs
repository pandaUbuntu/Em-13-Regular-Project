using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regular_RPG_Progect.Entities.Characters
{
    public enum EnemyType
    {
        Tank = 1,
        Balanced,
        GlassCannon
    }

    public class Enemy : Character
    {
        private int _id;
        private static int autoInc = 1;
        private EnemyType _enemyType;
        private int _experienceReward;
        private int _goldReward;
        private int _damage;
        private int _defense;

        public int Id { get { return _id; } }
        public EnemyType Type { get { return _enemyType; } }
        public int ExperienceReward { get { return _experienceReward; } }
        public int GoldReward { get { return _goldReward; } }
        public int Damage { get { return _damage; } }
        public int Defense { get { return _defense; } }

        public Enemy(string name, EnemyType enemyType, int level, int experienceReward, int goldReward, int damage, int defense) : base(name, level)
        {
            this._id = autoInc++;
            this._enemyType = enemyType;
            _experienceReward = experienceReward;
            _goldReward = goldReward;
            _damage = damage;
            _defense = defense;
        }
    }
}
