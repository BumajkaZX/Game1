using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioClip GG;
    public AudioClip currentName;
    public string Name;
 
    void Update()
    {
       ;  
       switch(Name)
        {
            case "Alex":
                currentName = GG;
                break;
        }
    }
}
