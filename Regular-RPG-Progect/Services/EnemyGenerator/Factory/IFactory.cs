using Regular_RPG_Progect.Entities.Characters;

namespace Regular_RPG_Progect.Services.EnemyGenerator.Factory
{
    internal interface IFactory
    {
        Enemy CreateEnemy(int level, EnemyType enemyType);
    }
}
