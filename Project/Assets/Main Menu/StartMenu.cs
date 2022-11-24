using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

public class StartMenu : MonoBehaviour
{ 
    private AppEntryPoint _appEntryPoint;

    [Inject]
    public void Conctructor(AppEntryPoint appEntryPoint)
    {
        _appEntryPoint = appEntryPoint;
    }
    
    public void PlayGame()
    {
        _appEntryPoint.LoadMainScene();
    }
}
