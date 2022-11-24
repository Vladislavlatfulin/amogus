using UnityEngine;
using Zenject;

public class EnemyPoolInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.BindInterfacesAndSelfTo<MediumEnemyPool>()
            .AsCached();

        Container.BindInterfacesAndSelfTo<HardEnemyPool>()
            .AsCached();
    }
}