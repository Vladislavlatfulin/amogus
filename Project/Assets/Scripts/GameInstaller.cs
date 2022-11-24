using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    [SerializeField] private List<Transform> _mediumEnemiesTransform;
    [SerializeField] private List<Transform> _hardEnemiesTransform;
    
    public override void InstallBindings()
    {
        Container
            .BindInstance(_mediumEnemiesTransform)
            .WithId("mediumEnemiesTransform")
            .WhenInjectedInto<CreatorEnemies>()
            .NonLazy();
        
        Container
            .BindInstance(_hardEnemiesTransform)
            .WithId("hardEnemiesTransform")
            .WhenInjectedInto<CreatorEnemies>()
            .NonLazy();

        Container
            .BindInterfacesAndSelfTo<CreatorEnemies>()
            .AsSingle()
            .NonLazy();
    }
}