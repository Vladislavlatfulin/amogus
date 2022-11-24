using System.Collections.Generic;
using System.Linq;
using Zenject;

public class MediumEnemyPool : IEnemyPool, IInitializable
{
    private const int POOL_SIZE = 5;
    private List<MediumEnemy> _hardEnemyList;
    private MediumEnemyFactory _hardEnemyFactory;

    [Inject]
    public MediumEnemyPool(MediumEnemyFactory hardEnemyFactory)
    {
        _hardEnemyFactory = hardEnemyFactory;
    }
    
    public void Initialize()
    {
        _hardEnemyList = new List<MediumEnemy>();
        
        for (int i = 0; i < POOL_SIZE; i++)
        {
            var enemy = _hardEnemyFactory.Create();
            _hardEnemyList.Add((MediumEnemy)enemy);
        }
    }
    
    public IEnemy Get()
    {
        var freeEnemy = _hardEnemyList.Where(e => e.gameObject.activeInHierarchy == false);
        return freeEnemy.First();
    }
}