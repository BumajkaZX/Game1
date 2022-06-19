using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dialogue : MonoBehaviour
{
    [SerializeField]
    public List<string> text = new List<string>();
    public GameObject TextBox;
    public GameObject NameBox;
    public GameObject Int;
    public int i = 0;
   public string nameP;
   public string words;
    public bool isover;
    Camera camhash;
    private void Awake()
    {
        camhash = Camera.main;
    }
    public void Next()
    {
        if (text.Count == i)
        {
            GetComponent<TextFloating>().fulltext = true ;
            Int.SetActive(false);
            isover = true;
        }
        else
        {
            int position = text[i].IndexOf(":");
            nameP = text[i].Substring(0, position);
            camhash.GetComponent<Audio>().Name = nameP;
            words = text[i].Substring(position + 1);
            TextBox.GetComponentInChildren<TextMeshProUGUI>().text = words;
            NameBox.GetComponentInChildren<TextMeshProUGUI>().text = nameP;
            ++i;
            Debug.Log(i);
        }
    }
    
}

    

