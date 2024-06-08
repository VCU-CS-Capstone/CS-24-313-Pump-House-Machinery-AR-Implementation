using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartTeleport : MonoBehaviour
{
    public string sceneToLoadName;
    private AsyncOperation asyncLoad;

    void Start()
    {
        asyncLoad = SceneManager.LoadSceneAsync(sceneToLoadName); // Begin loading the scene asynchronously when the script starts
        asyncLoad.allowSceneActivation = false; // Don't automatically activate the scene
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand"))
        {
            LoadSceneAsync();
        }
    }

    private void LoadSceneAsync()
    {
        asyncLoad.allowSceneActivation = true; // Activate the scene once it's fully loaded
    }
}
