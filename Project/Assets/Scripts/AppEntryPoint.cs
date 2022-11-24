using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

public class AppEntryPoint : IAppEntryPoint, ILateDisposable
{
    private string _entryScene;
    private ZenjectSceneLoader _zenjectSceneLoader;
    
    [Inject] 
    public AppEntryPoint(string entryScene, ZenjectSceneLoader zenjectSceneLoader)
    {
        _entryScene = entryScene;
        _zenjectSceneLoader = zenjectSceneLoader;
    }

    public void LoadMainScene()
    {
        _zenjectSceneLoader.LoadScene(_entryScene);
    }
    
    public void LateDispose()
    {
        Debug.Log("ILateDisposable");
    }
}