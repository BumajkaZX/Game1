using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ClocksSlider : MonoBehaviour
{
    public Slider clocks;
    
    void Update()
    {
      if (clocks.value<1f && Input.touchCount == 0)
        {
            clocks.value = 0f;
        }  
      else if (clocks.value == 1f)
        {
           Camera.main.GetComponent<LevelScripts>().Level1Clock(); 
        }
    }
}
