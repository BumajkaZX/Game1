using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextFloating : MonoBehaviour
{
    public GameObject TextUI;
    public float delay;
    public  bool skip;
    public AudioClip currentAudio;
    public AudioSource Sor;
    public bool fulltext;
    Camera camhash;
    private void Awake()
    {
        camhash = Camera.main;
    }
    public void SpawnText()
    {
        if (!fulltext)
        {

            TextUI.GetComponentInChildren<TextMeshProUGUI>().text = "";
            if (!skip)
            {
                StartCoroutine(printText(gameObject.GetComponent<Dialogue>().words, delay));
            }
            else if (skip)
            {
                StopAllCoroutines();
                StartCoroutine(printText(gameObject.GetComponent<Dialogue>().words, delay));
            }
        }
        

        Debug.Log("SpawnText is W");
    }
    public void Stop()
    {
        TextUI.GetComponentInChildren<TextMeshProUGUI>().text = gameObject.GetComponent<Dialogue>().words;
        StopAllCoroutines();
        
        
    }
    IEnumerator printText(string TextIn, float delay)
    {
        yield return skip = true;

            for (int i = 1; i <= TextIn.Length; i++)
            {
                currentAudio = camhash.GetComponent<Audio>().currentName;
                TextUI.GetComponentInChildren<TextMeshProUGUI>().text = TextIn.Substring(0, i);
                Sor.PlayOneShot(currentAudio);
                yield return new WaitForSeconds(delay);
            }
      yield return  skip = false;
       
    }
 
    
}
