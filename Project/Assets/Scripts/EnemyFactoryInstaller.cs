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
        
        Debug.Log("create");
        BindHardFactory();
        BindMediumFactory();
    }
    
    private void BindHardFactory()
    {
        Container.BindInterfacesAndSelfTo<HardEnemy>()
            .AsCached();
    }
    
    private void BindMediumFactory()
    {
        Container.BindInterfacesAndSelfTo<MediumEnemy>()
            .AsCached();
    }
}