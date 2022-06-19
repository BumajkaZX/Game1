using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerStart : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    public GameObject Start;
    public GameObject Exit;
    public GameObject dial;

    public void OnMouseDown()
    {
        dial.GetComponent<TextFloating>().Stop() ;
        cam1.SetActive(false);
        Start.SetActive(true);
        Exit.SetActive(false);
        cam2.SetActive(true);
    }
    
}
