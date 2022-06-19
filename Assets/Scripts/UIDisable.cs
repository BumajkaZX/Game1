using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIDisable : MonoBehaviour
{
    private void OnMouseDrag()
    {
        Camera.main.GetComponent<CameraZoom>().touchUI = true;
        Debug.Log("Drag");
    }
   void  OnMouseUp()
    {
      Camera.main.GetComponent<CameraZoom>().touchUI = false;   
    }

}

