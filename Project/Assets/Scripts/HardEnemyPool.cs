using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Zenject;

public class HardEnemyPool : IEnemyPool, IInitializable
{
    private const int POOL_SIZE = 5;
    private List<HardEnemy> _hardEnemyList;
    private HardEnemyFactory _hardEnemyFactory;

    [Inject]
    public HardEnemyPool(HardEnemyFactory hardEnemyFactory)
    {
        _hardEnemyFactory = hardEnemyFactory;
    }
    
    public void Initialize()
    {
        _hardEnemyList = new List<HardEnemy>();

        for (int i = 0; i < POOL_SIZE; i++)
        {
            var enemy = _hardEnemyFactory.Create();
            _hardEnemyList.Add((HardEnemy)enemy);
        }
    }
    
    public IEnemy Get()
    {
        var freeEnemy = _hardEnemyList.Where(e => e.gameObject.activeInHierarchy == false);
        return freeEnemy.First();
    }
}