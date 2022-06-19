using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScreen : MonoBehaviour
{
    public GameObject loadingScreen;
    public GameObject menuScreen;
    public Slider bar;
    public GameObject textLoad;
    public GameObject textSCT;
    public void load(int Scene)
    {
        menuScreen.SetActive(false);
        loadingScreen.SetActive(true);
        StartCoroutine(LoadN(Scene));
    }
    IEnumerator LoadN(int Scene)
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(Scene);
        asyncLoad.allowSceneActivation = false;
        while (!asyncLoad.isDone)
        {
            bar.value = asyncLoad.progress;
            if (asyncLoad.progress >= 0.9f && !asyncLoad.allowSceneActivation)
            {
                bar.value = 2f;
                textLoad.SetActive(false);
                textSCT.SetActive(true);
              
                if (Input.anyKeyDown)
                {
                    asyncLoad.allowSceneActivation = true;
                }
            }
            yield return null;
        }
    }
}