using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class CreatorEnemies : IInitializable
{
    [Inject] private HardEnemyPool _hardEnemyPool;
    [Inject] private MediumEnemyPool _mediumEnemyPool;
    [Inject(Id = "hardEnemiesTransform")] private List<Transform> _hardEnemiesPosition;
    [Inject(Id = "mediumEnemiesTransform")] private List<Transform> _mediumEnemiesPosition;

    public void Initialize()
    {
        for (int i = 0; i < _mediumEnemiesPosition.Count; i++)
        {
            var enemy = _mediumEnemyPool.Get();
            var mediumEnemy = (MediumEnemy)enemy;
            mediumEnemy.gameObject.SetActive(true);
            mediumEnemy.transform.position = _mediumEnemiesPosition[i].position;
        }
        
        for (int i = 0; i < _hardEnemiesPosition.Count; i++)
        {
            var enemy = _hardEnemyPool.Get();
            var hardEnemy = (HardEnemy)enemy;
            hardEnemy.gameObject.SetActive(true);
            hardEnemy.transform.position = _hardEnemiesPosition[i].position;
        }
    }
}