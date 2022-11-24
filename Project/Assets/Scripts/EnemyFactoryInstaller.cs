using UnityEngine;
using Zenject;

public class EnemyFactoryInstaller : MonoInstaller
{
    [SerializeField] private HardEnemy _hardEnemy;
    [SerializeField] private MediumEnemy _mediumEnemy;
    
    public override void InstallBindings()
    {
        Container.BindInstance(_hardEnemy);
        Container.BindInstance(_mediumEnemy);
        
        BindHardFactory();
        BindMediumFactory();
    }
    
    private void BindHardFactory()
    {
        Container.BindInterfacesAndSelfTo<HardEnemyFactory>()
            .AsCached();
    }
    
    private void BindMediumFactory()
    {
        Container.BindInterfacesAndSelfTo<MediumEnemyFactory>()
            .AsCached();
    }
}