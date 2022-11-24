using UnityEngine;
using Zenject;

public class HardEnemyFactory : IEnemyFactoryMethod
{
    private DiContainer _diContainer;
    private HardEnemy _enemyPrefab;
    
    [Inject]
    public HardEnemyFactory(DiContainer diContainer, HardEnemy enemyPrefab)
    {
        _diContainer = diContainer;
        _enemyPrefab = enemyPrefab;
    }
    
    public IEnemy Create()
    {
        var enemy = _diContainer.InstantiatePrefabForComponent<HardEnemy>(_enemyPrefab);
        enemy.gameObject.SetActive(false);
        return enemy;
    }
}