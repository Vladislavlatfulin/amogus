using Zenject;

public class MediumEnemyFactory : IEnemyFactoryMethod
{
    private DiContainer _diContainer;
    private MediumEnemy _enemyPrefab;
    
    [Inject]
    public MediumEnemyFactory(DiContainer diContainer, MediumEnemy enemyPrefab)
    {
        _diContainer = diContainer;
        _enemyPrefab = enemyPrefab;
    }
    
    public IEnemy Create()
    {
        var enemy = _diContainer.InstantiatePrefabForComponent<MediumEnemy>(_enemyPrefab);
        enemy.gameObject.SetActive(false);
        return enemy;
    }
}