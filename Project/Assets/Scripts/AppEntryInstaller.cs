using UnityEngine;
using Zenject;

public class AppEntryInstaller : MonoInstaller
{
    [SerializeField] private string _entryScene;
    
    public override void InstallBindings()
    {
        Container
            .BindInterfacesAndSelfTo<AppEntryPoint>()
            .AsSingle()
            .NonLazy();
        
        Container.BindInstance(_entryScene);
    }
}