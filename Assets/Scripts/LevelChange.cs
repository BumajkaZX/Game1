using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LevelChange : MonoBehaviour
{   public GameObject CurrentLevel;
    public GameObject NewLevel;
    public GameObject CurrentOtherSide;
    public GameObject DirectLight;
    public GameObject SpotLight;
    public float TimeToChange;
    public Color color;
    public Color OS;
    public bool NormalWorld;
    Camera camhash;
    private void Awake()
    {
        camhash = Camera.main;
    }
    void Start()
    {  
            color = camhash.backgroundColor;
        OS = Color.black;
    }
    public void SpawnLevel()
    {
       
        StartCoroutine(change());
        
    }
   
    IEnumerator change()
    {
        CurrentLevel.SetActive(false);
        camhash.backgroundColor = color;
        yield return new WaitForSeconds(TimeToChange);
        camhash.backgroundColor = color;
        NewLevel.SetActive(true); 
    }
    
    public void ToOtherSide()
    {   if (NormalWorld)
        {
            StartCoroutine(OtherSide());
        }
        else
            StartCoroutine(Normal());
        Debug.Log(CurrentLevel);
    }
    IEnumerator OtherSide()
    {
        NewLevel.SetActive(false);
        camhash.backgroundColor = OS;
        DirectLight.SetActive(false);
        yield return new WaitForSeconds(TimeToChange);
        SpotLight.SetActive(true);
        camhash.backgroundColor = OS;
        CurrentOtherSide.SetActive(true);
        NormalWorld = false;
    }
    IEnumerator Normal()
    {
        CurrentOtherSide.SetActive(false);
        camhash.backgroundColor = OS;
        SpotLight.SetActive(false);
        yield return new WaitForSeconds(TimeToChange);
        DirectLight.SetActive(true);
        camhash.backgroundColor = color;
        NewLevel.SetActive(true);
        NormalWorld = true;
    }
}
