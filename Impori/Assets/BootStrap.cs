/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BootStrap : MonoBehaviour
{
    // Start is called before the first frame update
    async void Start()
    {
        Application.runInBackground = true;
        //await UnityServices.InitializeAsync();

        if (SceneManager.loadedSceneCount == 1)
            SceneManager.LoadScene(0, LoadSceneMode.Additive);
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    static void Init()
    {
        #if UNITY_EDITOR
        var currentlyLoadedEditorScene = SceneManager.GetActiveScene();
        #endif

        if (SceneManager.GetSceneByName("Bootstrap").isLoaded != true)
            SceneManager.LoadScene("Bootstrap");
        
        #if UNITY_EDITOR
        if (currentlyLoadedEditorScene.IsValid())
            SceneManager.LoadSceneAsync(currentlyLoadedEditorScene.name, LoadSceneMode.Additive);
        #else
        SceneManager.LoadSceneAsync(0, LoadSceneMode.Additive);
        #endif
    }
}
*/
